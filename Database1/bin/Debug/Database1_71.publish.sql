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
PRINT N'Altering [dbo].[TotalStats2020]...';


GO
ALTER VIEW [dbo].[TotalStats2020]
	AS 
	SELECT F.PlayerId, (F.Goals + S.Goals + V.Goals) AS Goals, 
		   (F.Assists + S.Assists + V.Assists) AS Assists,
		   (F.PlayedMinutes + S.PlayedMinutes + V.PlayedMinutes) AS PlayedMinutes,
		   (F.StartingXI + S.StartingXI + V.StartingXI) AS StartingXI,
		   (F.SubstitutedIn + S.SubstitutedIn + V.SubstitutedIn) AS SubstituTedIn,
		   (F.OnTheBench + S.OnTheBench + V.OnTheBench) AS OnTheBench 
	FROM [2020Friendlystats] F 
	JOIN [2020Suomencupstats] S ON F.PlayerId = S.PlayerId 
	JOIN [2020Veikkausliigastats] V ON F.PlayerId = V.PlayerId
	GROUP BY F.PlayerId
GO
PRINT N'Update complete.';


GO
