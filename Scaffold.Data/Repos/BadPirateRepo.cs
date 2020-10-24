using System.Collections.Generic;
using Scaffold.BusinessLogic.Contracts;
using Scaffold.Data.Models;
using System.Linq;

namespace Scaffold.Data.Repos
{
    public class BadPirateRepo : IPirateRepo
    {
        private List<IPirate> collection = new List<IPirate>()
        {
            new Pirate(){ Id = 0, Name = "Buggy", Status = "A" },
            new Pirate(){ Id = 1, Name = "Black Beard", Status = "A" },
            new Pirate(){ Id = 2, Name = "Moria", Status = "A" }
        };
        public string GetName(int Id)
        {
            return this.Get(Id)?.Name;
        }

        public IPirate Get(int Id)
        {
            return this.collection.FirstOrDefault( x => x.Id == Id );
        }
    }
}