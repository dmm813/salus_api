using System.ComponentModel.DataAnnotations;

namespace Salus_2._0.Models
{
    public abstract class PessoaModel
    {
        [Key]
        public int Id { get; set; }
        public int Cod { get; set; }
        public List<ContatoModel>? ContatoModels { get; set; }
       
    }
}
