namespace Daf.PiApprox.Cli;
public class PiService : IPiService
{
    // at first it will be 1000 point then you will have to increment it go straight to 10000 then 1000000
    private readonly int _pointsArrayLength = 1000000; 
    public static bool IsInCircle(Point point) => point.X * point.X + point.Y * point.Y <= 1;
    public double ApproxPi()
    {
        var rand = new Random();
        var pointsArray = new Point[_pointsArrayLength];
        var pointsInCircle = new List<Point>();
        for(int i = 0; i < _pointsArrayLength; i++)
        {
            var randomPoint = GeneratePoint(rand);
            pointsArray[i] = randomPoint;
            if (IsInCircle(randomPoint))
                pointsInCircle.Add(randomPoint);
        }

        return pointsInCircle.Count / (double)_pointsArrayLength * 4;
    }

    private static Point GeneratePoint(Random rand) => new() { X = rand.NextDouble(), Y = rand.NextDouble() };
}
