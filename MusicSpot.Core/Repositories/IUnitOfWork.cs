using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSpot.Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IMusicRepository Musics { get; set; }
        IArtistRepository Artist { get; set; }
        Task<int> CommitAsync();
    }
}
