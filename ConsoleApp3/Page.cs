using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Page
    {
        public List<WebElement> webElements {get; set;}

        public Page(List<WebElement> elements)
        {
            webElements = elements;
        }
    }
  
}