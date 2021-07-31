using MusicSpot.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSpot.Core.Repositories
{
    public interface IMusicRepository : IRepository<Music>
    {
        Task<IEnumerable<Music>> GetAllWithArtistAsync();
        Task<Music> GetWithArtistByIdAsync(int id);
        Task<IEnumerable<Music>> GetAllWithArtistByArtistId(int artistId);
    }
}
