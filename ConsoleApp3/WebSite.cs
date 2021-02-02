using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class WebSite
    {
        public List<Page> webPages { get; set; }

        public WebSite(List<Page> pages)
        {
            webPages = pages;
        }
    }
}
