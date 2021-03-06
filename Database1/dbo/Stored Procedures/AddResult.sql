﻿CREATE PROCEDURE [dbo].[AddResult]
	@Id INT,
	@Result NVARCHAR(10),
	@ResultCode INT,
	@Attendance INT,
	@Referee INT
AS
BEGIN
	UPDATE Game
	SET Result = @Result, ResultCode = @ResultCode, Attendance = @Attendance, RefereeId = @Referee
	WHERE Game.Id = @Id
END
