using FluentAssertions;
using OOPsReview;
namespace TDDUnitTestDemo
{
    public class Person_Should
    {
        [Fact]
        public void Create_an_Instance_With_First_And_Last_Name()
        {
            //arrange
            string firstname = "Khushman";
            string lastname = "Kapoor";

            //act
            Person sut = new Person(firstname, lastname);

            //assert (testing of the action)
            sut.FirstName.Should().Be(firstname);
            sut.LastName.Should().Be(lastname);
        }
    }
}