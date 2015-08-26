using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercice1_Projet_S_VideoStore.Models
{
    public class Repository
    {

        public List<Movie> GetAllMovies()
        {
            Movie m1 = new Movie
            {
                ID = 1,
                Title = "La Guerre",
                Genre = "Action"
            };

            Movie m2 = new Movie
            {
                ID = 2,
                Title = "Die Hard",
                Genre = "Action"
            };

            List<Movie> list = new List<Movie>();
            list.Add(m1);
            list.Add(m2);

            return list;
        }

        public string GetMovie(int id)
        {
            if (id == 1)
            {
                return "La Guerre";
            }
            if (id == 2)
            {
                return "Die Hard";
            }
            else
            {
                return "Error inexsistant";
            }
        }

        public string UpdateMovie(int id)
        {
            return "Nothing for the moment";
        }

        public void AddMovie(string titre, string genre)
        {
           
        }

        public void DeleteMovie(int id)
        {
            
        }
    }
}