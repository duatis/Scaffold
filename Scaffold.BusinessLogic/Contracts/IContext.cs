using System.Collections.Generic;

namespace Scaffold.BusinessLogic.Contracts
{
    public interface IContext{
        IEnumerable<IPirate> Pirates{get;}
    }
}