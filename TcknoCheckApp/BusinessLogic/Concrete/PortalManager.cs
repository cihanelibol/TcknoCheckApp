using System.Collections.Generic;
using System.Linq;
using TcknoCheckApp.BusinessLogic.Abstract;
using TcknoCheckApp.DataAccess.Concrete;
using TcknoCheckApp.Models.Concrete;

namespace TcknoCheckApp.BusinessLogic.Concrete
{
    public class PortalManager : IPortalManager
    {
        private IPortalDal _portalDal;
        public PortalManager(IPortalDal portalDal)
        {
            _portalDal = portalDal;
        }

        public void Add(Portal portal)
        {
            _portalDal.Add(portal);
        }

        public void Delete(Portal portal)
        {
            _portalDal.Delete(portal);
        }

        public List<Portal> GetList()
        {
            return _portalDal.GetList().ToList();
        }

        public void Update(Portal portal)
        {
            _portalDal.Update(portal);
        }
    }
}
