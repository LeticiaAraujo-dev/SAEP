using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAEP_Treino_Final.Models
{
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }
        public string Senha { get; set; }

        [ForeignKey("Perfis")]
        public int IdPerfil { get; set; }
        public Perfis Perfis { get; set; }
    }
}
