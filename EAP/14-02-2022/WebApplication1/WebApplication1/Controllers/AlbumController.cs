using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    public class AlbumController : ApiController
    {
        static readonly IAlbumRepository albumRepository = new AlbumRepository();
        
        [HttpGet]//using Web Browser
        public IHttpActionResult Get()
        {
            return Ok(albumRepository.GetAll());
        }
        [HttpGet]//using Web Browser
        public Album Get(int id)
        {
            Album album = albumRepository.Get(id);
            if (album == null) {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return album;
        }
        public IEnumerable<Album> getAlbumsByGenre(string genre) =>
            albumRepository.GetAll().Where(album =>
                album.Genre.ToLower().Trim().Equals(genre.ToLower().Trim()));
        //LINQ = Language Integrated Query

    }
}