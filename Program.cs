using System;

namespace Assignment1QA
{
    class Program

    {
        static Rectangle r = new Rectangle();
        static void Main(string[] args)

        {
            Menu();
        }


        static void Menu(int v = 0)
        {
            int option;

            if (v == 0)
            {
                option = Options();
            }
            else
            {
                option = v;
            }

            switch (option)
            {
                case 1:
                    int lenght = r.GetLenght();
                    Console.WriteLine("The lenght of the rectangle is: " + lenght.ToString());
                    Menu(0);
                    break;
                case 2:
                    ChangeLenght();
                    break;
                case 3:
                    int width = r.GetWidth();
                    Console.WriteLine("The width of the rectangle is: " + width.ToString());
                    Menu(0);
                    break;
                case 4:
                    ChangeWidth();
                    break;
                case 5:
                    int p = r.GetPerimeter();
                    Console.WriteLine("The perimeter of the rectangle is: " + p.ToString());
                    Menu(0);
                    break;
                case 6:
                    int a = r.GetArea();
                    Console.WriteLine("The area of the rectangle is: " + a.ToString());
                    Menu(0);
                    break;
                case 7:
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("does not exist");
                    Menu(0);
                    break;
            }

        }

        static int Options()
        {
            int option;
            Console.WriteLine("Choose one option, typing the number");
            Console.WriteLine("");
            Console.WriteLine("1. Get rectangle length");
            Console.WriteLine("2. Change rectangle length");
            Console.WriteLine("3. Get rectangle width");
            Console.WriteLine("4. Change rectangle width");
            Console.WriteLine("5. Get rectangle perimeter");
            Console.WriteLine("6. Get rectangle area");
            Console.WriteLine("7. Exit");
            option = Convert.ToInt32(Console.ReadLine());
            return option;
        }


        static void ChangeLenght()
        {
            Console.WriteLine("Type the rectangle lenght:");
            int l = Convert.ToInt32(Console.ReadLine());
            if (l >= 0)
            {
                r.SetLength(l);
                Menu(0);
            }
            else
            {
                Console.WriteLine("Lenght must be greater or equal to 0");
                Menu(2);
            }

        }

        static void ChangeWidth()
        {
            Console.WriteLine("Type the rectangle width:");
            int w = Convert.ToInt32(Console.ReadLine());
            if (w >= 0)
            {
                r.SetWidth(w);
                Menu(0);
            }
            else
            {
                Console.WriteLine("Width must be greater or equal to 0");
                Menu(4);
            }
        }
    }
}
