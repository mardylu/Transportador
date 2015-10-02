using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Transportador.Models
{

    public class TransportadoraModels
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome não pode ser branco.")]
        public string Nome { get; set; }

        public int ClassificacaoId { get; set; }
        public IQueryable<ClassificacaoModels> Classificacao { get; set; }
    }
}
