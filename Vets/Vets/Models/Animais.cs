using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vets.Models
{
    public class Animais
    {

        public int AnimaisID { get; set; }

        public string NomeDoAnimal { get; set; }

        public string Especie { get; set; }

        public string Raca { get; set; }

        //criar uma chave forasteira - FK 
        [ForeignKey("Dono")]
        public int DonoFK { get; set; } //existe para criar uma FK na BD
        public Donos Dono { get; set; } //existe para relaccionar os objectos no C#
       

    }
}