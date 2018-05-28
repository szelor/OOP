using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    public class Button : Control
    {
        private string text;

        public Button(int xPos, int yPos, string text)
            : base(xPos, yPos)
        {
            this.text = text;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Button...");
        }
    }
}
