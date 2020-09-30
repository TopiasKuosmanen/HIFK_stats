CREATE TABLE [dbo].[OpponentGoal]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [GameId] INT NOT NULL, 
	[Score] NVARCHAR(10) NULL,
    [Winner] BIT NOT NULL,
	[Penalty] BIT NOT NULL,
	[Minute] INT NOT NULL,
	/*CONSTRAINT [FK_OpponentGoal_Game] FOREIGN KEY ([GameId]) REFERENCES [dbo].[Game] ([Id])*/
)
