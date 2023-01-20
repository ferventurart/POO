public class Human
{
    public string Name { get; set; } = "";
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Age { get; set; }

    public void ComeMucho()
    {
        Weight += 2;
    }

    public void HaceEjercicio()
    {
        Weight -= 4;
    }

    public string VerGeneracion()
    {
        if(Age > 50)
        {
            return "Ya esta viejito";
        }

        return "Aun esta jovenazo";
    }
} 