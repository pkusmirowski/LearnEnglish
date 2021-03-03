using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SicariosSA.Models
{
    [Table("DialogueTasksGapsAnswerPack")]
    public partial class DialogueTasksGapsAnswerPack
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("idDialogueTasksGaps")]
        public int? IdDialogueTasksGaps { get; set; }
        [Column("answerNumber")]
        public string AnswerNumber { get; set; }

        [ForeignKey(nameof(IdDialogueTasksGaps))]
        [InverseProperty(nameof(DialogueTasksGapsCorrectAnswer.DialogueTasksGapsAnswerPacks))]
        public virtual DialogueTasksGapsCorrectAnswer IdDialogueTasksGaps1 { get; set; }
        [ForeignKey(nameof(IdDialogueTasksGaps))]
        [InverseProperty(nameof(DialogueTasksGap.DialogueTasksGapsAnswerPacks))]
        public virtual DialogueTasksGap IdDialogueTasksGapsNavigation { get; set; }
    }
}
