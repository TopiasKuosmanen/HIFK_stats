CREATE PROCEDURE [dbo].[AddPlayersPosition]
	@PlayerId INT,
	@Position NVARCHAR(50)
AS
BEGIN
	DELETE FROM dbo.Playersposition WHERE PlayerId = @PlayerId
	INSERT INTO dbo.Playersposition(PlayerId, PositionId)
	VALUES (@PlayerId, (SELECT DISTINCT P.PositionId
						FROM Position P 
						WHERE P.Position = @Position )
						)
END

