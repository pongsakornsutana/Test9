using System;

namespace Test99
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string select;
            Console.Write("Input skill name:");
            name = Console.ReadLine();
            if (name != "?")
            {
                Console.WriteLine("Input skill name:" + name);
                Console.Write("? (Y/N): ");
                select = Console.ReadLine();
                if ("Y" != "Input skill name:")
                {
                    Console.Write("Input skill name:" + name);

                    Console.Write("Input skill name:", name);
                    Console.Write("? (Y/N): ");
                    select = Console.ReadLine();
                    if ("Y" == "Input skill name:")
                    {
                        Console.WriteLine("Input skill name:"+name);

                    }
                    if ("N" == "Input skill name:")
                    {
                        Console.WriteLine("Input skill name:"+name);
                    }
                }
            }
            else {
                Console.WriteLine("Add dependency for"+name);
                Console.Write("? (Y/N): ");
                select = Console.ReadLine();
                if ("Y" == "Input skill name:")
                {
                    Console.WriteLine("Input skill name:");
                    name = Console.ReadLine();
                }
                if ("N" == "Input skill name:")
                {
                    Console.WriteLine("Input skill name:" + name);
                }
            }
        }
      


        }
    }

