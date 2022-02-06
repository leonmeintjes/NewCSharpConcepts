using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace NewCSharpConcepts
{
    public class MyListBox : Control
    {
        private List<string> list = new List<string>();

        public MyListBox(int xPos, int yPos, List<string> contents) : base(xPos,yPos)
        {

            this.list = contents;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing ListBox...");

        }
    }
}