using System.Text.Json;
using Lab3;

string input;
Dictionary<int, double> coordinatesInput = new Dictionary<int, double>()
{
    {0, 0},
    {1,0},
    {2,0},
    {3,0},
};

using (StreamReader reader = new StreamReader("C:\\Users\\servo\\RiderProjects\\Lab3\\Lab3\\JSON_input.json"))
{
    input = reader.ReadToEnd();
}

if (input != null)
{
    coordinatesInput = JsonSerializer.Deserialize<Dictionary<int, double>>(input);
}

Vector v1 = new Vector(coordinatesInput);
Vector v2 = new Vector(13.0673, -863.33, -2.340, 0.2);
    
    
Console.WriteLine("Vector 1:");
v1.Display();
Console.WriteLine("\nVector 2:");
v2.Display();

Console.WriteLine("\nv3 = v1 + v2");
Vector v3 = v1 + v2;
v3.Display();
Console.WriteLine("\n(v1 + v2 - v3)");
(v1 + v2 - v3).Display();

Vector v4 = v3 * 3.45;
Console.WriteLine("\nv4 = v3 * 3.45");
v4.Display();

Console.WriteLine("\nDot-product of vectors v3 and v4:\t"+Vector.DotProduct(v3, v4));

Console.WriteLine("\nRemoving last coordinate from v4:");
v4.RemoveLastCoordinate().Display();

Console.WriteLine("\nAdding new coordinate to v4:");
v4.AddCoordinate(-14.88).Display();

Console.WriteLine("\nv4 length:\t"+v4.GetLength());

using (StreamWriter writer = new StreamWriter("C:\\Users\\servo\\RiderProjects\\Lab3\\Lab3\\JSON_output.json", false))
{
    writer.Write(JsonSerializer.Serialize(v4.GetCoordinatesDict()));
}


Console.ReadKey();