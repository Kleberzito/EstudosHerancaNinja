public class Uchira : Ninja
{
     public string PowerClaStatus { get; private set; }

     public Uchira(string name, int age, string village) : base(name, age, village)
    {
        Cla = "Uchira";
        PowerClaStatus = "";        
    }

    public Uchira(string name, int age, string village, bool powerCla) : base(name, age, village)
    {
        Cla = "Uchira";
        PowerClaStatus = PowerCla(powerCla);        
    }
    private string PowerCla(bool status)
    {
        if(status)
            return "Ativado Sharingan.";
        return "Não usou o Sharingan";
    }

    public override string ToString()
    {
        if(PowerClaStatus == "")
            return base.ToString();

        return base.ToString() + $"{base.Name}:  {PowerClaStatus}\n";
    }
}