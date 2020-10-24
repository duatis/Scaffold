 using System;

namespace  Scaffold.BusinessLogic.Contracts
{
    public interface IRepo<TModel> where TModel: IModel
    {
        
        TModel Get(int Id);
    }
}