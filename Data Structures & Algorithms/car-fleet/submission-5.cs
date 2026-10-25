public class Solution 
{
    public int CarFleet(int target, int[] position, int[] speed) 
    {
        int n = position.Length;
        (int pos, double time)[] cars = new (int, double)[n];

        for (int i = 0; i < n; i++) 
        {
            cars[i] = (position[i], (double)(target - position[i]) / speed[i]);
        }

        Array.Sort(cars, (a, b) => b.pos.CompareTo(a.pos));

        int fleets = 0;
        double maxTime = 0;

        foreach (var car in cars) 
        {
            if (car.time > maxTime) 
            {
                fleets++;
                maxTime = car.time; // New bottleneck time for all cars behind
            }
        }

        return fleets;
    }
}