public class Solution {
    public int CalPoints(string[] operations) {
        // C# uses PascalCase for the class name
        Stack<int> scoreStack = new Stack<int>();

        for (int i = 0; i < operations.Length; i++) {
            // Strings must use double quotes " "
            if (operations[i] == "C") {
                scoreStack.Pop();
            }
            else if (operations[i] == "D") {
                // Peek the top, double it, and push it back
                int doublenum = 2 * scoreStack.Peek();
                scoreStack.Push(doublenum);
            }
            else if (operations[i] == "+") {
                // To get the top two without losing them:
                int top = scoreStack.Pop();
                int second = scoreStack.Peek(); 
                
                scoreStack.Push(top); // Put the top back
                scoreStack.Push(top + second); // Push the new sum
            }
            else {
                // Convert the numeric string to an integer
                int num = int.Parse(operations[i]);
                scoreStack.Push(num);
            }
        }

        int sum = 0;
        // foreach iterates from top to bottom
        foreach (int score in scoreStack) {
            sum += score;
        }
        return sum;
    }
}