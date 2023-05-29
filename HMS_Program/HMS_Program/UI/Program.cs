using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_Program.Class;
using HMS_Program.IterFace;
using HMS_Program.Model;

namespace HMS_Program.UI
{
    internal class Program
    {
        public static void Main()
        {
            Interface1 detail = new GeneralMedicine();          // Object of Interface
            Interface1 detail1 = new Dental();
            Interface1 detail2 = new Orthopedist();
            int a;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("_____________________");
                Console.WriteLine("Hospital Management Program");
                Console.WriteLine("Three DepartMent present in this program");
                Console.WriteLine("_____________________");
                Console.WriteLine("Press 1 for General Medicine");
                Console.WriteLine("Press 2 for Dental");
                Console.WriteLine("Press 3 for OrthoPedi");
                Console.WriteLine("_____________________");

                Console.WriteLine("Enter your Choice");
                a= int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        {
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine("Press 1 For Add Patient of general medicine..");
                            Console.WriteLine("Press 2 For Display Patient list of general medicine..");
                            Console.WriteLine("Press 3 for Update Patient List of general medicine");
                            Console.WriteLine("Press 4 for Delete Patient List of general medicine");

                            Console.WriteLine("-----------------------------------------------------------");
                            int n;
                            Console.WriteLine("Enter your choice...");
                            n = Convert.ToInt32(Console.ReadLine());

                            switch (n)
                            {
                                case 1:
                                    Patient obj = new Patient();
                                    Console.WriteLine("Enter Patient Registration Id : ");
                                    obj.PatientID = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Enter Patient First Name : ");
                                    obj.FirstName = Console.ReadLine();

                                    Console.WriteLine("Enter Patient Last Name : ");
                                    obj.LastName = Console.ReadLine();

                                    Console.WriteLine("Enter Patient Phone No : ");
                                    obj.ContactNo = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine("Enter Patient Gender : ");
                                    obj.Gender = Console.ReadLine();

                                    Console.WriteLine("Enter Patient Age : ");
                                    obj.Age = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Enter Patient Address : ");
                                    obj.Address = Console.ReadLine();

                                    Console.WriteLine("Enter Patient Adhar No : ");
                                    obj.AdharNo = Convert.ToDouble(Console.ReadLine());
                                    
                                   

                                    detail.addpatient(obj);
                                    break;


                                case 2:
                                    detail.display();
                                    break;

                                case 3:
                                   Console.WriteLine("To update   the patient please enter Registration id");
                                    int id=Convert.ToInt32(Console.ReadLine());
                                    detail.updatepatient(id);
                                    break;

                                case 4:
                                    Console.WriteLine("To Delete the patient please enter Registration id");
                                    int PatientID = Convert.ToInt32(Console.ReadLine());
                                    detail.DeletePatient(PatientID);
                                    break;



                                default:
                                    Console.WriteLine("Enter valid choice ");
                                    break;

                                
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine("Enter 1 For Add Patient of Dental..");
                            Console.WriteLine("Enter 2 For Display Patient list of Dental..");
                            Console.WriteLine("Press 3 for Update Patient List of Dental");
                            Console.WriteLine("Press 4 for Delete Patient List of general medicine");
                            Console.WriteLine("----------------------------------------------------------");

                            int n;
                            Console.WriteLine("Enter your choice...");
                            n = Convert.ToInt32(Console.ReadLine());

                            switch (n)
                            {
                                case 1:
                                    Patient obj = new Patient();
                                    Console.WriteLine("Enter Patient Registration Id : ");
                                    obj.PatientID = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Enter Patient First Name : ");
                                    obj.FirstName = Console.ReadLine();

                                    Console.WriteLine("Enter Patient Last Name : ");
                                    obj.LastName = Console.ReadLine();

                                    Console.WriteLine("Enter Patient Phone No : ");
                                    obj.ContactNo = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine("Enter Patient Gender : ");
                                    obj.Gender = Console.ReadLine();

                                    Console.WriteLine("Enter Patient Age : ");
                                    obj.Age = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Enter Patient Address : ");
                                    obj.Address = Console.ReadLine();

                                    Console.WriteLine("Enter Patient Adhar No : ");
                                    obj.AdharNo = Convert.ToDouble(Console.ReadLine());

                                    detail1.addpatient(obj);
                                    break;
                                case 2:
                                    detail1.display();
                                    break;

                                case 3:
                                    Console.WriteLine("To update te  the patient please enter Registration id");
                                    int id = Convert.ToInt32(Console.ReadLine());
                                    detail1.updatepatient(id);
                                    break;

                                case 4:
                                    Console.WriteLine("To Delete the patient please enter Registration id");
                                    int PatientID = Convert.ToInt32(Console.ReadLine());
                                    detail1.DeletePatient(PatientID);
                                    break;
                                    
                                default:
                                    Console.WriteLine("Enter valid choice ");
                                    break;

                               
                            }

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine("Enter 1 For Add Patient of Ortho..");
                            Console.WriteLine("Enter 2 For Display Patient list of Ortho..");
                            Console.WriteLine("Press 3 for Update Patient List of Ortho");
                            Console.WriteLine("Press 4 for Delete Patient List of general medicine");
                            Console.WriteLine("----------------------------------------------------------");

                            int n;
                            Console.WriteLine("Enter your choice...");
                            n = Convert.ToInt32(Console.ReadLine());

                            switch (n)
                            {
                                case 1:
                                    Patient obj = new Patient();
                                    Console.WriteLine("Enter Patient Registration Id : ");
                                    obj.PatientID = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Enter Patient First Name : ");
                                    obj.FirstName = Console.ReadLine();

                                    Console.WriteLine("Enter Patient Last Name : ");
                                    obj.LastName = Console.ReadLine();

                                    Console.WriteLine("Enter Patient Phone No : ");
                                    obj.ContactNo = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine("Enter Patient Gender : ");
                                    obj.Gender = Console.ReadLine();

                                    Console.WriteLine("Enter Patient Age : ");
                                    obj.Age = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Enter Patient Address : ");
                                    obj.Address = Console.ReadLine();

                                    Console.WriteLine("Enter Patient Adhar No : ");
                                    obj.AdharNo = Convert.ToDouble(Console.ReadLine());


                                    detail2.addpatient(obj);
                                    break;
                                case 2:
                                    detail2.display();
                                    break;

                                case 3:
                                    Console.WriteLine("To update te  the patient please enter Registration id");
                                    int id = Convert.ToInt32(Console.ReadLine());
                                    detail2.updatepatient(id);
                                    break;


                                case 4:
                                    Console.WriteLine("To Delete the patient please enter Registration id");
                                    int PatientID = Convert.ToInt32(Console.ReadLine());
                                    detail2.DeletePatient(PatientID);
                                    break;

                                default:
                                    Console.WriteLine("Enter valid choice ");
                                    break;
                            }
                            break;
                        }


                }

            }
            string ch;
            Console.WriteLine("Do you want to Continue ? Enter 'Y' for Yes. Otherwise Press 'N'");
            ch = Console.ReadLine();
            if (ch == "Y" || ch == "y")
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
        }
    }
                
 }
        
    

