namespace Scaffold.BusinessLogic.Contracts
{
    public abstract class ManagerBase<TModel> : IManager<TModel> where TModel: IModel
    {
        protected IRepo<TModel> repo { get; set; }

        public ManagerBase(IRepo<TModel> _repo)
        {
            repo = _repo;
        }

        public virtual TModel Get(int Id)
        {
            return repo.Get(Id);
        }       
    }
}