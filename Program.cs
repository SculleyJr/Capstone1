using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to the pig latin translater:");
            Console.WriteLine("Enter a word");
            // variable for letters
            string userInput = Console.ReadLine().ToLower();
            // variable for words
            string[] userInputArray = userInput.Split(' ');
            string modified = "";
            StringBuilder whole = new StringBuilder();
            
            // foreach (string word in userInputArray)
            // Method.Name

            if (userInput[0] == 'a' || userInput[0] == 'e' || userInput[0] == 'i' || userInput[0] == 'o' || userInput[0] == 'u')
                {
                    userInput = (userInput + "way");
                    Console.WriteLine(userInput);
                    return;
                }

                    for (int n = 0; n <= userInput.Length; n++)
                    {
                        if (userInput[n] == 'a' || userInput[n] == 'e' || userInput[n] == 'i' || userInput[n] == 'o' || userInput[n] == 'u')
                        {
                            modified = userInput.Insert(n, "-");
                            string[] modifiedArray = modified.Split('-');
                            modified = userInput;
                            Console.WriteLine($"{modifiedArray[1]}{modifiedArray[0]}" + "ay");
                            return;
                            
                        }
                    }
                
                
                Console.ReadKey();
               
        }
                




            
            
        
    }
}
