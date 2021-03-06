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
PRINT N'Dropping unnamed constraint on [dbo].[2020Friendlystats]...';


GO
ALTER TABLE [dbo].[2020Friendlystats] DROP CONSTRAINT [DF__2020Frien__Goals__43D61337];


GO
PRINT N'Dropping unnamed constraint on [dbo].[2020Friendlystats]...';


GO
ALTER TABLE [dbo].[2020Friendlystats] DROP CONSTRAINT [DF__2020Frien__Assis__44CA3770];


GO
PRINT N'Dropping unnamed constraint on [dbo].[2020Friendlystats]...';


GO
ALTER TABLE [dbo].[2020Friendlystats] DROP CONSTRAINT [DF__2020Frien__Playe__45BE5BA9];


GO
PRINT N'Dropping unnamed constraint on [dbo].[2020Friendlystats]...';


GO
ALTER TABLE [dbo].[2020Friendlystats] DROP CONSTRAINT [DF__2020Frien__Start__46B27FE2];


GO
PRINT N'Dropping unnamed constraint on [dbo].[2020Friendlystats]...';


GO
ALTER TABLE [dbo].[2020Friendlystats] DROP CONSTRAINT [DF__2020Frien__Subst__47A6A41B];


GO
PRINT N'Dropping unnamed constraint on [dbo].[2020Friendlystats]...';


GO
ALTER TABLE [dbo].[2020Friendlystats] DROP CONSTRAINT [DF__2020Frien__OnThe__489AC854];


GO
PRINT N'Dropping unnamed constraint on [dbo].[2020Suomencupstats]...';


GO
ALTER TABLE [dbo].[2020Suomencupstats] DROP CONSTRAINT [DF__2020Suome__Goals__498EEC8D];


GO
PRINT N'Dropping unnamed constraint on [dbo].[2020Suomencupstats]...';


GO
ALTER TABLE [dbo].[2020Suomencupstats] DROP CONSTRAINT [DF__2020Suome__Assis__4A8310C6];


GO
PRINT N'Dropping unnamed constraint on [dbo].[2020Suomencupstats]...';


GO
ALTER TABLE [dbo].[2020Suomencupstats] DROP CONSTRAINT [DF__2020Suome__Playe__4B7734FF];


GO
PRINT N'Dropping unnamed constraint on [dbo].[2020Suomencupstats]...';


GO
ALTER TABLE [dbo].[2020Suomencupstats] DROP CONSTRAINT [DF__2020Suome__Start__4C6B5938];


GO
PRINT N'Dropping unnamed constraint on [dbo].[2020Suomencupstats]...';


GO
ALTER TABLE [dbo].[2020Suomencupstats] DROP CONSTRAINT [DF__2020Suome__Subst__4D5F7D71];


GO
PRINT N'Dropping unnamed constraint on [dbo].[2020Suomencupstats]...';


GO
ALTER TABLE [dbo].[2020Suomencupstats] DROP CONSTRAINT [DF__2020Suome__OnThe__4E53A1AA];


GO
PRINT N'Dropping unnamed constraint on [dbo].[2020Veikkausliigastats]...';


GO
ALTER TABLE [dbo].[2020Veikkausliigastats] DROP CONSTRAINT [DF__2020Veikk__Goals__4F47C5E3];


GO
PRINT N'Dropping unnamed constraint on [dbo].[2020Veikkausliigastats]...';


GO
ALTER TABLE [dbo].[2020Veikkausliigastats] DROP CONSTRAINT [DF__2020Veikk__Assis__503BEA1C];


GO
PRINT N'Dropping unnamed constraint on [dbo].[2020Veikkausliigastats]...';


GO
ALTER TABLE [dbo].[2020Veikkausliigastats] DROP CONSTRAINT [DF__2020Veikk__Playe__51300E55];


GO
PRINT N'Dropping unnamed constraint on [dbo].[2020Veikkausliigastats]...';


GO
ALTER TABLE [dbo].[2020Veikkausliigastats] DROP CONSTRAINT [DF__2020Veikk__Start__5224328E];


GO
PRINT N'Dropping unnamed constraint on [dbo].[2020Veikkausliigastats]...';


GO
ALTER TABLE [dbo].[2020Veikkausliigastats] DROP CONSTRAINT [DF__2020Veikk__Subst__531856C7];


GO
PRINT N'Dropping unnamed constraint on [dbo].[2020Veikkausliigastats]...';


GO
ALTER TABLE [dbo].[2020Veikkausliigastats] DROP CONSTRAINT [DF__2020Veikk__OnThe__540C7B00];


GO
PRINT N'Dropping [dbo].[FK_2020FriendlyStats_Player]...';


GO
ALTER TABLE [dbo].[2020Friendlystats] DROP CONSTRAINT [FK_2020FriendlyStats_Player];


GO
PRINT N'Dropping [dbo].[FK_2020SuomencupStats_Player]...';


GO
ALTER TABLE [dbo].[2020Suomencupstats] DROP CONSTRAINT [FK_2020SuomencupStats_Player];


GO
PRINT N'Dropping [dbo].[FK_2020VeikkausliigaStats_Player]...';


GO
ALTER TABLE [dbo].[2020Veikkausliigastats] DROP CONSTRAINT [FK_2020VeikkausliigaStats_Player];


GO
PRINT N'Starting rebuilding table [dbo].[2020Friendlystats]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_2020Friendlystats] (
    [PlayerId]      INT NOT NULL,
    [Goals]         INT DEFAULT 0 NULL,
    [Assists]       INT DEFAULT 0 NULL,
    [YellowCards]   INT DEFAULT 0 NULL,
    [RedCards]      INT DEFAULT 0 NULL,
    [PlayedMinutes] INT DEFAULT 0 NULL,
    [StartingXI]    INT DEFAULT 0 NULL,
    [SubstitutedIn] INT DEFAULT 0 NULL,
    [OnTheBench]    INT DEFAULT 0 NULL,
    PRIMARY KEY CLUSTERED ([PlayerId] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[2020Friendlystats])
    BEGIN
        INSERT INTO [dbo].[tmp_ms_xx_2020Friendlystats] ([PlayerId], [Goals], [Assists], [PlayedMinutes], [StartingXI], [SubstitutedIn], [OnTheBench])
        SELECT   [PlayerId],
                 [Goals],
                 [Assists],
                 [PlayedMinutes],
                 [StartingXI],
                 [SubstitutedIn],
                 [OnTheBench]
        FROM     [dbo].[2020Friendlystats]
        ORDER BY [PlayerId] ASC;
    END

DROP TABLE [dbo].[2020Friendlystats];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_2020Friendlystats]', N'2020Friendlystats';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
PRINT N'Starting rebuilding table [dbo].[2020Suomencupstats]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_2020Suomencupstats] (
    [PlayerId]      INT NOT NULL,
    [Goals]         INT DEFAULT 0 NULL,
    [Assists]       INT DEFAULT 0 NULL,
    [YellowCards]   INT DEFAULT 0 NULL,
    [RedCards]      INT DEFAULT 0 NULL,
    [PlayedMinutes] INT DEFAULT 0 NULL,
    [StartingXI]    INT DEFAULT 0 NULL,
    [SubstitutedIn] INT DEFAULT 0 NULL,
    [OnTheBench]    INT DEFAULT 0 NULL,
    PRIMARY KEY CLUSTERED ([PlayerId] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[2020Suomencupstats])
    BEGIN
        INSERT INTO [dbo].[tmp_ms_xx_2020Suomencupstats] ([PlayerId], [Goals], [Assists], [PlayedMinutes], [StartingXI], [SubstitutedIn], [OnTheBench])
        SELECT   [PlayerId],
                 [Goals],
                 [Assists],
                 [PlayedMinutes],
                 [StartingXI],
                 [SubstitutedIn],
                 [OnTheBench]
        FROM     [dbo].[2020Suomencupstats]
        ORDER BY [PlayerId] ASC;
    END

DROP TABLE [dbo].[2020Suomencupstats];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_2020Suomencupstats]', N'2020Suomencupstats';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
PRINT N'Starting rebuilding table [dbo].[2020Veikkausliigastats]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_2020Veikkausliigastats] (
    [PlayerId]      INT NOT NULL,
    [Goals]         INT DEFAULT 0 NULL,
    [Assists]       INT DEFAULT 0 NULL,
    [YellowCards]   INT DEFAULT 0 NULL,
    [RedCards]      INT DEFAULT 0 NULL,
    [PlayedMinutes] INT DEFAULT 0 NULL,
    [StartingXI]    INT DEFAULT 0 NULL,
    [SubstitutedIn] INT DEFAULT 0 NULL,
    [OnTheBench]    INT DEFAULT 0 NULL,
    PRIMARY KEY CLUSTERED ([PlayerId] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[2020Veikkausliigastats])
    BEGIN
        INSERT INTO [dbo].[tmp_ms_xx_2020Veikkausliigastats] ([PlayerId], [Goals], [Assists], [PlayedMinutes], [StartingXI], [SubstitutedIn], [OnTheBench])
        SELECT   [PlayerId],
                 [Goals],
                 [Assists],
                 [PlayedMinutes],
                 [StartingXI],
                 [SubstitutedIn],
                 [OnTheBench]
        FROM     [dbo].[2020Veikkausliigastats]
        ORDER BY [PlayerId] ASC;
    END

DROP TABLE [dbo].[2020Veikkausliigastats];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_2020Veikkausliigastats]', N'2020Veikkausliigastats';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
PRINT N'Creating [dbo].[FK_2020FriendlyStats_Player]...';


GO
ALTER TABLE [dbo].[2020Friendlystats] WITH NOCHECK
    ADD CONSTRAINT [FK_2020FriendlyStats_Player] FOREIGN KEY ([PlayerId]) REFERENCES [dbo].[Player] ([Id]);


GO
PRINT N'Creating [dbo].[FK_2020SuomencupStats_Player]...';


GO
ALTER TABLE [dbo].[2020Suomencupstats] WITH NOCHECK
    ADD CONSTRAINT [FK_2020SuomencupStats_Player] FOREIGN KEY ([PlayerId]) REFERENCES [dbo].[Player] ([Id]);


GO
PRINT N'Creating [dbo].[FK_2020VeikkausliigaStats_Player]...';


GO
ALTER TABLE [dbo].[2020Veikkausliigastats] WITH NOCHECK
    ADD CONSTRAINT [FK_2020VeikkausliigaStats_Player] FOREIGN KEY ([PlayerId]) REFERENCES [dbo].[Player] ([Id]);


GO
PRINT N'Refreshing [dbo].[TotalStats2020]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[TotalStats2020]';


GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[2020Friendlystats] WITH CHECK CHECK CONSTRAINT [FK_2020FriendlyStats_Player];

ALTER TABLE [dbo].[2020Suomencupstats] WITH CHECK CHECK CONSTRAINT [FK_2020SuomencupStats_Player];

ALTER TABLE [dbo].[2020Veikkausliigastats] WITH CHECK CHECK CONSTRAINT [FK_2020VeikkausliigaStats_Player];


GO
PRINT N'Update complete.';


GO
