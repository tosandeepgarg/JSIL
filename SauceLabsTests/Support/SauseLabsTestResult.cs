using System;

namespace JSIL.SauceLabsTests.Support
{
    public class TestResult
    {
        public TestResult(string name, bool result, int time, Uri resultInfo)
        {
            Name = name;
            Result = result;
            Time = time;
            ResultInfo = resultInfo;
        }

        public string Name{ get; private set; }
        public bool Result { get; private set; }
        public int Time { get; private set; }
        public Uri ResultInfo { get; private set; }
    }
}