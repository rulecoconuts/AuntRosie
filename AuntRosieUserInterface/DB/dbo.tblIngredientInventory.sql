
create table [dbo].[tblIngredientInventory]
(
  primary key (IngredientID),
  foreign key (IngredientID) references dbo.tblIngredient (IngredientID),
  [PurchaseDate] datetime primary key not null,
  [ExpireDate] date not null,
  [PaymentMethod] char (1) not null,
  [Quantity] decimal,
  [Unit] varchar (20),
  [Cost] money,
  foreign key (SupplierID) references dbo.tblSupplier (SupplierID),
);
