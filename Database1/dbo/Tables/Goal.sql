CREATE TABLE [dbo].[Goal]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [GameId] INT NOT NULL, 
	[Score] NVARCHAR(10) NULL,
    [Winner] BIT NOT NULL, 
    [PlayerId] INT NOT NULL, 
    [AssistId] INT NULL, 
    [Penalty] BIT NOT NULL,
	[Minute] INT NOT NULL,
	/*CONSTRAINT [FK_Goal_Game] FOREIGN KEY ([GameId]) REFERENCES [Game],
	CONSTRAINT [FK_Goal_GoalPlayer] FOREIGN KEY ([PlayerId]) REFERENCES [Player],
	CONSTRAINT [FK_Goal_AssistPlayer] FOREIGN KEY ([AssistId]) REFERENCES [Player]*/
)
