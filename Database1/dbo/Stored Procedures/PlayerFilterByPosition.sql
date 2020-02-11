CREATE PROCEDURE [dbo].[PlayerFilterByPosition]
	@PlayerPosition NVARCHAR (50)
AS

IF (@PlayerPosition = 'Goalkeeper')
BEGIN
	SELECT p.*, FLOOR((CAST (GETDATE() AS INTEGER) - CAST(p.BirthDate AS INTEGER)) / 365.25) AS Age,
		   s.Goals, s.Assists, (s.StartingXI + s.SubstituTedIn) AS 'Games', s.PlayedMinutes
	FROM Goalkeeper p JOIN dbo.TotalStats2020 s ON s.PlayerId = p.Id
END
IF (@PlayerPosition = 'Defender')
BEGIN
	SELECT p.*, FLOOR((CAST (GETDATE() AS INTEGER) - CAST(p.BirthDate AS INTEGER)) / 365.25) AS Age,
		   s.Goals, s.Assists, (s.StartingXI + s.SubstituTedIn) AS 'Games', s.PlayedMinutes
	FROM Defender p JOIN dbo.TotalStats2020 s ON s.PlayerId = p.Id
END
IF (@PlayerPosition = 'Midfielder')
BEGIN
	SELECT p.*, FLOOR((CAST (GETDATE() AS INTEGER) - CAST(p.BirthDate AS INTEGER)) / 365.25) AS Age,
		   s.Goals, s.Assists, (s.StartingXI + s.SubstituTedIn) AS 'Games', s.PlayedMinutes
	FROM Midfielder p JOIN dbo.TotalStats2020 s ON s.PlayerId = p.Id
END
IF (@PlayerPosition = 'Striker')
BEGIN
	SELECT p.*, FLOOR((CAST (GETDATE() AS INTEGER) - CAST(p.BirthDate AS INTEGER)) / 365.25) AS Age,
		   s.Goals, s.Assists, (s.StartingXI + s.SubstituTedIn) AS 'Games', s.PlayedMinutes
	FROM Striker p JOIN dbo.TotalStats2020 s ON s.PlayerId = p.Id
END