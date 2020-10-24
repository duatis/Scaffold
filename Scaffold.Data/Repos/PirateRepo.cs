using System.Collections.Generic;
using Scaffold.BusinessLogic.Contracts;
using Scaffold.Data.Models;
using System.Linq;

namespace Scaffold.Data.Repos
{
    public class PirateRepo : IPirateRepo
    {
        private List<IPirate> collection = new List<IPirate>()
        {
            new Pirate(){ Id = 0, Name = "Luffy", Status = "A" },
            new Pirate(){ Id = 1, Name = "Zoro", Status = "A" },
            new Pirate(){ Id = 2, Name = "Nami", Status = "A" },
            new Pirate(){ Id = 3, Name = "Usoop", Status = "A" },

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