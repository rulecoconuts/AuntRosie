using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class ProductIngredient : RosieEntity
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

        public override void Create(SqlTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public override void Delete(SqlTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public override void Update(SqlTransaction transaction = null)
        {
            throw new NotImplementedException();
        }
    }
}