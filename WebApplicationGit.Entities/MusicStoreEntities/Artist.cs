using System.ComponentModel.DataAnnotations;

namespace WebApplicationGit.Entities.MusicStoreEntities
{
    public class Artist
    {
        public virtual int ArtistId { get; set; }
        [Required]
        [MaxLength(30)]
        public virtual string Name { get; set; }
    }
}