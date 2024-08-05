using System.Data.Common;
using System.Transactions;

namespace PerformanceTestCSharp.Models;

public class Animal
{
    //properties
    protected int Id  {get;set;}
    protected string Name {get;set;}
    protected DateOnly BirthDate  {get;set;}
    protected string Breed {get;set;}
    protected string Color {get;set;}
    protected double WeightInKG  {get;set;}
    protected string BasicReviewI {get; set;}

//ctor
    public Animal(int Id ,string Name ,DateOnly BirthDate ,string Breed ,string Color ,double WeightInKG, string BasicReviewI)
    {
        this.Id = Id;
        this.Name = Name;
        this.BirthDate = BirthDate;
        this.Breed = Breed;
        this.Color = Color;
        this.WeightInKG = WeightInKG;
        this.BasicReviewI = BasicReviewI; 
    }


//obtaining methods

public int GetId() => this.Id;
public void SetId(int newId) =>this.Id = newId;

public string GetName() => this.Name;
public void SetName(string newName) =>this.Name = newName;

public DateOnly GetBirthdate() => this.BirthDate;
public void SetBirthDate(DateOnly newBirthDate) =>this.BirthDate = newBirthDate;

public string GetBreed() => this.Breed;
public void SetBreed(string newBreed) =>this.Breed = newBreed;

public string GetColor() => this.Color;
public void SetColor(string newColor) =>this.Color = newColor;

public double GetWeight() => this.WeightInKG;
public void SetWeightInKG(double newWeightInKG) =>this.WeightInKG = newWeightInKG;

public string GetBasicReview() => this.BasicReviewI;
public string SetBasicReview(string NewBasicReview) => this.BasicReviewI = NewBasicReview;

//main methods
public virtual void ShowInformation()
{
    Console.WriteLine(@$"
Id: {this.Id}
Name: {this.Name}
BirthDate: {this.BirthDate}
Breed: {this.Breed}
Color: {this.Color}
WeightInKg: {this.WeightInKG} Kg
Basic review: {this.BasicReviewI}");
}

protected static string BasicReview()
{
    Console.Write("Enter a basic review of the animal: ");
    string BasicReview = verificationSystem.NormalizationOfString("Enter a basic review of the animal: ");
    return BasicReview;
}

public static string ReceiveBasicreview()
{
    string review = BasicReview();
    return review;
}
protected int CalculateAgeInMonths()
{
    int yearsToMonths = ((DateTime.Now.Year - BirthDate.Year)*12) - 1;

    if(BirthDate.Month >DateTime.Now.Month)
    {
        return yearsToMonths + DateTime.Now.Month;
    }
    else
    {
        return yearsToMonths +1 + (DateTime.Now.Month - BirthDate.Month)  ;
    }
}
}
