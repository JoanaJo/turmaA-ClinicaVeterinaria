using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vets.Models
{   //os : é equivalente ao extends do java , o VetsDB vai herdar do DbContext
    public class VetsDB : DbContext     {
    //representa a Base de Dados
    //descrevendo as tabelas que lá estao contidas

    //representar o 'construtor' desta clase
    //identifica onde se encontra a Base de Dados

    public VetsDB() : base("VetsDBConnection") { }

    //descrever as tabelas que estao na base de dados
    public virtual DbSet<Donos > Donos { get; set; }
    public virtual DbSet<Animais> Animais { get; set; }

    }
}