// See https://aka.ms/new-console-template for more information
//Boolean: bool 
//Character Type: char
//Integer types: sbyte, byte, short, ushort, int, unit, long and ulong
//Floating-point types: float and double
//Decimal precision: decimal
//String: string
//Object type: object

Console.WriteLine("Hola vamos a crear un perrito:");
Console.WriteLine("\n");
Console.WriteLine("Ok, empecemos vamos a necesitar el color y tamano");
Console.WriteLine("\n");
Console.WriteLine("Ingrese el color del perrito:");

var leerColor = Console.ReadLine();
Console.WriteLine("Ingrese el tamano del perrito");
Console.WriteLine("\n");
Console.WriteLine("Seleccione un tamano permitido:");
Console.WriteLine("\n");
Console.WriteLine("0. Si es Pequeno \n");
Console.WriteLine("1. Si es Mediano \n");
Console.WriteLine("2. Si es Grande \n");

var leerTamano = Convert.ToInt32(Console.ReadLine());

if(!Enum.IsDefined(typeof(AnimalSize), (AnimalSize)leerTamano))
{
    throw new ArgumentException("Usted ingreso una opcion incorrecta, la aplicacion se detendra");
}

Console.WriteLine("Cuantas libras de comida le da al dia?");
var leerLibras = Console.ReadLine();

Animal dog = new()
{
    Legs = 4,
    CanSwimming = true,
    Color = leerColor,
    Size = (AnimalSize)leerTamano
};

dog.Eat(Convert.ToInt32(leerLibras));

Console.WriteLine(dog.ViewData);