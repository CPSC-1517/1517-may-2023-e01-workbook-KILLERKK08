using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    public class Person
    {
        private string _FirstName;
        private string _LastName;

        public string FirstName
        { get; set; }

        public string LastName
        { get; set; }
        
        public Residence Address { get; set; }
        
        public List<Employment> EmploymentPositions { get; set; }
        
        public Person(string firstname, string lastname, Residence address, List<Employment> employmentpositions)
        {
            FirstName = firstname;
            LastName = lastname;
            if (employmentpositions != null)
            {
                EmploymentPositions = employmentpositions;
            }
            else
            {
                EmploymentPositions = new List<Employment>();
            }
        }
        public Person()
        {
            EmploymentPositions = new List<Employment>();
        }
    }
}
