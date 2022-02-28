using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public interface IAlbumRepository
    {
        IEnumerable<Album> GetAll();
        Album Get(int id);
        Album Add(Album newAlbum);
        void Delete(int id);
        Album Update(Album album);

    }
}
