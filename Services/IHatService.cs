using HatsApi.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HatsApi.Services
{
    public interface IHatService
    {
        public List<Hat> GetHats();

        public bool AddHat(Hat H);

        public bool DeleteHat(Hat H);

        public bool UpdateHat(Hat H);
    }
}
