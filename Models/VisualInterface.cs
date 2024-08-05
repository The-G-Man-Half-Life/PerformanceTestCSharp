using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace PerformanceTestCSharp.Models;
public static class VisualInterface
{

//classes that allow showing visual interfaces
    public static string DisplayKindOfHairDresses()
    {
        Console.Clear();
        ManagerApp.ShowSeparator();
        Console.Write(@"
1.Without hair
2.Short hair
3.Medium hair
4.Long hair

Enter the number that corresponds to your dog hair style option: ");

        int selection = verificationSystem.VerificateRange(@"
1.Without hair
2.Short hair
3.Medium hair
4.Long hair

Enter the number that corresponds to your dog hair style option: ", 1, 4);

        switch (selection)
        {
            case 1:
                return "without hair";

            case 2:
                return "short hair";

            case 3:
                return "medium hair";

            case 4:
                return "long hair";

            default:
                return "no";
        }
    }

    public static void DisplayCats(List<Cat> Cats)
    {

        ManagerApp.ShowSeparator();
        Console.WriteLine("-------------------------Cats-------------------------------");
        foreach (Cat cat in Cats)
        {
            cat.ShowInformation();
            ManagerApp.ShowSeparator();
        }
        Console.WriteLine("-------------------------------------------------------------");
    }

    public static void DisplayDogs(List<Dog> Dogs)
    {

        ManagerApp.ShowSeparator();
        Console.WriteLine("---------------------------Dogs-----------------------------");
        foreach (Dog dog in Dogs)
        {
            dog.ShowInformation();
            ManagerApp.ShowSeparator();
        }
        Console.WriteLine("-------------------------------------------------------------");
    }

    public static string DisplayKindOfTemperaments()
    {
        Console.Clear();
        ManagerApp.ShowSeparator();
        Console.Write(@"
1.Shy
2.Normal
3.Aggressive

Enter the number that corresponds to your dog temperament: ");

        int selection = verificationSystem.VerificateRange(@"
1.Shy
2.Normal
3.Aggressive

Enter the number that corresponds to your dog temperament: ", 1, 3);

        switch (selection)
        {
            case 1:
                return "shy";

            case 2:
                return "normal";

            case 3:
                return "aggressive";

            default:
                return "no";
        }
    }


// main class that activates all proccess
    public static void RunSystem()
    {
        Console.Clear();
        Console.Write("Enter the veterinary name: ");
        string name = verificationSystem.NormalizationOfString("Enter the veterinary name: ");

        Console.Write("Enter the veterinary address: ");
        string address = verificationSystem.NormalizationOfString("Enter the veterinary address: ");

        var vet = new VeterinaryClinic(name, address);

        bool flag = true;
        while (flag == true)
        {

            ManagerApp.ShowHeader(name, address);
            Console.Write(@"
1.Create a dog
2.Create a cat
3.Update a dog
4.Update a cat
5.Delete a dog
6.Delete a cat
7.Show all patients
8.Show only dogs
9.Show only cats
10.Look for a dog patient
11.Look for a cat patient
12.Castrate a dog
13.Castrate a cat
14.Change a dog hairstyle
15.Change a  cat hairStyle
16.Change bark volume(only for dogs)
17.Close system

Write down the number of your option: ");

            int option = verificationSystem.VerificateRange(@"
1.Create a dog
2.Create a cat
3.Update a dog
4.Update a cat
5.Delete a dog
6.Delete a cat
7.Show all patients
8.Show only dogs
9.Show only cats
10.Look for a dog patient
11.Look for a cat patient
12.Castrate a dog
13.Castrate a cat
14.Change a dog hairstyle
15.Change a  cat hairStyle
16.Change bark volume(only for dogs)
17.Close system

Write down the number of your option: ", 1, 17);

            switch (option)
            {
                case 1:
                    ManagerApp.ShowHeader(name, address);
                    Dog newDog = ManagerApp.CreateADog(vet);
                    vet.SaveDog(newDog);
                    Console.Write("Press any key to continue");
                    Console.ReadKey();
                    break;
                case 2:
                    ManagerApp.ShowHeader(name, address);
                    Cat newCat = ManagerApp.CreateACat(vet);
                    vet.SaveCat(newCat);
                    Console.Write("Press any key to continue");
                    Console.ReadKey();
                    break;
                case 3:
                    ManagerApp.ShowHeader(name, address);
                    vet.UpdateDog(vet);
                    Console.Write("Press any key to continue");
                    Console.ReadKey();
                    break;
                case 4:
                    ManagerApp.ShowHeader(name, address);
                    vet.UpdateCat(vet);
                    Console.Write("Press any key to continue");
                    Console.ReadKey();
                    break;
                case 5:
                    ManagerApp.ShowHeader(name, address);
                    Console.Write("Enter the id of the dog: ");
                    int dogId = verificationSystem.VerificateIdDogExistence2(vet.Dogs,"Enter the id of the dog: ");
                    vet.DeleteDog(dogId);
                    Console.Write("Press any key to continue");
                    Console.ReadKey();
                    break;
                case 6:
                    ManagerApp.ShowHeader(name, address);
                    Console.Write("Enter the id of the cat: ");
                    int catId = verificationSystem.VerificateIdCatExistence2(vet.Cats, "Enter the id of the cat: ");
                    vet.DeleteCat(catId);
                    Console.Write("Press any key to continue");
                    Console.ReadKey();
                    break;
                case 7:
                    ManagerApp.ShowHeader(name, address);
                    vet.ShowAllPatients();
                    Console.Write("Press any key to continue");
                    Console.ReadKey();
                    break;
                case 8:
                    ManagerApp.ShowHeader(name, address);
                    vet.ShowAnimals("dog");
                    Console.Write("Press any key to continue");
                    Console.ReadKey();
                    break;
                case 9:
                    ManagerApp.ShowHeader(name, address);
                    vet.ShowAnimals("cat");
                    Console.Write("Press any key to continue");
                    Console.ReadKey();
                    break;
                case 10:
                    ManagerApp.ShowHeader(name, address);
                    Console.Write("Enter the id of the dog: ");
                    int dogId2 = verificationSystem.VerificateIdDogExistence2(vet.Dogs, "Enter the id of the dog: ");
                    vet.ShowPatientDog(dogId2);
                    Console.Write("Press any key to continue");
                    Console.ReadKey();
                    break;
                case 11:
                    ManagerApp.ShowHeader(name, address);
                    Console.Write("Enter the id of the cat: ");
                    int catId2 = verificationSystem.VerificateIdCatExistence2(vet.Cats, "Enter the id of the cat: ");
                    vet.ShowPatientCat(catId2);
                    Console.Write("Press any key to continue");
                    Console.ReadKey();
                    break;
                case 12:
                    ManagerApp.ShowHeader(name, address);
                    Console.Write("Enter the id of the dog you want to castrate: ");
                    int dogUbicationToCastrate = verificationSystem.verificateDogExistence(vet.Dogs,"Enter the id of the dog you want to castrate: ");
                    vet.Dogs[dogUbicationToCastrate].CastrateAnimal();
                    Console.Write("Press any key to continue");
                    Console.ReadKey();

                    break;
                case 13:
                    ManagerApp.ShowHeader(name, address);
                    Console.Write("Enter the id of the cat you want to castrate: ");
                    int catUbicationToCastrate = verificationSystem.verificateCatExistence(vet.Cats,"Enter the id of the cat you want to castrate: ");
                    vet.Cats[catUbicationToCastrate].CastrateAnimal();
                    Console.Write("Press any key to continue");
                    Console.ReadKey();
                    break;

                case 14:
                ManagerApp.ShowHeader(name,address);
                    Console.Write("Enter the id of the dog you want to change hair: ");
                    int dogUbicationToChangeHair = verificationSystem.verificateDogExistence(vet.Dogs,"Enter the id of the dog you want to change hair: ");
                    vet.Dogs[dogUbicationToChangeHair].Hairdress();
                    Console.Write("Press any key to continue");
                    Console.ReadKey();
                break;
                case 15:
                ManagerApp.ShowHeader(name,address);
                    Console.Write("Enter the id of the cat you want to change hair: ");
                    int catUbicationToChangeHair = verificationSystem.verificateCatExistence(vet.Cats,"Enter the id of the cat you want to change hair: ");
                    vet.Dogs[catUbicationToChangeHair].Hairdress();
                    Console.Write("Press any key to continue");
                    Console.ReadKey();
                break;
                case 16:
                ManagerApp.ShowHeader(name,address);
                    Console.Write("Enter the id of the dog you want to change bark volume: ");
                    int dogUbicationToChangeBarkVolume = verificationSystem.verificateDogExistence(vet.Dogs,"Enter the id of the dog you want to change the bark volume: ");
                    
                    Console.WriteLine("Enter the new bark volumen of you dog: ");
                    double BarkVolume = verificationSystem.VerificateDouble("Enter the new bark volumen of you dog: "); 
                    string barkVolumeI = Convert.ToString(BarkVolume) + "db";
                    vet.Dogs[dogUbicationToChangeBarkVolume].BarkVolume = barkVolumeI;
                    Console.Write("Press any key to continue");
                    Console.ReadKey();
                break;
                case 17:
                Console.WriteLine("Goodbye");
                ManagerApp.ShowFooter();
                    flag = false;
                break;
                default:
                    break;
            }
        }

    }
}
