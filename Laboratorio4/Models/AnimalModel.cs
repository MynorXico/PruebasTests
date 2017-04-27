using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Laboratorio4.Models
{
    public class AnimalModel
    {
        public AnimalModel(int id, string nombre, int ojos, int patas, string apodo, string cubierta)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Ojos = ojos;
            this.Patas = patas;
            this.Apodo = apodo;
            this.Cubierta = cubierta;
        }


        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }
        
        [Required]
        public int Ojos { get; set; }

        [Required]
        public int Patas { get; set; }

        [Required]
        public string Apodo { get; set; }

        [Required]
        public string Cubierta { get; set; }

    }
}