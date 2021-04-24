using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace myBooks.Model
{
    public class Drzave
    {
        public int DrzavaId { get; set; }

        [Required]
        public string Naziv { get; set; }
    }
}
