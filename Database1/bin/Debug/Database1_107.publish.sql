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
PRINT N'Altering [dbo].[BestScorersByLeague]...';


GO
ALTER PROCEDURE [dbo].[BestScorersByLeague]
	@League NVARCHAR(50)
AS

IF (@League = 'Veikkausliiga')
BEGIN
	SELECT p.FirstName, p.LastName, Goals
	FROM [2020Veikkausliigastats] s join Player p ON s.PlayerId = p.Id
	ORDER BY Goals DESC
END
IF (@League = 'Suomen Cup')
BEGIN
	SELECT p.FirstName, p.LastName, Goals
	FROM [2020Suomencupstats] s join Player p ON s.PlayerId = p.Id
	ORDER BY Goals DESC
END
IF (@League = 'Friendly')
BEGIN
	SELECT p.FirstName, p.LastName, Goals
	FROM [2020Friendlystats] s JOIN Player p ON s.PlayerId = p.Id
	ORDER BY Goals DESC
END
IF (@League = 'All')
BEGIN
	SELECT p.FirstName, p.LastName, Goals
	FROM TotalStats2020 s join Player p ON s.PlayerId = p.Id
	ORDER BY Goals DESC
END
GO
PRINT N'Update complete.';


GO
