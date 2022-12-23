﻿using System.Runtime.InteropServices;

namespace ResurrectedEternal.BSPParse
{
    [StructLayout(LayoutKind.Sequential)]
    public struct dedge_t
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ushort[] m_V;
    }
}
