using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_2._0.Models
{
    public class PessoaModel
    {
        [Key]
        public int Id { get; set; }
        public int Cod { get; set; }
        public List<ContatoModel>? ContatoModels { get; set; }
       
    }
}
