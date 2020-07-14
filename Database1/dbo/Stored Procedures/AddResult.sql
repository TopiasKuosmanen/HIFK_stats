CREATE PROCEDURE [dbo].[AddResult]
	@Id INT,
	@Result NVARCHAR(10),
	@ResultCode INT
AS
BEGIN
	UPDATE Game
	SET Result = @Result, ResultCode = @ResultCode
	WHERE Game.Id = @Id
END
