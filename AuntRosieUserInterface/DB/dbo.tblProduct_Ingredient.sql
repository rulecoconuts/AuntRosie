
create table [dbo].[tblProduct_Ingredient]
(
  primary key (ProductItemID, IngredientID),
  foreign key (ProductItemID) references dbo.tblProductItem (ProductItemID),
  foreign key (IngredientID) references dbo.tblIngredient (IngredientID),
  [Quantity] decimal not null,
  [Unit] varchar (10) not null
);
