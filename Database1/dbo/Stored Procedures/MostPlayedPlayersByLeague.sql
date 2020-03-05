CREATE PROCEDURE [dbo].[MostPlayedPlayersByLeague]
	@MinutesOrGames VARCHAR(50),
	@League VARCHAR(50)
AS


BEGIN
	IF (@League = 'ALL')
	BEGIN
		IF (@MinutesOrGames = 'Minutes')
		BEGIN
		SELECT p.FirstName, p.LastName, s.PlayedMinutes, (s.StartingXI+s.SubstitutedIn) AS 'PlayedGames'
		FROM [Stats] s JOIN Player p ON s.PlayerId = p.Id
		ORDER BY s.PlayedMinutes
	END
	IF (@MinutesOrGames = 'Games')
		BEGIN
		SELECT p.FirstName, p.LastName, s.PlayedMinutes, (s.StartingXI+s.SubstitutedIn) AS 'PlayedGames'
		FROM [stats] s JOIN Player p ON s.PlayerId = p.Id
		ORDER BY (s.StartingXI+s.SubstitutedIn)
	END
	END
	ELSE
	IF (@MinutesOrGames = 'Minutes')
		BEGIN
		SELECT p.FirstName, p.LastName, s.PlayedMinutes, (s.StartingXI+s.SubstitutedIn) AS 'PlayedGames'
		FROM [Stats] s JOIN Player p ON s.PlayerId = p.Id
		WHERE s.LeagueId = (SELECT Id FROM League WHERE LeagueName = @League)
		ORDER BY s.PlayedMinutes
	END
	IF (@MinutesOrGames = 'Games')
		BEGIN
		SELECT p.FirstName, p.LastName, s.PlayedMinutes, (s.StartingXI+s.SubstitutedIn) AS 'PlayedGames'
		FROM [stats] s JOIN Player p ON s.PlayerId = p.Id
		WHERE s.LeagueId = (SELECT Id FROM League WHERE LeagueName = @League)
		ORDER BY (s.StartingXI+s.SubstitutedIn)
	END
END
