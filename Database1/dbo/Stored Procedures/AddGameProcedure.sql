CREATE PROCEDURE [dbo].[AddGameProcedure]
	@League NVARCHAR(50),
	@Opponent NVARCHAR(50),
	@DateTime DATETIME,
	@Homegame BIT,
	@Stadium NVARCHAR(50),
	@ExtraTime BIT,
	@Penalties BIT
AS
BEGIN
	INSERT INTO dbo.Game(OpponentId, DateTime, Serie, Stadion, Home_match, Extra_time, Penalties)
	VALUES ((SELECT Opponent.Id
			 FROM Opponent
			 WHERE Opponent.Team = @Opponent),
			 @DateTime, @League, @Stadium, @Homegame, @ExtraTime, @Penalties)
END

