using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    class GetStudentsInfo
    {
        public void GetInfoFromStudent()
        {
            
            bool run = true;
            char answer = ' ';
            int y = 0;
            var getInfo = new StudentsDatabase();


            while (run)
            {
                y++;
                //First name
                Console.Write("Give the first name: ");
                getInfo.firstName.Add(Console.ReadLine());
                //Last name
                Console.Write("Give the last name: ");
                getInfo.lastName.Add(Console.ReadLine());
                //Year of birth
                Console.Write("Give the year of birth: ");
                getInfo.date.Add(Convert.ToInt32(Console.ReadLine()));
                //Fee
                Console.Write("Give the fee student have paid: ");
                getInfo.fee.Add(Convert.ToInt32(Console.ReadLine()));
                //Id
                getInfo.id.Add(1);

                
                Console.WriteLine("Do you want to add new student: Y/N");

                answer = Convert.ToChar(Console.ReadLine());
                if (answer == 'Y' || answer == 'y')
                {
                    Console.WriteLine("Give me the new student.");
                    Console.WriteLine();
                }
                else if(answer == 'N' || answer == 'n')
                {
                    
                    run = false;
                }

                
            }
            

        }
        public void listOfStudents()
        {
          var printStudentsList = new  StudentsDatabase();

            var fnamePrint = printStudentsList.firstName;
            var lnamePrint = printStudentsList.lastName;
            var datePrint = printStudentsList.date;
            var feePrint = printStudentsList.fee;
            var idPrint = printStudentsList.id;
            int x = 0;
            Console.WriteLine("Is working");
            bool listRun = true;
            //do
            //{
            //    x++;
            //    Console.WriteLine("{0}{1}{2}{3}{4}", fnamePrint[x], lnamePrint[x], datePrint[x], feePrint[x], idPrint[x]);
            //} while (listRun);
            foreach(string at in fnamePrint)
            {
                x++;
                Console.WriteLine("not working");
                Console.WriteLine("{0}", at[x]);
            }


        }



    }
}
