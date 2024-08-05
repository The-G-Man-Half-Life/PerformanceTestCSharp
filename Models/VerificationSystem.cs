using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PerformanceTestCSharp.Models;

// all my verification functionalities for data and existence of certain elements
public static class verificationSystem
{
    public static string NormalizationOfString(string phrase)
    {
        bool flag = true;
        string newWord = "";

        while (flag == true)
        {
            string inputWord = Console.ReadLine();
            ManagerApp.ShowSeparator();
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

        while (flag == true)
        {
            string inputWord = Console.ReadLine();
            ManagerApp.ShowSeparator();
            if (double.TryParse(inputWord, out newNumber) == false || inputWord.Contains("-"))
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

    public static int VerificateYear(string phrase)
    {
        bool flag = true;
        int newNumber = 0;

        while (flag == true)
        {
            string inputWord = Console.ReadLine();
            ManagerApp.ShowSeparator();
            if (int.TryParse(inputWord, out newNumber) == false || newNumber < 0001 || newNumber > DateTime.Now.Year)
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

        while (flag == true)
        {
            string inputWord = Console.ReadLine();
            ManagerApp.ShowSeparator();
            if (int.TryParse(inputWord, out newNumber) == false || newNumber < 1 || newNumber > 12)
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

        while (flag == true)
        {
            string inputWord = Console.ReadLine();
                ManagerApp.ShowSeparator();
            if (int.TryParse(inputWord, out newNumber) == false || newNumber < 1 || newNumber > 31)
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

        while (flag == true)
        {
            string inputWord = Console.ReadLine();
            ManagerApp.ShowSeparator();
            if (int.TryParse(inputWord, out newNumber) == false || inputWord.Contains("-"))
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
        int catUbication = 0;

        while (flag == true)
        {
            int inputWord = VerificateInt(phrase);
            bool catExists = list.Any(item => item.GetId() == inputWord);

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
        int dogUbication = 0;

        while (flag == true)
        {
            int inputWord = VerificateInt(phrase);
            bool dogExists = list.Any(item => item.GetId() == inputWord);

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

    public static int VerificateRange(string phrase, int minValue, int maxValue)
    {
        bool flag = true;
        byte newNumber = 0;

        while (flag == true)
        {
            string inputWord = Console.ReadLine();
            ManagerApp.ShowSeparator();
            if (byte.TryParse(inputWord, out newNumber) == false || newNumber < minValue || newNumber > maxValue)
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

    public static int VerificateIdDogExistence(List<Dog> list, string phrase)
    {
        bool flag = true;
        int dogUbication = 0;

        while (flag == true)
        {
            int inputWord = VerificateInt(phrase);
            bool dogExists = list.Any(item => item.GetId() == inputWord);

            if (dogExists == true)
            {
                Console.Clear();
                Console.WriteLine("The Id already exists keep trying");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                dogUbication = inputWord;
                break;
            }
        }
        return dogUbication;
    }

    public static int VerificateIdCatExistence(List<Cat> list, string phrase)
    {
        bool flag = true;
        int catUbication = 0;

        while (flag == true)
        {
            int inputWord = VerificateInt(phrase);
            bool catExists = list.Any(item => item.GetId() == inputWord);

            if (catExists != false)
            {
                Console.Clear();
                Console.WriteLine("The Id already exists keep trying");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                catUbication = inputWord;
                break;
            }
        }
        return catUbication;
    }


    public static int VerificateIdDogExistence2(List<Dog> list, string phrase)
    {
        bool flag = true;
        int dogUbication = 0;

        while (flag == true)
        {
            int inputWord = VerificateInt(phrase);
            bool dogExists = list.Any(item => item.GetId() == inputWord);

            if (dogExists == false)
            {
                Console.Clear();
                Console.WriteLine("The Id does no exist keep trying");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                dogUbication = inputWord;
                break;
            }
        }
        return dogUbication;
    }

    public static int VerificateIdCatExistence2(List<Cat> list, string phrase)
    {
        bool flag = true;
        int catUbication = 0;

        while (flag == true)
        {
            int inputWord = VerificateInt(phrase);
            bool catExists = list.Any(item => item.GetId() == inputWord);

            if (catExists == false)
            {
                Console.Clear();
                Console.WriteLine("The Id already exists keep trying");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
            else
            {
                catUbication = inputWord;
                break;
            }
        }
        return catUbication;
    }

    public static bool VerificateBreedingStatus(string phrase)
    {
        bool flag = true;
        bool newStatus = true;

        while (flag == true)
        {
            string inputWord = Console.ReadLine().Trim().ToLower();
            ManagerApp.ShowSeparator();
            if (inputWord == "yes")
            {
                newStatus = true;
                break;
            }
            else if (inputWord == "no")
            {
                newStatus = false;
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You must write yes or no");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(phrase);
            }
        }
        return newStatus;
    }
}