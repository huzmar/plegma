﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Nancy;
using Nancy.ViewEngines.Razor;
using Nancy.Cryptography;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Nancy.TinyIoc;
using Nancy.Diagnostics;
using Nancy.Serialization.JsonNet;
using Nancy.Bootstrapper;
using Nancy.Conventions;

namespace Yodiwo.NodeLibrary.Pairing.NancyPairing
{
    public class RazorConfig : IRazorConfiguration
    {
        public IEnumerable<string> GetAssemblyNames()
        {
            return null;
        }

        public IEnumerable<string> GetDefaultNamespaces()
        {
            return null;
        }

        public bool AutoIncludeModelNamespace
        {
            get { return false; }
        }
    }

    public class Bootstrapper : DefaultNancyBootstrapper
    {
        // The bootstrapper enables you to reconfigure the composition of the framework,
        // by overriding the various methods and properties.
        // For more information https://github.com/NancyFx/Nancy/wiki/Bootstrapper

        protected override IRootPathProvider RootPathProvider
        {
            get { return new CustomRootPathProvider(); }
        }

        protected override void ApplicationStartup(Nancy.TinyIoc.TinyIoCContainer container, Nancy.Bootstrapper.IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);

            //Enable CSRF protection
            Nancy.Security.Csrf.Enable(pipelines);

            // Enabled cookie sessions
            Nancy.Session.CookieBasedSessions.Enable(pipelines);

            //Setup frame and origin options ( https://www.owasp.org/index.php/List_of_useful_HTTP_headers )
            //may be overwritten by server (apache,ngix,iis,..) for config see https://developer.mozilla.org/en-US/docs/Web/HTTP/X-Frame-Options
            pipelines.AfterRequest.AddItemToEndOfPipeline((ctx) =>
            {
                if (ctx.Response.StatusCode == HttpStatusCode.InternalServerError) return;

                ctx.Response.Headers.Add("X-Frame-Options", "SAMEORIGIN");
                ctx.Response.Headers.Add("X-Download-Options", "noopen"); // IE extension
                ctx.Response.Headers.Add("X-Content-Type-Options", "nosniff");
                ctx.Response.Headers.Add("X-XSS-Protection", "1; mode=block");
            });

            // Retain the casing in serialization of nancy json
            Nancy.Json.JsonSettings.RetainCasing = true;

            StaticConfiguration.CaseSensitive = false;

            // Enable debugging of nancy
            StaticConfiguration.EnableRequestTracing = false;

            // Dummy call to force the include of the Nancy.Serialization.JsonNet dll
            JsonNetSerializer a = new JsonNetSerializer();
            a.CanSerialize("{}");
        }

        // ---------------------------------------------------------------------------------------------------------------------------------

#if true
        protected override DiagnosticsConfiguration DiagnosticsConfiguration
        {
            get { return new DiagnosticsConfiguration { Password = @"1234" }; }
        }
#endif

        // ---------------------------------------------------------------------------------------------------------------------------------

        protected override void ConfigureConventions(NancyConventions conventions)
        {
            base.ConfigureConventions(conventions);
        }
    }

    public class CustomRootPathProvider : IRootPathProvider
    {
        public string GetRootPath()
        {
            return Environment.CurrentDirectory;
        }
    }
}
