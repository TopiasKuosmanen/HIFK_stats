CREATE VIEW [dbo].[TotalStats2020]
	AS 
	SELECT PlayerId, SUM(Games) AS Games, SUM(Goals) AS Goals, SUM(Assists) AS Assists,
	   SUM(PlayedMinutes) AS PlayedMinutes, SUM(StartingXI) AS StartingXI, SUM(SubstitutedIn) AS SubstitutedIn,
	   SUM(OnTheBench) AS OnTheBench, SUM(YellowCards) AS YellowCards, SUM(RedCards) AS RedCards 
FROM
(
	SELECT PlayerId, SUM(StartingXI + SubstitutedIn) AS Games, SUM(Goals) AS Goals, SUM(Assists) AS Assists,
	   SUM(PlayedMinutes) AS PlayedMinutes, SUM(StartingXI) AS StartingXI, SUM(SubstitutedIn) AS SubstitutedIn,
	   SUM(OnTheBench) AS OnTheBench, SUM(YellowCards) AS YellowCards, SUM(RedCards) AS RedCards 
FROM Veikkausliigastats
GROUP BY PlayerId
UNION
SELECT PlayerId, SUM(StartingXI + SubstitutedIn) AS Games, SUM(Goals) AS Goals, SUM(Assists) AS Assists,
	   SUM(PlayedMinutes) AS PlayedMinutes, SUM(StartingXI) AS StartingXI, SUM(SubstitutedIn) AS SubstitutedIn,
	   SUM(OnTheBench) AS OnTheBench, SUM(YellowCards) AS YellowCards, SUM(RedCards) AS RedCards 
FROM Suomencupstats
GROUP BY PlayerId
UNION
SELECT PlayerId, SUM(StartingXI + SubstitutedIn) AS Games, SUM(Goals) AS Goals, SUM(Assists) AS Assists,
	   SUM(PlayedMinutes) AS PlayedMinutes, SUM(StartingXI) AS StartingXI, SUM(SubstitutedIn) AS SubstitutedIn,
	   SUM(OnTheBench) AS OnTheBench, SUM(YellowCards) AS YellowCards, SUM(RedCards) AS RedCards 
FROM Friendlystats
GROUP BY PlayerId
) AS A
GROUP BY A.PlayerId

