CREATE PROCEDURE [Auction].[uspListingInsert]
(
	@Item nvarchar(50),
	@AuctionCategoryID int,
	@Quantity int,
	@ListedTime datetime,
	@EndingTime datetime,
	@CurrentBid money,
	@CurrentBidCustomer nvarchar(50)
)
AS
SET NOCOUNT OFF;
INSERT INTO [Auction].[Listing] ([Item], [AuctionCategoryID], [Quantity], [ListedTime], [EndingTime], [CurrentBid], [CurrentBidCustomer]) VALUES (@Item, @AuctionCategoryID, @Quantity, @ListedTime, @EndingTime, @CurrentBid, @CurrentBidCustomer)