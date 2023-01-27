using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_solution_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Xoş gəldiniz");
            string name,surname, gender;
            Console.Write("Adınızı daxil edin");
            name = Console.ReadLine();
            Console.Write("Soyadınızı daxil edin");
            surname = Console.ReadLine();
            Console.Write("Sizə necə müraciət edim?");
            gender = Console.ReadLine();

            Console.Clear();
         
            Console.Write(name + " " + gender, "Doğum tarixiniz nədir?");
            DateTime specificDate = Convert.ToDateTime(Console.ReadLine());
         
            string country, city;
            Console.Write(name + " " + gender, "Hansı ölkədə yaşayırsınız? ");
            country = Console.ReadLine();
            Console.Write(name + " " + gender, "Hansı şəhərdə yaşayırsınız?");
            city = Console.ReadLine();
            float height = Convert.ToSingle(Console.ReadLine());
            float weight = Convert.ToSingle(Console.ReadLine());
            decimal salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(specificDate);
            Console.WriteLine(country);
            Console.WriteLine(city);
            Console.WriteLine(height);
            Console.WriteLine(weight);
            Console.WriteLine(salary);
            Console.ReadLine();

                























































































































































        }
    }
}
