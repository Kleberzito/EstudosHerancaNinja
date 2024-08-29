public class Hyuga : Ninja
{
     public string PowerClaStatus { get; private set; }

     public Hyuga(string name, int age, string village) : base(name, age, village)
    {
        Cla = "Hyuga";
        PowerClaStatus = "";        
    }

    public Hyuga(string name, int age, string village, bool powerCla) : base(name, age, village)
    {
        Cla = "Hyuga";
        PowerClaStatus = PowerCla(powerCla);        
    }
    private string PowerCla(bool status)
    {
        if(status)
            return "Ativado Byakugan.";
        return "Não usou o Byakugan";
    }

    public override string ToString()
    {
        if(PowerClaStatus == "")
            return base.ToString();

        return base.ToString() + $"{base.Name}:  {PowerClaStatus}\n";
    }
}