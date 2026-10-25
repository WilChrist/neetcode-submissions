public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        List<(int position, int speed)> l = new List<(int, int)>();
        for (int i = 0; i < speed.Length; i++) {
            l.Add((position: position[i], speed: speed[i]));
        }

        l.Sort((x, y) => y.position.CompareTo(x.position));

        Stack<(int position, int speed)> stack = new Stack<(int position, int speed)>();
        int res = 0;
        double bt = 0;
        // Console.WriteLine(0); [(4,1), (2,3), (0,2)] : 6 3 5
        foreach (var t in l) {
            if (stack.Count == 0) {
                stack.Push(t);
                res++;
                bt = ComputeTime(target, t);
                continue;
            }
            if (ComputeTime(target, t) <= bt) {
                stack.Push(t);

            } else {
                
                bt = ComputeTime(target, t);

                while (stack.Count > 0 &&
                       (bt> ComputeTime(target, stack.Peek()))) {
                    stack.Pop();
                }
                stack.Push(t);
                res++;
            }
        }

        return res;
    }

    public double ComputeTime(int target, (int position, int speed)t) {
        return (target - t.position) / (double)t.speed;
    }
}
