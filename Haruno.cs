public class Haruno : Ninja
{
     public string PowerClaStatus { get; private set; }

      public Haruno(string name, int age, string village) : base(name, age, village)
    {
        Cla = "Haruno"; 
        PowerClaStatus = "";       
    }

    public Haruno(string name, int age, string village, bool powerCla) : base(name, age, village)
    {
        Cla = "Haruno";
        PowerClaStatus = PowerCla(powerCla);        
    }
    private string PowerCla(bool status)
    {
        if(status)
            return "Ativado cura.";
        return "Não usou o cura";
    }

    public override string ToString()
    {
        if(PowerClaStatus == "")
            return base.ToString();

        return base.ToString() + $"{base.Name}:  {PowerClaStatus}\n";
    }
}