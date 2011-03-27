﻿using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MvcMovie.Models {
    public class Movie {
        public int ID { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Genre must be specified")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Price Required")]
        [Range(1, 100, ErrorMessage = "Price must be between $1 and $100")]
        public decimal Price { get; set; }

        [StringLength(5)]
        public string Rating { get; set; }

        public virtual ICollection<Actor> Actors { get; set; }

        public override int GetHashCode() {
            return ID;
        }

        public override bool Equals(object obj) {
            return ID == (obj as Movie).ID;
        }
    }
}