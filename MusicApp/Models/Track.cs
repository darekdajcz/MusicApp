using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicApp.Models
{
    public class Track
    {
        [Key]
        public int IdTrack { get; set; }
        [Required]
        [MaxLength(20)]
        public string TrackName { get; set; }
        [Required]
        [MaxLength(50)]
        public float Duration { get; set; }
        [MaxLength(20)]

        public virtual ICollection<Musican_Track> Musican_Track { get; set; }

        [ForeignKey("IdAlbum")]
        public virtual Album Album { get; set; }
    }
}
