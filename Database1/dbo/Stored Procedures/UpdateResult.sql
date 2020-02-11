CREATE PROCEDURE [dbo].[UpdateResult]
	@GameId INT,
	@Result NVARCHAR(10)

AS
BEGIN
	UPDATE Game
	SET Result = @Result
	WHERE Id = @GameId
END