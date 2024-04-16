using Lab3;


Vector v1 = new Vector(new Dictionary<int, double>()
{
    {0, 213.4323},
    {1, 3443.53},
    {2, -23.340},
    {3, -0.2}
});
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

Console.ReadKey();