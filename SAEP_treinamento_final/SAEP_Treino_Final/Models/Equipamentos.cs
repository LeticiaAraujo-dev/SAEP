using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SAEP_Treino_Final.Models
{
    public class Equipamentos
    {
        [Key]
        public int Id { get; set; }
        public string Equipamento { get; set; }
        public string Imagem { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public DateTime Data { get; set; }

        public ICollection<Comentarios> Comentarios { get; set; }

    }
}
