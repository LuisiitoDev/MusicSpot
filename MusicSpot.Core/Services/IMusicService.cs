using MusicSpot.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSpot.Core.Services
{
    public interface IMusicService
    {
        Task<IEnumerable<Music>> GetAllWithArtist();
        Task<Music> GetMusicById();
        Task<IEnumerable<Music>> GetMusicByArtistId(int artistId);
        Task<Music> CreateMusic(Music music);
        Task UpdateMusic(Music musicToBeUpdated, Music music);
        Task DeleteMusic(Music music);
    }
}
