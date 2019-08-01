CREATE PROCEDURE [Auction].[uspListingDelete]
(
	@Original_ListingID int,
	@Original_Item nvarchar(50),
	@Original_AuctionCategoryID int,
	@Original_Quantity int,
	@Original_ListedTime datetime,
	@Original_EndingTime datetime,
	@IsNull_CurrentBid money,
	@Original_CurrentBid money,
	@IsNull_CurrentBidCustomer nvarchar(50),
	@Original_CurrentBidCustomer nvarchar(50)
)
AS
SET NOCOUNT OFF;
DELETE FROM [Auction].[Listing] WHERE (([ListingID] = @Original_ListingID) AND ([Item] = @Original_Item) AND ([AuctionCategoryID] = @Original_AuctionCategoryID) AND ([Quantity] = @Original_Quantity) AND ([ListedTime] = @Original_ListedTime) AND ([EndingTime] = @Original_EndingTime) AND ((@IsNull_CurrentBid = 1 AND [CurrentBid] IS NULL) OR ([CurrentBid] = @Original_CurrentBid)) AND ((@IsNull_CurrentBidCustomer = 1 AND [CurrentBidCustomer] IS NULL) OR ([CurrentBidCustomer] = @Original_CurrentBidCustomer)))