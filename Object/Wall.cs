using System;
using System.Collections.Generic;
using System.Text;
using Sneak.AX3;

namespace Sneak.AX4
{
    internal class Wall : GameObject
    {
        public Wall(int x, int y)
        {
            pos = new Position(x, y);
        }

        public override void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("■");
        }
    }
}
