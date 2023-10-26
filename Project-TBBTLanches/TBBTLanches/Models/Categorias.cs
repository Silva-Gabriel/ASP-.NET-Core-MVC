using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TBBTLanches.Models
{
    [Table("Categorias")]
    public class Categorias
    {
        [Key]
        public int CategoriaId { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho máximo é de {0} caracteres")]
        [Required(ErrorMessage = "Informe o nome da categoria")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho máximo é de {0} caracteres")]
        [Required(ErrorMessage = "Informe a descrição")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public List<Lanches> Lanches { get; set; }
    }
}
