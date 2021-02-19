using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SicariosSA.Models
{
    [Table("TasksABCAnswer")]
    public partial class TasksAbcanswer
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("question", TypeName = "text")]
        public string Question { get; set; }
        [Column("option1", TypeName = "text")]
        public string Option1 { get; set; }
        [Column("option2", TypeName = "text")]
        public string Option2 { get; set; }
        [Column("option3", TypeName = "text")]
        public string Option3 { get; set; }
        [Column("option1PL", TypeName = "text")]
        public string Option1Pl { get; set; }
        [Column("option2PL", TypeName = "text")]
        public string Option2Pl { get; set; }
        [Column("option3PL", TypeName = "text")]
        public string Option3Pl { get; set; }
        [Column("correctAnswer", TypeName = "text")]
        public string CorrectAnswer { get; set; }
        [Column("idTasksABC")]
        public int? IdTasksAbc { get; set; }
        [Column("explanation", TypeName = "text")]
        public string Explanation { get; set; }

        [ForeignKey(nameof(IdTasksAbc))]
        [InverseProperty(nameof(TasksAbc.TasksAbcanswers))]
        public virtual TasksAbc IdTasksAbcNavigation { get; set; }
    }
}
