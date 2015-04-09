using System;

namespace FbxSharp
{
    public struct FbxTime
    {
        public FbxTime(long time)
        {
            Value = time;
        }

        public long Value;

        public double GetSecondDouble()
        {
            return Value / 46186158000.0;
        }

        public long GetFrameCount()
        {
            return Value / 1539538600L;
        }
    }
    
}
