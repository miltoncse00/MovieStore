using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveStore.Data.Common.Interfaces
{
    public interface IUnityOfWork:IDisposable
    {
        void Commit();
        Task<int> CommitAsync();
    }
}
