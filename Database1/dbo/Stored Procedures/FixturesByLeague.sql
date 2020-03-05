CREATE PROCEDURE [dbo].[FixturesByLeague]
	@League NVARCHAR(50)
AS
BEGIN
IF (@League = 'All')
BEGIN
	SELECT G.*, O.Team AS 'Opponent'
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id
	WHERE Result IS NULL
	ORDER BY DateTime
END
ELSE
BEGIN
	SELECT G.*, O.Team AS 'Opponent'
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id
	WHERE Result IS NULL AND Serie = @League
	ORDER BY DateTime
END
END
