using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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

        public int ProductItemId { get => productItemId; set => productItemId = value; }
        public long IngredientId { get => ingredientId; set => ingredientId = value; }
        public double Quantity { get => quantity; set => quantity = value; }
        public string Unit { get => unit; set => unit = value; }

        public override void Create(SqlTransaction transaction = null)
        {
            string query = "insert into [tblProductIngredient]([ProductItemID], [IngredientID], [Quantity], [Unit]) " +
                $"values ({ProductItemId}, {IngredientId}, {Quantity}, '{Unit}')";
            Connector.Insert(query, false, transaction);
        }

        public override void Delete(SqlTransaction transaction = null)
        {
            string query = $"delete from [tblProductIngredient] where " +
                $"[ProductItemID]={ProductItemId} and [IngredientID]={IngredientId}";
            Connector.Delete(query);
        }

        public override void Update(SqlTransaction transaction = null)
        {
            string query = $"update [tblProductIngredient] set [Quantity]={Quantity}, [Unit]='{Unit}'";
            Connector.Update(query, transaction);
        }

        public static DataTable GetIngredientsTable(int productItemID)
        {
            DataTable ingredients = new DataTable();
            string query = "select p.[ProductName] as 'Product Name', concat(psz.[SizeName], '(', psz.[SizeValue], ' ', " +
                "psz.[Unit], ')') as 'Size', i.[IngredientName] as 'Ingredient Name', it.[TypeName] as 'Type' " +
                "from [tblProductIngredient] pin " +
                "inner join [tblProductItem] pi on pin.[ProductItemID]=pi.[ProductItemID] " +
                "inner join [tblProduct] p on p.[ProductID] = pi.[ProductID] " +
                "inner join [tblProductSize] psz on psz.[SizeID] = pi.[SizeID] " +
                "inner join [tblIngredient] i on i.[IngredientID]=pin.[IngredientID] " +
                "inner join [tblIngredientType] it on i.[IngredientTypeID]=it.[IngredientTypeID] " +
                $"where pin.[ProductItemID]={productItemID}";

            SqlCommand command = new SqlCommand(query, Connector.Connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ingredients);
            }
            catch
            {
                return null;
            }

            return ingredients;
        }
    }
}