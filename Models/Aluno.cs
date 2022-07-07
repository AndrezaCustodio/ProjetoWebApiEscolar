using System.Text.Json.Serialization;

namespace escola.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public int? totalFaltas { get; set; }
        public int turmaid_Id { get; set; }

        [JsonIgnore]
        #region Navigation Properties
        public virtual Turma? Turma { get; set; }
        #endregion
    }
}
