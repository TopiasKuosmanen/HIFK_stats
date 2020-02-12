CREATE PROCEDURE [dbo].[BestScorersByLeague]
	@League NVARCHAR(50)
AS

IF (@League = 'Veikkausliiga')
BEGIN
	SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals
	FROM [Veikkausliigastats] s JOIN Player p ON s.PlayerId = p.Id
	GROUP BY p.FirstName, p.LastName
	ORDER BY Goals DESC
END
IF (@League = 'Suomen Cup')
BEGIN
	SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals
	FROM [Suomencupstats] s JOIN Player p ON s.PlayerId = p.Id
	GROUP BY p.FirstName, p.LastName
	ORDER BY Goals DESC
END
IF (@League = 'Friendly')
BEGIN
	SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals
	FROM [Friendlystats] s JOIN Player p ON s.PlayerId = p.Id
	GROUP BY p.FirstName, p.LastName
	ORDER BY Goals DESC
END
IF (@League = 'All')
BEGIN
	SELECT p.FirstName, p.LastName, S.Goals
	FROM TotalStats2020 s JOIN Player p ON s.PlayerId = p.Id
	ORDER BY Goals DESC
END
