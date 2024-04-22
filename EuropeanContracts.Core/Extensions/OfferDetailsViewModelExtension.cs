using EuropeanContracts.Core.Contracts;
using System.Text.RegularExpressions;

namespace EuropeanContracts.Core.Extensions
{
    public static class OfferDetailsViewModelExtension
    {
        public static string GetSearchingInfo(this IOfferModel model)
        {
            string result;

            if (model.ActionType != null)
            {
                result = $"{ReturnProductName(model.ProductName)}-from-{model.LoadingCountry}-{ReturnLoadingAddress(model.LoadingAddress)}-for-{model.ActionType}";
            }
            else
            {
                result = $"{model.ProductName}-from-{model.LoadingCountry}-{ReturnLoadingAddress(model.LoadingAddress)}";
            }

            return result;
        }

        private static string ReturnLoadingAddress(string address)
        {
            address = string.Join("-", address.Split(" ").Take(1));
            address = Regex.Replace(address, @"[^a-zA-Z0-9\-]", string.Empty);

            return address;
        }

        private static string ReturnProductName(string productName)
        {
            productName = productName.Replace(" ","-");

            return productName;
        }
    }
}
