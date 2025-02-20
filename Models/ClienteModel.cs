using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_2._0.Models
{
    public class ClienteModel
    {
        #region Propriedades

        [Key]
        public int Id { get; set; }
        
        public int Cod { get; set; }
        
        public string? Nome { get; set; }
        
        public DateTime DataCadastro { get; set; }
        
        public string? DocIdentidade { get; set; }
        
        public string? CPFCNPJ { get; set; }
        
        public string? CEP { get; set; }
        
        public string? Rua { get; set; }
        
        public string? Numero { get; set; }
        
        public string? Complemento { get; set; }
        
        public string? Bairro { get; set; }
        
        public int IdMunicipio { get; set; }
        
        public bool Ativo { get; set; }
        
        public bool Exclusao{ get; set;}
        #endregion
        public List<ContatoModel>? Contatos { get; set; }
    }
}
