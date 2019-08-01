CREATE PROCEDURE [Auction].[uspCategoryDelete]
(
	@Original_AuctionCategoryID int,
	@Original_Name nvarchar(80)
)
AS
SET NOCOUNT OFF;
DELETE FROM [Auction].[Category] WHERE (([AuctionCategoryID] = @Original_AuctionCategoryID) AND ([Name] = @Original_Name))
IF @@ROWCOUNT <> 1 RAISERROR('Could not delete category. Row was not found.',11,1)