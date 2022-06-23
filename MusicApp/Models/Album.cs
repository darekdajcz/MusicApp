using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicApp.Models
{
    public class Album
    {
        [Key]
        public int IdAlbum { get; set; }
        [Required]
        [MaxLength(30)]
        public string AlbumName { get; set; }
        [Required]
        public DateTime PublishDate { get; set; }

        public virtual ICollection<Track> Track { get; set; }

        [ForeignKey("IdMusicLabel")]
        public virtual MusicLabel MusicLabel { get; set; }
    }
}
