using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

[Serializable]
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct _st_typePLD_Line
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
    public string no;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public string filler1;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
    public string dist;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string gap;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string filler2;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string filler3;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public string gh;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public string LINENAME;

}
