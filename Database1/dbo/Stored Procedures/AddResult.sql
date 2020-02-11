CREATE PROCEDURE [dbo].[AddResult]
	@Id INT,
	@Result NVARCHAR(10)
AS
BEGIN
	UPDATE Game
	SET Result = @Result
	WHERE Game.Id = @Id
END
