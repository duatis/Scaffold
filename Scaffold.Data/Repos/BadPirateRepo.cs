using System.Collections.Generic;
using Scaffold.BusinessLogic.Contracts;
using Scaffold.Data.Models;
using System.Linq;

namespace Scaffold.Data.Repos
{
    // Repo that turns good pirates into bad and bad pirates into worst
    public class BadPirateRepo : IPirateRepo
    {
        private IEnumerable<IPirate> collection;

        public BadPirateRepo(IContext context)
        {
            collection = context.Pirates;
        }
        public string GetName(int Id)
        {
            return this.Get(Id)?.Name;
        }

        public IPirate Get(int Id)
        {
            var tmp = this.collection.FirstOrDefault( x => x.Id == Id );
            tmp.Name = $"💀 {tmp.Name}";
            return tmp;
        }
    }
}