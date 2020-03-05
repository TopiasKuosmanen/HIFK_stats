CREATE PROCEDURE [dbo].[AddPlayerToStatsTables]
	@PlayerId INT
AS
BEGIN
	INSERT INTO dbo.[Stats] (LeagueId, PlayerId, GameId)
	SELECT Id, (@PlayerId), (0)
	FROM dbo.League
END
