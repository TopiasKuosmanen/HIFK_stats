CREATE PROCEDURE [dbo].[AddGoal]
	@GameId INT,
	@Goal NVARCHAR(5),
	@Winner BIT,
	@Player INT,
	@Assist INT,
	@Penalty BIT,
	@Minute INT
AS
BEGIN
	INSERT INTO dbo.Goal (GameId, Goal, Winner, PlayerId, AssistId, Penalty, Minute)
	VALUES (@GameId, @Goal, @Winner, @Player, @Assist, @Penalty, @Minute)
END

