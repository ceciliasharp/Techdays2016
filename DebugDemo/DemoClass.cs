using System;

namespace DebugDemo
{

    class DemoClass
    {
        public DemoClass2 Value { get; set; }
        public DemoClass()
        {
            Value = new DemoClass2();
        }
        public void ThrowException()
        {
            throw new Exception();
        }
    }

    public class DemoClass2
    {
        private DemoClass3 property;

        public DemoClass3 Property()
        {
            return null;
        }

    }

    public class DemoClass3
    {
        public int Text { get; set; }
    }
}
