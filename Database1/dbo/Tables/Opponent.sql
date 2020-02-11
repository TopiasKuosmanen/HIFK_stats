CREATE TABLE [dbo].[Opponent]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Team] NVARCHAR(50) NOT NULL,
	[Stadium] INT,
    --CONSTRAINT [FK_Opponent_Game] FOREIGN KEY ([Id]) REFERENCES [Game],
	CONSTRAINT [FK_Opponent_Stadium] FOREIGN KEY ([Stadium]) REFERENCES [Stadium]

)
