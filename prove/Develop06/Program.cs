// Creativity: To exceed requirements I did the following:
// 1- Created a new type of goal called BadHabit. With this goal you can list  
// bad habits you want to avoid. If you record an envent for it you lose points.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}