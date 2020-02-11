CREATE TABLE [dbo].[Suomencupstats]
(
    [PlayerId] INT NOT NULL, 
	[GameId] INT NOT NULL,
    [Goals] INT NULL DEFAULT 0, 
    [Assists] INT NULL DEFAULT 0,
	[YellowCards] INT NULL DEFAULT 0,
	[RedCards] INT NULL DEFAULT 0,
    [PlayedMinutes] INT NULL DEFAULT 0, 
    [StartingXI] INT NULL DEFAULT 0, 
	[SubstitutedIn] INT NULL DEFAULT 0,
    [OnTheBench] INT NULL DEFAULT 0, 
    --CONSTRAINT [FK_2020SuomencupStats_Player] FOREIGN KEY ([PlayerId]) REFERENCES [Player]([Id])
)

