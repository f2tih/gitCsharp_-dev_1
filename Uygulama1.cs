using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev1
{
    internal class Uygulama1
    {
 public void appRun()
        {
              Console.WriteLine("1.sayıyı giriniz");
            int s1 = Convert.ToInt32(Console.ReadLine());

              Console.WriteLine("2.sayıyı giriniz");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3.sayıyı giriniz");
            int s3 = Convert.ToInt32(Console.ReadLine());

   
            Console.WriteLine("4.sayıyı giriniz");
            int s4 = Convert.ToInt32(Console.ReadLine());


            int avarge = (s1 + s2 + s3 + s4) / 4;
            Console.WriteLine("sayıların ortalaması" + avarge);

        }
    }
}
