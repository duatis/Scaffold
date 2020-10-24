using System.Collections.Generic;
using Scaffold.BusinessLogic.Contracts;
using Scaffold.Data.Models;

namespace Scaffold.Data
{
    public class Context : IContext
    {
        public IEnumerable<IPirate> Pirates => new List<IPirate>()
        {
            new Pirate(){ Id = 0, Name = "Luffy", Status = "A" },
            new Pirate(){ Id = 1, Name = "Zoro", Status = "A" },
            new Pirate(){ Id = 2, Name = "Nami", Status = "A" },
            new Pirate(){ Id = 3, Name = "Usoop", Status = "A" }

        };

    }
}