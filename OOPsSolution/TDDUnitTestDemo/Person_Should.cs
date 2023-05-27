using FluentAssertions;
using OOPsReview;
namespace TDDUnitTestDemo
{
    public class Person_Should
    {
        [Fact]
        public void Create_an_Instance_Using_Default_Constructor()
        {

            //act
            Person sut = new Person();

            //assert (testing of the action)
            sut.FirstName.Should().BeNull();
            sut.LastName.Should().BeNull();
            sut.Address.Should().BeNull();
            sut.EmploymentPositions.Count().Should().Be(0);
        }


        [Fact]
        public void Create_an_Instance_With_First_And_Last_Name_Residence_With_No_List_of_Employement()
        {
            //arrange
            string firstname = "Khushman";
            string lastname = "Kapoor";
            Residence address = new Residence(123, "Maple St.", "Edmonton", "AB", "T6Y7U8");
            string expectedAddress = "123,Maple St., Edmonton,AB,T6Y7U8";


            //act
            Person sut = new Person(firstname, lastname, address, null);

            //assert (testing of the action)
            sut.FirstName.Should().Be(firstname);
            sut.LastName.Should().Be(lastname);
            sut.Address.ToString().Should().Be(expectedAddress);
            sut.EmploymentPositions.Count().Should().Be(0);
        }
    }
}