using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrustedRide.Services.Implementations;
using TrustedRide.Services.Interfaces;

namespace TrustedRide.ViewModels
{
    public class DealerCartVM
    {
        public IDealerCart DealerCart { get; set; }
        public decimal CartTotal { get; set; }
    }
}
