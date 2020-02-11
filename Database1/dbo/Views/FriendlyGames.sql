CREATE VIEW [dbo].[FriendlyGames]
	AS 
	SELECT g.Id, g.DateTime, g.Serie, g.Result, g.Stadion, g.Home_match, o.Team AS 'Opponent'
	FROM Game g JOIN Opponent o ON g.OpponentId = o.Id
	WHERE g.Serie = 'Friendly'
