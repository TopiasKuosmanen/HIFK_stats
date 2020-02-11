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
PRINT N'Altering [dbo].[Staff]...';


GO
ALTER TABLE [dbo].[Staff] ALTER COLUMN [BirthDate] DATETIME NULL;


GO
PRINT N'Altering [dbo].[Person]...';


GO
ALTER VIEW [dbo].[Person]
	AS SELECT p.FirstName, p.LastName, P.BirthDate, FLOOR((CAST (GetDate() AS INTEGER) - CAST(P.BirthDate AS INTEGER)) / 365.25) AS Age
	FROM dbo.Player p
	UNION
	SELECT s.FirstName, s.LastName, s.BirthDate, FLOOR((CAST (GetDate() AS INTEGER) - CAST(S.BirthDate AS INTEGER)) / 365.25) AS Age
	FROM dbo.Staff s
GO
PRINT N'Refreshing [dbo].[Person_FilterByLastName]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[Person_FilterByLastName]';


GO
PRINT N'Update complete.';


GO
