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
PRINT N'Creating [dbo].[GetPlayersNationalities]...';


GO
CREATE PROCEDURE [dbo].[GetPlayersNationalities]
	@Id INT
AS
BEGIN
	SELECT P.Position
	FROM Position P JOIN Playersposition X ON P.PositionId = X.PositionId
	WHERE X.PlayerId = @Id
END
GO
PRINT N'Creating [dbo].[GetPlayersPositions]...';


GO
CREATE PROCEDURE [dbo].[GetPlayersPositions]
	@Id INT
AS
BEGIN
	SELECT N.Nationality
	FROM Nationality N JOIN PlayersNationality P ON P.NationalityId = N.NationalityId
	WHERE P.PlayerId = @Id
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
