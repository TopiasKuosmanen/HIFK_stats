CREATE PROCEDURE [dbo].[GetGoals]
	@Leagues NVARCHAR(50),
	@Opponents NVARCHAR(50),
	@StartingDay DATETIME,
	@EndingDay DATETIME,
	@Player NVARCHAR(50),
	@Winner BIT,
	@Penalty BIT,
	@Assist NVARCHAR(50),
	@Minute INT
AS
BEGIN
IF (@Leagues != '' AND @Opponents != '' AND @Player != '' AND @Assist != '' AND @Minute IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.Serie = @Leagues AND O.Team = @Opponents AND GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND (P.LastName LIKE '%' + @Player + '%' OR P.FirstName LIKE '%' + @Player + '%') AND 
(A.LastName LIKE '%' + @Player + '%' OR A.FirstName LIKE '%' + @Player + '%') AND G.Winner = @Winner AND G.Penalty = @Penalty AND G.MINUTE = @Minute
END
IF(@Leagues = 'All' AND @Opponents = 'All' AND @Player = '' AND @Assist = '' AND @Minute IS NULL)
BEGIN
SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Winner = @Winner AND G.Penalty = @Penalty
END
END
