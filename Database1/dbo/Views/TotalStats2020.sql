CREATE VIEW [dbo].[TotalStats2020]
	AS 
	SELECT S.PlayerId, SUM(F.Goals + S.Goals + V.Goals) AS Goals, 
		   SUM(F.Assists + S.Assists + V.Assists) AS Assists,
		   SUM(F.PlayedMinutes + S.PlayedMinutes + V.PlayedMinutes) AS PlayedMinutes,
		   SUM(F.StartingXI + S.StartingXI + V.StartingXI) AS StartingXI,
		   SUM(F.SubstitutedIn + S.SubstitutedIn + V.SubstitutedIn) AS SubstituTedIn,
		   SUM(F.OnTheBench + S.OnTheBench + V.OnTheBench) AS OnTheBench 
	FROM [Friendlystats] F 
	JOIN [Suomencupstats] S ON F.PlayerId = S.PlayerId 
	JOIN [Veikkausliigastats] V ON F.PlayerId = V.PlayerId
	WHERE F.GameId IN (SELECT Id
					  FROM Game
					  WHERE YEAR(DateTime) = 2020 )
	OR	  S.GameId IN (SELECT Id
					  FROM Game
					  WHERE YEAR(DateTime) = 2020 )
	OR	  V.GameId IN (SELECT Id
					  FROM Game
					  WHERE YEAR(DateTime) = 2020 )
	GROUP BY S.PlayerId


