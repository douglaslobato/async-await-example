// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Hello, World!");

var egg = CookEggs();
var bacon = CookBacon();
var butter = Butter();

Console.WriteLine("Em preparo, cozinhando...");

await Task.WhenAll(egg, bacon, butter);

var myText = PrepareBread();
Console.WriteLine(myText.Result);

Console.ReadLine();


static async Task<bool> CookEggs()
{
    bool eggsCooked = false;
    await Task.Run(() =>
    {
        Thread.Sleep(4000);
        Console.WriteLine("Ovos cozinhados");
        eggsCooked = true;
    });

    return eggsCooked;
}

static async Task<bool> CookBacon()
{
    bool baconCooked = false;

    await Task.Run(() =>
    {
        Thread.Sleep(4000);

        Console.WriteLine("Bacons cozinhados");
        
        baconCooked = true;
    });

    return baconCooked;

}

static async Task<bool> Butter()
{
    bool breadButter = false;

    await Task.Run(() =>
    {
        Thread.Sleep(2000);

        Console.WriteLine("Passado manteiga");

        breadButter = true;
    });

    return breadButter;
}

static async Task<string> PrepareBread()
{
    string teste = string.Empty;
    await Task.Run(() =>
    {
        Console.WriteLine("Feito");
        teste = "Pao feito com bacon e ovos";
    });

    return teste;
}