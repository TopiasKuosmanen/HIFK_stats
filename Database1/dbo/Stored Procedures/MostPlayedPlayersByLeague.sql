CREATE PROCEDURE [dbo].[MostPlayedPlayersByLeague]
	@MinutesOrGames VARCHAR(50),
	@League VARCHAR(50)
AS

IF (@League = 'Veikkausliiga')
BEGIN
	IF (@MinutesOrGames = 'Minutes')
	BEGIN
		SELECT p.FirstName, p.LastName, s.PlayedMinutes, (s.StartingXI+s.SubstitutedIn) AS 'PlayedGames'
		FROM [Veikkausliigastats] s join Player p ON s.PlayerId = p.Id
		ORDER BY s.PlayedMinutes
	END
	IF (@MinutesOrGames = 'Games')
	BEGIN
		SELECT p.FirstName, p.LastName, s.PlayedMinutes, (s.StartingXI+s.SubstitutedIn) AS 'PlayedGames'
		FROM [Veikkausliigastats] s JOIN Player p ON s.PlayerId = p.Id
		ORDER BY (s.StartingXI+s.SubstitutedIn)
	END
END

IF (@League = 'Suomen Cup')
BEGIN
	IF (@MinutesOrGames = 'Minutes')
		BEGIN
		SELECT p.FirstName, p.LastName, s.PlayedMinutes, (s.StartingXI+s.SubstitutedIn) AS 'PlayedGames'
		FROM [Suomencupstats] s JOIN Player p ON s.PlayerId = p.Id
		ORDER BY s.PlayedMinutes
	END
	IF (@MinutesOrGames = 'Games')
		BEGIN
		SELECT p.FirstName, p.LastName, s.PlayedMinutes, (s.StartingXI+s.SubstitutedIn) AS 'PlayedGames'
		FROM [Suomencupstats] s JOIN Player p ON s.PlayerId = p.Id
		ORDER BY (s.StartingXI+s.SubstitutedIn)
	END
END

IF (@League = 'Friendly')
BEGIN
	IF (@MinutesOrGames = 'Minutes')
		BEGIN
		SELECT p.FirstName, p.LastName, s.PlayedMinutes, (s.StartingXI+s.SubstitutedIn) AS 'PlayedGames'
		FROM [Friendlystats] s JOIN Player p ON s.PlayerId = p.Id
		ORDER BY s.PlayedMinutes
	END
	IF (@MinutesOrGames = 'Games')
		BEGIN
		SELECT p.FirstName, p.LastName, s.PlayedMinutes, (s.StartingXI+s.SubstitutedIn) AS 'PlayedGames'
		FROM [Friendlystats] s JOIN Player p ON s.PlayerId = p.Id
		ORDER BY (s.StartingXI+s.SubstitutedIn)
	END
END
