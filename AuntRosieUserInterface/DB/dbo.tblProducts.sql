create table [dbo].[tblProducts]
(
   [ProductID] int primary key not null,
   [ProductName] varchar not null,
   [ProductType] varchar not null,
   [ServingSize] float not null,
   [Unit] varchar not null
);