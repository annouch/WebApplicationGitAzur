//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace WebApplicationGitAzur.Models
//{
//    public class MusicStoreDbInitializer : System.Data.Entity.DropCreateDatabaseAlways<WebApplicationGitAzurDB>
//    {
//        protected override void Seed(WebApplicationGitAzurDB context)
//        {
//            context.Artists.Add(new Artist { Name = "Artiste1" });
//            context.Genres.Add(new Genre { Name = "Rock" });
//            context.Albums.Add(new Album
//            {
//                Artist = new Artist { Name = "Artiste2" },
//                Genre = new Genre { Name = "Jazz" },
//                Price = 9.10m,
//                Title = "ALbum1"
//            });


//            base.Seed(context);
//        }
//    }
//}