using System.Collections.Generic;
using Scaffold.BusinessLogic.Contracts;
using Scaffold.Data.Models;
using System.Linq;
using Scaffold.Data.Contracts;

namespace Scaffold.Data.Repos
{
    // Repo that turns good pirates into bad and bad pirates into worst
    public class BadPirateRepo : IPirateRepo
    {
      protected IPirateQuery query;
        protected IPirateCommand command;
        public BadPirateRepo(IPirateQuery query, IPirateCommand command)
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
            var tmp = this.query.Get(id);
            tmp.Name = $"💀 {tmp.Name}";
            return tmp;
        }
    }
}