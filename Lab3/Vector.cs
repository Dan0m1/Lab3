namespace Lab3;

public class Vector
{
    private Dictionary<int,double> _coordinates;

    public Vector(Dictionary<int,double>coordinates)
    {
        _coordinates = coordinates;
    }

    public Vector(params double[] values)
    {
        int i = 0;
        _coordinates = new Dictionary<int, double>();
        foreach (double value in values)
        {
            _coordinates.Add(i++, value);
        }
    }

    public Vector AddCoordinate(double value)
    {
        _coordinates.Add(_coordinates.Count, value);
        return this;
    }

    public Vector RemoveLastCoordinate()
    {
        if (_coordinates.Count < 3)
        {
            Console.WriteLine("You can't remove last coordinate: coordinate's amount equals 2");
        }
        _coordinates.Remove(_coordinates.Count - 1);
        return this;
    }
    
    public static Vector operator +(Vector v1, Vector v2)
    {
        if (v1._coordinates.Count != v2._coordinates.Count)
        {
            throw new ArgumentException("Vectors defer in amount of coordinates. Please use this method only to add vectors with the same amount of coordinates.");
        }
        Dictionary<int,double> add = new Dictionary<int,double>();
        for (int i = 0; i < v1._coordinates.Count; i++)
        {
            add.Add(i, v1._coordinates[i] + v2._coordinates[i]);
        }

        return new Vector(add);
    }
    
    public static Vector operator -(Vector v1, Vector v2)
    {
        if (v1._coordinates.Count != v2._coordinates.Count)
        {
            throw new ArgumentException("Vectors defer in amount of coordinates. Please use this method only to substitute vectors with the same amount of coordinates.");
        }
        Dictionary<int,double> sub = new Dictionary<int,double>();
        for (int i = 0; i < v1._coordinates.Count; i++)
        {
            sub.Add(i, v1._coordinates[i] - v2._coordinates[i]);
        }

        return new Vector(sub);
    }

    public static Vector operator *(Vector v, double value)
    {
        Dictionary<int,double> product = new Dictionary<int,double>();
        foreach (var pair in v._coordinates)
        {
            product.Add(pair.Key, v._coordinates[pair.Key]*value);
        }

        return new Vector(product);
    }

    public static double DotProduct(Vector v1, Vector v2)
    {
        if (v1._coordinates.Count != v2._coordinates.Count)
        {
            throw new ArgumentException("Vectors defer in amount of coordinates. Please use this method only to dot-product vectors with the same amount of coordinates.");
        }

        double dotProduct = 0.0;
        for (int i = 0; i < v1._coordinates.Count; i++)
        {
            dotProduct += v1._coordinates[i] * v2._coordinates[i];
        }

        return dotProduct;
    }
    
    public double GetLength()
    {
        return Math.Sqrt(_coordinates.Sum(p => Math.Pow(p.Value, 2)));
    }

    public void Display()
    {
        string vTupple = "";
        for (int i = 0; i < _coordinates.Count; i++)
        {
            Console.WriteLine($"Coordinate {i}:\t{_coordinates[i]}");
            vTupple += _coordinates[i] + (i < _coordinates.Count-1? ", ": "");
        }
        Console.WriteLine("Vector in tupple: (" + vTupple + ")");
    }

    public Dictionary<int, double> GetCoordinatesDict()
    {
        return _coordinates;
    }
}