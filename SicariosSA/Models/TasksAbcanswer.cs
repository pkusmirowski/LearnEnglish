using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SicariosSA.Models
{
    [Table("TasksABCAnswer")]
    public partial class TasksAbcanswer
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("question")]
        public string Question { get; set; }
        [Column("option1")]
        public string Option1 { get; set; }
        [Column("option2")]
        public string Option2 { get; set; }
        [Column("option3")]
        public string Option3 { get; set; }
        [Column("option1PL")]
        public string Option1Pl { get; set; }
        [Column("option2PL")]
        public string Option2Pl { get; set; }
        [Column("option3PL")]
        public string Option3Pl { get; set; }
        [Column("correctAnswer")]
        public string CorrectAnswer { get; set; }
        [Column("idTasksABC")]
        public int? IdTasksAbc { get; set; }
        [Column("explanation")]
        public string Explanation { get; set; }

        [ForeignKey(nameof(IdTasksAbc))]
        [InverseProperty(nameof(TasksAbc.TasksAbcanswers))]
        public virtual TasksAbc IdTasksAbcNavigation { get; set; }
    }
}
