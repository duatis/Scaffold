namespace Scaffold.BusinessLogic.Contracts
{
    public abstract class ManagerBase<TModel> : IManager<TModel> where TModel: IModel
    {
        public IRepo<TModel> repo { get; set; }

        public TModel Get(int Id)
        {
            return repo.Get(Id);
        }       
    }
}