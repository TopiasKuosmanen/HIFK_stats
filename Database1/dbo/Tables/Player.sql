CREATE TABLE [dbo].[Player]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Number] INT NULL, 
    [YearOfAccession] INT NULL, 
    [ContractEndDate] DATE NOT NULL, 
    [BirthDate] DATETIME NOT NULL,
)
