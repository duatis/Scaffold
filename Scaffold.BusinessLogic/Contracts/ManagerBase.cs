namespace Scaffold.BusinessLogic.Contracts
{
    public abstract class ManagerBase<TModel> : IManager<TModel> where TModel: IModel
    {

        public ManagerBase(IRepo<TModel> _repo)
        {
            repo = _repo;
        }


        public IRepo<TModel> repo { get; set; }

        public TModel Get(int Id)
        {
            return repo.Get(Id);
        }       
    }
}