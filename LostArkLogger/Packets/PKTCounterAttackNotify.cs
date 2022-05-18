using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class PKTCounterAttackNotify
    {
        public PKTCounterAttackNotify(BitReader reader)
        {
            field0 = reader.ReadBytes(5);
            SourceId = reader.ReadUInt64();
            field2 = reader.ReadByte();
            TargetId = reader.ReadUInt64();
        }
        public Byte[] field0;
        public UInt64 SourceId;
        public Byte field2;
        public UInt64 TargetId;
    }
}
