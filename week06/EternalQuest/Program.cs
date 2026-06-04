using System;

// Creativity:  1.- I added a leveling system based on the user's total score.
//              2.- The program displays the current level every time the menu appears.
//              3.- I also added an achievement message when the user reaches 5000 points.
//              4.- This adds more gamification beyond the basic project requirements.
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}