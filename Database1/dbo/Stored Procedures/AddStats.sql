CREATE PROCEDURE [dbo].[AddStats]
	@League NVARCHAR(50),
	@PlayerId INT,
	@GameId INT
AS
BEGIN
	INSERT INTO [Stats] (LeagueId, PlayerId, GameId) 
	VALUES ((SELECT Id FROM League WHERE LeagueName = @League), @PlayerId, @GameId)
END
