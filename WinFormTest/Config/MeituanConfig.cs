using System;

namespace WinFormTest
{
    class MeituanConfig
    {
        public string DevelopId { get; }
        public string CharSet { get; set; }
        public string SignKey { get; } 


        public MeituanConfig()
        {
            DevelopId = "100344";
            CharSet = "utf-8";
            SignKey = "y484oyevqjysj8q8";
        }
    }
}
