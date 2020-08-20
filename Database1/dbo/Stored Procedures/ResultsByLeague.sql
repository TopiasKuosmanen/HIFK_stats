CREATE PROCEDURE [dbo].[ResultsByLeague]
	@League NVARCHAR(50),
	@StartingDay DATETIME,
	@EndingDay DATETIME
AS

IF (@StartingDay = 0 AND @EndingDay = 0)
BEGIN
IF (@League = 'All')
BEGIN
	SELECT G.*, O.Team AS 'Opponent', (R.FirstName+' '+R.LastName) AS Referee, DATENAME(WEEKDAY, g.DateTime) AS WeekDay
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id LEFT JOIN REFEREE R ON R.Id = G.RefereeId
	WHERE Result IS NOT NULL
	ORDER BY DateTime DESC
END
ELSE
BEGIN
	SELECT G.*, O.Team AS 'Opponent', (R.FirstName+' '+R.LastName) AS Referee, DATENAME(WEEKDAY, g.DateTime) AS WeekDay
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id LEFT JOIN REFEREE R ON R.Id = G.RefereeId
	WHERE Result IS NOT NULL AND Serie = @League
	ORDER BY DateTime DESC
END
END
ELSE
BEGIN
IF (@League = 'All')
BEGIN
	SELECT G.*, O.Team AS 'Opponent', (R.FirstName+' '+R.LastName) AS Referee, DATENAME(WEEKDAY, g.DateTime) AS WeekDay
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id LEFT JOIN REFEREE R ON R.Id = G.RefereeId
	WHERE Result IS NOT NULL AND G.DateTime >= @StartingDay AND G.DateTime <= @EndingDay
	ORDER BY DateTime DESC
END
ELSE
BEGIN
	SELECT G.*, O.Team AS 'Opponent', (R.FirstName+' '+R.LastName) AS Referee, DATENAME(WEEKDAY, g.DateTime) AS WeekDay
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id LEFT JOIN REFEREE R ON R.Id = G.RefereeId
	WHERE Result IS NOT NULL AND G.DateTime >= @StartingDay AND G.DateTime <= @EndingDay AND Serie = @League
	ORDER BY DateTime DESC
END
END