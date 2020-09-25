using System;

namespace TestECS
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();

            // main game loop
            while (true)
            {
                game.Update(0.01f); // assume the proper frame delta is passed
            }
        }

    }
}
