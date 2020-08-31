CREATE PROCEDURE [dbo].[GetAllStats]
	@League NVARCHAR(50),
	@Year INT
AS

IF (@Year = 0 AND @League <> 'All')
BEGIN
	SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals, SUM(s.StartingXI + s.SubstitutedIn) AS Games, SUM(s.Assists) AS Assists,
	   SUM(s.PlayedMinutes) AS PlayedMinutes, SUM(s.StartingXI) AS StartingXI, SUM(s.SubstitutedIn) AS SubstitutedIn,
	   SUM(s.OnTheBench) AS OnTheBench, SUM(s.YellowCards) AS YellowCards, SUM(s.RedCards) AS RedCards, p.Id AS PlayerId
	FROM [Stats] s JOIN Player p ON s.PlayerId = p.Id
	WHERE s.LeagueId = (SELECT Id FROM League WHERE LeagueName = @League)
	GROUP BY p.FirstName, p.LastName, p.Id
	ORDER BY Goals DESC
END
IF (@League = 'All' AND @Year = 0)
BEGIN
	SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals, SUM(s.StartingXI + s.SubstitutedIn) AS Games, SUM(s.Assists) AS Assists,
	   SUM(s.PlayedMinutes) AS PlayedMinutes, SUM(s.StartingXI) AS StartingXI, SUM(s.SubstitutedIn) AS SubstitutedIn,
	   SUM(s.OnTheBench) AS OnTheBench, SUM(s.YellowCards) AS YellowCards, SUM(s.RedCards) AS RedCards, p.Id AS PlayerId
	FROM [Stats] s JOIN Player p ON s.PlayerId = p.Id
	GROUP BY p.FirstName, p.LastName, p.Id
	ORDER BY Goals DESC
END

IF (@Year <> 0)
BEGIN
	IF (@League = 'All')
	BEGIN
		SELECT FirstName, LastName, SUM(Games) AS Games, SUM(Goals) AS Goals, SUM(Assists) AS Assists,
		SUM(PlayedMinutes) AS PlayedMinutes, SUM(StartingXI) AS StartingXI, SUM(SubstitutedIn) AS SubstitutedIn,
		SUM(OnTheBench) AS OnTheBench, SUM(YellowCards) AS YellowCards, SUM(RedCards) AS RedCards, PlayerId AS PlayerId
	    FROM
		(
			SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals, SUM(s.StartingXI + s.SubstitutedIn) AS Games, SUM(s.Assists) AS Assists,
			SUM(s.PlayedMinutes) AS PlayedMinutes, SUM(s.StartingXI) AS StartingXI, SUM(s.SubstitutedIn) AS SubstitutedIn,
			SUM(s.OnTheBench) AS OnTheBench, SUM(s.YellowCards) AS YellowCards, SUM(s.RedCards) AS RedCards, p.Id AS PlayerId
			FROM [Stats] s JOIN Player p ON s.PlayerId = p.Id
			WHERE s.GameId IN (SELECT Id
					   FROM Game
					   WHERE YEAR(Game.DateTime) = @Year
					   )
			GROUP BY p.FirstName, p.LastName, p.Id
		) AS p
		GROUP BY FirstName, LastName, PlayerId
	END
	ELSE
	BEGIN
		SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals, SUM(s.StartingXI + s.SubstitutedIn) AS Games, SUM(s.Assists) AS Assists,
	   SUM(s.PlayedMinutes) AS PlayedMinutes, SUM(s.StartingXI) AS StartingXI, SUM(s.SubstitutedIn) AS SubstitutedIn,
	   SUM(s.OnTheBench) AS OnTheBench, SUM(s.YellowCards) AS YellowCards, SUM(s.RedCards) AS RedCards, p.Id AS PlayerId
	FROM [Stats] s JOIN Player p ON s.PlayerId = p.Id
	WHERE s.GameId IN (SELECT Id
					   FROM Game
					   WHERE YEAR(Game.DateTime) = @Year
					   ) AND s.LeagueId = (SELECT Id FROM League WHERE LeagueName = @League)
	GROUP BY p.FirstName, p.LastName, p.Id
	ORDER BY Goals DESC
	END
	

END