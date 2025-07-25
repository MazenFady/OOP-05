/*
 Define 3D Point Class and the basic Constructors (use chaining in constructors).

Override the ToString Function to produce this output:
Point3D P = new Point3D (10,10,10);
Console. WriteLine (P. ToString( ));
Output: “Point Coordinates: (10, 10, 10)”.
 Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).

Try to use ==
If (P1 == P2)   Does it work properly? 
Define an array of points and sort this array based on X & Y coordinates.
Implement ICloneable interface to be able to clone the object.
To implement more than one interface.
class Point3D:IComparable ,ICloneable 


Second Project:
Define Class Maths that has four methods: Add, Subtract, Multiply, and Divide, each of them takes two parameters. Call each method in Main ().
 Modify the program so that you do not have to create an instance of class to call the four methods.

 */
using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
namespace Demo
{
    internal class Program 
    {
        //#region Q1
        //public static void Main(string[] args) 
        //{
        //    Console.WriteLine("Please Enter coordinates for Point 1:");
        //    int x1 =int.Parse(Console.ReadLine());
        //    int y1 =int.Parse(Console.ReadLine());
        //    int z1 =int.Parse(Console.ReadLine());
        //    Point3D p1= new Point3D (x1,y1,z1);
        //    Console.WriteLine("Please Enter coordinates for Point 2:");
        //    int x2 = int.Parse(Console.ReadLine());
        //    int y2 = int.Parse(Console.ReadLine());
        //    int z2 = int.Parse(Console.ReadLine());
        //    Point3D p2 = new Point3D(x2,y2,z2);

        //    if (p1==p2)
        //        Console.WriteLine("p1 and p2 is equal");
        //    else
        //        Console.WriteLine("p1 and p2 not equal");

        //    Point3D p = new Point3D(10, 10, 10);
        //    Console.WriteLine(p.ToString());

        //    Point3D[] P =
        //    {

        //    new Point3D (1,5,9),
        //    new Point3D (2,4,3),
        //    new Point3D (7,8,6),
        //    new Point3D (8,9,9),
        //    p1,p2

        //    };

        //    Array.Sort(P);
        //    Console.WriteLine("\nSort Points");
        //    foreach (var point in P) 
        //    {
        //        Console.WriteLine(point);
        //    }
        //    Point3D clone =(Point3D)p1.Clone();
        //    Console.WriteLine($"\nCloned Point from P1: {clone}");






        //    Console.ReadKey();



        //}
        //public class Point3D : IComparable<Point3D>, ICloneable
        //{
        //    public int X {get; set; }
        //    public int Y {get; set; }
        //    public int Z { get; set;}

        //    public Point3D() : this(0, 0, 0) {}
        //    public Point3D(int x): this(x, 0, 0) {}

        //    public Point3D (int x , int y ) : this(x, y, 0) { }



        //    public Point3D(int x, int y, int z)
        //    {
        //        X = x;
        //        Y = y;
        //        Z = z;

        //    }

        //    public override string ToString()
        //    {
        //        return $"Point Coordinates : {X} , {Y} , {Z}";

        //    }
        //    public override bool Equals(object obj)
        //    {
        //        if (obj is Point3D other)
        //        {
        //            return this.X == other.X && this.Y == other.Y && this.Z == other.Z;
        //        } 
        //        return false ;
        //    }
        //    public override int GetHashCode()
        //    {
        //        return HashCode.Combine(X, Y, Z);
        //    }
        //    public static  bool operator ==(Point3D p1 , Point3D p2)
        //    {
        //        if (ReferenceEquals(p1,p2))
        //        return true;
        //        if (p1 is null || p2 is null )
        //            return false;
        //        return p1.Equals(p2);
        //    }
        //    public static bool operator !=(Point3D p1, Point3D p2)
        //    {
        //        return !(p1 == p2);
        //    }
        //    public int CompareTo(Point3D other)
        //    {
        //        if (this.X != other.X)
        //            return this.X.CompareTo(other.X);
        //        else return this.Y.CompareTo(other.Y);

        //    }
        //    public object Clone()
        //    {
        //        return new Point3D(this.X, this.Y, this.Z);

        //    }



        //}

        //#endregion

        #region Q2
        public static void Main(string[] args)
        {
           
            Console.WriteLine($" Add : {Maths.Add(5, 6)} ");
            Console.WriteLine($"Subtract : {Maths.Subtract(10, 20)}");
            Console.WriteLine($"Multiply :{Maths.Multiply(100,2000)} ");
            Console.WriteLine($"Divide : {Maths.Divide(10, 5)}");


            Console.ReadKey();
        }
        public class Maths
        {
            public static int Add(int X, int Y)
            {
               return X + Y;

            }
            public static int Subtract(int X2, int Y2)
            {
                return X2 - Y2;

            }
            public static int Multiply(int X3, int Y3)
            {
                return X3 * Y3;
            }
            public static int Divide(int X4, int Y4)
            {
                return X4 / Y4;
            }

        }

        #endregion


    }





}