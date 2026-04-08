using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Creativity / exceed requirements:
        // 1. Added a level/title system based on total score.
        // 2. The user earns a title as they gain more points.
        // 3. The title is displayed in the main menu along with score.
        // These features go beyond the core requirements.

        GoalManager manager = new GoalManager();
        manager.Start();
    }
}