using System;
using System.Collections.Generic;

namespace _5._300_Countries_Lab_GC
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryController countryController = new CountryController  //start the controller and pass it a list of countries
                (
                new List<Country>
                {
                    new Country("United States of America", Continent.North_America, new List<string>{"Red","White","Blue"}),
                    new Country("Japan", Continent.Asia, new List<string>{"White","Red"}),
                    new Country("Belgium", Continent.Europe, new List<string>{"Black","Yellow","Red"}),
                    new Country("Equatorial Guinea", Continent.Africa, new List<string>{"White","Green","Red","Blue"}),
                    new Country("Ethiopia", Continent.Africa, new List<string>{"Yellow","Green","Blue","Red"}),
                    new Country("Azerbaijan", Continent.Europe, new List<string>{"Blue","Red","Green","White"}),
                    new Country("Peru", Continent.South_America, new List<string>{"White","Red" }),
                    new Country("Tasmania", Continent.Australia, new List<string>{"Blue","White","Red"}),
                    new Country("Papua New Guinea", Continent.Australia, new List<string>{"Black","Red","White","Yellow"}),
                    new Country("Australia", Continent.Australia, new List<string>{"Blue","White","Red"}),
                    new Country("Mexico", Continent.North_America, new List<string>{"White","Green","Red"}),
                    new Country("Canada", Continent.North_America, new List<string>{"Red","White"}),
                    new Country("Jamaica", Continent.North_America, new List<string>{"Green","Black","Yellow","Black"}),
                    new Country("Antarctic Treaty", Continent.Antarctica, new List<string>{"Blue","White"})
                }
            );
            countryController.WelcomeAction();      //let the controller do its thing.
        }
    }
}
