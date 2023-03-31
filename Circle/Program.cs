class Circle
{
    static void Main(string[] args)
    {
        // declaring variables
        int radius;
        double circumference;
        double diameter;
        double area;

        // prompting user and taking input for radius
        Console.Write("Enter Radius Of Circle:  ");
        radius = Convert.ToInt32(Console.ReadLine());

        // calculations
        diameter = 2 * radius;
        circumference = 2 * Math.PI * radius;
        area = Math.PI * radius * radius;

        // displaying circumference
        Console.WriteLine("Diameter Of Circumference:  " + Decimal.Round(Convert.ToDecimal(circumference), 2));

        // displaying diameter
        Console.WriteLine("Diameter Of Circle:  " + Decimal.Round(Convert.ToDecimal(diameter), 2));

        // displaying area
        Console.WriteLine("Area Of Circle:  " + Decimal.Round(Convert.ToDecimal(area), 2));
    }
    // end of Main method
}
// end of Circle class
