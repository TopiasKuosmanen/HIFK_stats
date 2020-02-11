CREATE PROCEDURE [dbo].[BestScorersByLeague]
	@League NVARCHAR(50)
AS

IF (@League = 'Veikkausliiga')
BEGIN
	SELECT p.FirstName, p.LastName, Goals
	FROM [Veikkausliigastats] s join Player p ON s.PlayerId = p.Id
	ORDER BY Goals DESC
END
IF (@League = 'Suomen Cup')
BEGIN
	SELECT p.FirstName, p.LastName, Goals
	FROM [Suomencupstats] s join Player p ON s.PlayerId = p.Id
	ORDER BY Goals DESC
END
IF (@League = 'Friendly')
BEGIN
	SELECT p.FirstName, p.LastName, Goals
	FROM [Friendlystats] s JOIN Player p ON s.PlayerId = p.Id
	ORDER BY Goals DESC
END
IF (@League = 'All')
BEGIN
	SELECT p.FirstName, p.LastName, Goals
	FROM TotalStats2020 s join Player p ON s.PlayerId = p.Id
	ORDER BY Goals DESC
END
