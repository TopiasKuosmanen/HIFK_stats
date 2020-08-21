CREATE PROCEDURE [dbo].[GamesOnThisDay]
AS
BEGIN
	SELECT o.Team AS Opponent, g.OpponentId, g.DateTime, DATENAME(WEEKDAY, g.DateTime) AS WeekDay, g.Serie, g.Result, g.Stadion, g.Home_match, g.ResultCode, g.Attendance, (r.FirstName + ' ' + r.LastName) AS Referee
	FROM Game g JOIN Opponent o ON g.OpponentId = o.Id LEFT JOIN Referee r ON g.RefereeId = r.Id
	WHERE DAY(DateTime) = DAY(GETDATE())+1 AND MONTH(DateTime) = MONTH(GETDATE()) AND YEAR(DateTime) != YEAR(GETDATE())
END
