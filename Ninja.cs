public class Ninja
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Village { get; set; }
    public string Cla { get; set;}

    public Ninja(string name, int age, string village)
    {
        Name = name;
        Age = age;
        Village = village;
        Cla = "Ninja";
    }

    public override string ToString()
    {
        return $"Name:    {Name}\nAge:     {Age}\nVillage: {Village}\nClã:     {Cla}\n";
    }

}