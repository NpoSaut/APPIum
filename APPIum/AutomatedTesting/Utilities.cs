using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APPIum.AutomatedTesting
{
    class Utilities
    {
        public static byte GetByte(byte[] buffer, int offset)
        {
            return buffer[offset];
        }
        
        public static byte[] GetBytes(byte[] buffer, int offset, int length)
        {
            byte[] bytes = new byte[length];
            Buffer.BlockCopy(buffer, offset, bytes, 0, length);
            return bytes;
        }

        public static string GetStringFromCP1251(byte[] buffer, int offset, int length)
        {
            byte[] bytes = Utilities.GetBytes(buffer, offset, length);
            return Encoding.GetEncoding(1251).GetString(bytes.TakeWhile(b => !b.Equals(0)).ToArray());
        }
    }
}
