CREATE PROCEDURE [dbo].[GetAllGames]
AS
BEGIN
	SELECT G.*, O.Team AS 'Opponent'
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id
	ORDER BY DateTime
END