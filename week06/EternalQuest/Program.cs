using System;

// CREATIVITY - EXCEEDING CORE REQUIREMENTS:
// 1. Level System: Users earn levels as they accumulate points (every 1000 points = 1 level)
// 2. Negative Goals: Added ability to track bad habits that subtract points when recorded
// 3. Goal Statistics: Show total goals completed, in progress, and percentage complete
// 4. Bonus Points Animation: Display celebration message when earning checklist bonus
// 5. Input Validation: Prevents crashes from invalid user input using TryParse throughout

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}