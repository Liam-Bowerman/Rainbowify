## Summary

This package is only usable in c#.

All methods with Write or WriteLine in this project are functions that can be called on their own. They do not need to be called inside of a Console.Write or WriteLine.

All functions (except for Rainbows()) return a new string value.

## Issues or Suggestions?
#### If there are issues with compatability or if you have any suggestions please email ak3m1.h3art@gmail.com or contact Akemi through NuGet.

##
For a color picker to find an exact rgb value that's easy to use you can use this color picker website:
- https://htmlcolorcodes.com/color-picker/

## Updates
### January 16, 2026:
Version: 1.2.1
- Override functions for Color() functions.
- Updated hover elements

## Usage

``` csharp
//In order to use Rainbowify you need to make sure you use the power of rainbows! To do so make sure you have the following line in your file:
using Rainbows;

//NEW!!!
//New overide functions for all Color() functions.
string newString = Rainbowify.StoreColor("Hello world!", string colorName);
//The string "colorName" accepts color names.
//As of right now those colors inclue: red, orange, yellow, green, blue, purple, black, white, pink, gray, cyan, and dark green.

//WriteColor() and WriteLineColor() have also recieved an overide function with the same thing.

//There is now a function to store a rainbowified or colored string, Store() and StoreColor().
string newString = Rainbowify.Store("Hello world!");
//result --> A string variable that says "Hello world!" in rainbow text that you can then call later.

//StoreColor() works the same just with a specific rgb color.
string newString = Rainbowify.StoreColor("Hello world!", int, int, int);
//result --> A string variable that says "Hello world!" in any color text that you can then call later.

//For rainbow text you can use Write or WriteLine just like you would use Console.Write() or Console.WriteLine()

Rainbowify.Write("example text");
Rainbowify.WriteLine("example text");

//For solid colored text you need to know the RGB numbers of the color you want.
//The functions for solid color are very simallar.

Rainbowify.WriteColor("example text", int, int, int);
Rainbowify.WriteLineColor("example text", int, int, int);

//You can also have a line that constantly changes colors, however this line clears everything on the console so no other text will be allowed to print in the terminal/console.

Rainbowify.Rainbows("example text");

//To see how it looks in the terminal/console there's now an example function!
//This will show you specific examples of the functions.

Rainbowify.Example();

//Enjoy Rainbowify and thank you for downloading it!
```