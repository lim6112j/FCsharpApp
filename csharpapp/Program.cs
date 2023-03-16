// See https://aka.ms/new-console-template for more information
namespace CsharpApp;
public class Program {
  public static void Main(){
    Console.WriteLine("hello");
    fsharpapp.Say.hello("lim");
    Console.WriteLine(fsharpapp.types.MyOption<int>.Some);
  }
}
