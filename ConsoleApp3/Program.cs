using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        

        //public static void MoveLeft(Window window)
        //{
        //    window.LeftTop.X -= 5;
        //}

        //public static void MoveDown(Window window)
        //{
        //    window.LeftTop.Y += 5;
        //}

        //public static void MoveUp(Window window)
        //{
        //    window.LeftTop.X += 5;
        //}

        //public static void MoveRight(Window window)
        //{
        //    window.LeftTop.X += 5;
        //}

        //public static void ResizeWidth(Window window)
        //{
        //    window.Width += 5;
        //}

        //public static void ResizeHeight(Window window)
        //{
        //    window.Height += 5;
        //}

        //public static void ChangeWindowPosition(List<Window> windowList, ChangePosition changeDelegate)
        //{
        //    foreach (Window window in windowList)
        //    {
        //        changeDelegate(window);
        //    }
        //}


        //public delegate void ChangePosition(Window window);


        static void Main(string[] args)
        {





            var pages = new List<Page>
            {
                new Page(new List<WebElement>
                {
                    new Button(new Point(5,1), 15, 8),
                    new Window(new Point(9,4), 25, 40, "Page 1 Window 1"),
                    new Window(new Point(0,11), 8, 65, "Page 1 Window 2"),
                    new Window(new Point(-5,8), 25, 30, "Page 1 Window 3"),
                    new Button(new Point(5,5), 10, 2),
                    new Window(new Point(6,3), 45, 8, "Page 1 Window 4"),
                    new Window(new Point(12,-1), 10, 5, "Page 1 Window 5"),
                    new CheckBox(new Point(2,5), 4,4),
                    new Window(new Point(15,6), 48, 10, "Page 1 Window 6"),
                    new Window(new Point(1,3), 8, 2, "Page 1 Window 6"),
                    new Window(new Point(2,9), 12, 4, "Page 1 Window 7")
                }),
                new Page(new List<WebElement>
                {
                    new Button(new Point(5,1), 15, 8),
                    new CheckBox(new Point(2,5), 4,4),
                    new Window(new Point(9,4), 25, 40, "Page 2 Window 1"),
                    new Window(new Point(0,11), 8, 65, "Page 2 Window 2"),
                    new CheckBox(new Point(2,5), 4,4),
                    new Button(new Point(51,21), 5, 18),
                    new Window(new Point(1,3), 8, 2, "Page 2 Window 3"),
                    new Window(new Point(2,9), 12, 4, "Page 2 Window 4")
                }),
                new Page(new List<WebElement>
                {
                    new Button(new Point(5,1), 15, 8),
                    new Window(new Point(0,11), 8, 65, "Page 3 Window 1"),
                    new Button(new Point(5,5), 10, 2),
                    new Window(new Point(6,3), 45, 8, "Page 3 Window 2"),
                    new Window(new Point(12,-1), 10, 5, "Page 3 Window 3"),
                    new Window(new Point(15,6), 48, 10, "Page 3 Window 4"),
                    new Window(new Point(2,9), 12, 4, "Page 3 Window 5"),
                    new Button(new Point(55,15), 1, 22),
                }),
                new Page(new List<WebElement>
                {
                    new Button(new Point(5,1), 15, 8),
                    new Button(new Point(5,1), 9, 8),
                    new Window(new Point(9,4), 25, 40, "Page 4 Window 1"),
                    new Window(new Point(1,3), 8, 2, "Page 4 Window 2"),
                    new Window(new Point(2,9), 12, 4, "Page 4 Window 3"),
                    new CheckBox(new Point(2,5), 4,4),
                }),


            };


            var site = new List<WebSite>
            {
                new WebSite(new List<Page>
                {
                    pages[0],
                    pages[1],
                    pages[2],
                    pages[3],

                })
            };
            var site2 = new List<WebSite>
            {
                new WebSite(new List<Page>
                {
                     pages[1],
                     pages[0],
                     pages[2],
                })
            };


 

            
            var one = site.Select(x => x.webPages.SelectMany(x => x.webElements.Select(x => (x.LeftTop.X, x.LeftTop.Y, x.Width, x.Height)).OrderByDescending(x => x.X))).ToList();
            var two = site.Select(x => x.webPages.SelectMany(x => x.webElements).Where(x => x is Window).Select(x => x as Window).Where(x => x.Height > 10).Select(x => x.Name)).ToList();
                        


            Console.WriteLine("");




            //Console.WriteLine("Enter command: \n1 - Move left \n2 - Move right \n3 - Move down \n4 - Move up \n5 - Resize width \n6 - Resize height)");

            //int choice = Convert.ToInt32(Console.ReadLine());


            //if (choice == 1)
            //{
            //    ChangePosition changeDelegate = MoveLeft;
            //    ChangeWindowPosition(windows, changeDelegate);

            //    foreach (Window window in windows)
            //    {
            //        Console.WriteLine(window.LeftTop.X + " " + window.LeftTop.Y + " " + window.Width + "  " + window.Height);
            //    }

            //}

            //if (choice == 2)
            //{
            //    ChangePosition changeDelegate = MoveRight;
            //    ChangeWindowPosition(windows, changeDelegate);

            //    foreach (Window window in windows)
            //    {
            //        Console.WriteLine(window.LeftTop.X + " " + window.LeftTop.Y + " " + window.Width + "  " + window.Height);
            //    }

            //}

            //if (choice == 3)
            //{
            //    ChangePosition changeDelegate = MoveDown;
            //    ChangeWindowPosition(windows, changeDelegate);

            //    foreach (Window window in windows)
            //    {
            //        Console.WriteLine(window.LeftTop.X + " " + window.LeftTop.Y + " " + window.Width + "  " + window.Height);
            //    }

            //}

            //if (choice == 4)
            //{
            //    ChangePosition changeDelegate = MoveUp;
            //    ChangeWindowPosition(windows, changeDelegate);

            //    foreach (Window window in windows)
            //    {
            //        Console.WriteLine(window.LeftTop.X + " " + window.LeftTop.Y + " " + window.Width + "  " + window.Height);
            //    }

            //}

            //if (choice == 5)
            //{
            //    ChangePosition changeDelegate = ResizeWidth;
            //    ChangeWindowPosition(windows, changeDelegate);

            //    foreach (Window window in windows)
            //    {
            //        Console.WriteLine(window.LeftTop.X + " " + window.LeftTop.Y + " " + window.Width + "  " + window.Height);
            //    }

            //}

            //if (choice == 6)
            //{
            //    ChangePosition changeDelegate = ResizeHeight;
            //    ChangeWindowPosition(windows, changeDelegate);

            //    foreach (Window window in windows)
            //    {
            //        Console.WriteLine(window.LeftTop.X + " " + window.LeftTop.Y + " " + window.Width + "  " + window.Height);
            //    }

            //}

            //else
            //{
            //    Console.WriteLine("Wrong value!");
            //}

            //ChangePosition changeDelegate = MoveDown;
            ////ChangePosition changeDelegate = new ChangePosition(MoveDown);
            //ChangeWindowPosition(windows, changeDelegate);

            //foreach (Window window in windows)
            //{
            //    Console.WriteLine(window);
            //}


        }
    }
}
