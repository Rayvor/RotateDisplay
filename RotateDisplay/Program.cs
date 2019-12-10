using System;

namespace RotateDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        Display.Rotate(1, Display.Orientations.DEGREES_CW_0);
                        break;
                    case "1":
                        Display.Rotate(1, Display.Orientations.DEGREES_CW_180);
                        break;
                    case "2":
                        Display.Rotate(1, Display.Orientations.DEGREES_CW_90);
                        break;
                    case "3":
                        Display.Rotate(1, Display.Orientations.DEGREES_CW_270);
                        break;
                }
            }
            
        }
    }
}
