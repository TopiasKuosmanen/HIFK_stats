CREATE TABLE [dbo].[Game]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [OpponentId] INT NOT NULL,
    [DateTime] DATETIME NULL, 
    [Serie] NVARCHAR(50) NOT NULL, 
    [Result] NVARCHAR(10) NULL, 
    [Stadion] NVARCHAR(50) NULL, 
    [Home_match] BIT NOT NULL, 
    CONSTRAINT [CK_Game_Serie] CHECK (Serie IN ('Veikkausliiga', 'Suomen Cup', 'Friendly'))
)
