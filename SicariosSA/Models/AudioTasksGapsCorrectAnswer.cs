using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SicariosSA.Models
{
    [Table("AudioTasksGapsCorrectAnswer")]
    public partial class AudioTasksGapsCorrectAnswer
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("answer1")]
        public string Answer1 { get; set; }
        [Column("answer2")]
        public string Answer2 { get; set; }
        [Column("answer3")]
        public string Answer3 { get; set; }
        [Column("answer4")]
        public string Answer4 { get; set; }
        [Column("answer1PL")]
        public string Answer1Pl { get; set; }
        [Column("answer2PL")]
        public string Answer2Pl { get; set; }
        [Column("answer3PL")]
        public string Answer3Pl { get; set; }
        [Column("answer4PL")]
        public string Answer4Pl { get; set; }
        [Column("idAudioTask")]
        public int? IdAudioTask { get; set; }

        [ForeignKey(nameof(IdAudioTask))]
        [InverseProperty(nameof(AudioTasksGap.AudioTasksGapsCorrectAnswers))]
        public virtual AudioTasksGap IdAudioTaskNavigation { get; set; }
    }
}
