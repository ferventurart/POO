// See https://aka.ms/new-console-template for more information

Human fernando = new();
Human pedro = new();

fernando.Name = "Fernando Ventura";
fernando.Height = 187;
fernando.Weight = 217;
fernando.Age = 27;

//fernando.ComeMucho();
fernando.HaceEjercicio();

string message = $"El humano con nombre {fernando.Name} tiene un peso de {fernando.Weight} libras y una altura de {fernando.Height} cms con una edad de {fernando.Age} anios. Por lo que {fernando.VerGeneracion()}";



Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(message);
