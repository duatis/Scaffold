namespace Scaffold.BusinessLogic.Contracts
{
    public interface IPirateRepo:IRepo<IPirate>
    {
        string GetName(int Id);
    }
}