CREATE PROCEDURE [dbo].[GetPlayersNames]
AS
BEGIN
	SELECT FirstName, LastName
	FROM Player
END