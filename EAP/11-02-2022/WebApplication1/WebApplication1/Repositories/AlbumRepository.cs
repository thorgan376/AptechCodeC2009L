using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class AlbumRepository : IAlbumRepository
    {
        private List<Album> albums = new List<Album>();
        public AlbumRepository() { 
            //initial, fake data
            albums.Add(new Album() { 
                Id = 1, 
                Name="Album AA", 
                Genre="genre1",
                Price = 111,
            });
            albums.Add(new Album()
            {
                Id = 2,
                Name = "Album BB",
                Genre = "genre1",
                Price = 333,
            });
            albums.Add(new Album()
            {
                Id = 3,
                Name = "Album CC",
                Genre = "genre2",
                Price = 222,
            });
        }
        public IEnumerable<Album> GetAll() => albums;
        public Album Add(Album newAlbum)
        {
            if (newAlbum == null) {
                throw new ArgumentNullException("new album cannot be null");
            }
            newAlbum.Id = (int)((DateTimeOffset)DateTime.UtcNow).ToUnixTimeSeconds();
            return newAlbum;

        }

        public void Delete(int id)
        {
            albums.RemoveAll(album => album.Id == id);
        }

        public Album Get(int id) => albums.FirstOrDefault();       
        
        public Album Update(Album album)
        {
            throw new NotImplementedException();
        }
    }
}