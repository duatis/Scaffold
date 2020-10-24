using Scaffold.BusinessLogic.Contracts;


namespace Scaffold.BusinessLogic.Managers
{
    public class PirateManager : ManagerBase<IPirate>
    {
        public PirateManager(IPirateRepo _repo): base(_repo){}

        public IPirate GetA(int Id)
        {
            var tmp = Get(Id);
            tmp.Status = "A";
            return tmp;
        }
    }
}