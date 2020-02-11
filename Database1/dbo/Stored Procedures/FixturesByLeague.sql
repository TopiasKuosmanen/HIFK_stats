CREATE PROCEDURE [dbo].[FixturesByLeague]
	@League NVARCHAR(50)
AS
BEGIN
IF (@League = 'Veikkausliiga')
BEGIN
	SELECT G.*, O.Team AS 'Opponent'
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id
	WHERE Result IS NULL AND Serie = 'Veikkausliiga'
	ORDER BY DateTime
END
IF (@League = 'Suomen Cup')
BEGIN
	SELECT G.*, O.Team AS 'Opponent'
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id
	WHERE Result IS NULL AND Serie = 'Suomen Cup'
	ORDER BY DateTime
END
IF (@League = 'Friendly')
BEGIN
	SELECT G.*, O.Team AS 'Opponent'
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id
	WHERE Result IS NULL AND Serie = 'Friendly'
	ORDER BY DateTime
END
IF (@League = 'All')
BEGIN
	SELECT G.*, O.Team AS 'Opponent'
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id
	WHERE Result IS NULL
	ORDER BY DateTime
	
END
END
