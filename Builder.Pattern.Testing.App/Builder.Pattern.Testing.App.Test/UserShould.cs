using Builder.Pattern.Testing.App.Test.Fixtures;

namespace Builder.Pattern.Testing.App.Test
{
    public class UserShould
    {
        private Home home;
        [SetUp]
        public void Setup()
        {
            home = new Home();
        }

        [Test]
        public void get_message_under_eighteen_years()
        {
            //Given
            var givenUserUnderEighteen = new UserBuilder().WithName("Pepito")
                .WithAge(16)
                .Build();

            //When
            var message = home.Access(givenUserUnderEighteen);

            //Then
            Assert.IsTrue(string.Equals(message, "Aplicación web solo para personas mayores de edad",
                StringComparison.OrdinalIgnoreCase));
        }

        [Test]
        public void get_message_over_eighteen_under_thirty_years()
        {
            //Given
            var givenUserOverEighteenUnderThirty = new UserBuilder().WithName("Pepito")
                .WithAge(29)
                .Build();

            //When
            var message = home.Access(givenUserOverEighteenUnderThirty);

            //Then
            Assert.IsTrue(string.Equals(message, "Consigue un descuento de 20€ en tu primer pedido",
                StringComparison.OrdinalIgnoreCase));
        }


        [Test]
        public void get_message_over_thirty_under_sixty_five_years()
        {
            //Given
            var givenUserOverThirtyUnderSixtyFive = new UserBuilder().WithName("Pepito")
                .WithAge(46)
                .Build();

            //When
            var message = home.Access(givenUserOverThirtyUnderSixtyFive);

            //Then
            Assert.IsTrue(string.Equals(message, "Consigue un descuento de 25€ en tu primer pedido",
                StringComparison.OrdinalIgnoreCase));
        }

        [Test]
        public void get_message_over_sixty_five_years()
        {
            //Given
            var givenUserOverSixtyFive = new UserBuilder().WithName("Pepito")
                .WithAge(67)
                .Build();

            //When
            var message = home.Access(givenUserOverSixtyFive);

            //Then
            Assert.IsTrue(string.Equals(message, "Consigue un descuento de 30€ en tu primer pedido",
                StringComparison.OrdinalIgnoreCase));
        }
    }
}