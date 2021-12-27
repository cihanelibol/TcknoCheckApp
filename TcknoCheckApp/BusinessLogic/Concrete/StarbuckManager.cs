using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TcknoCheckApp.BusinessLogic.Abstract;
using TcknoCheckApp.BusinessLogic.DataControl;
using TcknoCheckApp.DataAccess.Abstract;
using TcknoCheckApp.DataAccess.Concrete;
using TcknoCheckApp.Models.Concrete;

namespace TcknoCheckApp.BusinessLogic.Concrete
{
    public class StarbuckManager : IStarbuckManager
    {
        private IStarbuckDal _starbuckDal;
        public StarbuckManager(IStarbuckDal starbuckDal )
        {
            _starbuckDal = starbuckDal;
        }

        public async Task<bool> Add(Starbuck starbuck)
        {
            
            var control = await TcknoControl.TcknoChecked(starbuck);
            if (control)
            {
                _starbuckDal.Add(starbuck);
            }
            return control;
            
        }

        public void Delete(Starbuck starbuck)
        {
            _starbuckDal.Delete(starbuck);    
        }

        public List<Starbuck> GetList()
        {
           return  _starbuckDal.GetList().ToList();
        }

        public void Update(Starbuck starbuck)
        {
            _starbuckDal.Update(starbuck);
        }
    }
}
