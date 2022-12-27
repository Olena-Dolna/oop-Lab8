using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelForm
{
    public class Tour
    {
        private Countries Country { get; set; }
        private int Days { get; set; }
        private int People { get; set; }
        private Seasons Season { get; set; }
        private bool PersonalGuide { get; set; }

        public Tour()
        {
            Country = Countries.Bulgaria;
            Days = 0;
            People = 0;
            Season = Seasons.Summer;
            PersonalGuide = false;
        }
        public Tour(Countries country, int days, int people, Seasons season, bool personalGuide)
        {
            Country = country;
            Days = days;
            People = people;
            Season = season;
            PersonalGuide = personalGuide;
        }
        public int GetPrice()
        {
            int priceListValue = 0, price = 0;
            switch(Season)
            {
                case Seasons.Summer:
                    switch(Country)
                    {
                        case Countries.Bulgaria:
                            priceListValue = 100;
                            break;
                        case Countries.Germany:
                            priceListValue = 160;
                            break;
                        case Countries.Poland:
                            priceListValue = 120;
                            break;
                    }
                    break;
                case Seasons.Winter:
                    switch (Country)
                    {
                        case Countries.Bulgaria:
                            priceListValue = 150;
                            break;
                        case Countries.Germany:
                            priceListValue = 200;
                            break;
                        case Countries.Poland:
                            priceListValue = 180;
                            break;
                    }
                    break;
            }
            switch(PersonalGuide)
            { 
                case true:
                    price = priceListValue * Days * People + 50 * Days;
                    break;
                case false:
                    price = priceListValue * Days * People;
                    break;
            }
            return price;
        }
    }
    public enum Countries
    {
        Bulgaria,
        Germany,
        Poland
    }
    public enum Seasons
    {
        Summer,
        Winter
    }
}
