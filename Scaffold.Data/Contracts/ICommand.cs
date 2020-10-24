using Scaffold.BusinessLogic.Contracts;

namespace Scaffold.Data.Contracts
{
    public interface ICommand<TModel>
    {
        TModel Save(TModel entity);
        TModel Update(int id, TModel entity);
    }
}