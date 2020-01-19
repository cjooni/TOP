using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

[Serializable]
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct _st_typePLD
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public string dist;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public string inv;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public string dia;

}
