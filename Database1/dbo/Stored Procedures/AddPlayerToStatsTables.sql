CREATE PROCEDURE [dbo].[AddPlayerToStatsTables]
	@PlayerId INT
AS
BEGIN
	INSERT INTO dbo.[Suomencupstats] (PlayerId, GameId)
	VALUES (@PlayerId, 0)
END
BEGIN
	INSERT INTO dbo.[Veikkausliigastats] (PlayerId, GameId)
	VALUES (@PlayerId, 0)
END
BEGIN
	INSERT INTO dbo.[Friendlystats] (PlayerId, GameId)
	VALUES (@PlayerId, 0)
END