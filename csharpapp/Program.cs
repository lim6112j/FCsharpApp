// See https://aka.ms/new-console-template for more information
using fsharpapp;
namespace CsharpApp;
public class Program
{
    public static void Main()
    {
        // f# function
        fsharpapp.Say.hello("lim");
        // f# type -- type has no constructor , value needed from fsharp
        var optionValue = MyTypes.value1;
        Console.WriteLine(optionValue);
        Console.WriteLine(String.Join(", ", Example.withYieldBang.ToList()));
        Console.Write("[");
        Example.withYield.ToList().ForEach(
            x =>
            {
                Console.Write("[");
                foreach (int i in x)
                {
                    if(i == x.Count() -1) {
                    Console.Write(i);
                    } else {
                    Console.Write(i + " ,");
                    }
                }
                Console.WriteLine("]");
            }
            );
        Console.Write("]");
    }
}
