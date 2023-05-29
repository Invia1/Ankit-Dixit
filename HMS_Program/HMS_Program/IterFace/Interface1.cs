using HMS_Program.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_Program.Model;
using HMS_Program.Class;

namespace HMS_Program.IterFace
{
    public interface Interface1
    {
        int addpatient(Patient temp);
        List<Patient> display();

        void updatepatient(int id);
        void DeletePatient(int id);


    }
}
