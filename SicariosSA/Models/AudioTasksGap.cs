using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SicariosSA.Models
{
    public partial class AudioTasksGap
    {
        public AudioTasksGap()
        {
            AudioTasksGapsCorrectAnswers = new HashSet<AudioTasksGapsCorrectAnswer>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("taskName")]
        public string TaskName { get; set; }
        [Column("explanation")]
        public string Explanation { get; set; }
        [Column("soundtrackName")]
        public string SoundtrackName { get; set; }

        [InverseProperty(nameof(AudioTasksGapsCorrectAnswer.IdAudioTaskNavigation))]
        public virtual ICollection<AudioTasksGapsCorrectAnswer> AudioTasksGapsCorrectAnswers { get; set; }
    }
}
