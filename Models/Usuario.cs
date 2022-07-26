using System;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class Usuario
    {
        [Key]
        public int id{get;set;}

        public string tipoDocumento{get;set;}
        public long numeroDocumento{get;set;}
        public string nombres{get;set;}

        public string apellidos{get;set;}

        public string correo{get;set;}
    }
}