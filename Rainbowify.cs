using System.Threading.Tasks;
namespace Rainbows
{
    public class Rainbowify
    {
        public static bool rainbowsBool = true; 
        private static int i = 1;
        //Rainbowify.Write() and Rainbowify.WriteLine() work the same as Console.Write() and Console.WriteLine() *essentially

        /// <summary>
        /// A function used to print a string in the active line with rainbow text.
        /// </summary>
        /// <param name="s">A string whose charecters will be colored the colors of the rainbow.</param>
        /// <returns>A new written string with the same text as the inputed string but with rainbow colored text.</returns>
        public static string Write(string s)
        {
            string newS = "";
            i = 1;
            foreach (char c in s)
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
                newS += foreColor + c;
                i++;
                if (i > 6)
                {
                    i = 1;
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            return newS;
        }
        /// <summary>
        /// A function used with a new variable name to store Rainbowified text.
        /// </summary>
        /// <param name="s">A string whose contents will be returned with rainbow coloration.</param>
        /// <returns>A value of the inputed string with different colors.</returns>
        public static string Store(string s)
        {
            string newS = "";
            i = 1;
            foreach (char c in s)
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
                newS += foreColor + c;
                i++;
                if (i > 6)
                {
                    i = 1;
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            return newS;
        }
        /// <summary>
        /// A function used to print a string with rainbow text and end the line.
        /// </summary>
        /// <param name="s">A string whose charecters will be colored the colors of the rainbow.</param>
        /// <returns>A new written string with the same text as the inputed string but with rainbow colored text</returns>
        public static string WriteLine(string s)
        {
            string newS = "";
            i = 1;
            foreach (char c in s)
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
                newS += foreColor + c;
                i++;
                if (i > 6)
                {
                    i = 1;
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("");
            return newS;
        }
        /// <summary>
        /// A function used to oscillate colors until a value (rainbowsBool) is set to false. 
        /// </summary>
        /// <param name="s">A string whose acharecter value will be printed infinately while changing color.</param>
        public static void Rainbows(string s)
        {
            foreach (char c in s)
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
            Thread.Sleep(150);
            Console.Clear();
            while(rainbowsBool == true)
            {
                Rainbows(s);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        /// <returns></returns>
        public static string WriteColor(string s, int red, int green, int blue)
        {
            string newS = "";
            foreach (char c in s)
            {
                string foreColor = "\x1b[38;2" + ";" + red + ";" + green + ";" + blue + "m";
                Console.Write(foreColor + c);
                newS += foreColor + c;
                Console.ForegroundColor = ConsoleColor.White;
            }
            return newS;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        /// <returns></returns>
        public static string StoreColor(string s, int red, int green, int blue)
        {
            string newS = "";
            foreach (char c in s)
            {
                string foreColor = "\x1b[38;2" + ";" + red + ";" + green + ";" + blue + "m";
                newS += foreColor + c;
                Console.ForegroundColor = ConsoleColor.White;
            }
            return newS;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        /// <returns></returns>
        public static string WriteLineColor(string s, int red, int green, int blue)
        {
            string newS = "";
            foreach (char c in s)
            {
                string foreColor = "\x1b[38;2" + ";" + red + ";" + green + ";" + blue + "m";
                Console.Write(foreColor + c);
                newS += foreColor + c;
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("");
            return newS;
        }
        /// <summary>
        /// A function that shows an example of all the other functions
        /// </summary>
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
            rainbowsBool = false;
        }
    }
}