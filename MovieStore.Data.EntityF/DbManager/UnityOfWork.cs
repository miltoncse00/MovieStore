using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoveStore.Data.Common.Interfaces;

namespace MovieStore.Data.EntityF.DbManager
{
    public class UnityOfWork: DbContext,IUnityOfWork
    {
        private readonly DB _context;

        public UnityOfWork()
        {
            _context = new DB();

        }

        public DB Context
        {
            get { return _context; }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public Task<int> CommitAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
