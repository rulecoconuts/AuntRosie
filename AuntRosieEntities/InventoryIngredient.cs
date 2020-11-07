using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class InventoryIngredient
    {
        private long ingredientID;
        private DateTime purchaseDate;
        private DateTime expiryDate;
        private PaymentMethod paymentMethod;
        private double quantity;
        private string unit;
        private double cost;
        private long supplierID;

        public Ingredient Ingredient
        {
            get => default;
            set
            {
            }
        }

        public Supplier Supplier
        {
            get => default;
            set
            {
            }
        }
    }
}