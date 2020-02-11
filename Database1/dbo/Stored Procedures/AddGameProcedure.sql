CREATE PROCEDURE [dbo].[AddGameProcedure]
	@League NVARCHAR(50),
	@Opponent NVARCHAR(50),
	@DateTime DATETIME,
	@Homegame BIT,
	@Stadium NVARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.Game(OpponentId, DateTime, Serie, Stadion, Home_match)
	VALUES ((SELECT Opponent.Id
			 FROM Opponent
			 WHERE Opponent.Team = @Opponent),
			 @DateTime, @League, @Stadium, @Homegame)
END

