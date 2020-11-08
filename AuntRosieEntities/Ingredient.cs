using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class Ingredient : RosieEntity
    {
        private bigint id;
        private string name;
        private short ingredientTypeId;
        private string storingNote;

        public IngredientType IngredientType
        {
            get => default;
            set
            {
            }
        }
    }
}