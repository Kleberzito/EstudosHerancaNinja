﻿class Program
{
    static void Main(string[] args)
    {
        Uzumaki Naruto = new Uzumaki("Naruto", 17, "Vila da folha", false);        
        Ninja Sasuke = new Ninja("Sasuke", 18, "Vila da folha");
        Ninja Sakura = new Ninja("Sakura", 18, "Vila da folha");
        Ninja Hinata = new Ninja("Hinata", 16, "Vila da folha");

        Console.WriteLine(Naruto.ToString());
        Console.WriteLine(Sasuke.ToString());                     
        Console.WriteLine(Sakura.ToString());
        Console.WriteLine(Hinata.ToString());
    }
    
}