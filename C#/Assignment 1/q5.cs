
class Circle
{
    public double[] CalculateAreaAndCircumference(int radius)
    {
        double pi = 3.14;
        double circumference, area;
        circumference = 2 * pi * radius;
        area = pi * radius * radius;
        double[] result = new double[] {circumference, area};
        return result;
    }

    public static void Main()
    {
        Console.WriteLine("Enter the radius of the circle");
        int r = Convert.ToInt32(Console.ReadLine());
        Circle circle = new Circle();
        double[] result = circle.CalculateAreaAndCircumference(r);
        Console.WriteLine("The Area of the circle is :{0} \nThe Circumference of the circle is :{1}", result[1], result[0]);
    }
}