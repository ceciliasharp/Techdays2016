using System;

namespace DebugDemo
{

    class DemoClass
    {
        public DemoClass2 Item { get; set; }
        public DemoClass()
        {
            Item = new DemoClass2();
        }
        public void ThrowException()
        {
            throw new Exception();
        }
    }

    public class DemoClass2
    {
        public StuffClass GetDetails()
        {
            return null;
        }

    }

    public class StuffClass
    {
        public int Value { get; set; }
    }
}
