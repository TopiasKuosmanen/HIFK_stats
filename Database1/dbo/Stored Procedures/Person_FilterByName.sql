CREATE PROCEDURE [dbo].[Person_FilterByName]
	@Name NVARCHAR (50)
AS
BEGIN
	SELECT p.Id, p.FirstName, p.LastName, P.BirthDate, FLOOR((CAST (GetDate() AS INTEGER) - CAST(P.BirthDate AS INTEGER)) / 365.25) AS Age
	FROM dbo.Player p
	WHERE P.LastName LIKE '%' + @Name + '%' OR P.FirstName LIKE '%' + @Name + '%'
	UNION
	SELECT s.Id, s.FirstName, s.LastName, s.BirthDate, FLOOR((CAST (GETDATE() AS INTEGER) - CAST(S.BirthDate AS INTEGER)) / 365.25) AS Age
	FROM dbo.Staff s
	WHERE S.LastName LIKE '%' + @Name + '%' OR S.FirstName LIKE '%' + @Name + '%'
	ORDER BY LastName
END