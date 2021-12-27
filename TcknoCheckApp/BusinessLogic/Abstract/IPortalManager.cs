using System.Collections.Generic;
using TcknoCheckApp.Models.Concrete;

namespace TcknoCheckApp.BusinessLogic.Abstract
{
    public interface IPortalManager
    {
        List<Portal> GetList();
        void Add(Portal portal);
        void Delete(Portal portal);
        void Update(Portal portal);
    }
}
