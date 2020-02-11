CREATE VIEW [dbo].[Midfielder]
	AS SELECT p.FirstName, p.LastName, p.BirthDate, p.Number, p.Id
	FROM Player p
	WHERE p.Id IN (SELECT DISTINCT PlayerId
				   FROM Playersposition
				   WHERE PositionId IN (5,6,7,8)
				   )
                   