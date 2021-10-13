using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_List_Lab
{
    class Movie
    {
        private string Title;

        public string GetTitle()
        {
            return Title;
        }

        private string Category;
        public string GetCategory()
        {
            return Category;
        }

        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }



    }

}

