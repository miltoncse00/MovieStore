using System;

namespace MovieStore.Data.EntityF.DbEntity
{
    [Serializable]
    public class Person:MovieEntity
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
    }
}