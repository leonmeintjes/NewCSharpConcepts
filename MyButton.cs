using System;

namespace NewCSharpConcepts
{
    public class MyButton : Control
    {
        private string MyText;

        public MyButton(int xPos, int yPos, string PassedText) : base(xPos,yPos)
        {
            this.MyText = PassedText;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Button...");
        }
    }
}