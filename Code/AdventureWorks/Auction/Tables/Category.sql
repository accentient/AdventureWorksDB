CREATE TABLE [Auction].[Category]
(
  AuctionCategoryID	int IDENTITY(1,1)	NOT NULL, 
  Name				nvarchar(100)		NOT NULL, 
    CONSTRAINT [PK_AuctionCategory] PRIMARY KEY ([AuctionCategoryID])
)