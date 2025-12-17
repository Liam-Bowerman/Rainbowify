namespace Rainbows
{
    public class Rainbowify
    {
        //Rainbowify.Write() and Rainbowify.WriteLine() work the same as Console.Write() and Console.WriteLine() *essentially
        //Rainbowified strings CANNOT become string variables as of this time
        public static string Write(string userTextToMakeRainbow)
        {
            int i = 1;
            foreach (char c in userTextToMakeRainbow)
            {
                string foreColor = "\x1b[38;2" + ";" + 255 + ";" + 0 + ";" + 0 + "m";
                switch (i)
                {
                    case 1:
                        foreColor = "\x1b[38;2" + ";" + 255 + ";" + 0 + ";" + 0 + "m";
                        break;
                    case 2:
                        foreColor = "\x1b[38;2" + ";" + 242 + ";" + 136 + ";" + 29 + "m";
                        break;
                    case 3:
                        foreColor = "\x1b[38;2" + ";" + 255 + ";" + 255 + ";" + 0 + "m";
                        break;
                    case 4:
                        foreColor = "\x1b[38;2" + ";" + 0 + ";" + 255 + ";" + 0 + "m";
                        break;
                    case 5:
                        foreColor = "\x1b[38;2" + ";" + 0 + ";" + 0 + ";" + 255 + "m";
                        break;
                    case 6:
                        foreColor = "\x1b[38;2" + ";" + 128 + ";" + 0 + ";" + 128 + "m";
                        break;
                    default:
                        break;
                }
                Console.Write(foreColor + c);
                i++;
                if (i > 6)
                {
                    i = 1;
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            return null;
        }
        public static string WriteLine(string userTextToMakeRainbow)
        {
            Write(userTextToMakeRainbow);
            Console.WriteLine("");
            return null;
        }
        public static string WriteColor(string userTextToMakeRainbow, int red, int green, int blue)
        {
            foreach (char c in userTextToMakeRainbow)
            {
                string foreColor = "\x1b[38;2" + ";" + red + ";" + green + ";" + blue + "m";
                Console.Write(foreColor + c);
                Console.ForegroundColor = ConsoleColor.White;
            }
            return null;
        }
        public static string WriteLineColor(string userTextToMakeRainbow, int red, int green, int blue)
        {
            WriteColor(userTextToMakeRainbow, red, green, blue);
            Console.WriteLine("");
            return null;
        }
    }
}