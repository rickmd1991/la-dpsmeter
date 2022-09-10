using System;
using System.Collections.Generic;
using LoggerLinux.Configuration;

namespace LostArkLogger
{
    public partial class StatPair
    {
        public StatPair(BitReader reader)
        {
            if (Configuration.Region == Region.Steam) SteamDecode(reader);
            if (Configuration.Region == Region.Korea) KoreaDecode(reader);
        }
        public List<Int64> Value = new List<Int64>();
        public List<Byte> StatType = new List<Byte>();
        public UInt16 num;
    }
}
