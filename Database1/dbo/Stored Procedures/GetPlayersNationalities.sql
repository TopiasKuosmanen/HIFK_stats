CREATE PROCEDURE [dbo].[GetPlayersNationalities]
	@Id INT
AS
BEGIN
	SELECT N.Nationality
	FROM Nationality N JOIN PlayersNationality P ON P.NationalityId = N.NationalityId
	WHERE P.PlayerId = @Id
END
