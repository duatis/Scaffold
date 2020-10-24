using Scaffold.BusinessLogic.Contracts;


namespace Scaffold.BusinessLogic.Managers
{
    public class PirateManager : ManagerBase<IPirate>
    {
        public PirateManager(IPirateRepo _repo): base(_repo){}

        // example of overriding parent methods
        public override IPirate Get(int Id)
        {
            var tmp = base.Get(Id);
            tmp.Status = "Z";
            return tmp;
        }
    }
}