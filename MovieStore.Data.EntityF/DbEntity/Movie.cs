using System;
using System.Collections.Generic;

namespace MovieStore.Data.EntityF.DbEntity
{
    [Serializable]
   public class Movie:MovieEntity
    {
        public string Name { get; set; }
        public decimal Rating { get; set; }
        public  int Genre { get; set; }
        public Producer Producer { get; set; }
        public List<Director> Directors { get; set; }
    }
}
