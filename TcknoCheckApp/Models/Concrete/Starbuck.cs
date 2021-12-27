using System.ComponentModel.DataAnnotations;
using TcknoCheckApp.Models.Abstract;

namespace TcknoCheckApp.Models.Concrete
{
    public class Starbuck : IEntity
    {
        public int Id { get; set; }
        public long Tckno { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
    }
}
