using System.Collections.Generic;
using System.Threading.Tasks;
using TcknoCheckApp.Models.Concrete;

namespace TcknoCheckApp.BusinessLogic.Abstract
{
    public interface IStarbuckManager
    {
        List<Starbuck> GetList();
        Task<bool> Add(Starbuck starbuck);
        void Delete(Starbuck starbuck);
        void Update(Starbuck starbuck);
    }
}

