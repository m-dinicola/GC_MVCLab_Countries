using System;
using System.Collections.Generic;
using System.Text;

namespace _5._300_Countries_Lab_GC
{
    class Country
    {
        public string Name { set; get; }
        public Continent Continent { set; get; }
        public List<string> Colors { set; get; }

        public Country(string name, Continent continent, List<string> colors)
        {
            Name = name;
            Continent = continent;                          //continent is an Enum
            Colors = colors.ConvertAll(x => x.ToLower());   //stores as lower, because why not
        }
    }
}
