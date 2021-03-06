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
PRINT N'Altering [dbo].[ResultsByLeague]...';


GO
ALTER PROCEDURE [dbo].[ResultsByLeague]
	@League NVARCHAR(50),
	@StartingDay DATETIME,
	@EndingDay DATETIME
AS

IF (@StartingDay = 0 AND @EndingDay = 0)
BEGIN
IF (@League = 'All')
BEGIN
	SELECT G.*, O.Team AS 'Opponent', (R.FirstName+' '+R.LastName) AS Referee, DATENAME(WEEKDAY, g.DateTime) AS WeekDay
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id LEFT JOIN REFEREE R ON R.Id = G.RefereeId
	WHERE Result IS NOT NULL
	ORDER BY DateTime DESC
END
ELSE
BEGIN
	SELECT G.*, O.Team AS 'Opponent', (R.FirstName+' '+R.LastName) AS Referee, DATENAME(WEEKDAY, g.DateTime) AS WeekDay
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id LEFT JOIN REFEREE R ON R.Id = G.RefereeId
	WHERE Result IS NOT NULL AND Serie = @League
	ORDER BY DateTime DESC
END
END
ELSE
BEGIN
IF (@League = 'All')
BEGIN
	SELECT G.*, O.Team AS 'Opponent', (R.FirstName+' '+R.LastName) AS Referee, DATENAME(WEEKDAY, g.DateTime) AS WeekDay
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id LEFT JOIN REFEREE R ON R.Id = G.RefereeId
	WHERE Result IS NOT NULL AND G.DateTime >= @StartingDay AND G.DateTime <= @EndingDay
	ORDER BY DateTime DESC
END
ELSE
BEGIN
	SELECT G.*, O.Team AS 'Opponent', (R.FirstName+' '+R.LastName) AS Referee, DATENAME(WEEKDAY, g.DateTime) AS WeekDay
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id LEFT JOIN REFEREE R ON R.Id = G.RefereeId
	WHERE Result IS NOT NULL AND G.DateTime >= @StartingDay AND G.DateTime <= @EndingDay AND Serie = @League
	ORDER BY DateTime DESC
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
