using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Getters_and_setters
{
    internal class Movie
    {
        public string title;
        public string director;
        private string rating; //now can only be set by getters and setters, for

        //constructor
        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating; // now only using the getters and setters values
        }
        public string Rating
        {
            get { return rating; }

            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
