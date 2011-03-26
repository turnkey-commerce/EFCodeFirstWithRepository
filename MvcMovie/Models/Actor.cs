using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models {
    public class Actor {
        public int ID { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

    }
}