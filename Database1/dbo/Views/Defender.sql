CREATE VIEW [dbo].[Defender]
	AS SELECT p.FirstName, p.LastName, p.BirthDate, p.Number, p.Id
	FROM Player p
	WHERE p.Id IN (SELECT DISTINCT PlayerId
				   FROM Playersposition
				   WHERE PositionId IN (2,3,4,14,15)
				   )
                   