CREATE PROCEDURE [dbo].[GetAllStats]
	@League NVARCHAR(50),
	@Year INT
AS

IF (@League = 'Veikkausliiga' AND @Year = 0)
BEGIN
	SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals, SUM(s.StartingXI + s.SubstitutedIn) AS Games, SUM(s.Assists) AS Assists,
	   SUM(s.PlayedMinutes) AS PlayedMinutes, SUM(s.StartingXI) AS StartingXI, SUM(s.SubstitutedIn) AS SubstitutedIn,
	   SUM(s.OnTheBench) AS OnTheBench, SUM(s.YellowCards) AS YellowCards, SUM(s.RedCards) AS RedCards
	FROM [Veikkausliigastats] s JOIN Player p ON s.PlayerId = p.Id
	GROUP BY p.FirstName, p.LastName
	ORDER BY Goals DESC
END
IF (@League = 'Suomen Cup' AND @Year = 0)
BEGIN
	SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals, SUM(s.StartingXI + s.SubstitutedIn) AS Games, SUM(s.Assists) AS Assists,
	   SUM(s.PlayedMinutes) AS PlayedMinutes, SUM(s.StartingXI) AS StartingXI, SUM(s.SubstitutedIn) AS SubstitutedIn,
	   SUM(s.OnTheBench) AS OnTheBench, SUM(s.YellowCards) AS YellowCards, SUM(s.RedCards) AS RedCards
	FROM [Suomencupstats] s JOIN Player p ON s.PlayerId = p.Id
	GROUP BY p.FirstName, p.LastName
	ORDER BY Goals DESC
END
IF (@League = 'Friendly' AND @Year = 0)
BEGIN
	SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals, SUM(s.StartingXI + s.SubstitutedIn) AS Games, SUM(s.Assists) AS Assists,
	   SUM(s.PlayedMinutes) AS PlayedMinutes, SUM(s.StartingXI) AS StartingXI, SUM(s.SubstitutedIn) AS SubstitutedIn,
	   SUM(s.OnTheBench) AS OnTheBench, SUM(s.YellowCards) AS YellowCards, SUM(s.RedCards) AS RedCards
	FROM [Friendlystats] s JOIN Player p ON s.PlayerId = p.Id
	GROUP BY p.FirstName, p.LastName
	ORDER BY Goals DESC
END
IF (@League = 'All' AND @Year = 0)
BEGIN
	SELECT p.FirstName, p.LastName, s.Goals, s.Games, s.Assists, s.PlayedMinutes, s.StartingXI, s.SubstitutedIn, s.OnTheBench, s.YellowCards, s.RedCards
	FROM TotalStats2020 s JOIN Player p ON s.PlayerId = p.Id
	ORDER BY Goals DESC
END

IF (@Year <> 0)
BEGIN
	IF (@League = 'Veikkausliiga')
	BEGIN
		SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals, SUM(s.StartingXI + s.SubstitutedIn) AS Games, SUM(s.Assists) AS Assists,
	   SUM(s.PlayedMinutes) AS PlayedMinutes, SUM(s.StartingXI) AS StartingXI, SUM(s.SubstitutedIn) AS SubstitutedIn,
	   SUM(s.OnTheBench) AS OnTheBench, SUM(s.YellowCards) AS YellowCards, SUM(s.RedCards) AS RedCards
	FROM [Veikkausliigastats] s JOIN Player p ON s.PlayerId = p.Id
	WHERE s.GameId IN (SELECT Id
					   FROM Game
					   WHERE YEAR(Game.DateTime) = @Year
					   )
	GROUP BY p.FirstName, p.LastName
	ORDER BY Goals DESC
	END
	IF (@League = 'Suomen Cup')
	BEGIN
		SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals, SUM(s.StartingXI + s.SubstitutedIn) AS Games, SUM(s.Assists) AS Assists,
	   SUM(s.PlayedMinutes) AS PlayedMinutes, SUM(s.StartingXI) AS StartingXI, SUM(s.SubstitutedIn) AS SubstitutedIn,
	   SUM(s.OnTheBench) AS OnTheBench, SUM(s.YellowCards) AS YellowCards, SUM(s.RedCards) AS RedCards
	FROM [Suomencupstats] s JOIN Player p ON s.PlayerId = p.Id
	WHERE s.GameId IN (SELECT Id
					   FROM Game
					   WHERE YEAR(Game.DateTime) = @Year
					   )
	GROUP BY p.FirstName, p.LastName
	ORDER BY Goals DESC
	END
	IF (@League = 'Friendly')
	BEGIN
		SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals, SUM(s.StartingXI + s.SubstitutedIn) AS Games, SUM(s.Assists) AS Assists,
	   SUM(s.PlayedMinutes) AS PlayedMinutes, SUM(s.StartingXI) AS StartingXI, SUM(s.SubstitutedIn) AS SubstitutedIn,
	   SUM(s.OnTheBench) AS OnTheBench, SUM(s.YellowCards) AS YellowCards, SUM(s.RedCards) AS RedCards
	FROM [Friendlystats] s JOIN Player p ON s.PlayerId = p.Id
	WHERE s.GameId IN (SELECT Id
					   FROM Game
					   WHERE YEAR(Game.DateTime) = @Year
					   )
	GROUP BY p.FirstName, p.LastName
	ORDER BY Goals DESC
	END
	IF (@League = 'All')
	BEGIN
		SELECT FirstName, LastName, SUM(Games) AS Games, SUM(Goals) AS Goals, SUM(Assists) AS Assists,
		SUM(PlayedMinutes) AS PlayedMinutes, SUM(StartingXI) AS StartingXI, SUM(SubstitutedIn) AS SubstitutedIn,
		SUM(OnTheBench) AS OnTheBench, SUM(YellowCards) AS YellowCards, SUM(RedCards) AS RedCards 
	    FROM
		(
			SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals, SUM(s.StartingXI + s.SubstitutedIn) AS Games, SUM(s.Assists) AS Assists,
			SUM(s.PlayedMinutes) AS PlayedMinutes, SUM(s.StartingXI) AS StartingXI, SUM(s.SubstitutedIn) AS SubstitutedIn,
			SUM(s.OnTheBench) AS OnTheBench, SUM(s.YellowCards) AS YellowCards, SUM(s.RedCards) AS RedCards
			FROM [Veikkausliigastats] s JOIN Player p ON s.PlayerId = p.Id
			WHERE s.GameId IN (SELECT Id
					   FROM Game
					   WHERE YEAR(Game.DateTime) = @Year
					   )
			GROUP BY p.FirstName, p.LastName
			UNION
			SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals, SUM(s.StartingXI + s.SubstitutedIn) AS Games, SUM(s.Assists) AS Assists,
			SUM(s.PlayedMinutes) AS PlayedMinutes, SUM(s.StartingXI) AS StartingXI, SUM(s.SubstitutedIn) AS SubstitutedIn,
			SUM(s.OnTheBench) AS OnTheBench, SUM(s.YellowCards) AS YellowCards, SUM(s.RedCards) AS RedCards
			FROM [Suomencupstats] s JOIN Player p ON s.PlayerId = p.Id
			WHERE s.GameId IN (SELECT Id
					   FROM Game
					   WHERE YEAR(Game.DateTime) = @Year
					   )
			GROUP BY p.FirstName, p.LastName
			UNION
			SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals, SUM(s.StartingXI + s.SubstitutedIn) AS Games, SUM(s.Assists) AS Assists,
			SUM(s.PlayedMinutes) AS PlayedMinutes, SUM(s.StartingXI) AS StartingXI, SUM(s.SubstitutedIn) AS SubstitutedIn,
			SUM(s.OnTheBench) AS OnTheBench, SUM(s.YellowCards) AS YellowCards, SUM(s.RedCards) AS RedCards
			FROM [Friendlystats] s JOIN Player p ON s.PlayerId = p.Id
			WHERE s.GameId IN (SELECT Id
					   FROM Game
					   WHERE YEAR(Game.DateTime) = @Year
					   )
			GROUP BY p.FirstName, p.LastName
		) AS A
		GROUP BY A.FirstName, A.LastName
	END

END