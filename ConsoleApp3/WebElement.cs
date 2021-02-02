using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class WebElement
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Point LeftTop { get; set; }

        public WebElement(Point topLeft, int width, int height)
        {
            LeftTop = topLeft;
            Width = width;
            Height = height;
        }

    }
}
