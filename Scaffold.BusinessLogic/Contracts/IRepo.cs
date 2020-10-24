 using System;

namespace  Scaffold.BusinessLogic.Contracts
{
    public interface IRepo<TModel> 
    {
        
        TModel Get(int Id);
    }
}