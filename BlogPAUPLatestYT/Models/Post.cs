﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPAUPLatestYT.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public DateTime DateOfCreation { get; set; } = DateTime.Now;
        public bool Visible { get; set; }
        public int Counter { get; set; }
        public string Image { get; set; }
        public virtual IdentityUser IdentityUser { get; set; }
        public CollageDirections CeollegeDirections { get; set; }

        public enum CollageDirections 
        {
            Racunarstvo,
            Menadzment,
            Odrzivi

        }
        public string NazivKreatora { get; set; }

        public string Description { get; set; }
        public string Tags { get; set; }
        public string Category { get; set; }

        //public SmjeroviFaksa SmjeroviFaksa { get; set; }

        //public ICollection<SmjeroviFaksa> SmjeroviFaksas { get; set; }

        //public ICollection<SmjeroviFaksa> SmjeroviFaksas { get; set; }

        /* public enum SmjeroviFaksa
         {
             [Display(Name="Racunarstvo")]
             FirstValue,
             [Display(Name = "Menadzment")]
             SecondValue,
             [Display(Name = "Odrzivi Razvoj")]
             ThirdValue,

         }
        */
    }
}
