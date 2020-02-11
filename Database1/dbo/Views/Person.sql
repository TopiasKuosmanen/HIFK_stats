CREATE VIEW [dbo].[Person]
	AS SELECT p.FirstName, p.LastName, P.BirthDate, FLOOR((CAST (GetDate() AS INTEGER) - CAST(P.BirthDate AS INTEGER)) / 365.25) AS Age
	FROM dbo.Player p
	UNION
	SELECT s.FirstName, s.LastName, s.BirthDate, FLOOR((CAST (GetDate() AS INTEGER) - CAST(S.BirthDate AS INTEGER)) / 365.25) AS Age
	FROM dbo.Staff s

	