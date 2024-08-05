using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace PerformanceTestCSharp.Models;
public class VeterinaryClinic
{ //properties and lists for dogs and cats
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Dog> Dogs { get; set; } = new List<Dog>{
        new Dog(1,"papa",new DateOnly(2004,12,06),"golden retriever","green",200,"The dog is in amazing conditions",true,"shy","a2","123db","long hair")
    };
    public List<Cat> Cats { get; set; } = new List<Cat>{
        new Cat(1,"pepe",new DateOnly(2004,06,20),"british shorthair","white",200.3,"The cat is death",false,"Without hair")
    };

//constructor
    public VeterinaryClinic(string Name, string Address)
    {
        this.Name = Name;
        this.Address = Address;
    }


// all methods of the crud
    public void SaveDog(Dog newDog)
    {
        Dogs.Add(newDog);
    }

    public void SaveCat(Cat newCat)
    {
        Cats.Add(newCat);
    }

    public void UpdateDog(VeterinaryClinic vet)
    {
        Console.Write("Enter the id of the pet: ");
        int petUbication = verificationSystem.verificateDogExistence(vet.Dogs, "Enter the id of the pet: ");
        Console.Write(@"
1.Id
2.Name
3.BirthDate
4.Breed
5.Color
6.Weight
7.Basic review
8.Breeding status
9.Temperament
10.Microchip number
11.Bark volume
12.Coat Type

Enter the number of the option you want to change: ");
        int option = verificationSystem.VerificateRange(@"
1.Id
2.Name
3.BirthDate
4.Breed
5.Color
6.Weight
7.Basic review
8.Breeding status
9.Temperament
10.Microchip number
11.Bark volume
12.Coat Type

Enter the number of the option you want to change: ", 1, 12);

        switch (option)
        {
            case 1:
                Console.Write("Enter the new id of the dog: ");
                int newId = verificationSystem.VerificateIdDogExistence(vet.Dogs, "Enter the new id of the dog: ");
                vet.Dogs[petUbication].SetId(newId);
                break;

            case 2:
                Console.Write("Enter the new name of the dog: ");
                string newName = verificationSystem.NormalizationOfString("Enter the new name of the dog: ");
                vet.Dogs[petUbication].SetName(newName);
                break;

            case 3:
                Console.Write("Enter the year of birth of the dog: ");
                int newYear = verificationSystem.VerificateYear("Enter the year of birth of the dog: ");
                Console.Write("Enter the month of birth of the dog: ");
                int newMonth = verificationSystem.VerificateMonth("Enter the month of birth of the dog: ");
                Console.Write("Enter the day of birth of the dog: ");
                int newDay = verificationSystem.Verificateday("Enter the day of birth of the dog: ");
                vet.Dogs[petUbication].SetBirthDate(new DateOnly(newYear, newMonth, newDay));
                break;

            case 4:
                Console.Write("Enter the breed of the dog: ");
                string newBreed = verificationSystem.NormalizationOfString("Enter the breed of the dog: ");
                vet.Dogs[petUbication].SetBreed(newBreed);
                break;

            case 5:
                Console.Write("Enter the new color of the dog");
                string newColor = verificationSystem.NormalizationOfString("Enter the new color of the dog");
                vet.Dogs[petUbication].SetColor(newColor);
                break;

            case 6:
                Console.Write("Enter the new weight of the dog");
                double newWeight = verificationSystem.VerificateDouble("Enter the new weight of the dog: ");
                vet.Dogs[petUbication].SetWeightInKG(newWeight);
                break;

            case 7:
                string newBasicReview = Dog.ReceiveBasicreview();
                vet.Dogs[petUbication].SetBasicReview(newBasicReview);
                break;

            case 8:
                Console.WriteLine("Are you sure you want to castrate the animal(yes/no)?: ");
                bool decition = verificationSystem.VerificateBreedingStatus("Are you sure you want to castrate the animal(yes/no)?: ");
                if (decition == false)
                {
                    Console.WriteLine("The castration did not happen");
                }
                else
                {
                    Dogs[petUbication].CastrateAnimal();
                }
                break;

            case 9:
                string newTemperament = VisualInterface.DisplayKindOfTemperaments();
                vet.Dogs[petUbication].Temperament = newTemperament;
                break;

            case 10:
                Console.Write("Enter the new microchip number of the dog: ");
                string newMicrochipNumber = verificationSystem.NormalizationOfString("Enter the new microchip number of the dog: ");
                vet.Dogs[petUbication].MicrochipNumber = newMicrochipNumber;
                break;

            case 11:
                Console.Write("Enter the bark volume of the dog (in numbers):");
                double newBarkVolume = verificationSystem.VerificateDouble("Enter the bark volume of the dog (in numbers):");
                string newBarkVolumeI = Convert.ToString(newBarkVolume) + "db";
                vet.Dogs[petUbication].BarkVolume = newBarkVolumeI;
                break;

            case 12:
                vet.Dogs[petUbication].Hairdress();
                break;

            default:
                break;
        }
    }

    public void UpdateCat(VeterinaryClinic vet)
    {
        Console.Write("Enter the id of the pet: ");
        int petUbication = verificationSystem.verificateCatExistence(vet.Cats, "Enter the id of the pet: ");
        Console.Write(@"
1.Id
2.Name
3.BirthDate
4.Breed
5.Color
6.Weight
7.Basic review
8.Breeding status
9.Fur length

Enter the number of the option: ");
        int option = verificationSystem.VerificateRange(@"
1.Id
2.Name
3.BirthDate
4.Breed
5.Color
6.Weight
7.Basic review
8.Breeding status
9.Fur length

Enter the number of the option: ", 1, 9);

        switch (option)
        {
            case 1:
                Console.Write("Enter the new id of the cat: ");
                int newId = verificationSystem.VerificateIdCatExistence(vet.Cats, "Enter the new id of the cat: ");
                vet.Cats[petUbication].SetId(newId);
                break;

            case 2:
                Console.Write("Enter the new name of the cat: ");
                string newName = verificationSystem.NormalizationOfString("Enter the new name of the cat: ");
                vet.Cats[petUbication].SetName(newName);
                break;

            case 3:
                Console.Write("Enter the year of birth of the cat: ");
                int newYear = verificationSystem.VerificateYear("Enter the year of birth of the cat: ");
                Console.Write("Enter the month of birth of the cat: ");
                int newMonth = verificationSystem.VerificateMonth("Enter the month of birth of the cat: ");
                Console.Write("Enter the day of birth of the cat: ");
                int newDay = verificationSystem.Verificateday("Enter the day of birth of the cat: ");
                vet.Cats[petUbication].SetBirthDate(new DateOnly(newYear, newMonth, newDay));
                break;

            case 4:
                Console.Write("Enter the breed of the cat: ");
                string newBreed = verificationSystem.NormalizationOfString("Enter the breed of the cat: ");
                vet.Cats[petUbication].SetBreed(newBreed);
                break;

            case 5:
                Console.Write("Enter the new color of the cat");
                string newColor = verificationSystem.NormalizationOfString("Enter the new color of the cat");
                vet.Cats[petUbication].SetColor(newColor);
                break;

            case 6:
                Console.Write("Enter the new weight of the cat");
                double newWeight = verificationSystem.VerificateDouble("Enter the new weight of the cat: ");
                vet.Cats[petUbication].SetWeightInKG(newWeight);
                break;

            case 7:
                string newBasicReview = Cat.ReceiveBasicreview();
                vet.Cats[petUbication].SetBasicReview(newBasicReview);
                break;

            case 8:
                Console.WriteLine("Are you sure you want to castrate the animal?(yes/no): ");
                bool decition = verificationSystem.VerificateBreedingStatus("Are you sure you want to castrate the animal(yes/no)?: ");
                if (decition == false)
                {
                    Console.WriteLine("The castration did not happen");
                }
                else
                {
                    Cats[petUbication].CastrateAnimal();
                }
                break;

            case 9:
                Cats[petUbication].Hairdress();
                break;

            default:
                break;
        }
    }

    public void DeleteDog(int id)
    {
        Console.Write("Are you sure you want to delete a pet(yes/no): ");
        bool decition = verificationSystem.VerificateBreedingStatus("Are you sure you want to delete a pet(yes/no): ");
        if (decition == true)
        {
            int ubication = Dogs.FindIndex(dog => dog.GetId() == id);
            Dogs.RemoveAt(ubication);
        }
    }

    public void DeleteCat(int id)
    {
        Console.Write("Are you sure you want to delete a pet(yes/no): ");
        bool decition = verificationSystem.VerificateBreedingStatus("Are you sure you want to delete: a pet(yes/no): ");
        if (decition == true)
        {
            int ubication = Cats.FindIndex(cat => cat.GetId() == id);
            Cats.RemoveAt(ubication);
        }

    }

    public void ShowAllPatients()
    {
        VisualInterface.DisplayCats(Cats);

        VisualInterface.DisplayDogs(Dogs);
    }

    public void ShowAnimals(string type)
    {
        if (type == "dog")
        {
            VisualInterface.DisplayDogs(Dogs);
        }
        else
        {
            VisualInterface.DisplayCats(Cats);
        }
    }

    public void ShowPatientDog(int idPatient)
    {

        List<Dog> foundDog = Dogs.Where(dog => dog.GetId() == idPatient).ToList();
        if (foundDog.Count() < 1)
        {
            Console.WriteLine("There are not dogs with that id");
        }
        else
        {
            VisualInterface.DisplayDogs(foundDog);
        }

    }

    public void ShowPatientCat(int idPatient)
    {
        List<Cat> foundCat = Cats.Where(cat => cat.GetId() == idPatient).ToList();
        if (foundCat.Count() < 1)
        {
            Console.WriteLine("There is not any dog with those characteristics");
        }
        else
        {
            VisualInterface.DisplayCats(foundCat);
        }

    }
}
