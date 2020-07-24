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
PRINT N'Rename refactoring operation with key 5bd38f6c-b5e5-41ab-b3c8-25c827e72ea2 is skipped, element [dbo].[Goal].[Player] (SqlSimpleColumn) will not be renamed to PlayerId';


GO
PRINT N'Dropping [dbo].[Tie_Win_Lose_ETW_ETL_PKW_PKL]...';


GO
ALTER TABLE [dbo].[Game] DROP CONSTRAINT [Tie_Win_Lose_ETW_ETL_PKW_PKL];


GO
PRINT N'Creating [dbo].[Goal]...';


GO
CREATE TABLE [dbo].[Goal] (
    [Id]       INT           NOT NULL,
    [GameId]   INT           NOT NULL,
    [Goal]     NVARCHAR (10) NOT NULL,
    [Winner]   BIT           NOT NULL,
    [PlayerId] INT           NOT NULL,
    [AssistId] INT           NULL,
    [Penalty]  BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[OpponentGoal]...';


GO
CREATE TABLE [dbo].[OpponentGoal] (
    [Id]      INT           NOT NULL,
    [GameId]  INT           NOT NULL,
    [Goal]    NVARCHAR (10) NOT NULL,
    [Winner]  BIT           NOT NULL,
    [Penalty] BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Tie_Win_Lose_ETW_ETL_PKW_PKL]...';


GO
ALTER TABLE [dbo].[Game] WITH NOCHECK
    ADD CONSTRAINT [Tie_Win_Lose_ETW_ETL_PKW_PKL] CHECK (ResultCode BETWEEN 0 AND 6);


GO
-- Refactoring step to update target server with deployed transaction logs
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '5bd38f6c-b5e5-41ab-b3c8-25c827e72ea2')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('5bd38f6c-b5e5-41ab-b3c8-25c827e72ea2')

GO

GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Game] WITH CHECK CHECK CONSTRAINT [Tie_Win_Lose_ETW_ETL_PKW_PKL];


GO
PRINT N'Update complete.';


GO
