using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerformanceTestCSharp.Models;
public static class ManagerApp
{//methodsof Create for both animals
    public static Dog CreateADog(VeterinaryClinic vet)
    {       ShowSeparator();
        Console.Write("Enter the Id of your Dog: ");
        int dogId = verificationSystem.VerificateIdDogExistence(vet.Dogs,"Enter the Id of your Dog: ");
                ShowSeparator();
        Console.Write("Enter the name of your Dog: ");
        string dogName = verificationSystem.NormalizationOfString("Enter the name of your Dog: ");
                ShowSeparator();
        Console.Write("Enter the year of birth your Dog: ");
        int dogBirthYear = verificationSystem.VerificateYear("Enter the year of birth your Dog: ");
        ShowSeparator();
        Console.Write("Enter the month of birth of your Dog: ");
        int dogBirthMonth = verificationSystem.VerificateMonth("Enter the month of birth of your Dog: ");
        ShowSeparator();
        Console.Write("Enter the day of birth of your Dog: ");
        int dogBirthDay = verificationSystem.Verificateday("Enter the day of birth of your Dog: ");
        ShowSeparator();
        Console.Write("Enter the breed of your dog: ");
        string dogBreed = verificationSystem.NormalizationOfString("Enter the breed of your dog: ");
        ShowSeparator();
        Console.Write("Enter the color of your dog: ");
        string dogColor = verificationSystem.NormalizationOfString("Enter the color of your dog: ");
        ShowSeparator();
        Console.Write("Enter the weight of your Dog (only numbers) in kg: ");
        double dogWeightInKG = verificationSystem.VerificateDouble("Enter the weight of your Dog (only numbers) in kg: ");
        ShowSeparator();
        string Review =Animal.ReceiveBasicreview();
        ShowSeparator();
        Console.Write("Is your dog castrated(yes/no): ");
        bool dogBreedingStatus = verificationSystem.VerificateBreedingStatus("Is your dog castrated(yes/no): ");
        ShowSeparator();
        string dogTemperament = VisualInterface.DisplayKindOfTemperaments();
        ShowSeparator();
        Console.Write("Enter the microchip number of your Dog: ");
        string dogMicrochip = verificationSystem.NormalizationOfString("Enter the microchip number of your dog: ");
        ShowSeparator();
        Console.Write("Enter the bark volume of your Dog (only numbers): ");
        double dogBarkDB = verificationSystem.VerificateDouble("Enter the Volume of your Dog: ");
        string dogBarkDBI= Convert.ToString(dogName) + "db";
            ShowSeparator();
        string coatType = VisualInterface.DisplayKindOfHairDresses();

        return new Dog(dogId ,dogName ,new DateOnly(dogBirthYear,dogBirthMonth,dogBirthDay) ,dogBreed ,dogColor ,dogWeightInKG ,Review,dogBreedingStatus ,dogTemperament ,dogMicrochip ,dogBarkDBI ,coatType);
    }

    public static Cat CreateACat(VeterinaryClinic vet)
    {
        ShowSeparator();
        Console.Write("Enter the Id of your cat: ");
        int catId = verificationSystem.VerificateIdCatExistence(vet.Cats,"Enter the Id of your cat: ");
                ShowSeparator();
        Console.Write("Enter the name of your cat: ");
        string catName = verificationSystem.NormalizationOfString("Enter the name of your cat: ");
                ShowSeparator();
        Console.Write("Enter the year of birth your cat: ");
        int catBirthYear = verificationSystem.VerificateYear("Enter the year of birth your cat: ");
        ShowSeparator();
        Console.Write("Enter the month of birth of your cat: ");
        int catBirthMonth = verificationSystem.VerificateMonth("Enter the month of birth of your cat: ");
        ShowSeparator();
        Console.Write("Enter the day of birth of your cat: ");
        int catBirthDay = verificationSystem.Verificateday("Enter the day of birth of your cat: ");
        ShowSeparator();
        Console.Write("Enter the breed of your cat: ");
        string catBreed = verificationSystem.NormalizationOfString("Enter the breed of your cat: ");
        ShowSeparator();
        Console.Write("Enter the color of your cat: ");
        string catColor = verificationSystem.NormalizationOfString("Enter the color of your cat: ");
        ShowSeparator();
        Console.Write("Enter the weight of your cat (only numbers) in kg: ");
        double catWeightInKG = verificationSystem.VerificateDouble("Enter the weight of your cat (only numbers) in kg: ");
        ShowSeparator();
        string Review =Animal.ReceiveBasicreview();
        ShowSeparator();
        Console.Write("Is your cat castrated(yes/no): ");
        bool catBreedingStatus = verificationSystem.VerificateBreedingStatus("Is your cat castrated(yes/no): ");
        ShowSeparator();
        string catFurLength = VisualInterface.DisplayKindOfHairDresses();

        return new Cat(catId ,catName ,new DateOnly(catBirthYear,catBirthMonth,catBirthDay) ,catBreed ,catColor ,catWeightInKG ,Review,catBreedingStatus ,catFurLength);
    }


//visual methods
    public static void ShowHeader(string name, string address)
    {
        Console.Clear();
        Console.WriteLine(@$"
__________________________________________________________________________________________________
|____________________|Name:{name,-15}|____________|Address:{address,-12}|____________________|");

    }
    public static void ShowSeparator()
    {
        Console.WriteLine(@"__________________________________________________________________________________________________");
    }
    public static void ShowFooter()
    {
        Console.WriteLine("__________________________________________________________________________________________________");
    }
}
