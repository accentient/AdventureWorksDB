CREATE SCHEMA [Auction]
AUTHORIZATION [dbo];

GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Contains objects related to online auctions.', @level0type = N'SCHEMA', @level0name = N'Auction';