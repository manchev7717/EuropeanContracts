﻿using EuropeanContracts.Core.Contracts;
using System.ComponentModel.DataAnnotations;

namespace EuropeanContracts.Core.ServiceViewModels.Offer
{
    public class OfferDetailViewModel : IOfferModel
    {
        public int Id { get; set; }

        [Display(Name = "Product name")]
        public string ProductName { get; set; } = string.Empty;

        [Display(Name = "Product quantity in kilograms")]
        public int ProductQuantity { get; set; }

        [Display(Name = "Product price in EURO")]
        public decimal ProductPrice { get; set; }

        public string ProductImageURL { get; set; } = string.Empty;

        [Display(Name = "Loading Country")]
        public string LoadingCountry { get; set; } = string.Empty;

        [Display(Name = "Loadring address")]
        public string LoadingAddress { get; set; } = string.Empty;

        [Display(Name = "Product temperature requirement")]
        public bool IsTemperatureControlNeeded { get; set; }

        [Display(Name = "Publication day")]
        public DateTime PublicationDay { get; set; }


        [Display(Name = "Action type identifier")]
        public string? ActionType { get; set; }

        public string? ActionDescription { get;set; }

        [Display(Name ="Supplier identifier")]
        public int SupplierId { get; set; }

        [Display(Name = "Name of creator")]
        public string CreatorName { get; set; } = string.Empty;

        [Display(Name = "Creator Phone number")]
        public string CreatorPhoneNumber { get; set; } = string.Empty;

    }
}