CREATE TABLE [dbo].[Staff]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Role] NVARCHAR(50) NULL, 
    [ContractStartDate] DATE NULL, 
    [ContractEndDate] DATE NULL, 
    [BirthDate] DATETIME NULL
)
