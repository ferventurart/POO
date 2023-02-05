namespace PillarsOOP.Models;

public class Bicycle : Vehicle
{
    public string Company { get; set; }
    public string Model { get; set; }
    public int NumberOfTyres { get; set; }

    public override int GetNumberOfTyres()
    {
        return NumberOfTyres;
    }
}