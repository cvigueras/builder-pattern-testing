namespace Builder.Pattern.Testing.App
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public static User Create(string name, int age)
        {
            return new User(name, age);
        }
    }
}
