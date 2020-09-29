CREATE PROCEDURE [dbo].[GetOpponentsGoals]
	@Leagues NVARCHAR(50),
	@Opponents NVARCHAR(50),
	@StartingDay DATETIME,
	@EndingDay DATETIME,
	@Winner BIT,
	@Penalty BIT,
	@Min INT,
	@Max INT
AS
BEGIN
/*IF LEAGUE = ALL*/
IF (@Leagues = 'ALL')
BEGIN
/*100000*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max
END
/*110000*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents 
END
/*111000*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1
END
/*111100*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0
END
/*111110*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0
END
/*111111*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0
END
/*101111*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Winner = 1 AND G.Penalty = 0
END
/*100111*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Penalty = 0
END
/*100011*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay
END
/*100001*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min
END
/*110100*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Penalty = 0
END
/*110110*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute <= @Max AND O.Team = @Opponents AND G.Penalty = 0
END
/*110111*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND O.Team = @Opponents AND G.Penalty = 0
END
/*110101*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND O.Team = @Opponents AND G.Penalty = 0
END
/*110010*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute <= @Max AND O.Team = @Opponents
END
/*110001*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND O.Team = @Opponents
END
/*110011*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND O.Team = @Opponents
END
/*111101*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0
END
/*111001*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND O.Team = @Opponents AND G.Winner = 1
END
/*111011*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND O.Team = @Opponents AND G.Winner = 1
END
/*111010*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND O.Team = @Opponents AND G.Winner = 1 AND G.Minute <= @Max
END
/*100110*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute <= @Max AND G.Penalty = 0
END
/*100100*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Penalty = 0 AND G.Minute >= @Min AND G.Minute <= @Max
END
/*100101*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Penalty = 0 AND G.Minute >= @Min
END
/*100010*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute <= @Max
END
/*101110*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute <= @Max AND G.Penalty = 0 AND G.Winner = 1
END
/*101100*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute <= @Max AND G.Penalty = 0 AND G.Winner = 1 AND G.Minute >= @Min
END
/*101101*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Penalty = 0 AND G.Winner = 1 AND G.Minute >= @Min
END
/*101000*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Winner = 1 AND G.Minute >= @Min AND G.Minute <= @Max
END
/*101001*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Winner = 1 AND G.Minute >= @Min
END
/*101011*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Winner = 1
END
/*101010*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Winner = 1 AND G.Minute <= @Max
END
END /*NEXT ELSE IF OPPONENT = ALL*/
ELSE
BEGIN
/*000000*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND GA.Serie = @Leagues
END
/*010000*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents  AND GA.Serie = @Leagues
END
/*011000*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND GA.Serie = @Leagues
END
/*011100*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*011110*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*011111*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*001111*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*000111*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*000011*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND GA.Serie = @Leagues
END
/*000001*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND GA.Serie = @Leagues
END
/*010100*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*010110*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute <= @Max AND O.Team = @Opponents AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*010111*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND O.Team = @Opponents AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*010101*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND O.Team = @Opponents AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*010010*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute <= @Max AND O.Team = @Opponents AND GA.Serie = @Leagues
END
/*010001*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND O.Team = @Opponents AND GA.Serie = @Leagues
END
/*010011*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND O.Team = @Opponents AND GA.Serie = @Leagues
END
/*011101*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*011001*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND O.Team = @Opponents AND G.Winner = 1 AND GA.Serie = @Leagues
END
/*011011*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND O.Team = @Opponents AND G.Winner = 1 AND GA.Serie = @Leagues
END
/*011010*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND O.Team = @Opponents AND G.Winner = 1 AND G.Minute <= @Max AND GA.Serie = @Leagues
END
/*000110*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute <= @Max AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*000100*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Penalty = 0 AND G.Minute >= @Min AND G.Minute <= @Max AND GA.Serie = @Leagues
END
/*000101*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Penalty = 0 AND G.Minute >= @Min AND GA.Serie = @Leagues
END
/*000010*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute <= @Max AND GA.Serie = @Leagues
END
/*001110*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute <= @Max AND G.Penalty = 0 AND G.Winner = 1 AND GA.Serie = @Leagues
END
/*001100*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute <= @Max AND G.Penalty = 0 AND G.Winner = 1 AND G.Minute >= @Min AND GA.Serie = @Leagues
END
/*001101*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Penalty = 0 AND G.Winner = 1 AND G.Minute >= @Min AND GA.Serie = @Leagues
END
/*001000*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Winner = 1 AND G.Minute >= @Min AND G.Minute <= @Max AND GA.Serie = @Leagues
END
/*001001*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Winner = 1 AND G.Minute >= @Min AND GA.Serie = @Leagues
END
/*001011*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Winner = 1 AND GA.Serie = @Leagues
END
/*001010*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute, A.FirstName AS AssistFirstName, A.LastName AS AssistLastName
FROM Goal G JOIN Player P ON P.Id = G.PlayerId LEFT JOIN (SELECT G.Id, G.GameID, P.FirstName, P.LastName, G.Winner, G.Penalty, G.Minute
FROM Goal G JOIN Player P ON P.Id = G.AssistId) A ON A.Id = G.Id JOIN Game GA ON GA.Id = G.GameId JOIN Opponent O ON O.Id = GA.OpponentId
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Winner = 1 AND G.Minute <= @Max AND GA.Serie = @Leagues
END
END
END