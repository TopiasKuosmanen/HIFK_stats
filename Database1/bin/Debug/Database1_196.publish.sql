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
PRINT N'Dropping [dbo].[CK_Game_Serie]...';


GO
ALTER TABLE [dbo].[Game] DROP CONSTRAINT [CK_Game_Serie];


GO
PRINT N'Creating [dbo].[CK_Game_Serie]...';


GO
ALTER TABLE [dbo].[Game] WITH NOCHECK
    ADD CONSTRAINT [CK_Game_Serie] CHECK (Serie IN ('Veikkausliiga', 'Suomen Cup', 'Friendly'));


GO
PRINT N'Altering [dbo].[FixturesByLeague]...';


GO
ALTER PROCEDURE [dbo].[FixturesByLeague]
	@League NVARCHAR(50),
	@Year NVARCHAR(5)
AS

IF (@Year = 0)
BEGIN
IF (@League = 'Veikkausliiga')
BEGIN
	SELECT G.*, O.Team AS 'Opponent'
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id
	WHERE Result IS NULL AND Serie = 'Veikkausliiga'
	ORDER BY DateTime
END
IF (@League = 'Suomen Cup')
BEGIN
	SELECT G.*, O.Team AS 'Opponent'
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id
	WHERE Result IS NULL AND Serie = 'Suomen Cup'
	ORDER BY DateTime
END
IF (@League = 'Friendly')
BEGIN
	SELECT G.*, O.Team AS 'Opponent'
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id
	WHERE Result IS NULL AND Serie = 'Friendly'
	ORDER BY DateTime
END
IF (@League = 'All')
BEGIN
	SELECT G.*, O.Team AS 'Opponent'
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id
	WHERE Result IS NULL
	ORDER BY DateTime
	
END
END
ELSE
BEGIN
IF (@League = 'Veikkausliiga')
BEGIN
	SELECT *
	FROM VeikkausliigaGames
	WHERE Result IS NULL AND YEAR(DateTime) = @Year
	ORDER BY DateTime
END
IF (@League = 'Suomen Cup')
BEGIN
	SELECT *
	FROM SuomencupGames
	WHERE Result IS NULL AND YEAR(DateTime) = @Year
	ORDER BY DateTime 
END
IF (@League = 'Friendly')
BEGIN
	SELECT *
	FROM FriendlyGames
	WHERE Result IS NULL
	ORDER BY DateTime
END
IF (@League = 'All')
BEGIN
	SELECT G.*, O.Team AS 'Opponent'
	FROM Game G JOIN Opponent O ON G.OpponentId = O.Id
	WHERE Result IS NULL AND YEAR(G.DateTime) = @Year
	ORDER BY DateTime
	
END
END
GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Game] WITH CHECK CHECK CONSTRAINT [CK_Game_Serie];


GO
PRINT N'Update complete.';


GO
