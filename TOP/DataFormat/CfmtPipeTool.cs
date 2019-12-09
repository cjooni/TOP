using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


[Serializable]
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
public struct _st_type2_arr1
{

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
    public string sFromLine;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sFiller1;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
    public string sEndLine;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string sFiller2;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
    public string s;

 
}
