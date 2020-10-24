using System.Collections.Generic;
using Scaffold.BusinessLogic.Contracts;
using Scaffold.Data.Models;

namespace Scaffold.Data
{
    // Context with bad pirates
    public class BadContext : IContext
    {
        public IEnumerable<IPirate> Pirates => new List<IPirate>()
        {
            new Pirate(){ Id = 0, Name = "Buggy", Status = "A" },
            new Pirate(){ Id = 1, Name = "Black Beard", Status = "A" },
            new Pirate(){ Id = 2, Name = "Moria", Status = "A" }
        };

    }
}