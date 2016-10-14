using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;

namespace programme.fr
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args[1] == "interactive")
                {
                    switch (args[2])
                    {
                        case "faire":
                            System.Diagnostics.Process.Start(args[3]);
                            break;
                        case "ecoute":
                            if (args[3] == "")
                            {
                                Console.ReadLine();
                            }
                            Console.WriteLine(args[3]);
                            Console.ReadLine();
                            break;
                    }
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(Strings.ERROR_PRESS_KEY_TO_CONTINUE);
                Console.Read();

            }
        }
    }
}
