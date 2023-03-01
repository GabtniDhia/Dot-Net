using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        //public int PassengerId { get; set; }
        [Required,DataType(DataType.DateTime),Display(Name ="Date Of Birth")]
        public DateTime BirthDate { get; set; }
        [Key, StringLength(7)]
        public int PassportNumber { get; set; }
        [DisplayName("Email")]
        [EmailAddress]
        public String EmailAddress { get; set; }
        [MaxLength(25, ErrorMessage ="Maximum 25 Chars"),MinLength(3 , ErrorMessage = "Minimum 3 Chars")]
        public String FirstName { get; set; }
        public String LastName { get; set; }
        [RegularExpression("[0-9]{8,}")]
        public String TelNumber { get; set; }



        public bool CheckProfile(string Fn, string Ln, string Em = null)
        {
            if (Em != null)
            {
                return Fn == FirstName && Ln == LastName && Em == EmailAddress;
            }
            return Fn == FirstName && Ln == LastName;
        }
        public virtual void PassengerType()
        {
            Console.WriteLine("I'm a passenger");
        }
        public List<Flight>? Flights { get; set; }
       
        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
