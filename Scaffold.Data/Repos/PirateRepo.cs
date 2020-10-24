using System.Collections.Generic;
using Scaffold.BusinessLogic.Contracts;
using Scaffold.Data.Models;
using System.Linq;
using Scaffold.Data.Contracts;

namespace Scaffold.Data.Repos
{
    // Normal repo for pirates
    public class PirateRepo : IPirateRepo
    {
        protected IPirateQuery query;
        protected IPirateCommand command;
        public PirateRepo(IPirateQuery query, IPirateCommand command)
        {
            this.query = query;
            this.command = command;
        }

        public string GetName(int Id)
        {
            return this.Get(Id)?.Name;
        }

        public IPirate Save(Pirate entity)
        {
            return command.Save(entity);
        }

        public IPirate Get(int id)
        {
            return this.query.Get(id);
        }
    }
}