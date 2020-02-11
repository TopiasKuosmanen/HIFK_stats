CREATE TABLE [dbo].[Stadium]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Capacity] INT NULL, 
    [Turf] BIT NULL
)
