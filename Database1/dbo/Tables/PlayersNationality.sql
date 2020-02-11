CREATE TABLE [dbo].[PlayersNationality]
(
	[PlayerId] INT NOT NULL, 
    [NationalityId] INT NOT NULL, 
    CONSTRAINT [FK_PlayersNationality_Nationality] FOREIGN KEY (NationalityId) REFERENCES [Nationality]

)
