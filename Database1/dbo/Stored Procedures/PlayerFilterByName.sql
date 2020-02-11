CREATE PROCEDURE [dbo].[Player_FilterByName]
	@PlayerName NVARCHAR (50)
AS
BEGIN
	SELECT p.Id, p.FirstName, p.LastName, p.BirthDate, FLOOR((CAST (GETDATE() AS INTEGER) - CAST(p.BirthDate AS INTEGER)) / 365.25) AS Age,
		   s.Goals, s.Assists, (s.StartingXI + s.SubstituTedIn) AS 'Games', s.PlayedMinutes
	FROM dbo.Player p JOIN dbo.TotalStats2020 s ON s.PlayerId = p.Id
	WHERE p.LastName LIKE '%' + @PlayerName + '%' OR p.FirstName LIKE '%' + @PlayerName + '%'
	AND ContractEndDate > GETDATE()
	ORDER BY LastName
END