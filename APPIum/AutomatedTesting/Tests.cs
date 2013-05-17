using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APPIum.AutomatedTesting
{
    class Test11 : ITest
    {
        int testTimeout = 0;
        string msgText = String.Empty;
        
        int LoadFromByteFrame(byte[] byteFrame)
        {
            if (byteFrame[0] != 0x11)
                return -1;

            testTimeout = byteFrame[1];
            msgText = Utilities.GetStringFromCP1251(byteFrame, 2, 30);

            return 0;
        }
    }
}
