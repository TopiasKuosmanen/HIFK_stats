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
PRINT N'Altering [dbo].[Defender]...';


GO
ALTER VIEW [dbo].[Defender]
	AS SELECT p.FirstName, p.LastName, p.BirthDate, p.Number, p.Id
	FROM Player p
	WHERE p.Id IN (SELECT DISTINCT PlayerId
				   FROM Playersposition
				   WHERE PositionId IN (2,3,4,14,15)
				   )
GO
PRINT N'Altering [dbo].[Goalkeeper]...';


GO
ALTER VIEW [dbo].[Goalkeeper]
	AS SELECT p.FirstName, p.LastName, p.BirthDate, p.Number, p.Id
	FROM Player p
	WHERE p.Id IN (SELECT DISTINCT PlayerId
				   FROM Playersposition
				   WHERE PositionId = 1
				   )
GO
PRINT N'Altering [dbo].[Midfielder]...';


GO
ALTER VIEW [dbo].[Midfielder]
	AS SELECT p.FirstName, p.LastName, p.BirthDate, p.Number, p.Id
	FROM Player p
	WHERE p.Id IN (SELECT DISTINCT PlayerId
				   FROM Playersposition
				   WHERE PositionId IN (5,6,7,8)
				   )
GO
PRINT N'Altering [dbo].[Striker]...';


GO
ALTER VIEW [dbo].[Striker]
	AS SELECT p.FirstName, p.LastName, p.BirthDate, p.Number, p.Id
	FROM Player p
	WHERE p.Id IN (SELECT DISTINCT PlayerId
				   FROM Playersposition
				   WHERE PositionId IN (9, 10, 11, 12, 13)
				   )
GO
PRINT N'Creating [dbo].[PlayerFilterByPosition]...';


GO
CREATE PROCEDURE [dbo].[PlayerFilterByPosition]
	@PlayerPosition NVARCHAR (50)
AS

IF (@PlayerPosition = 'Goalkeeper')
BEGIN
	SELECT p.*, FLOOR((CAST (GETDATE() AS INTEGER) - CAST(p.BirthDate AS INTEGER)) / 365.25) AS Age,
		   s.Goals, s.Assists, (s.StartingXI + s.SubstituTedIn) AS 'Games', s.PlayedMinutes
	FROM Goalkeeper p JOIN dbo.TotalStats2020 s ON s.PlayerId = p.Id
END
IF (@PlayerPosition = 'Defender')
BEGIN
	SELECT p.*, FLOOR((CAST (GETDATE() AS INTEGER) - CAST(p.BirthDate AS INTEGER)) / 365.25) AS Age,
		   s.Goals, s.Assists, (s.StartingXI + s.SubstituTedIn) AS 'Games', s.PlayedMinutes
	FROM Defender p JOIN dbo.TotalStats2020 s ON s.PlayerId = p.Id
END
IF (@PlayerPosition = 'Midfielder')
BEGIN
	SELECT p.*, FLOOR((CAST (GETDATE() AS INTEGER) - CAST(p.BirthDate AS INTEGER)) / 365.25) AS Age,
		   s.Goals, s.Assists, (s.StartingXI + s.SubstituTedIn) AS 'Games', s.PlayedMinutes
	FROM Midfielder p JOIN dbo.TotalStats2020 s ON s.PlayerId = p.Id
END
IF (@PlayerPosition = 'Striker')
BEGIN
	SELECT p.*, FLOOR((CAST (GETDATE() AS INTEGER) - CAST(p.BirthDate AS INTEGER)) / 365.25) AS Age,
		   s.Goals, s.Assists, (s.StartingXI + s.SubstituTedIn) AS 'Games', s.PlayedMinutes
	FROM Striker p JOIN dbo.TotalStats2020 s ON s.PlayerId = p.Id
END
GO
PRINT N'Update complete.';


GO
