CREATE PROCEDURE [dbo].[DeleteGame]
	@League NVARCHAR(50),
	@GameId INT,
	@Result NVARCHAR(10)
AS
BEGIN
	DELETE FROM GAME WHERE Game.Id = @GameId
END
IF @Result IS NOT NULL
BEGIN
		DELETE FROM [Stats] WHERE GameId = @GameId AND LeagueId = (SELECT Id FROM League WHERE LeagueName = @League)
END

