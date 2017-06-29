using System;
using MoveStore.Data.Common.Interfaces;

namespace MovieStore.Data.EntityF.DbEntity
{
    [Serializable]
    public class MovieEntity : IEntity
    {
        public Guid Id { get; set; }
    }
}