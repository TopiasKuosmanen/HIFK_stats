CREATE TABLE [dbo].[Game] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [OpponentId] INT           NOT NULL,
    [DateTime]   DATETIME      NULL,
    [Serie]      NVARCHAR (50) NOT NULL,
    [Result]     NVARCHAR (10) NULL,
    [Stadion]    NVARCHAR (50) NULL,
    [Home_match] BIT           NOT NULL,
	[Extra_time] BIT		   NULL,
	[Penalties]  BIT		   NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
   -- CONSTRAINT [CK_Game_Serie] CHECK (([Serie]) IN (CheckLeague()))
);

