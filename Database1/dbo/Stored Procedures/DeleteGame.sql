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
	IF @League = 'Veikkausliiga'
	BEGIN
		DELETE FROM [Veikkausliigastats] WHERE GameId = @GameId
	END
	IF @League = 'Suomen Cup'
	BEGIN
		DELETE FROM [Suomencupstats] WHERE GameId = @GameId
	END
	IF @League = 'Friendly'
	BEGIN
		DELETE FROM [Friendlystats] WHERE GameId = @GameId
	END
END

