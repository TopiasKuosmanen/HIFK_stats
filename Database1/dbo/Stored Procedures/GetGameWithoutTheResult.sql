CREATE PROCEDURE [dbo].[GetGameWithoutTheResult]
AS
BEGIN
	SELECT G.*, O.Team AS 'Opponent'
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id
	WHERE DateTime <= CURRENT_TIMESTAMP AND Result IS NULL
END