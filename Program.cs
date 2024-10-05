using System;
using System.Runtime.InteropServices;
namespace Vazifa
{
    class Program
    {
        static void Main(string[] args){
            System.Console.Write("Biror so'z kiriting: ");
            string str = Console.ReadLine();
            System.Console.Write("Son kiriting: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if(x > str.Length){
                
                System.Console.WriteLine(str.ToUpper());
            }
            else{
                System.Console.WriteLine(str.ToLower());
            }
        }
    }
}
// (To.Upper() yoki str.Length metodlarisiz ishlanishi zarur emasmi?)