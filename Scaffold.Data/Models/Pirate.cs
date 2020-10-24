using Scaffold.BusinessLogic.Contracts;

namespace Scaffold.Data.Models
{
    public class Pirate : IPirate
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Name { get; set;}
    }
}