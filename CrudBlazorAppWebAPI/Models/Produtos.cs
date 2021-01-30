using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudBlazorAppWebAPI.Models
{
    public class Produtos
    {		
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome do Produto é Obrigatório")]
        [Display(Name = "Nome do Produto")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O Tipo do Produto é Obrigatório")]
		[Display(Name = "Tipo do Produto")]
        public string Tipo { get; set; }
		
    }
}
