using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerformanceTestCSharp.Models;
public static class VisualInterface
{
    public static string DisplayKindOfHairDresses()
    {
Console.WriteLine(@"
1.Without hair
2.Short hair
3.Medium hair
4.Long hair

Enter the number of your option: ");

int selection = verificationSystem.VerificateRange(@"
1.Without hair
2.Short hair
3.Medium hair
4.Long hair

Enter the number of your option: ",1,4);

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
        Console.WriteLine("-------------------------Cats-------------------------------");
        foreach (Cat cat in Cats)
        {
        cat.ShowInformation();
        }
        Console.WriteLine("-------------------------------------------------------------");
    }

        public static void DisplayDogs(List<Dog> Dogs)
    {
        Console.WriteLine("---------------------------Dogs-----------------------------");
        foreach (Dog dog in Dogs)
        {
        dog.ShowInformation();
        }
        Console.WriteLine("-------------------------------------------------------------");
    }
}
