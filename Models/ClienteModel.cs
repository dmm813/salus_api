using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_2._0.Models
{
    [Table("Cliente")]
    public class ClienteModel:PessoaModel
    {
        #region Propriedades

                
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
        
    }
}
