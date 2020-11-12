using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

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

        public static void Retrieve(short nutritionId, short productId)
        {
            throw new System.NotImplementedException();
        }

        public static List<ProductNutrition> GetProductNutrition(short productId)
        {
            throw new System.NotImplementedException();
        }
    }
}