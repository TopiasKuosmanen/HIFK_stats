CREATE TABLE [dbo].[Playersposition]
(
	[PlayerId] INT NOT NULL, 
    [PositionId] INT NOT NULL,  
    CONSTRAINT [FK_Playersposition_Position] FOREIGN KEY (PositionId) REFERENCES [Position]
)
