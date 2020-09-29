﻿/*
Deployment script for HIFK

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "HIFK"
:setvar DefaultFilePrefix "HIFK"
:setvar DefaultDataPath "C:\Users\Topias Kuosmanen\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB"
:setvar DefaultLogPath "C:\Users\Topias Kuosmanen\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Dropping [dbo].[Tie_Win_Lose_ETW_ETL_PKW_PKL]...';


GO
ALTER TABLE [dbo].[Game] DROP CONSTRAINT [Tie_Win_Lose_ETW_ETL_PKW_PKL];


GO
PRINT N'Creating [dbo].[Tie_Win_Lose_ETW_ETL_PKW_PKL]...';


GO
ALTER TABLE [dbo].[Game] WITH NOCHECK
    ADD CONSTRAINT [Tie_Win_Lose_ETW_ETL_PKW_PKL] CHECK (ResultCode BETWEEN 0 AND 6);


GO
PRINT N'Creating [dbo].[GetOpponentsGoals]...';


GO
CREATE PROCEDURE [dbo].[GetOpponentsGoals]
	@Leagues NVARCHAR(50),
	@Opponents NVARCHAR(50),
	@StartingDay DATETIME,
	@EndingDay DATETIME,
	@Winner BIT,
	@Penalty BIT,
	@Min INT,
	@Max INT
AS
BEGIN
/*IF LEAGUE = ALL*/
IF (@Leagues = 'ALL')
BEGIN
/*100000*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*110000*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*111000*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*111100*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*111110*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*111111*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*101111*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*100111*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*100011*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*100001*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*110100*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*110110*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*110111*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*110101*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*110010*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*110001*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*110011*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*111101*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*111001*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*111011*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*111010*/
IF (@Leagues = 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*100110*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*100100*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*100101*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*100010*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*101110*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*101100*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*101101*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*101000*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*101001*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*101011*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*101010*/
IF (@Leagues = 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
END /*NEXT ELSE IF OPPONENT = ALL*/
ELSE
BEGIN
/*000000*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*010000*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*011000*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*011100*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*011110*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*011111*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*001111*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*000111*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*000011*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*000001*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*010100*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*010110*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*010111*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*010101*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*010010*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*010001*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*010011*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*011101*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*011001*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*011011*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*011010*/
IF (@Leagues != 'All' AND @Opponents != 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*000110*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*000100*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*000101*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*000010*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 0 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*001110*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*001100*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*001101*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 1 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*001000*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*001001*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NOT NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*001011*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
/*001010*/
IF (@Leagues != 'All' AND @Opponents = 'All' AND @Winner = 1 AND @Penalty = 0 AND @Min IS NULL AND @Max IS NOT NULL)
BEGIN
	SELECT G.Id, G.GameID, G.Winner, G.Penalty, G.Minute
FROM OpponentGoal G JOIN Game GA ON G.GameId = GA.Id JOIN Opponent O ON GA.OpponentId = O.Id
WHERE GA.DateTime >= @StartingDay AND GA.DateTime <= @EndingDay AND G.Minute >= @Min AND G.Minute <= @Max AND O.Team = @Opponents AND G.Winner = 1 AND G.Penalty = 0 AND GA.Serie = @Leagues
END
END
END
GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Game] WITH CHECK CHECK CONSTRAINT [Tie_Win_Lose_ETW_ETL_PKW_PKL];


GO
PRINT N'Update complete.';


GO
