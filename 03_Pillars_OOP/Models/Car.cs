namespace PillarsOOP.Models;

public class Car : Vehicle
{
    public string Company { get; set; }
    public string Model { get; set; }
    public int FrontTyres { get; set; }
    public int BackTyres { get; set; }

    public override int GetNumberOfTyres()
    {
        return FrontTyres + BackTyres;
    }
}