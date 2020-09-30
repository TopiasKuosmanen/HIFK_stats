CREATE PROCEDURE [dbo].[AddOpponentsGoal]
	@GameId INT,
	@Goal NVARCHAR(5),
	@Winner BIT,
	@Penalty BIT,
	@Minute INT
AS
BEGIN
	INSERT INTO dbo.OpponentGoal (GameId, Score, Winner, Penalty, Minute)
	VALUES (@GameId, @Goal, @Winner, @Penalty, @Minute)
END