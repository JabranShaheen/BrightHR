﻿using CheckoutSystem.Abstractions.Entities;
using System.Collections.Generic;

namespace CheckoutSystem.Abstractions.Services
{
    public interface IPromotionService
    {
        void AddPromotion(Promotion promotion);
        IEnumerable<Promotion> GetPromotionsForItem(string sku);
    }
}
