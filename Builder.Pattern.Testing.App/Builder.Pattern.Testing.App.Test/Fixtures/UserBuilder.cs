namespace Builder.Pattern.Testing.App.Test.Fixtures
{
    public class UserBuilder
    {
        private string Name;
        private int Age;

        public UserBuilder WithName(String name)
        {
            this.Name = name;
            return this;
        }

        public UserBuilder WithAge(int age)
        {
            this.Age = age;
            return this;
        }

        public User Build()
        {
            return new User (Name, Age);
        }
    }
}
