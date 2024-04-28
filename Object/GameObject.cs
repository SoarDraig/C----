using System;
using System.Collections.Generic;
using System.Text;

namespace Sneak.AX3
{
    internal abstract class GameObject : IDraw
    {
        public Position pos;
        public abstract void Draw();
    }
}
