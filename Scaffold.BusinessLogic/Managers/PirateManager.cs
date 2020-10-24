using Scaffold.BusinessLogic.Contracts;


namespace Scaffold.BusinessLogic.Managers
{
    public class PirateManager : ManagerBase<IPirate>
    {
        public PirateManager(IRepo<IPirate> _repo)
        {
            repo = _repo;
        }

        public IPirate GetA(int Id)
        {
            var tmp = Get(Id);
            tmp.Status = "A";
            return tmp;
        }
    }
}