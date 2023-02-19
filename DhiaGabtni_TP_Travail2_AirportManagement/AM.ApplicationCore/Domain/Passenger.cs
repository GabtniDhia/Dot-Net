using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public int PassportNumber { get; set; }
        public String EmailAddress { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
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
