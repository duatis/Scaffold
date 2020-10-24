using System.Collections.Generic;
using Scaffold.BusinessLogic.Contracts;
using Scaffold.Data.Models;
using System.Linq;

namespace Scaffold.Data.Repos
{
    // Normal repo for pirates
    public class PirateRepo : IPirateRepo
    {
        private IEnumerable<IPirate> collection;
        public PirateRepo(IContext context)
        {
            this.collection = context.Pirates;
        }

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