//You are climbing a staircase. It takes n steps to reach the top.

//Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?


//!!!This problem is a classic example of dynamic programming and can be solved using the Fibonacci sequence!!!


int ClimbStairs(int n)
{
    if (n <= 2) return n;
    int[] dp = new int[n + 1];
    dp[1] = 1;
    dp[2] = 2;
    for (int i = 3; i <= n; i++)
    {
        dp[i] = dp[i - 1] + dp[i - 2];
    }
    return dp[n];
}

int steps = ClimbStairs(2);
Console.WriteLine(steps); // Output: 2

Console.ReadLine();
