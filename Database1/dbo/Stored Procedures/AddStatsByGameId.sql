CREATE PROCEDURE [dbo].[AddStatsByGameId]
	@League NVARCHAR(50),
	@PlayerId INT,
	@GameId INT,
	@Goals INT,
	@Assists INT,
	@YellowCards INT,
	@RedCards INT,
	@PlayedMinutes INT,
	@StartingXI INT,
	@SubstitutedIn INT,
	@OnTheBench INT
AS
BEGIN
	UPDATE [Stats] 
	SET Goals = @Goals, Assists = @Assists, YellowCards = @YellowCards, RedCards = @RedCards, PlayedMinutes = @PlayedMinutes,
		StartingXI = @StartingXI, SubstitutedIn = @SubstitutedIn, OnTheBench = @OnTheBench
	WHERE GameId = @GameId AND PlayerId = @PlayerId AND LeagueId = (SELECT Id FROM League WHERE LeagueName = @League)
END
