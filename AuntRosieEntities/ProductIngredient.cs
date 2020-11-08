using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class ProductIngredient : IRosieEntity
    {
        private int productItemId;
        private long ingredientId;
        private double quantity;
        private string unit;

        public Ingredient Ingredient
        {
            get => default;
            set
            {
            }
        }

        public ProductItem ProductItem
        {
            get => default;
            set
            {
            }
        }
    }
}