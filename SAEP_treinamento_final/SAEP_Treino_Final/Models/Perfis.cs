using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SAEP_Treino_Final.Models
{
    public class Perfis
    {
        [Key]
        public int Id { get; set; }
        public string Perfil { get; set; }

        public ICollection<Usuarios> Usuarios { get; set; }
        public ICollection<Comentarios> Comentarios { get; set; }
    }
}
