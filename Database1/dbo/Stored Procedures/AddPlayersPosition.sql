CREATE PROCEDURE [dbo].[AddPlayersPosition]
	@PlayerId INT,
	@Position NVARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.Playersposition(PlayerId, PositionId)
	VALUES (@PlayerId, (SELECT DISTINCT P.PositionId
						FROM Position P --JOIN Playersposition B ON P.PositionId = B.PositionId
						WHERE P.Position = @Position )
						)
END

