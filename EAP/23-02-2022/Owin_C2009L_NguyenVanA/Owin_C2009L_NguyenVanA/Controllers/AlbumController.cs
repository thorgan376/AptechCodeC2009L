using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Web.Http;
using Owin_C2009L_NguyenVanA.Models;

namespace Owin_C2009L_NguyenVanA.Controllers
{
    public class AlbumController: ApiController
    {
        //api, server
        private List<Album> list = new List<Album> {
            new Album {
                Id = 1,
                Title = "Come Away With Me", 
                Genre = "Jazz", 
                Price = 12.9
            },
            new Album {
                Id = 2,
                Title = "The BluePrint", 
                Genre = "Hip Hop", 
                Price = 15.5
            },
            new Album {
                Id = 3,
                Title = "Unconditional", 
                Genre = "Hard Rock", 
                Price = 10.9
            }
        };
        [HttpGet]
        public IHttpActionResult Get() {
            return Ok(list);
        }
        [HttpGet]
        public Album Get(int id) {
            return list.Where(album => album.Id == id).FirstOrDefault();
        }
        [HttpPost]
        public void Post(Album item) { 
            list.Add(item);
        }
        [HttpPut]
        public void Put(int id, Album item) {
            //how to read this request?
            Album foundAlbum = this.Get(id);
            if (foundAlbum != null) { 
                foundAlbum.Title = item.Title != null ? item.Title : foundAlbum.Title;
                foundAlbum.Genre = item.Genre != null ? item.Genre : foundAlbum.Genre;
                foundAlbum.Price = item.Price > 0 ? item.Price : foundAlbum.Price;
            }
        }
        [HttpDelete]
        public void Delete(int id) {
            Album foundAlbum = this.Get(id);
            if (foundAlbum != null)
            {
                list.Remove(foundAlbum);
            }
            
        }
    }
}
