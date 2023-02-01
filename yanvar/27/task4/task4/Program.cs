using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            
              Console.WriteLine("Deyer daxıl edin");
              string trueText = Console.ReadLine();
              bool convertToBoolen = Convert.ToBoolean(trueText);
            


              Console.WriteLine("Deyer daxil edin");
              string Text1 = Console.ReadLine();
              string convertTostring = Convert.ToString(Text1);


              Console.WriteLine("Deyer daxil edin");
              string Text2 = Console.ReadLine();
              short parseShort = short.Parse(Text2);
            
              Console.WriteLine("Deyer daxil edin");
              string Text3 = Console.ReadLine();
              long parseLong = long.Parse(Text3);
           
            
              Console.WriteLine("Deyer daxil edin");
              int integerValue;
              string noString = Console.ReadLine();
              bool goodResult = int.TryParse(noString, out integerValue);
           
              Console.WriteLine("Deyer daxil edin");
              string noText = Console.ReadLine();
              DateTime parseDateTime = DateTime.Parse(noText);

             //char-ı yaza bilmedim.







        }
    }
}
