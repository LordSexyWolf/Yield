using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Yield
{
    class Program
    {
        static void Main(string [] args)
        {
            foreach (var update in GetElement())
            {
                Console.WriteLine("Installing..."+update+" Component.");
            }
        }
        static IEnumerable<int> GetElement()
        {
            //List<int> elements = new List<int>();
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine("Downloading Visual Studio part: "+i);
                //elements.Add(i);
                yield return i;
                Console.WriteLine("- Deleting Temporary Files -");
            }
            //return elements;
        }
    }
}