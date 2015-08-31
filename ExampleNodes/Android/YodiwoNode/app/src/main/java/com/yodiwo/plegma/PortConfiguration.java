package com.yodiwo.plegma;

import java.util.HashMap;

/**
 * Created by ApiGenerator Tool (Java) on 28/08/2015 19:25:12.
 */

public class PortConfiguration {

    public static final HashMap<ePortType, Class<?>> PortTypeDict;

    public static final HashMap<ePortType, Object> PortTypeDefaultValueDict;


    static {
        PortTypeDict = new HashMap<ePortType, Class<?>>();
        PortTypeDict.put(ePortType.Undefined, Object.class);
        PortTypeDict.put(ePortType.Integer, Integer.class);
        PortTypeDict.put(ePortType.Decimal, float.class);
        PortTypeDict.put(ePortType.DecimalHigh, double.class);
        PortTypeDict.put(ePortType.Boolean, Boolean.class);
//PortTypeDict.put(ePortType.Color,System.Tuple<int, int, int>.class);
        PortTypeDict.put(ePortType.String, String.class);
        PortTypeDefaultValueDict = new HashMap<ePortType, Object>();
        PortTypeDefaultValueDict.put(ePortType.Undefined, null);
        PortTypeDefaultValueDict.put(ePortType.Integer, 0);
        PortTypeDefaultValueDict.put(ePortType.Decimal, 0);
        PortTypeDefaultValueDict.put(ePortType.DecimalHigh, 0);
        PortTypeDefaultValueDict.put(ePortType.Boolean, false);
//PortTypeDefaultValueDict.put(ePortType.Color,new System.Tuple<int, int, int>());
        PortTypeDefaultValueDict.put(ePortType.String, "");
    }
}
