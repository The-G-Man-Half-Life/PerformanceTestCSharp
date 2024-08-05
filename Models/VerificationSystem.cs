using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerformanceTestCSharp.Models;

public static class verificationSystem
{
    public static string NormalizationOfString(string phrase)
    {
        bool flag = true;
        string newWord = "";
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(inputWord))
            {
                Console.Clear();
                Console.WriteLine("You must write a valid Word");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                newWord = inputWord.Trim().ToLower();
                break;
            }
        }
        return newWord;
    } 

    public static double VerificateDouble(string phrase)
    {
        bool flag = true;
        double newNumber = 0;
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (double.TryParse(inputWord, out newNumber)== false || inputWord.Contains("-"))
            {
                Console.Clear();
                Console.WriteLine("You must write a valid number");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                break;
            }
        }
        return newNumber;
    } 

    public static byte Verificatebyte(string phrase)
    {
        bool flag = true;
        byte newNumber = 0;
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (byte.TryParse(inputWord, out newNumber)== false || inputWord.Contains("-"))
            {
                Console.Clear();
                Console.WriteLine("You must write a valid age");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                break;
            }
        }
        return newNumber;
    } 

    public static string VerificateEmail(string phrase)
    {
        bool flag = true;
        string newWord = "";
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(inputWord) || inputWord.Contains("@")== false || inputWord.Contains(".com")== false)
            {
                Console.Clear();
                Console.WriteLine("You must write a valid email");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                newWord = inputWord.Trim().ToLower();
                break;
            }
        }
        return newWord;
    }


    public static int VerificateYear(string phrase)
    {
        bool flag = true;
        int newNumber = 0;
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (int.TryParse(inputWord, out newNumber)== false || newNumber<0001 || newNumber>DateTime.Now.Year)
            {
                Console.Clear();
                Console.WriteLine("You must write a valid year");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                break;
            }
        }
        return newNumber;
    }

    public static int VerificateMonth(string phrase)
    {
        bool flag = true;
        int newNumber = 0;
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (int.TryParse(inputWord, out newNumber)== false || newNumber<1 || newNumber>12)
            {
                Console.Clear();
                Console.WriteLine("You must write a valid month");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                break;
            }
        }
        return newNumber;
    }

    public static int Verificateday(string phrase)

    {
        bool flag = true;
        int newNumber = 0;
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (int.TryParse(inputWord, out newNumber)== false || newNumber<1 || newNumber>31)
            {
                Console.Clear();
                Console.WriteLine("You must write a valid day");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                break;
            }
        }
        return newNumber;
    }

    public static int VerificateInt(string phrase)
    {
        bool flag = true;
        int newNumber = 0;
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (int.TryParse(inputWord, out newNumber)== false || inputWord.Contains("-"))
            {
                Console.Clear();
                Console.WriteLine("You must write a valid number");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                break;
            }
        }
        return newNumber;
    } 
    
    public static int verificateCatExistence(List<Cat> list, string phrase)
    {
        bool flag = true;
        int catUbication= 0;
        
        while(flag==true)
        {
            int inputWord =VerificateInt(phrase);
            bool catExists = list.Any(item=>item.GetId() == inputWord);

            if (catExists == false)
            {
                Console.Clear();
                Console.WriteLine("The cat doesnt exist keep trying");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                catUbication = list.FindIndex(cat => cat.GetId() == inputWord);
                break;
            }
        }
        return catUbication;
    }

        public static int verificateDogExistence(List<Dog> list, string phrase)
    {
        bool flag = true;
        int dogUbication= 0;
        
        while(flag==true)
        {
            int inputWord =VerificateInt(phrase);
            bool dogExists = list.Any(item=>item.GetId() == inputWord);

            if (dogExists == false)
            {
                Console.Clear();
                Console.WriteLine("The dog doesnt exist keep trying");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                dogUbication = list.FindIndex(dog => dog.GetId() == inputWord);
                break;
            }
        }
        return dogUbication;
    }
    
    public static int VerificateRange(string phrase,int minValue,int maxValue)
    {
        bool flag = true;
        byte newNumber = 0;
        
        while(flag==true)
        {
            string inputWord = Console.ReadLine();

            if (byte.TryParse(inputWord, out newNumber)== false || newNumber<minValue || newNumber>maxValue)
            {
                Console.Clear();
                Console.WriteLine("You must write a valid option");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                break;
            }
        }
        return newNumber;
    }
    }
