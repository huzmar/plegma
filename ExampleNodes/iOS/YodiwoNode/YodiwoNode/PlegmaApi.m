//
//  PlegmaApi.m
//  YodiwoNode
//
//  Created by r00tb00t on 8/7/15.
//  Copyright (c) 2015 yodiwo. All rights reserved.
//

#import "PlegmaApi.h"
#import "YodiwoApi.h"

@implementation PlegmaApi

+(NSInteger)apiVersion {
    return 1;
}

+(NSString *)keySeparator {
    return @"-";
}

+(NSDictionary *)apiMsgNames {
    static NSDictionary *_apiMsgNames = nil;
    static dispatch_once_t onceToken;
    dispatch_once(&onceToken, ^{

        // TODO: Implement remaining api types and uncomment
        _apiMsgNames = [NSDictionary dictionaryWithObjectsAndKeys:
                        //@"loginreq", [LoginReq class],
                        //@"loginrsp", [LoginRsp class],
                        @"nodeinforeq", [NodeInfoReq class],
                        @"nodeinforsp", [NodeInfoRsp class],
                        @"thingsreq", [ThingsReq class],
                        @"thingsrsp", [ThingsRsp class],
                        @"porteventmsg", [PortEventMsg class],
                        @"portstatereq", [PortStateReq class],
                        @"portstatersp", [PortStateRsp class],
                        @"activeportkeysmsg", [ActivePortKeysMsg class],
                        nil];
    });

    return _apiMsgNames;
}

+(NSArray *)apiMessages {
    static NSArray *_apiMessages = nil;
    static dispatch_once_t onceToken;
    dispatch_once(&onceToken, ^{

        // TODO: Implement remaining api types and uncomment
        _apiMessages = [NSArray arrayWithObjects:
                        //[LoginReq class],
                        //[LoginRsp class],
                        [NodeInfoReq class],
                        [NodeInfoRsp class],
                        [ThingsReq class],
                        [ThingsRsp class],
                        [PortEventMsg class],
                        [PortStateReq class],
                        [PortStateRsp class],
                        [ActivePortKeysMsg class],
                        nil];
    });

    return _apiMessages;
}

@end
