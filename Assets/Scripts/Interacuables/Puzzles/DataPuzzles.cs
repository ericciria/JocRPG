using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataPuzzles
{
    private static bool _l1_p1, _l1_p2, _l2_p1, _l2_p2, _l2_p3, _l2_pF;

    public static bool l1_p1
    {
        get{return _l1_p1;}
        set{_l1_p1 = value;}
    }
    public static bool l1_p2
    {
        get{return _l1_p2;}
        set{_l1_p2 = value;}
    }
    public static bool l2_p1
    {
        get{return _l2_p1;}
        set{_l2_p1 = value;}
    }
    public static bool l2_p2
    {
        get { return _l2_p2; }
        set { _l2_p2 = value; }
    }
    public static bool l2_p3
    {
        get { return _l2_p3; }
        set { _l2_p3 = value; }
    }
    public static bool l2_pF
    {
        get { return _l2_pF; }
        set { _l2_pF = value; }
    }


}
