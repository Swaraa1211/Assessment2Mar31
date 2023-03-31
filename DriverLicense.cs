using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2Mar31
{
    internal class DriverLicense
    {
        public static void Main(string[] args)
        {
            DriverLicense obj = new DriverLicense();
            Console.WriteLine("Hello!");
            
            /*string name = "Eric";
            int agent = 2;
            List<string> other_people = new List<string>();
            other_people.Add("Adam");
            other_people.Add("Caroline");
            other_people.Add("Rebecca");
            other_people.Add("Frank");*/

            
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("\nAgent: ");
            int agent = Convert.ToInt32(Console.ReadLine());

            List<string> other_people = new List<string>();
            for(int i=0; i<4; i++)
            {
                Console.Write("\nOthers: ");
                var names = Console.ReadLine();
                other_people.Add(names);
            }

             


            obj.License(name,agent, other_people);
            Console.WriteLine("Thank You!");
        }

        public void License(string name,int agent, List<string> other_people)
        {
            other_people.Add(name);
            other_people.Sort();
            int num = other_people.FindIndex(a => a.Contains(name));
            Console.WriteLine($"In {num*20} mins, your license would be processed");
        }
    }
}
