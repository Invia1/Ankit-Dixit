using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Program.Model
{
    public class Patient
    {
        public int PatientID { get; set; }  
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double ContactNo { get; set; }
        public int Age { get; set; }
        

        public string Gender { get; set; }
        public double AdharNo { get; set; }

        public string Address { get; set; }
        
        public string Speciality { get; set; }  

    }
}
