using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Data.Common.Interfaces
{
    public interface IUnityOfWork
    {
         void Commit();
    }
}
