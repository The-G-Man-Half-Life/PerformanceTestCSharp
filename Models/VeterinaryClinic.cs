using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerformanceTestCSharp.Models;
public class VeterinaryClinic
{
    public string Name {get;set;}
    public string Address {get;set;}
    public List<Dog> Dogs {get;set;} = new List<Dog>();
    public List<Cat> Cats  {get;set;} = new List<Cat>();


    public VeterinaryClinic(string Name,string Address)
    {
        this.Name = Name;
        this.Address = Address;
    }

    public void SaveDog(Dog newDog)
    {
        Dogs.Add(newDog);
    }

    public void SaveCat(Cat newCat)
    {
        Cats.Add(newCat);
    }

    public void UpdateDog(Dog dog,int Ubication)
    {
        Dogs[Ubication] = dog;
    }

    public void UpdateCat(Cat cat,int Ubication)
    {
        Cats[Ubication] = cat;
    }

    public void DeleteDog(int id)
    {
        int ubication = Dogs.FindIndex(dog=>dog.GetId()==id);
        Dogs.RemoveAt(ubication);
    }

    public void DeleteCat(int id)
    {
        int ubication = Cats.FindIndex(cat=>cat.GetId()==id);
        Cats.RemoveAt(ubication);
    }

    public void ShowAllPatients()
    {
        VisualInterface.DisplayCats(Cats);

        VisualInterface.DisplayDogs(Dogs);
    }

    public void ShowAnimals(string type)
    {
        if(type == "dog")
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
            List<Dog> foundDog = Dogs.Where(dog=>dog.GetId() == idPatient).ToList();
            VisualInterface.DisplayDogs(foundDog);
    }

    public void ShowPatientCat(int idPatient)
    {
            List<Cat> foundCat = Cats.Where(cat=>cat.GetId() == idPatient).ToList();
            VisualInterface.DisplayCats(foundCat);
    }
}
