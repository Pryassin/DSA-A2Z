public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n=position.Length;
        if(n==0) return 0;
        (int pos,int speed) [] cars= new (int,int) [n];
        for (int i = 0; i < n; i++) {
            cars[i] = (position[i], speed[i]);
        }
        Array.Sort(cars,(a,b)=>b.pos.CompareTo(a.pos));
        Stack<double> fleettime=new Stack<double>();
        foreach(var car in cars)
        {
            double time=(double)(target-car.pos)/car.speed;

            if(fleettime.Count==0||time>fleettime.Peek())
            {
                fleettime.Push(time);
            }
        }
        return fleettime.Count;

     }
}