class Program
{
    static void Main(string[] args)
    {
        Uzumaki Naruto = new Uzumaki("Naruto", 17, "Vila da folha", true);        
        Uchira Sasuke = new Uchira("Sasuke", 18, "Vila da folha");
        Haruno Sakura = new Haruno("Sakura", 18, "Vila da folha");
        Hyuga Hinata = new Hyuga("Hinata", 16, "Vila da folha", true);

        Console.WriteLine(Naruto.ToString());
        Console.WriteLine(Sasuke.ToString());                     
        Console.WriteLine(Sakura.ToString());
        Console.WriteLine(Hinata.ToString());
    }
    
}