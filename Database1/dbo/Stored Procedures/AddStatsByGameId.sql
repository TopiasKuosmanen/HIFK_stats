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
IF @League = 'Veikkausliiga'
BEGIN
	UPDATE [Veikkausliigastats] 
	SET Goals = @Goals, Assists = @Assists, YellowCards = @YellowCards, RedCards = @RedCards, PlayedMinutes = @PlayedMinutes,
		StartingXI = @StartingXI, SubstitutedIn = @SubstitutedIn, OnTheBench = @OnTheBench
	WHERE GameId = @GameId AND PlayerId = @PlayerId

END
IF @League = 'Suomen Cup'
BEGIN
	UPDATE [Suomencupstats]
	SET Goals = @Goals, Assists = @Assists, YellowCards = @YellowCards, RedCards = @RedCards, PlayedMinutes = @PlayedMinutes,
		StartingXI = @StartingXI, SubstitutedIn = @SubstitutedIn, OnTheBench = @OnTheBench
	WHERE GameId = @GameId AND PlayerId = @PlayerId
END
IF @League = 'Friendly'
BEGIN
	UPDATE [Friendlystats] 
	SET Goals = @Goals, Assists = @Assists, YellowCards = @YellowCards, RedCards = @RedCards, PlayedMinutes = @PlayedMinutes,
		StartingXI = @StartingXI, SubstitutedIn = @SubstitutedIn, OnTheBench = @OnTheBench
	WHERE GameId = @GameId AND PlayerId = @PlayerId
END


