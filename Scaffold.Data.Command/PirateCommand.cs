using System;
using Scaffold.Data.Contracts;
using Scaffold.Data.Models;
using System.Linq;
using Scaffold.BusinessLogic.Contracts;

namespace Scaffold.Data.Command
{
    public class PirateCommand : IPirateCommand
    {

         protected IContext context;
        public PirateCommand(IContext context)
        { 
            this.context = context;
        }

        public IPirate Save(IPirate entity)
        {
            this.context.Pirates.ToList().Add(entity);
            return entity;
        }        

        public IPirate Update(int id, IPirate entity)
        {
            var tmp = this.context.Pirates.FirstOrDefault( x => x.Id == id);
            tmp = entity;
            return tmp; 
        }

       
    }
}
