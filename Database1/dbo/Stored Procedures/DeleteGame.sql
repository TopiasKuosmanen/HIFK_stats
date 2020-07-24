CREATE PROCEDURE [dbo].[DeleteGame]
	@League NVARCHAR(50),
	@GameId INT,
	@Result NVARCHAR(10)
AS
BEGIN
	DELETE FROM Game WHERE Game.Id = @GameId
END
IF @Result IS NOT NULL
BEGIN
		DELETE FROM [Stats] WHERE GameId = @GameId AND LeagueId = (SELECT Id FROM League WHERE LeagueName = @League)
		DELETE FROM [Goal] WHERE GameId = @GameId
		DELETE FROM [OpponentGoal] WHERE GameId = @GameId
END

