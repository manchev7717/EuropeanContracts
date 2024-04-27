using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuropeanContracts.Core.ServiceViewModels.Offer
{
    public class LawyerAllViewModel
    {
        public const int OffersCountOnPage = 3;

        public int CurrentPage { get; init; } = 1;

        public int TotalOffersCount { get; set; }

        public IEnumerable<OfferDetailViewModel> Offers { get; set; } = new List<OfferDetailViewModel>();
    }
}
