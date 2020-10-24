using Scaffold.BusinessLogic.Contracts;
using Scaffold.Data.Contracts;
using Scaffold.Data.Models;
using System.Linq;

namespace Scaffold.Data.Query
{
    public class PirateQuery : IPirateQuery
    {
        protected IContext context;
        public PirateQuery(IContext context)
        {
            this.context = context;
        }

        public IPirate Get(int id)
        {
            return this.context.Pirates.FirstOrDefault( x => x.Id == id);
        }
    }
}