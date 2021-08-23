using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationGit.Entities.MusicStoreEntities
{
    public class Genre
    {
        public virtual int GenreId { get; set; }
        [Required]
        [MaxLength(30)]
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual List<Album> Albums { get; set; }
        }
}