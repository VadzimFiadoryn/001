using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable
            var menu = new Menu();
            var figure = new Figure();
            int menuParametrFigur = 0;
            int menuParametrColor = 0;
            //
            Console.WriteLine(menu.figureNames());
            menuParametrFigur = int.Parse(Console.ReadLine());
            Console.WriteLine(menu.figureColor());
            menuParametrColor = int.Parse(Console.ReadLine());            
            Console.Clear();
            //Color
            Console.ForegroundColor = (ConsoleColor)menuParametrColor;
            //DrawFigur
            {
                switch (menuParametrFigur)
                {
                    case 1:
                        Console.WriteLine(figure.rectangle());
                        break;

                    case 2:
                        Console.WriteLine(figure.rhombus());
                        break;
                    case 3:
                        Console.WriteLine(figure.triangle());
                        break;
                    case 4:
                        Console.WriteLine(figure.trapezoid());
                        break;
                    case 5:
                        Console.WriteLine(figure.polygon());
                        break;
                    default:
                        Console.WriteLine("default");
                        break;
                }                
            }
        }
    }
}
