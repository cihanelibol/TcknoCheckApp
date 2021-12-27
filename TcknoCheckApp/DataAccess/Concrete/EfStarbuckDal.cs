using TcknoCheckApp.DataAccess.Abstract;
using TcknoCheckApp.DataAccess.EFramework;
using TcknoCheckApp.DataAccess.EFramework.Contexts;
using TcknoCheckApp.Models.Concrete;

namespace TcknoCheckApp.DataAccess.Concrete
{
    public class EfStarbuckDal:EfBase<Starbuck,PortalContext>,IStarbuckDal
    {
    }
}
