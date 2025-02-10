using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Wk5Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ask user input a string
            string input = Console.ReadLine();
            //process
            Dictionary<char, int> duplications = new Dictionary<string, int>();
            foreach (char c in input)
            {
                //check if dictionary already not has a key (character), then add a key
                if (!duplications.ContainsKey(c))
                {
                    duplications[c] = 1;
                }
                else
                {
                    duplications[c]++;
                }
            }

            foreach (KeyValuePair<string, int> pair in duplications.Values)
            { 
                Console.WriteLine(Kvp.key + ";"+kvp.Value);
            }

            Console.ReadLine();
        }
    }
}
