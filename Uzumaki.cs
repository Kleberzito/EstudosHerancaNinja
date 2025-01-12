public class Uzumaki : Ninja
{
     public string PowerClaStatus { get; private set; }

     public Uzumaki(string name, int age, string village) : base(name, age, village)
    {
        Cla = "Uzumaki";
        PowerClaStatus = "";        
    }

    public Uzumaki(string name, int age, string village, bool powerCla) : base(name, age, village)
    {
        Cla = "Uzumaki";
        PowerClaStatus = PowerCla(powerCla);        
    }

    private string PowerCla(bool status)
    {
        if(status)
            return "Ativado modo sábio.";
        return "Não usou o modo sábio";
    }

    public override string ToString()
    {
        if(PowerClaStatus == "")
            return base.ToString();

        return base.ToString() + $"{base.Name}:  {PowerClaStatus}\n";
    }
}
