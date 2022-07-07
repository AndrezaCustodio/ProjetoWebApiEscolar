using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace escola.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public bool? ativo { get; set; }

        [JsonIgnore]
        #region Navigation Properties
        public virtual List<Aluno>? Aluno { get; set; }
        #endregion
    }
}
