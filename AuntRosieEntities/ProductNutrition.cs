using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class ProductNutrition : RosieEntity
    {
        private short productId;
        private short nutritionId;
        private double value;
        private char valueType;

        public Nutrition Nutrition
        {
            get => default;
            set
            {
            }
        }
    }
}