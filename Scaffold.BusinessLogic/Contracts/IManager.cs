 using System;

namespace Scaffold.BusinessLogic.Contracts
{
    public interface IManager<TModel> where TModel: IModel
    {
        TModel Get(int Id);  
    }
}