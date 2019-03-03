using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            //eleman sayısı kullanıcı tarafındna belırlenen n adetli diziyi 
            //baska bır dızıye tersten ekleyen program
            int s = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[s];
            int []dizi2=new int[s];
            int a=0;
            Random r = new Random();
            for (int i = 0; i < s;i++)
            {
                dizi[i] = r.Next(50);             
            }
            for (int i = 0; i < s; i++)
            {
                Console.Write(dizi[i] + " ");
            }
            Console.WriteLine();
            for (int i = s - 1; i >= 0; i--)
            {
                dizi2[a] = dizi[i];
                a++;
            }
            for (int i = 0; i < s; i++)
            {
                Console.Write(dizi2[i] + " ");
            }
            Console.WriteLine();
            
        }
    }
}
