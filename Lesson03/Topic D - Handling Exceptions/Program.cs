using System;
using static System.Console;
using System.IO;

namespace Ch03_HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Before parsing");
            Write("Which page number you are in? ");
            string input = Console.ReadLine();
            try
            {
                int pg = int.Parse(input);
                WriteLine($"You are in page number {pg}.");
            }
            catch (OverflowException)
            {
                WriteLine("Your page number is a valid number format but it is either too big or small.");
            }
            catch (FormatException)
            {
                WriteLine("The page number you entered is not a valid number format.");
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            WriteLine("After parsing");

           string path = @"C:\Code\Lesson3"; // Windows

             FileStream file = null;
             StreamWriter writer = null;
             try
             {

                 if (Directory.Exists(path))
                 {
                     file = File.OpenWrite(Path.Combine(path, "file.txt"));
                     writer = new StreamWriter(file);
                     writer.WriteLine("Hello, C#!");
                 }
                 else
                 {
                     WriteLine($"{path} does not exist!");
                 }
             }
             catch (Exception ex)
             {
                 // if the path doesn't exist the exception will be caught
                 WriteLine($"{ex.GetType()} says {ex.Message}");
             }
             finally
             {
                 if (writer != null)
                 {
                     writer.Dispose();
                     WriteLine("The writer's unmanaged resources have been disposed.");
                 }
                 if (file != null)
                 {
                     file.Dispose();
                     WriteLine("The file's unmanaged resources have been disposed.");
                 }
             }

             using (FileStream file2 = File.OpenWrite(
                 Path.Combine(path, "file2.txt")))
             {
                 using (StreamWriter writer2 = new StreamWriter(file2))
                 {
                     try
                     {
                         writer2.WriteLine("Welcome, .NET Core!");
                     }
                     catch (Exception ex)
                     {
                         WriteLine($"{ex.GetType()} says {ex.Message}");
                     }
                 } // automatically calls Dispose if the object is not null
             } // automatically calls Dispose if the object is not null
             MultipleCatch("128");
             MultipleCatch("3000");
             MultipleCatch("abc");
             MultipleCatch();

         }
         static void MultipleCatch(params string[] args)
         {
             try
             {
                 byte b = byte.Parse(args[0]);
                 Console.WriteLine(b);
             }
             catch (IndexOutOfRangeException ex)
             {
                 Console.WriteLine("Atleast one argument is required (IndexOutOfRangeException)");
             }
             catch (FormatException ex)
             {
                 Console.WriteLine("Not a number! (FormatException)");
             }
             catch (OverflowException ex)
             {
                 Console.WriteLine("More than a byte (OverflowException)...");
             }
        }
    }
    }
