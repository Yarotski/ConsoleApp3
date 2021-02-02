using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Window:WebElement
    {
        public string Name { get; set; }
        public Window(Point topLeft, int width, int height, string name): base (topLeft, width, height)
        {
            Name = name;
        }

    }
}
