using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TBBTLanches.Models
{
    [Table("Lanches")]
    public class Lanches
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' precisa ser informado")]
        [Display(Name = "Nome do Lanche")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O campo deve conter no mínimo {1} caracteres e no máximo {0}")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo 'DescricaoCurta' precisa ser informado")]
        [Display(Name = "Descrição curta")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O campo deve conter no mínimo {1} caracteres e no máximo {0}")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "O campo 'DescricaoDetalhada' precisa ser informado")]
        [Display(Name = "Descrição detalhada")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "O campo deve conter no mínimo {1} caracteres e no máximo {0}")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "O campo 'Preco' precisa ser informado")]
        [Display(Name = "Preco do lanche")]
        [Column(TypeName = "decimal(10, 2)")]
        [Range(1.0, 99.99, ErrorMessage = "O preço deve estar entre {0} e {1}")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O campo deve ter no máximo {0} caracteres")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O campo deve ter no máximo {0} caracteres")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Lanche Preferido?")]
        public bool EmDestaque { get; set; }

        [Display(Name = "Em estoque?")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categorias Categoria { get; set; }

    }
}
