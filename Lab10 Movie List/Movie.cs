using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_Movie_List
{
    class Movie
    {

        //fields
        private string title;
        private string category;

        //Parameters
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        //constructors
        public Movie()
        {

        }

        public Movie(string _title, string _category)
        {
            title = _title;
            category = _category;
        }

        public void Choice()
        {
            Console.WriteLine(title);
           
        }
    }
}



