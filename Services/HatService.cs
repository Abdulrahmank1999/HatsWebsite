using HatsApi.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HatsApi.Services
{
    public class HatService:IHatService
    {
        private readonly HatDbContext _db;

        public HatService(HatDbContext db)
        {
            _db = db;
        }

        public List<Hat> GetHats()
        {
            return _db.Hats.ToList();
        }

        public bool AddHat(Hat H)
        {
           Hat M = _db.Hats.Find(H.HatId);

            if (M == null)
            {
                _db.Hats.Add(H);
                _db.SaveChanges();

                return true;
            }

            else
            {
                return false;
            }
        }

        
        public bool DeleteHat(Hat H)
        {
            Hat M = _db.Hats.Find(H.HatId);
            if (M != null)
            {
                _db.Hats.Remove(M);
                _db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool UpdateHat(Hat H)
        {
                _db.Hats.Update(H);
                _db.SaveChanges();
                return true;
            
        }


    }
}
