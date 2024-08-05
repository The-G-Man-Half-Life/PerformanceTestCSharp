using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerformanceTestCSharp.Models;
public class Cat: Animal
{
    public bool BreedingStatus {get; set;}
    public string FurLength {get; set;}


    public Cat(int Id ,string Name ,DateOnly BirthDate ,string Breed ,string Color ,double WeightInKG, string BasicReviewI,bool BreedingStatus,string FurLength):base(Id,Name,BirthDate,Breed,Color,WeightInKG,BasicReviewI)
    {
        this.BreedingStatus = BreedingStatus;
        this.FurLength = FurLength;
    }


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

    public string Hairdress()
    {
        if(this.FurLength == "without hair " || this.FurLength == "short hair")
        {
            Console.WriteLine("Your pet can not receive a hair cut");
            return this.FurLength;
        }
        else
        {
            string option = VisualInterface.DisplayKindOfHairDresses();
            return option;
        }
    }

    public override void ShowInformation()
    {
        base.ShowInformation();
        Console.WriteLine(@$"
Breeding status: {this.BreedingStatus}
Fur length: {this.FurLength}");
    }
}
