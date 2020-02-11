CREATE PROCEDURE [dbo].[AddStats]
	@League NVARCHAR(50),
	@PlayerId INT,
	@GameId INT
AS
IF @League = 'Veikkausliiga'
BEGIN
	INSERT INTO [Veikkausliigastats] (PlayerId, GameId) 
	VALUES (@PlayerId, @GameId)
END
IF @League = 'Suomen Cup'
BEGIN
	INSERT INTO [Suomencupstats] (PlayerId, GameId) 
	VALUES (@PlayerId, @GameId)
END
IF @League = 'Friendly'
BEGIN
	INSERT INTO [Friendlystats] (PlayerId, GameId) 
	VALUES (@PlayerId, @GameId)
END


