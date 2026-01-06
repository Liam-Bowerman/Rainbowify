## This is a program that makes text into a rainbow or any solid color

This package is only usable in c#.

Text that has been "Rainbowified" cannot become string variables as the functions return nulls and only print the colored text.

If there are issues with compatability or if the code isn't working please email ak3m1.h3art@gmail.com.

## Usage

``` csharp
//In order to use Rainbowify you need to make sure you use the power of rainbows! To do so make sure you have the following line in your file:
using Rainbows;

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