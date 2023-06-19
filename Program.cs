using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace DAB
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                 System.Console.WriteLine("Please enter the destination of file : \n");
                string dest = Console.ReadLine();

                System.Console.WriteLine("1. Read \n2. Write");
                var Data = Convert.ToInt32(Console.ReadLine());

               switch (Data)
               {
                   case 1:
                    readFiles();
                    System.Console.WriteLine("\nWe have Readed all your file in " + dest);
                   break;
                   case 2:
                    writeFiles();
                    System.Console.WriteLine("\nWe have writed your file in " + dest);
                    break;
                    case 3:
                    copyFiles();
                    System.Console.WriteLine("\nWe have Copied your file in " + dest);
                    break;
                    
                   default:
                    System.Console.WriteLine("error");
                    break;
               }

                // Methods

                void readFiles()
                {

                    string filePath = @"{dest}";

                    List<string> lines = new  List<string>();

                    lines = File.ReadAllLines(dest).ToList();

                    foreach (string read in lines)
                    {
                        System.Console.WriteLine(read);

                         
                    }

                }
            
                void writeFiles()
                {

                    System.Console.WriteLine("What do you want to write : \n");
                    var writeTxt = Console.ReadLine();

                    string filePath = @"{dest}";

                    List<string> lines = new  List<string>();

                    lines = File.ReadAllLines(dest).ToList();

                    lines.Add(writeTxt);
                    File.WriteAllLines(dest, lines);

                    

                }      
                void copyFiles()
                {

                    string[] files = Directory.GetFiles(dest);

                    string filePath = @"{dest}";

                    foreach (string file in filePath.ToString().Split())
                    {
                        File.Copy();
                    }
                }
                void createDirectory()
                {
                    string filePath = dest;

                    // System.Console.WriteLine("Directory Name : \n");
                    // string create = Console.ReadLine();

                    // Directory.CreateDirectory();

                    if (!Directory.Exists(filePath))
                        {
                            Directory.CreateDirectory(filePath);
                        }
                }
               
            }


            

            catch (System.Exception mess)
            {
                System.Console.WriteLine(mess.Message);
            }
        }
    }

}