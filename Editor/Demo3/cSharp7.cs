using System;

namespace Editor
{

    public class cSharp7
    {
        public string Name { get; set; }
        public void ParseOut(string numberString)
        {
            int i;
            int.TryParse(numberString, out i);
        }

        public void NullCheck(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException();
            }
            this.Name = name;
        }
    }
}
