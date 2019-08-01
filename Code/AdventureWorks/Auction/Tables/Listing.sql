CREATE TABLE [Auction].[Listing]
(
  ListingID int IDENTITY(1,1) NOT NULL,
  Item nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
  AuctionCategoryID int NOT NULL,
  Quantity int NOT NULL DEFAULT ((1)),
  ListedTime datetime NOT NULL DEFAULT (getdate()),
  EndingTime datetime NOT NULL DEFAULT (dateadd(day,(7),getdate())),
  CurrentBid money NULL,
  CurrentBidCustomer nvarchar(50) NULL,
  CONSTRAINT [PK_AuctionListing] PRIMARY KEY CLUSTERED
    ([ListingID] ASC) WITH (IGNORE_DUP_KEY = OFF)
)