using System.Threading.Tasks;
namespace Rainbows
{
    public class Rainbowify
    {
        public static int i = 1;
        //Rainbowify.Write() and Rainbowify.WriteLine() work the same as Console.Write() and Console.WriteLine() *essentially
        //Rainbowified strings CANNOT become string variables as of this time
        public static string Write(string userTextToMakeRainbow)
        {
            i = 1;
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
        public static void Rainbows(string userTextToMakeRainbow)
        {
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
            Thread.Sleep(100);
            Console.Clear();
            Rainbows(userTextToMakeRainbow);
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
        public static void Example()
        {
            Write("This is what Rainbowify.Write() looks like!");
            Console.WriteLine("You can even use other Write or WriteLines with this function to have them in the same line.");
            WriteLine("This is what Rainbowify.WriteLine() looks like! Like a normal WriteLine it makes it's own line.");
            WriteColor("And this is Rainbowify.WriteColor()! With the rgb of 234, 34, 86.", 234, 34, 86);
            Console.WriteLine("And just like the Rainbowify.Write() function it too can be used with other Write or WriteLine functions.");
            WriteLineColor("And this is Rainbowify.WriteLineColor()! With the rgb of 62, 43, 255.", 62, 43, 255);
            Console.WriteLine("To see the alternating rainbow function press any key");
            Console.ReadKey(true);
            Task task = new Task(() =>
            {
                while (true)
                {
                    Rainbows("This is Rainbowify.Rainbows() press any key to stop");
                } 
            });
            task.Start();
            Console.ReadKey(true);
        }
    }
}