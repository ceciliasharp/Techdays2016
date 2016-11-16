using System;

namespace Editor
{
    public class Strings
    {
        public void StringFormat()
        {
            var name = "Cecilia";
            var hello = string.Format("My name is {0}", name);
        }

        public void LongString()
        {
            var text = "Öl är en av de äldsta alkoholdryckerna i människans historia. Det är troligt att den första ölliknande drycken skapades genom att blött bröd jäste och därigenom skapades en lätt alkoholhaltig dryck.";
        }
    }

    public class cSharp7
    {
        public string Name { get; set; }
        public void ParseOut()
        {
            int i;
            int.TryParse("3", out i);
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
