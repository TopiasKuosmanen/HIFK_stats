﻿CREATE TABLE [dbo].[Referee]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NOT NULL,
    [BirthDate] DATETIME NULL
)
