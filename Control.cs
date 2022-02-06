using System;
using System.Security.AccessControl;

namespace NewCSharpConcepts
{
    public abstract class Control
    {
        protected int xPos;
        protected int yPos;

        public Control(int xPosition, int yPosition)
        {
            xPos = xPosition;
            yPos = yPosition;
        }

        public virtual void Clear()
        {
            Console.WriteLine("Clearing Control");
        }

        public abstract void Draw();
        
    }
}