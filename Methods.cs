// using System;
// using System.IO;
// using System.Collections.Generic;
// using System.Linq;

// namespace Methods
// {

//     public class Methods
//     {   
//         static void Main(string[] args)
//         {

//             System.Console.WriteLine("Please enter the file path you'd want to copy: \n");
//             string fl = Console.ReadLine();
//                         string rootPath = @"{fl}"; 
//                         string[] filePath = Directory.GetFiles(rootPath);

//                         string destination = @"C:\Users\Mohammad Omer\source\repos\textDocs\pattern\";

//                         foreach (string file in filePath)
//                         {
//                             File.Copy(file, $"{destination}{Path.GetFileName(file)}");
//                         }
//         }
//     }

// }