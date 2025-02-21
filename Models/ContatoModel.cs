using System.ComponentModel.DataAnnotations;

namespace Salus_2._0.Models
{
    public class ContatoModel
    {
        [Key]
        public int Id { get; set; }
        public int Tipo {  get; set; }
        public PessoaModel? Cliente { get; set; }
        public string? Contato {  get; set; }   
    }
}
