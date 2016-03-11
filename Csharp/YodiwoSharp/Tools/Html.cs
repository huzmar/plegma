﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Collections;

namespace Yodiwo.Tools
{
    public static class Html
    {

        //----------------------------------------------------------------------------------------------------------------------------------------------

        // Build the hash table of HTML entity references.  This list comes from the HTML 4.01 W3C recommendation.
        public static readonly IReadOnlyDictionary<string, char> Entities = new SortedDictionary<string, char>(StringComparer.Ordinal)
            {
                #region Entities
                {"nbsp", '\u00A0'},
                {"iexcl", '\u00A1'},
                {"cent", '\u00A2'},
                {"pound", '\u00A3'},
                {"curren", '\u00A4'},
                {"yen", '\u00A5'},
                {"brvbar", '\u00A6'},
                {"sect", '\u00A7'},
                {"uml", '\u00A8'},
                {"copy", '\u00A9'},
                {"ordf", '\u00AA'},
                {"laquo", '\u00AB'},
                {"not", '\u00AC'},
                {"shy", '\u00AD'},
                {"reg", '\u00AE'},
                {"macr", '\u00AF'},
                {"deg", '\u00B0'},
                {"plusmn", '\u00B1'},
                {"sup2", '\u00B2'},
                {"sup3", '\u00B3'},
                {"acute", '\u00B4'},
                {"micro", '\u00B5'},
                {"para", '\u00B6'},
                {"middot", '\u00B7'},
                {"cedil", '\u00B8'},
                {"sup1", '\u00B9'},
                {"ordm", '\u00BA'},
                {"raquo", '\u00BB'},
                {"frac14", '\u00BC'},
                {"frac12", '\u00BD'},
                {"frac34", '\u00BE'},
                {"iquest", '\u00BF'},
                {"Agrave", '\u00C0'},
                {"Aacute", '\u00C1'},
                {"Acirc", '\u00C2'},
                {"Atilde", '\u00C3'},
                {"Auml", '\u00C4'},
                {"Aring", '\u00C5'},
                {"AElig", '\u00C6'},
                {"Ccedil", '\u00C7'},
                {"Egrave", '\u00C8'},
                {"Eacute", '\u00C9'},
                {"Ecirc", '\u00CA'},
                {"Euml", '\u00CB'},
                {"Igrave", '\u00CC'},
                {"Iacute", '\u00CD'},
                {"Icirc", '\u00CE'},
                {"Iuml", '\u00CF'},
                {"ETH", '\u00D0'},
                {"Ntilde", '\u00D1'},
                {"Ograve", '\u00D2'},
                {"Oacute", '\u00D3'},
                {"Ocirc", '\u00D4'},
                {"Otilde", '\u00D5'},
                {"Ouml", '\u00D6'},
                {"times", '\u00D7'},
                {"Oslash", '\u00D8'},
                {"Ugrave", '\u00D9'},
                {"Uacute", '\u00DA'},
                {"Ucirc", '\u00DB'},
                {"Uuml", '\u00DC'},
                {"Yacute", '\u00DD'},
                {"THORN", '\u00DE'},
                {"szlig", '\u00DF'},
                {"agrave", '\u00E0'},
                {"aacute", '\u00E1'},
                {"acirc", '\u00E2'},
                {"atilde", '\u00E3'},
                {"auml", '\u00E4'},
                {"aring", '\u00E5'},
                {"aelig", '\u00E6'},
                {"ccedil", '\u00E7'},
                {"egrave", '\u00E8'},
                {"eacute", '\u00E9'},
                {"ecirc", '\u00EA'},
                {"euml", '\u00EB'},
                {"igrave", '\u00EC'},
                {"iacute", '\u00ED'},
                {"icirc", '\u00EE'},
                {"iuml", '\u00EF'},
                {"eth", '\u00F0'},
                {"ntilde", '\u00F1'},
                {"ograve", '\u00F2'},
                {"oacute", '\u00F3'},
                {"ocirc", '\u00F4'},
                {"otilde", '\u00F5'},
                {"ouml", '\u00F6'},
                {"divide", '\u00F7'},
                {"oslash", '\u00F8'},
                {"ugrave", '\u00F9'},
                {"uacute", '\u00FA'},
                {"ucirc", '\u00FB'},
                {"uuml", '\u00FC'},
                {"yacute", '\u00FD'},
                {"thorn", '\u00FE'},
                {"yuml", '\u00FF'},
                {"fnof", '\u0192'},
                {"Alpha", '\u0391'},
                {"Beta", '\u0392'},
                {"Gamma", '\u0393'},
                {"Delta", '\u0394'},
                {"Epsilon", '\u0395'},
                {"Zeta", '\u0396'},
                {"Eta", '\u0397'},
                {"Theta", '\u0398'},
                {"Iota", '\u0399'},
                {"Kappa", '\u039A'},
                {"Lambda", '\u039B'},
                {"Mu", '\u039C'},
                {"Nu", '\u039D'},
                {"Xi", '\u039E'},
                {"Omicron", '\u039F'},
                {"Pi", '\u03A0'},
                {"Rho", '\u03A1'},
                {"Sigma", '\u03A3'},
                {"Tau", '\u03A4'},
                {"Upsilon", '\u03A5'},
                {"Phi", '\u03A6'},
                {"Chi", '\u03A7'},
                {"Psi", '\u03A8'},
                {"Omega", '\u03A9'},
                {"alpha", '\u03B1'},
                {"beta", '\u03B2'},
                {"gamma", '\u03B3'},
                {"delta", '\u03B4'},
                {"epsilon", '\u03B5'},
                {"zeta", '\u03B6'},
                {"eta", '\u03B7'},
                {"theta", '\u03B8'},
                {"iota", '\u03B9'},
                {"kappa", '\u03BA'},
                {"lambda", '\u03BB'},
                {"mu", '\u03BC'},
                {"nu", '\u03BD'},
                {"xi", '\u03BE'},
                {"omicron", '\u03BF'},
                {"pi", '\u03C0'},
                {"rho", '\u03C1'},
                {"sigmaf", '\u03C2'},
                {"sigma", '\u03C3'},
                {"tau", '\u03C4'},
                {"upsilon", '\u03C5'},
                {"phi", '\u03C6'},
                {"chi", '\u03C7'},
                {"psi", '\u03C8'},
                {"omega", '\u03C9'},
                {"thetasym", '\u03D1'},
                {"upsih", '\u03D2'},
                {"piv", '\u03D6'},
                {"bull", '\u2022'},
                {"hellip", '\u2026'},
                {"prime", '\u2032'},
                {"Prime", '\u2033'},
                {"oline", '\u203E'},
                {"frasl", '\u2044'},
                {"weierp", '\u2118'},
                {"image", '\u2111'},
                {"real", '\u211C'},
                {"trade", '\u2122'},
                {"alefsym", '\u2135'},
                {"larr", '\u2190'},
                {"uarr", '\u2191'},
                {"rarr", '\u2192'},
                {"darr", '\u2193'},
                {"harr", '\u2194'},
                {"crarr", '\u21B5'},
                {"lArr", '\u21D0'},
                {"uArr", '\u21D1'},
                {"rArr", '\u21D2'},
                {"dArr", '\u21D3'},
                {"hArr", '\u21D4'},
                {"forall", '\u2200'},
                {"part", '\u2202'},
                {"exist", '\u2203'},
                {"empty", '\u2205'},
                {"nabla", '\u2207'},
                {"isin", '\u2208'},
                {"notin", '\u2209'},
                {"ni", '\u220B'},
                {"prod", '\u220F'},
                {"sum", '\u2211'},
                {"minus", '\u2212'},
                {"lowast", '\u2217'},
                {"radic", '\u221A'},
                {"prop", '\u221D'},
                {"infin", '\u221E'},
                {"ang", '\u2220'},
                {"and", '\u2227'},
                {"or", '\u2228'},
                {"cap", '\u2229'},
                {"cup", '\u222A'},
                {"int", '\u222B'},
                {"there4", '\u2234'},
                {"sim", '\u223C'},
                {"cong", '\u2245'},
                {"asymp", '\u2248'},
                {"ne", '\u2260'},
                {"equiv", '\u2261'},
                {"le", '\u2264'},
                {"ge", '\u2265'},
                {"sub", '\u2282'},
                {"sup", '\u2283'},
                {"nsub", '\u2284'},
                {"sube", '\u2286'},
                {"supe", '\u2287'},
                {"oplus", '\u2295'},
                {"otimes", '\u2297'},
                {"perp", '\u22A5'},
                {"sdot", '\u22C5'},
                {"lceil", '\u2308'},
                {"rceil", '\u2309'},
                {"lfloor", '\u230A'},
                {"rfloor", '\u230B'},
                {"lang", '\u2329'},
                {"rang", '\u232A'},
                {"loz", '\u25CA'},
                {"spades", '\u2660'},
                {"clubs", '\u2663'},
                {"hearts", '\u2665'},
                {"diams", '\u2666'},
                {"quot", '\u0022'},
                {"amp", '\u0026'},
                {"lt", '\u003C'},
                {"gt", '\u003E'},
                {"OElig", '\u0152'},
                {"oelig", '\u0153'},
                {"Scaron", '\u0160'},
                {"scaron", '\u0161'},
                {"Yuml", '\u0178'},
                {"circ", '\u02C6'},
                {"tilde", '\u02DC'},
                {"ensp", '\u2002'},
                {"emsp", '\u2003'},
                {"thinsp", '\u2009'},
                {"zwnj", '\u200C'},
                {"zwj", '\u200D'},
                {"lrm", '\u200E'},
                {"rlm", '\u200F'},
                {"ndash", '\u2013'},
                {"mdash", '\u2014'},
                {"lsquo", '\u2018'},
                {"rsquo", '\u2019'},
                {"sbquo", '\u201A'},
                {"ldquo", '\u201C'},
                {"rdquo", '\u201D'},
                {"bdquo", '\u201E'},
                {"dagger", '\u2020'},
                {"Dagger", '\u2021'},
                {"permil", '\u2030'},
                {"lsaquo", '\u2039'},
                {"rsaquo", '\u203A'},
                {"euro", '\u20AC'},
                #endregion
            }.AsReadOnly();

        //----------------------------------------------------------------------------------------------------------------------------------------------

        public class HtmlEscapeIgnoreAttribute : Attribute
        {
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary> Recursivle html encode all string fields  </summary>
        /// <param name="obj"></param>
        public static void HtmlEncodeObject(ref object obj)
        {
            _HtmlTranformObject(ref obj, null, 0, true);
        }

        /// <summary> Recursivle html decode all string fields  </summary>
        /// <param name="obj"></param>
        public static void HtmlDecodeObject(ref object obj)
        {
            _HtmlTranformObject(ref obj, null, 0, false);
        }

        //TODO: should optimize to avoid such heavy use of reflection
        static void _HtmlTranformObject(ref object obj, HashSet<object> processed, int Depth, bool Encode)
        {
            //no nulls and failsafe check
            if (obj == null || Depth > 50)
                return;
            var objType = obj.GetType();

            //create hashset if null
            if (processed == null)
                processed = new HashSet<object>();

            //avoid circles
            if (processed.Contains(obj))
                return;
            else
                processed.Add(obj);

            //handle object
            if (objType.IsList())
            {
                var list = obj as IList;
                for (int n = 0; n < list.Count; n++)
                {
                    var box = list[n];
                    _HtmlTranformObject(ref box, processed, Depth + 1, Encode);
                    list[n] = box;
                }
            }
            else if (objType.IsArray)
            {
                var arr = obj as Array;
                for (int n = 0; n < arr.Length; n++)
                {
                    var box = arr.GetValue(n);
                    _HtmlTranformObject(ref box, processed, Depth + 1, Encode);
                    arr.SetValue(box, n);
                }
            }
            else
            {
#if NETFX
                var members = objType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).As<MemberInfo>();
#elif UNIVERSAL
                var members = objType.GetTypeInfo().DeclaredFields.As<MemberInfo>();
#endif
                //members = members.Concat(objType.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).Where(p => p.CanRead && p.CanWrite && p.GetIndexParameters().Length == 0));
                //process all fields
                foreach (var mi in members)
                {
                    var fi = mi as FieldInfo;
                    var pi = (PropertyInfo)null;//mi as PropertyInfo;
                    var value = fi != null ? fi.GetValue(obj) : pi.GetValue(obj);
                    if (value == null ||
                        mi.IsDefined(typeof(HtmlEscapeIgnoreAttribute)) ||
                        mi.IsDefined(typeof(NonSerializedAttribute)) ||
                        mi.IsDefined(typeof(Newtonsoft.Json.JsonIgnoreAttribute))
                        )
                        continue;
                    //avoid circles
                    if (processed.Contains(value))
                        continue;
                    //do html escape
                    if (value is string)
                    {
                        //encode
                        if (Encode)
                            value = (value as string).HtmlEncode();
                        else
                            value = (value as string).HtmlDecode();
                        //write-back
                        if (fi != null)
                            fi.SetValue(obj, value);
                        else
                            pi.SetValue(obj, value);
                    }
                    //start recursion
#if NETFX
                    if (!value.GetType().IsPrimitive && !(value is string))
#elif UNIVERSAL
                    if (!value.GetType().GetTypeInfo().IsPrimitive && !(value is string))
#endif
                        _HtmlTranformObject(ref value, processed, Depth + 1, Encode);
                }
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------
    }
}
