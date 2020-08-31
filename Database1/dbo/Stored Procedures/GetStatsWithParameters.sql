CREATE PROCEDURE [dbo].[GetStatsWithParameters]
	@Leagues NVARCHAR(50),
	@Opponents NVARCHAR(50),
	@StartingDay DATETIME,
	@EndingDay DATETIME,
	@Player NVARCHAR(50)

AS
IF(@Leagues = 'All' AND @Opponents = 'All' AND @Player = '')
BEGIN
	SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals, SUM(s.StartingXI + s.SubstitutedIn) AS Games, SUM(s.Assists) AS Assists,
	   SUM(s.PlayedMinutes) AS PlayedMinutes, SUM(s.StartingXI) AS StartingXI, SUM(s.SubstitutedIn) AS SubstitutedIn,
	   SUM(s.OnTheBench) AS OnTheBench, SUM(s.YellowCards) AS YellowCards, SUM(s.RedCards) AS RedCards, PlayerId AS PlayerId
	FROM [Stats] s JOIN Player p ON s.PlayerId = p.Id JOIN Game g ON s.GameId = g.Id
	WHERE g.DateTime >= @StartingDay AND g.DateTime <= @EndingDay
	GROUP BY p.FirstName, p.LastName, s.PlayerId
	ORDER BY Goals DESC
END
IF (@Leagues = 'ALL' AND @Opponents != 'All' AND @Player = '')
BEGIN
	SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals, SUM(s.StartingXI + s.SubstitutedIn) AS Games, SUM(s.Assists) AS Assists,
	   SUM(s.PlayedMinutes) AS PlayedMinutes, SUM(s.StartingXI) AS StartingXI, SUM(s.SubstitutedIn) AS SubstitutedIn,
	   SUM(s.OnTheBench) AS OnTheBench, SUM(s.YellowCards) AS YellowCards, SUM(s.RedCards) AS RedCards, PlayerId AS PlayerId
	FROM [Stats] s JOIN Player p ON s.PlayerId = p.Id JOIN Game g ON s.GameId = g.Id JOIN Opponent o ON g.OpponentId = o.Id
	WHERE g.DateTime >= @StartingDay AND g.DateTime <= @EndingDay AND o.Team = @Opponents
	GROUP BY p.FirstName, p.LastName, s.PlayerId
	ORDER BY Goals DESC
END
IF (@Leagues != 'ALL' AND @Opponents = 'All' AND @Player = '')
BEGIN
	SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals, SUM(s.StartingXI + s.SubstitutedIn) AS Games, SUM(s.Assists) AS Assists,
	   SUM(s.PlayedMinutes) AS PlayedMinutes, SUM(s.StartingXI) AS StartingXI, SUM(s.SubstitutedIn) AS SubstitutedIn,
	   SUM(s.OnTheBench) AS OnTheBench, SUM(s.YellowCards) AS YellowCards, SUM(s.RedCards) AS RedCards, PlayerId AS PlayerId
	FROM [Stats] s JOIN Player p ON s.PlayerId = p.Id JOIN Game g ON s.GameId = g.Id
	WHERE g.DateTime >= @StartingDay AND g.DateTime <= @EndingDay AND g.Serie = @Leagues
	GROUP BY p.FirstName, p.LastName, s.PlayerId
	ORDER BY Goals DESC
END
IF (@Leagues != 'ALL' AND @Opponents != 'All' AND @Player = '')
BEGIN
	SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals, SUM(s.StartingXI + s.SubstitutedIn) AS Games, SUM(s.Assists) AS Assists,
	   SUM(s.PlayedMinutes) AS PlayedMinutes, SUM(s.StartingXI) AS StartingXI, SUM(s.SubstitutedIn) AS SubstitutedIn,
	   SUM(s.OnTheBench) AS OnTheBench, SUM(s.YellowCards) AS YellowCards, SUM(s.RedCards) AS RedCards, PlayerId AS PlayerId
	FROM [Stats] s JOIN Player p ON s.PlayerId = p.Id JOIN Game g ON s.GameId = g.Id JOIN Opponent o ON g.OpponentId = o.Id 
	WHERE g.DateTime >= @StartingDay AND g.DateTime <= @EndingDay AND g.Serie = @Leagues AND o.Team = @Opponents
	GROUP BY p.FirstName, p.LastName, s.PlayerId
	ORDER BY Goals DESC
END
IF (@Leagues != 'ALL' AND @Opponents != 'All' AND @Player != '')
BEGIN
	SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals, SUM(s.StartingXI + s.SubstitutedIn) AS Games, SUM(s.Assists) AS Assists,
	   SUM(s.PlayedMinutes) AS PlayedMinutes, SUM(s.StartingXI) AS StartingXI, SUM(s.SubstitutedIn) AS SubstitutedIn,
	   SUM(s.OnTheBench) AS OnTheBench, SUM(s.YellowCards) AS YellowCards, SUM(s.RedCards) AS RedCards, PlayerId AS PlayerId
	FROM [Stats] s JOIN Player p ON s.PlayerId = p.Id JOIN Game g ON s.GameId = g.Id JOIN Opponent o ON g.OpponentId = o.Id
	WHERE g.DateTime >= @StartingDay AND g.DateTime <= @EndingDay AND g.Serie = @Leagues AND o.Team = @Opponents AND (LastName LIKE '%' + @Player + '%' OR FirstName LIKE '%' + @Player + '%')
	GROUP BY p.FirstName, p.LastName, s.PlayerId
	ORDER BY Goals DESC
END
IF (@Leagues != 'ALL' AND @Opponents = 'All' AND @Player != '')
BEGIN
	SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals, SUM(s.StartingXI + s.SubstitutedIn) AS Games, SUM(s.Assists) AS Assists,
	   SUM(s.PlayedMinutes) AS PlayedMinutes, SUM(s.StartingXI) AS StartingXI, SUM(s.SubstitutedIn) AS SubstitutedIn,
	   SUM(s.OnTheBench) AS OnTheBench, SUM(s.YellowCards) AS YellowCards, SUM(s.RedCards) AS RedCards, PlayerId AS PlayerId
	FROM [Stats] s JOIN Player p ON s.PlayerId = p.Id JOIN Game g ON s.GameId = g.Id
	WHERE g.DateTime >= @StartingDay AND g.DateTime <= @EndingDay AND g.Serie = @Leagues AND (LastName LIKE '%' + @Player + '%' OR FirstName LIKE '%' + @Player + '%')
	GROUP BY p.FirstName, p.LastName, s.PlayerId
	ORDER BY Goals DESC
END
IF (@Leagues = 'ALL' AND @Opponents != 'All' AND @Player != '')
BEGIN
	SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals, SUM(s.StartingXI + s.SubstitutedIn) AS Games, SUM(s.Assists) AS Assists,
	   SUM(s.PlayedMinutes) AS PlayedMinutes, SUM(s.StartingXI) AS StartingXI, SUM(s.SubstitutedIn) AS SubstitutedIn,
	   SUM(s.OnTheBench) AS OnTheBench, SUM(s.YellowCards) AS YellowCards, SUM(s.RedCards) AS RedCards, PlayerId AS PlayerId
	FROM [Stats] s JOIN Player p ON s.PlayerId = p.Id JOIN Game g ON s.GameId = g.Id JOIN Opponent o ON g.OpponentId = o.Id
	WHERE g.DateTime >= @StartingDay AND g.DateTime <= @EndingDay AND o.Team = @Opponents AND (LastName LIKE '%' + @Player + '%' OR FirstName LIKE '%' + @Player + '%')
	GROUP BY p.FirstName, p.LastName, s.PlayerId
	ORDER BY Goals DESC
END
IF (@Leagues = 'ALL' AND @Opponents = 'All' AND @Player != '')
BEGIN
	SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals, SUM(s.StartingXI + s.SubstitutedIn) AS Games, SUM(s.Assists) AS Assists,
	   SUM(s.PlayedMinutes) AS PlayedMinutes, SUM(s.StartingXI) AS StartingXI, SUM(s.SubstitutedIn) AS SubstitutedIn,
	   SUM(s.OnTheBench) AS OnTheBench, SUM(s.YellowCards) AS YellowCards, SUM(s.RedCards) AS RedCards, PlayerId AS PlayerId
	FROM [Stats] s JOIN Player p ON s.PlayerId = p.Id JOIN Game g ON s.GameId = g.Id
	WHERE g.DateTime >= @StartingDay AND g.DateTime <= @EndingDay AND (LastName LIKE '%' + @Player + '%' OR FirstName LIKE '%' + @Player + '%')
	GROUP BY p.FirstName, p.LastName, s.PlayerId
	ORDER BY Goals DESC
END