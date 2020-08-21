CREATE PROCEDURE [dbo].[BirthdayProcedure]
AS
BEGIN
	SELECT (YEAR(GETDATE()) - YEAR(p.BirthDate)) AS Age, p.FirstName, p.LastName, n.Nationality
	FROM Player p JOIN PlayersNationality pn ON p.Id = pn.PlayerId JOIN Nationality n ON n.NationalityId = pn.NationalityId
	WHERE DAY(p.BirthDate) = DAY(GETDATE()) AND MONTH(p.BirthDate) = MONTH(GETDATE())
END