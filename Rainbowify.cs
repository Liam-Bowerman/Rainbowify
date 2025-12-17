namespace Rainbows
{
    public class Rainbowify
    {
        public static void Write(string userTextToMakeRainbow)
        {
            int i = 1;
            foreach (char c in userTextToMakeRainbow)
            {
                string foreColor = "\x1b[38;2" + ";" + 255 + ";" + 0 + ";" + 0 + "m";
                switch (i)
                {
                    case 1:
                        foreColor = "\x1b[38;2" + ";" + 255 + ";" + 0 + ";" + 0 + "m";
                        Console.Write(foreColor + c);
                        break;
                    case 2:
                        foreColor = "\x1b[38;2" + ";" + 242 + ";" + 136 + ";" + 29 + "m";
                        Console.Write(foreColor + c);
                        break;
                    case 3:
                        foreColor = "\x1b[38;2" + ";" + 255 + ";" + 255 + ";" + 0 + "m";
                        Console.Write(foreColor + c);
                        break;
                    case 4:
                        foreColor = "\x1b[38;2" + ";" + 0 + ";" + 255 + ";" + 0 + "m";
                        Console.Write(foreColor + c);
                        break;
                    case 5:
                        foreColor = "\x1b[38;2" + ";" + 0 + ";" + 0 + ";" + 255 + "m";
                        Console.Write(foreColor + c);
                        break;
                    case 6:
                        foreColor = "\x1b[38;2" + ";" + 128 + ";" + 0 + ";" + 128 + "m";
                        Console.Write(foreColor + c);
                        break;
                    default:
                        break;
                }
                i++;
                if (i > 6)
                {
                    i = 1;
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public static void WriteLine(string userTextToMakeRainbow)
        {
            int i = 1;
            foreach (char c in userTextToMakeRainbow)
            {
                string foreColor = "\x1b[38;2" + ";" + 255 + ";" + 0 + ";" + 0 + "m";
                switch (i)
                {
                    case 1:
                        foreColor = "\x1b[38;2" + ";" + 255 + ";" + 0 + ";" + 0 + "m";
                        Console.Write(foreColor + c);
                        break;
                    case 2:
                        foreColor = "\x1b[38;2" + ";" + 209 + ";" + 111 + ";" + 13 + "m";
                        Console.Write(foreColor + c);
                        break;
                    case 3:
                        foreColor = "\x1b[38;2" + ";" + 255 + ";" + 255 + ";" + 0 + "m";
                        Console.Write(foreColor + c);
                        break;
                    case 4:
                        foreColor = "\x1b[38;2" + ";" + 0 + ";" + 255 + ";" + 0 + "m";
                        Console.Write(foreColor + c);
                        break;
                    case 5:
                        foreColor = "\x1b[38;2" + ";" + 0 + ";" + 0 + ";" + 255 + "m";
                        Console.Write(foreColor + c);
                        break;
                    case 6:
                        foreColor = "\x1b[38;2" + ";" + 128 + ";" + 0 + ";" + 128 + "m";
                        Console.Write(foreColor + c);
                        break;
                    default:
                        break;
                }
                i++;
                if (i > 6)
                {
                    i = 1;
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("");
        }
        public static void WriteColor(string userTextToMakeRainbow, int red, int green, int blue)
        {
            foreach (char c in userTextToMakeRainbow)
            {
                string foreColor = "\x1b[38;2" + ";" + red + ";" + green + ";" + blue + "m";
                Console.Write(foreColor + c);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public static void WriteLineColor(string userTextToMakeRainbow, int red, int green, int blue)
        {
            foreach (char c in userTextToMakeRainbow)
            {
                string foreColor = "\x1b[38;2" + ";" + red + ";" + green + ";" + blue + "m";
                Console.Write(foreColor + c);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("");
        }
    }
}
