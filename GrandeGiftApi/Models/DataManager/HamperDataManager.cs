using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrandeGiftApi.Models;
using GrandeGiftApi.Repository;

namespace GrandeGiftApi.Models.DataManager
{
    public class HamperDataManager
    {
        readonly CRBGrandeGiftContext _context;

        public HamperDataManager(CRBGrandeGiftContext context)
        {
            _context = context;
        }
        public IEnumerable<Hampers> GetAll()
        {
            return _context.Hampers.ToList();
        }

        public IEnumerable<Hampers> GetByCategory(int id)
        {
            return _context.Hampers.Where(h => h.HamperCategoryId == id).ToList();
        }

        public IEnumerable<HamperCategory> GetCategories()
        {
            return _context.HamperCategory.ToList();
        }
    }
}
