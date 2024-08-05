using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerformanceTestCSharp.Models;
public class Cat: Animal
{//properties
    public bool BreedingStatus {get; set;}
    public string FurLength {get; set;}

//ctor
    public Cat(int Id ,string Name ,DateOnly BirthDate ,string Breed ,string Color ,double WeightInKG, string BasicReviewI,bool BreedingStatus,string FurLength):base(Id,Name,BirthDate,Breed,Color,WeightInKG,BasicReviewI)
    {
        this.BreedingStatus = BreedingStatus;
        this.FurLength = FurLength;
    }

//main execution methods
    public bool CastrateAnimal()
    {
        if(this.BreedingStatus == false)
        {
            Console.WriteLine("The animal can not be castrated again");
            return this.BreedingStatus = false;
        }
        else
        {
            Console.WriteLine("The animal was castrated succesfully");
            return this.BreedingStatus = false;
        }
    }

    public void Hairdress()
    {
        if(this.FurLength == "without hair")
        {
            Console.WriteLine("Your pet can not receive a hair cut");
            this.FurLength = this.FurLength;
        }
        else
        {
            string option = VisualInterface.DisplayKindOfHairDresses();
            this.FurLength = option;
        }
    }

    public override void ShowInformation()
    {
        base.ShowInformation();
        Console.WriteLine(@$"Breeding status: {this.BreedingStatus}
Fur length: {this.FurLength}
Age in motnhs: {this.CalculateAgeInMonths()}");
    }
}
