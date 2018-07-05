using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorldCup.Web.Models
{
    public class ModelViewMatch
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Equipe1")]
        public string Team1 { get; set; }

        [Required]
        [DisplayName("Equipe2")]
        public string Team2 { get; set; }


        [DisplayName("Vencedor")]
        public string Winner { get; set; }


        [HiddenInput(DisplayValue=false)]
        public bool Over { get; set; }

    }
}