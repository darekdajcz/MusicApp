using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicApp.Models
{
    public class Musican_Track
    {
        [Key]
        public int IdTrack { get; set; }
        [Required]
        public int IdMusican { get; set; }


        [Required]
        [ForeignKey("IdTrack")]
        public virtual Track Track { get; set; }

        [Required]
        [ForeignKey("IdMusican")]
        public virtual Musican Musican { get; set; }

    }
}
