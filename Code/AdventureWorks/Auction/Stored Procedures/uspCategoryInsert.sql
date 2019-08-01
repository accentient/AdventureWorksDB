CREATE PROCEDURE [Auction].[uspCategoryInsert]
(
	@Name nvarchar(80)
)
AS
SET NOCOUNT OFF

-- Does category already exist?

IF EXISTS(SELECT [Name] from [Auction].[Category] WHERE [Name] = @Name)
BEGIN
 RAISERROR('That category already exists.', 16, 1)
 RETURN 1
END

INSERT INTO [Auction].[Category] ([Name]) VALUES (@Name);
SELECT AuctionCategoryID, Name FROM Auction.Category WHERE (AuctionCategoryID = SCOPE_IDENTITY())