namespace Editor.Demo4
{
    class Refactor
    {
        public int Number { get; set; }

        public void Inizilazing()
        {
            var c = new Person();
            c.Name = "Testson";
            c.Age = 13;
            c.Phone = "123345";
            c.HairColor = "green";

        }

        public void IfStatement(int i)
        {
            if (i == 1)
            {
                //something
            }
            else if (i == 2)
            {
                //something somthing
            }
            else if (i == 3)
            {
                //something somthing something
            }
        }
    }
}
