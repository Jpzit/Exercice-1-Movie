using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Exercice1_Projet_S_VideoStore.Models
{
    public class Movie
    {
        
        public int ID { get; set; }

        [Required(ErrorMessage = "Le titre est obligatoire")]
        [Display(Name = "Entrez un titre")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Le Genre est obligatoire")]
        [Display(Name = "Entrez un genre")]
        public string Genre { get; set; }
    }
}