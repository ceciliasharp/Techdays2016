namespace Editor.Demo4
{
    public class Person
    {
        public int Age { get; internal set; }
        public string HairColor { get; internal set; }
        public string Name { get; internal set; }
        public string Phone { get; internal set; }
    }

    public class Customer : Person
    {
        public bool GoldLevel { get; set; }
    }
    public class Employee : Person { }
}
