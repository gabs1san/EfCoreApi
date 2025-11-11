using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class Contato
    {
        public int Id { get; set; }

       //[ForeignKey(“Usuario”)]
        
        public string? Telefone { get; set; }
        public string? Celular { get; set; }

        
        public int UsuarioId { get; set; }

        //[ForeignKey("UsuarioId")]
        public Usuario? Usuario { get; set; }

    }
}
