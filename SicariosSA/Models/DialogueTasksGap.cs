using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SicariosSA.Models
{
    public partial class DialogueTasksGap
    {
        public DialogueTasksGap()
        {
            DialogueTasksGapsAnswerPacks = new HashSet<DialogueTasksGapsAnswerPack>();
            DialogueTasksGapsCorrectAnswers = new HashSet<DialogueTasksGapsCorrectAnswer>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("taskName")]
        public string TaskName { get; set; }
        [Column("explanation")]
        public string Explanation { get; set; }
        [Column("textToFill")]
        public string TextToFill { get; set; }

        [InverseProperty(nameof(DialogueTasksGapsAnswerPack.IdDialogueTasksGapsNavigation))]
        public virtual ICollection<DialogueTasksGapsAnswerPack> DialogueTasksGapsAnswerPacks { get; set; }
        [InverseProperty(nameof(DialogueTasksGapsCorrectAnswer.IdDialogueTasksGapsNavigation))]
        public virtual ICollection<DialogueTasksGapsCorrectAnswer> DialogueTasksGapsCorrectAnswers { get; set; }
    }
}
