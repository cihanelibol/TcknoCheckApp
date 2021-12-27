using TcknoCheckApp.Models.Abstract;

namespace TcknoCheckApp.Models.Concrete
{
    public class Portal : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }

    }
}
