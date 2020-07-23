using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    class MenuClass
    {
        public void Menu()
        {
            var newStudent = new GetStudentsInfo();
            



            bool run = true;
            while (run)
            {

                Console.WriteLine("//////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("//                     Welcome to the Menu                              //");
                Console.WriteLine("//////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("//                     Here is your choices                             //");
                Console.WriteLine("//////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("// *Press (0) to add new student                                        //");
                Console.WriteLine("// *Press (1) to see list of students                                   //");
                Console.WriteLine("// *Press (2) for list of all the trainers                              //");
                Console.WriteLine("// *Press (3) for list of all the assignments                           //");
                Console.WriteLine("// *Press (4) for list of all the courses                               //");
                Console.WriteLine("// *Press (5) for all the students per course                           //");
                Console.WriteLine("// *Press (6) for all the trainers per course                           //");
                Console.WriteLine("// *Press (7) for all the assignments per course                        //");
                Console.WriteLine("// *Press (8) for all the assignments per student                       //");
                Console.WriteLine("// *Press (9) for list of students that belong to more than one courses //");
                Console.WriteLine("//////////////////////////////////////////////////////////////////////////");



                int choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 0:
                        newStudent.GetInfoFromStudent();
                        break;
                    case 1:
                        newStudent.listOfStudents();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;

                }
            }
        }
    }
}
