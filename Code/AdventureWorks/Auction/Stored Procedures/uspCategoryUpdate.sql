CREATE PROCEDURE [Auction].[uspCategoryUpdate]
(
	@Name nvarchar(80),
	@Original_AuctionCategoryID int,
	@Original_Name nvarchar(80),
	@AuctionCategoryID int
)
AS
SET NOCOUNT OFF;
UPDATE [Auction].[Category] SET [Name] = @Name WHERE (([AuctionCategoryID] = @Original_AuctionCategoryID) AND ([Name] = @Original_Name));
SELECT AuctionCategoryID, Name FROM Auction.Category WHERE (AuctionCategoryID = @AuctionCategoryID)