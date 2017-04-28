using Editor.Demo4;
using System;

namespace Editor
{
    public class cSharp7
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public void Literals()
        {

        }

        public void ParseOut(string numberString)
        {
            int i;
            if (int.TryParse(numberString, out i))
            {
                Number = i;
            }
        }

        public void NullCheck(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException();
            }
            this.Name = name;
        }

        public void Switch(Person p)
        {
            switch (p)
            {

                default:
                    break;
            }
        }

        public void TupleDemo()
        {
            var t = Test();
        }

        public Tuple<int, string> Test()
        {
            return new Tuple<int, string>(3, "test");
        }
    }
}
