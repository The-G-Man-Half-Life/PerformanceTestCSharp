using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace PerformanceTestCSharp.Models;
public class Dog: Animal
{
    //properties
    public bool BreedingStatus {get; set;}
    public string Temperament {get;set;}
    public string MicrochipNumber {get;set;}
    public string BarkVolume {get;set;}
    public string CoatType {get;set;}

//ctor
    public Dog(int Id ,string Name ,DateOnly BirthDate ,string Breed ,string Color ,double WeightInKG, string BasicReviewI,bool BreedingStatus,string Temperament,string MicrochipNumber,string BarkVolume,string CoatType):base(Id,Name,BirthDate,Breed,Color,WeightInKG,BasicReviewI)
    {
        this.BreedingStatus = BreedingStatus;
        this.Temperament = Temperament;
        this.MicrochipNumber = MicrochipNumber;
        this.BarkVolume = BarkVolume;
        this.CoatType = CoatType;
    }

//main methods
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
        if(this.CoatType == "without hair" || this.CoatType == "short hair")
        {
            
            Console.WriteLine("Your pet can not receive a hair cut");
            this.CoatType = this.CoatType;
        }
        else
        {
            string option = VisualInterface.DisplayKindOfHairDresses();
            this.CoatType = option;
        }
    }

    public override void ShowInformation()
    {
        base.ShowInformation();
        Console.WriteLine(@$"Breeding status: {this.BreedingStatus}
Temperament: {this.Temperament}
MicrochipNumber: {this.MicrochipNumber}
BarkVolume: {this.BarkVolume}
CoatType: {this.CoatType}
Age in months: {this.CalculateAgeInMonths()}");
    }
}
