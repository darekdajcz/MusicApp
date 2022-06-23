using System.ComponentModel.DataAnnotations;

namespace MusicApp.Models
{
    public class Musican
    {
        [Key]
        public int IdMusican { get; set; }
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(20)]
        public string Nickname { get; set; }

        public virtual ICollection<Musican_Track> Musican_Track { get; set; }

    }
}
