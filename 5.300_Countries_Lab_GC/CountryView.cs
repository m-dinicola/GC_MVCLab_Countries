using System;
using System.Collections.Generic;
using System.Text;

namespace _5._300_Countries_Lab_GC
{
    class CountryView
    {
        public Country DisplayCountry;

        public CountryView(Country displayCountry)
        {
            DisplayCountry = displayCountry;
        }

        public void Display()
        {
            string outputString = $"{DisplayCountry.Name} is in {DisplayCountry.Continent.ToString().Replace('_',' ')} and has"; //removes the underscore in continent Enum.
            foreach(string color in DisplayCountry.Colors)      //include the colors in the output string.
            {
                outputString += $" {color},";
            }

            outputString = outputString.Remove(outputString.Length - 1);        //remove the last comma
            int colorCount = DisplayCountry.Colors.Count;                       //count the colors, for dealing with plurals and edge cases.
            if (colorCount == 1)
            {
                outputString += "as its color. ";
            }
            else
            {
                outputString = outputString.Insert(outputString.LastIndexOf(','), " and") + " as its colors. "; //Lists with multiple should have an and
                outputString = outputString.Remove(outputString.LastIndexOf(','), 1);                           //and no comma before the last list item.
            }
            //dealing with colors
            List<ConsoleColor> colorSet = new List<ConsoleColor>();     //declare a list of colors from which we will set the console
            foreach(string color in DisplayCountry.Colors){             //cycle through country colors
                try
                {
                    colorSet.Add(Enum.Parse<ConsoleColor>(color, true));    //will add the consoleColor to the set if it can be found.
                }
                catch(Exception)
                {
                    Console.WriteLine("Pbtbtbtbt.");                        //if not, the exception will be caught and color will not be added.
                }
            }
            colorCount = colorSet.Count;        //recompute color count based on number of console compatible colors
            switch(colorCount)
            {
                case 0:
                    Console.ResetColor();  //if there is no compatible color we won't set the console color
                    Console.Write(outputString);
                    break;
                case 1:
                    Console.BackgroundColor = 0;  //if there is one color, we won't set the bg color
                    Console.ForegroundColor = colorSet[0];
                    Console.Write(outputString);
                    break;
                default:
                    int counter = 0;            //counter tracks our position in the string.
                    foreach (char c in outputString)
                    {
                        Console.BackgroundColor = colorSet[0];
                        Console.ForegroundColor = colorSet[(int)((colorCount - 1.0) * counter / outputString.Length) + 1];
                        Console.Write(c);       //foreground color set above based on fraction of string that has been printed so far.
                        counter++;
                    }
                    break;
            }
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
