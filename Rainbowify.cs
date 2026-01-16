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
        /// A function used to print a string with rainbow text and end the line of text.
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
        /// A function used to write text in any specific color using rgb values within the curent line of text.
        /// </summary>
        /// <param name="s">A string whose charecters will be printed with a user specified color.</param>
        /// <param name="red">The integer that decides the red value</param>
        /// <param name="green">The integer that decides the green value</param>
        /// <param name="blue">The integer that decides the blue value</param>
        /// <returns>A string with colored charecters acording to the specified rgb value and inputed string.</returns>
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
        /// A function used to store a colored string that can be used as a string variable.
        /// </summary>
        /// <param name="s">A string whose charecters will not be printed but returned</param>
        /// <param name="red">The integer that decides the red value</param>
        /// <param name="green">The integer that decides the green value</param>
        /// <param name="blue">The integer that decides the blue value</param>
        /// <returns>A colored string to be used as a new string variable.</returns>
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
        /// A function used to write text in any specific color using rgb values and ends the current line of text.
        /// </summary>
        /// <param name="s">A string whose charecters will be printed with a user specified color.</param>
        /// <param name="red">The integer that decides the red value</param>
        /// <param name="green">The integer that decides the green value</param>
        /// <param name="blue">The integer that decides the blue value</param>
        /// <returns>A string with colored charecters acording to the specified rgb value and inputed string.</returns>
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
        /// <summary>
        /// An overide verion of the WriteColor() function that uses color names to decide the color of the text.
        /// </summary>
        /// <param name="s">A string whose char values will be printed in a color specified by the user.</param>
        /// <param name="colorName">A color to change the text to.</param>
        /// <returns>A string with colored charecters acording to the specified color name and inputed string.</returns>
        public static string WriteColor(string s, string colorName)
        {
            int red = 0;
            int green = 0;
            int blue = 0;
            string newS = "";
            string color = colorName.ToLower();
            if(color == "red")
            {
                red = 255;
            }
            else if(color == "orange")
            {
                red = 242;
                green = 136;
                blue = 29;
            }
            else if(color == "yellow")
            {
                red = 255;
                green = 255;
            }
            else if(color == "green")
            {
                green = 255;
            }
            else if(color == "blue")
            {
                blue = 255;
            }
            else if(color == "purple")
            {
                red = 128;
                blue = 128;
            }
            else if(color == "black")
            {
                red = 0;
                blue = 0;
                green = 0;
            }
            else if(color == "white")
            {
                red = 255;
                blue = 255;
                green = 255;
            }
            else if(color == "pink")
            {
                red = 255;
                blue = 192;
                green = 203;
            }
            else if(color == "grey" || color == "gray")
            {
                red = 200;
                blue = 200;
                green = 200; 
            }
            else if(color == "cyan")
            {
                green = 255;
                blue = 255;
            }
            else if(color == "dark green")
            {
                red = 9;
                green = 94;
            }
            else
            {
                red = 255;
                blue = 255;
                green = 255;
            }
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
        /// An overide verion of the WriteLineColor() function that uses color names to decide the color of the text and end a line.
        /// </summary>
        /// <param name="s">A string whose char values will be printed in a color specified by the user.</param>
        /// <param name="colorName">A color to change the text to.</param>
        /// <returns>A string with colored charecters acording to the specified color name and inputed string.</returns>
        public static string WriteLineColor(string s, string colorName)
        {
            int red = 0;
            int green = 0;
            int blue = 0;
            string newS = "";
            string color = colorName.ToLower();
            if(color == "red")
            {
                red = 255;
            }
            else if(color == "orange")
            {
                red = 242;
                green = 136;
                blue = 29;
            }
            else if(color == "yellow")
            {
                red = 255;
                green = 255;
            }
            else if(color == "green")
            {
                green = 255;
            }
            else if(color == "blue")
            {
                blue = 255;
            }
            else if(color == "purple")
            {
                red = 128;
                blue = 128;
            }
            else if(color == "black")
            {
                red = 0;
                blue = 0;
                green = 0;
            }
            else if(color == "white")
            {
                red = 255;
                blue = 255;
                green = 255;
            }
            else if(color == "pink")
            {
                red = 255;
                blue = 192;
                green = 203;
            }
            else if(color == "grey" || color == "gray")
            {
                red = 200;
                blue = 200;
                green = 200; 
            }
            else if(color == "cyan")
            {
                green = 255;
                blue = 255;
            }
            else if(color == "dark green")
            {
                red = 9;
                green = 94;
            }
            else
            {
                red = 255;
                blue = 255;
                green = 255;
            }
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
        /// An override function for StoreColor that uses a string value to decide the color of the text.
        /// </summary>
        /// <param name="s">A string whose char values will be printed in a color specified by the user.</param>
        /// <param name="colorName">A color to change the text to.</param>
        /// <returns>A colored string to be used as a new string variable.</returns>
        public static string StoreColor(string s, string colorName)
        {
            int red = 0;
            int green = 0;
            int blue = 0;
            string newS = "";
            string color = colorName.ToLower();
            if(color == "red")
            {
                red = 255;
            }
            else if(color == "orange")
            {
                red = 242;
                green = 136;
                blue = 29;
            }
            else if(color == "yellow")
            {
                red = 255;
                green = 255;
            }
            else if(color == "green")
            {
                green = 255;
            }
            else if(color == "blue")
            {
                blue = 255;
            }
            else if(color == "purple")
            {
                red = 128;
                blue = 128;
            }
            else if(color == "black")
            {
                red = 0;
                blue = 0;
                green = 0;
            }
            else if(color == "white")
            {
                red = 255;
                blue = 255;
                green = 255;
            }
            else if(color == "pink")
            {
                red = 255;
                blue = 192;
                green = 203;
            }
            else if(color == "grey" || color == "gray")
            {
                red = 200;
                blue = 200;
                green = 200; 
            }
            else if(color == "cyan")
            {
                green = 255;
                blue = 255;
            }
            else if(color == "dark green")
            {
                red = 9;
                green = 94;
            }
            else
            {
                red = 255;
                blue = 255;
                green = 255;
            }
            foreach (char c in s)
            {
                string foreColor = "\x1b[38;2" + ";" + red + ";" + green + ";" + blue + "m";
                newS += foreColor + c;
                Console.ForegroundColor = ConsoleColor.White;
            }
            return newS;
        }
    }
}