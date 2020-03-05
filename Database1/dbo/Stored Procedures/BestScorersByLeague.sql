CREATE PROCEDURE [dbo].[BestScorersByLeague]
	@League NVARCHAR(50)
AS
IF (@League = 'All')
BEGIN
	SELECT p.FirstName, p.LastName, SUM(S.Goals) AS Goals
	FROM [Stats] s JOIN Player p ON s.PlayerId = p.Id
	GROUP BY p.FirstName, p.LastName
	ORDER BY Goals DESC
END
ELSE
BEGIN
	SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals
	FROM [Stats] s JOIN Player p ON s.PlayerId = p.Id
	WHERE s.LeagueId = (SELECT Id FROM League WHERE LeagueName = @League)
	GROUP BY p.FirstName, p.LastName	
	ORDER BY Goals DESC
END
