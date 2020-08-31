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
PRINT N'Altering [dbo].[GetAllStats]...';


GO
ALTER PROCEDURE [dbo].[GetAllStats]
	@League NVARCHAR(50),
	@Year INT
AS

IF (@Year = 0 AND @League <> 'All')
BEGIN
	SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals, SUM(s.StartingXI + s.SubstitutedIn) AS Games, SUM(s.Assists) AS Assists,
	   SUM(s.PlayedMinutes) AS PlayedMinutes, SUM(s.StartingXI) AS StartingXI, SUM(s.SubstitutedIn) AS SubstitutedIn,
	   SUM(s.OnTheBench) AS OnTheBench, SUM(s.YellowCards) AS YellowCards, SUM(s.RedCards) AS RedCards, p.Id AS PlayerId
	FROM [Stats] s JOIN Player p ON s.PlayerId = p.Id
	WHERE s.LeagueId = (SELECT Id FROM League WHERE LeagueName = @League)
	GROUP BY p.FirstName, p.LastName, p.Id
	ORDER BY Goals DESC
END
IF (@League = 'All' AND @Year = 0)
BEGIN
	SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals, SUM(s.StartingXI + s.SubstitutedIn) AS Games, SUM(s.Assists) AS Assists,
	   SUM(s.PlayedMinutes) AS PlayedMinutes, SUM(s.StartingXI) AS StartingXI, SUM(s.SubstitutedIn) AS SubstitutedIn,
	   SUM(s.OnTheBench) AS OnTheBench, SUM(s.YellowCards) AS YellowCards, SUM(s.RedCards) AS RedCards, p.Id AS PlayerId
	FROM [Stats] s JOIN Player p ON s.PlayerId = p.Id
	GROUP BY p.FirstName, p.LastName, p.Id
	ORDER BY Goals DESC
END

IF (@Year <> 0)
BEGIN
	IF (@League = 'All')
	BEGIN
		SELECT FirstName, LastName, SUM(Games) AS Games, SUM(Goals) AS Goals, SUM(Assists) AS Assists,
		SUM(PlayedMinutes) AS PlayedMinutes, SUM(StartingXI) AS StartingXI, SUM(SubstitutedIn) AS SubstitutedIn,
		SUM(OnTheBench) AS OnTheBench, SUM(YellowCards) AS YellowCards, SUM(RedCards) AS RedCards, PlayerId AS PlayerId
	    FROM
		(
			SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals, SUM(s.StartingXI + s.SubstitutedIn) AS Games, SUM(s.Assists) AS Assists,
			SUM(s.PlayedMinutes) AS PlayedMinutes, SUM(s.StartingXI) AS StartingXI, SUM(s.SubstitutedIn) AS SubstitutedIn,
			SUM(s.OnTheBench) AS OnTheBench, SUM(s.YellowCards) AS YellowCards, SUM(s.RedCards) AS RedCards, p.Id AS PlayerId
			FROM [Stats] s JOIN Player p ON s.PlayerId = p.Id
			WHERE s.GameId IN (SELECT Id
					   FROM Game
					   WHERE YEAR(Game.DateTime) = @Year
					   )
			GROUP BY p.FirstName, p.LastName, p.Id
		) AS p
		GROUP BY FirstName, LastName
	END
	ELSE
	BEGIN
		SELECT p.FirstName, p.LastName, SUM(s.Goals) AS Goals, SUM(s.StartingXI + s.SubstitutedIn) AS Games, SUM(s.Assists) AS Assists,
	   SUM(s.PlayedMinutes) AS PlayedMinutes, SUM(s.StartingXI) AS StartingXI, SUM(s.SubstitutedIn) AS SubstitutedIn,
	   SUM(s.OnTheBench) AS OnTheBench, SUM(s.YellowCards) AS YellowCards, SUM(s.RedCards) AS RedCards, p.Id AS PlayerId
	FROM [Stats] s JOIN Player p ON s.PlayerId = p.Id
	WHERE s.GameId IN (SELECT Id
					   FROM Game
					   WHERE YEAR(Game.DateTime) = @Year
					   ) AND s.LeagueId = (SELECT Id FROM League WHERE LeagueName = @League)
	GROUP BY p.FirstName, p.LastName, p.Id
	ORDER BY Goals DESC
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
