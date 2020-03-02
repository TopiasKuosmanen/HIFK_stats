CREATE PROCEDURE [dbo].[GetPlayersPositions]
	@Id INT
AS
BEGIN
	SELECT P.Position
	FROM Position P JOIN Playersposition X ON P.PositionId = X.PositionId
	WHERE X.PlayerId = @Id
END