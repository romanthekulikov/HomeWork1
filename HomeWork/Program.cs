using HomeWork1;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Д/З: Программа для расчета длины дуги и площади эллипса \n");

        Point hightPoint = new Point
        {
            X = 10,
            Y = 20

        };

        Point downPoint = new Point
        {
            X = 10,
            Y = 0
        };

        Point leftPoint = new Point
        {
            X = -20,
            Y = 10
        };

        Point rightPoint = new Point
        {
            X = 40,
            Y = 10
        };

        try
        {

            Ellipse ellips = new Ellipse(hightPoint, downPoint, leftPoint, rightPoint);
            double lenght = Math.Abs(ellips.lenghtEllipse());
            double square = Math.Abs(ellips.squareEllipse());
            lenght = Math.Round(lenght, 3, MidpointRounding.ToZero);
            square = Math.Round(square, 3, MidpointRounding.ToZero);

            int absciss = ellips.XcoordinateCenter();
            int ordinat = ellips.YcoordinateCenter();

            Console.WriteLine($"Центер элипса -  точка с координатами ( {absciss} ; {ordinat} )");
            Console.WriteLine($"Длина дуги эллипса: {lenght} \nПлощадь эллипса: {square}");

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}
