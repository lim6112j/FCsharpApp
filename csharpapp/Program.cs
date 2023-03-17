// See https://aka.ms/new-console-template for more information
using fsharpapp;
namespace CsharpApp;
public class Program {
  public static void Main(){
    // f# function
    fsharpapp.Say.hello("lim");
    // f# type -- type has no constructor , value needed from fsharp
    var optionValue = MyTypes.value1;
    Console.WriteLine(optionValue);
  }
}
