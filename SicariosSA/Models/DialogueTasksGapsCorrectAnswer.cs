using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SicariosSA.Models
{
    [Table("DialogueTasksGapsCorrectAnswer")]
    public partial class DialogueTasksGapsCorrectAnswer
    {
        public DialogueTasksGapsCorrectAnswer()
        {
            DialogueTasksGapsAnswerPacks = new HashSet<DialogueTasksGapsAnswerPack>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("idDialogueTasksGapsAnswerPack")]
        public int? IdDialogueTasksGapsAnswerPack { get; set; }
        [Column("correctAnswer")]
        public string CorrectAnswer { get; set; }
        [Column("idDialogueTasksGaps")]
        public int? IdDialogueTasksGaps { get; set; }
        [Column("correctAnswerPl")]
        public string CorrectAnswerPl { get; set; }

        [ForeignKey(nameof(IdDialogueTasksGaps))]
        [InverseProperty(nameof(DialogueTasksGap.DialogueTasksGapsCorrectAnswers))]
        public virtual DialogueTasksGap IdDialogueTasksGapsNavigation { get; set; }
        [InverseProperty(nameof(DialogueTasksGapsAnswerPack.IdDialogueTasksGaps1))]
        public virtual ICollection<DialogueTasksGapsAnswerPack> DialogueTasksGapsAnswerPacks { get; set; }
    }
}
