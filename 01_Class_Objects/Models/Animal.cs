public class Animal
{
    public int Weight { get; set; }
    public AnimalSize Size { get; set; }
    public int Legs { get; set; }
    public string Color { get; set; }
    public bool CanSwimming { get; set; }

    public void Eat(int pounds)
    {
        if(pounds > 10)
            Weight += 20;
        else
            Weight += 5;
    }

    public string ViewData => $"El perrito es de color {Color}, es tamano {Size} y Pesa {Weight} libras";
}