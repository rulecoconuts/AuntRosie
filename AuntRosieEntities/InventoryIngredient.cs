using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
 

namespace AuntRosieEntities
{
    public class InventoryIngredient : RosieEntity
    {
        private long ingredientID;
        private DateTime purchaseDate;
        private DateTime expiryDate;
        private string paymentMethod;
        private double quantity;
        private string unit;
        private double cost;
        private long supplierID;
        ///  
        private static SqlCommand createPrepCmd = null;
        private static SqlCommand deletePrepCmd = null;
        private static SqlCommand updatePrepCmd = null;

        public string Unit { get => unit; set => unit = value; }
        public long IngredientID { get => ingredientID; set => ingredientID = value; }
        public DateTime PurchaseDate { get => purchaseDate; set => purchaseDate = value; }
        public DateTime ExpiryDate { get => expiryDate; set => expiryDate = value; }
        public string ThisPaymentMethod { get => paymentMethod; set => paymentMethod = value; }
        public double Quantity { get => quantity; set => quantity = value; }
        public double Cost { get => cost; set => cost = value; }
        public long SupplierId { get => supplierID; set => supplierID = value; }





           /// <summary>
         /// Create a new type of Inventory in
         /// </summary>
         /// <param name="transaction"></param>
        public override void Create(SqlTransaction transaction = null)
        {
            if (createPrepCmd is null)
            {
                createPrepCmd = new SqlCommand(null, Connector.Connection);
                createPrepCmd.CommandText = "insert into [tblIngredientInventory]([IngredientID]," +
                    "[PurchaseDate],[ExpiryDate] ,[PaymentMethod],[Quantity],[Unit],[Cost],[SupplierID] )" +
                    " values (@ingredientId,@purchaseDate,@expiryDate,@pymentMethod,@quantity,@unit,@cost,@supplierID)";


                SqlParameter ingredientIdParam = new SqlParameter("@ingredientId", SqlDbType.BigInt );
                ingredientIdParam.Value = IngredientID;
                createPrepCmd.Parameters.Add(ingredientIdParam);

                SqlParameter purchaseDateParam = new SqlParameter("@purchaseDate", SqlDbType.Date);
                purchaseDateParam.Value = PurchaseDate;
                createPrepCmd.Parameters.Add(purchaseDateParam);

                SqlParameter expiryDateParam = new SqlParameter("@expiryDate", SqlDbType.Date);
                expiryDateParam.Value = ExpiryDate;
                createPrepCmd.Parameters.Add(expiryDateParam);

                SqlParameter paymentMethodParam = new SqlParameter("@pymentMethod", SqlDbType.Char,1);
                paymentMethodParam.Value = ThisPaymentMethod;
                createPrepCmd.Parameters.Add(paymentMethodParam);

                SqlParameter quantityParam = new SqlParameter("@quantity", SqlDbType.Decimal)
                {
                    Precision = 14,
                    Scale = 2
                }; 
                quantityParam.Value =Quantity;
                createPrepCmd.Parameters.Add(quantityParam);

                SqlParameter unitParam = new SqlParameter("@unit", SqlDbType.VarChar, 20);
                unitParam.Value = Unit;
                createPrepCmd.Parameters.Add(unitParam);

                SqlParameter costParam = new SqlParameter("@cost", SqlDbType.Money, 20);
                costParam.Value = Cost;
                createPrepCmd.Parameters.Add(costParam);

                SqlParameter supplierIDParam = new SqlParameter("@supplierID", SqlDbType.BigInt);
                supplierIDParam.Value = SupplierId;
                createPrepCmd.Parameters.Add(supplierIDParam);




                createPrepCmd.Prepare();
            }
            else
            {

               
                createPrepCmd.Parameters["@ingredientId"].Value =IngredientID  ;
                createPrepCmd.Parameters["@purchaseDate"].Value = PurchaseDate;
                createPrepCmd.Parameters["@expiryDate"].Value = ExpiryDate;
                createPrepCmd.Parameters["@pymentMethod"].Value = ThisPaymentMethod;
                createPrepCmd.Parameters["@quantity"].Value = Quantity;
                createPrepCmd.Parameters["@unit"].Value = Unit;
                createPrepCmd.Parameters["@supplierID"].Value = SupplierId;
            }

            Connector.Insert(createPrepCmd, true, transaction);
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