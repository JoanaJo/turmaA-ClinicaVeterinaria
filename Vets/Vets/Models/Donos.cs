using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vets.Models
{
    public class Donos
    {
        public Donos() {
            //construtor da Classe, que vai ser utilizado 
            //para inicializar o atributo 'ListaDeAnimais'

            ListaDeAnimais = new HashSet<Animais>();


        }

        //tudo o que seja publico nomes , atributos sao publicos logo tem de ser em maiuscula
        //caso seja privado sera minuscula

        public int DonosID { get; set; }

        public string Nome { get; set; }

        public string NIF { get; set; }

       //relaccionar os 'Donos' com os Animais
       //1 Dono tem Muitos Animais

        public virtual ICollection<Animais> ListaDeAnimais { get; set; }


    }
}