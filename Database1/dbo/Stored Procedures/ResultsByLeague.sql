CREATE PROCEDURE [dbo].[ResultsByLeague]
	@League NVARCHAR(50),
	@Year NVARCHAR(5)
AS

IF (@Year = 0)
BEGIN
IF (@League = 'Veikkausliiga')
BEGIN
	SELECT G.*, O.Team AS 'Opponent'
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id
	WHERE Result IS NOT NULL AND Serie = 'Veikkausliiga'
	ORDER BY DateTime DESC
END
IF (@League = 'Suomen Cup')
BEGIN
	SELECT G.*, O.Team AS 'Opponent'
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id
	WHERE Result IS NOT NULL AND Serie = 'Suomen Cup'
	ORDER BY DateTime DESC
END
IF (@League = 'Friendly')
BEGIN
	SELECT G.*, O.Team AS 'Opponent'
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id
	WHERE Result IS NOT NULL AND Serie = 'Friendly'
	ORDER BY DateTime DESC
END
IF (@League = 'All')
BEGIN
	SELECT G.*, O.Team AS 'Opponent'
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id
	WHERE Result IS NOT NULL
	ORDER BY DateTime DESC
	
END
END
ELSE
BEGIN
IF (@League = 'Veikkausliiga')
BEGIN
	SELECT *
	FROM VeikkausliigaGames
	WHERE Result IS NOT NULL AND YEAR(DateTime) = @Year
	ORDER BY DateTime DESC
END
IF (@League = 'Suomen Cup')
BEGIN
	SELECT *
	FROM SuomencupGames
	WHERE Result IS NOT NULL AND YEAR(DateTime) = @Year
	ORDER BY DateTime DESC
END
IF (@League = 'Friendly')
BEGIN
	SELECT *
	FROM FriendlyGames
	WHERE Result IS NOT NULL AND YEAR(DateTime) = @Year
	ORDER BY DateTime DESC
END
IF (@League = 'All')
BEGIN
	SELECT G.*, O.Team AS 'Opponent'
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id
	WHERE Result IS NOT NULL AND YEAR(G.DateTime) = @Year
	ORDER BY DateTime DESC
	
END
END