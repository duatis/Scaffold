 using System;

namespace Scaffold.BusinessLogic.Contracts
{
    public interface IManager<TModel> where TModel: IModel
    {
        IRepo<TModel> repo { get; set; }
        TModel Get(int Id);  
    }
}