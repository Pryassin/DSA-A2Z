link : https://leetcode.com/problems/fibonacci-number/

public class Solution
{
    // This method computes the nth Fibonacci number using plain recursion.
    // Time Complexity: O(2^n) – very inefficient for large n due to repeated calculations.
    // Space Complexity: O(n) – due to the call stack used in recursion.
    public int Fib(int n)
    {
        // Base case: Fib(0) = 0
        if (n == 0) return 0;

        // Base case: Fib(1) = 1
        if (n == 1) return 1;

        // Recursive case: Fib(n) = Fib(n-1) + Fib(n-2)
        return Fib(n - 1) + Fib(n - 2);
    }
}
