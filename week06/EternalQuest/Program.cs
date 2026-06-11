using System;

// Creativity:
// Added a player leveling system.
// Users advance through Bronze, Silver,
// Gold, and Platinum levels based on score.

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}