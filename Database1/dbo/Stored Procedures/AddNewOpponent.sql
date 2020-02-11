CREATE PROCEDURE [dbo].[AddNewOpponent]
	@Team NVARCHAR(50),
	@Stadium NVARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.Opponent (Team, Stadium)
	VALUES (@Team, (SELECT Id
					FROM Stadium
					WHERE Name = @Stadium))
END
