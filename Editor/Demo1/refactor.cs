namespace Editor.Demo4
{
    class Refactor
    {
        public int Number { get; set; }

        public void Test()
        {
            var c = new Person();
            c.Name = "Testson";
            c.Age = 13;
            c.Phone = "123345";
            c.HairColor = "green";
        }
    }
}
