CREATE PROCEDURE [dbo].[ResultsByLeague]
	@League NVARCHAR(50),
	@Year NVARCHAR(5)
AS

IF (@Year = 0)
BEGIN
IF (@League = 'All')
BEGIN
	SELECT G.*, O.Team AS 'Opponent'
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id
	WHERE Result IS NOT NULL
	ORDER BY DateTime DESC
END
ELSE
BEGIN
	SELECT G.*, O.Team AS 'Opponent'
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id
	WHERE Result IS NOT NULL AND Serie = @League
	ORDER BY DateTime DESC
END
END
ELSE
BEGIN
IF (@League = 'All')
BEGIN
	SELECT G.*, O.Team AS 'Opponent'
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id
	WHERE Result IS NOT NULL AND YEAR(G.DateTime) = @Year
	ORDER BY DateTime DESC
END
ELSE
BEGIN
	SELECT G.*, O.Team AS 'Opponent'
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id
	WHERE Result IS NOT NULL AND YEAR(DateTime) = @Year AND Serie = @League
	ORDER BY DateTime DESC
END
END