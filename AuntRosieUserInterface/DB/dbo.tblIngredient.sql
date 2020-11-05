
create table [dbo].[tblIngredient]
(
  [IngredientID] bigint identity(1,1) primary key,
  [IngredientName] varchar (50) not null,
  [StoringNote] text,
  foreign key (IngredientTypeID) references dbo.tblIngredientType (IngredientTypeID)
);
