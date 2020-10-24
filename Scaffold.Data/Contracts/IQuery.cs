using Scaffold.BusinessLogic.Contracts;

namespace Scaffold.Data.Contracts
{
    public interface IQuery<TModel> 
    {
        TModel Get(int id);
        
    }
}