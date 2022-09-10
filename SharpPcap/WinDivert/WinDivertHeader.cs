﻿using System;
namespace SharpPcap.WinDivert
{
    public class WinDivertHeader : ICaptureHeader
    {
        public uint InterfaceIndex { get; set; }
        public uint SubInterfaceIndex { get; set; }
        public WinDivertPacketFlags Flags { get; set; }

        public PosixTimeval Timeval { get; set; }

        public WinDivertHeader(PosixTimeval timeval) => Timeval = timeval;
    }
}
