﻿CREATE PROCEDURE [dbo].[AddPlayersNationality]
	@PlayerId INT,
	@Nationality NVARCHAR(50)
AS
BEGIN
	DELETE FROM dbo.PlayersNationality WHERE PlayerId = @PlayerId
	INSERT INTO dbo.PlayersNationality(PlayerId, NationalityId)
	VALUES (@PlayerId, (SELECT DISTINCT N.NationalityId
						FROM Nationality N --JOIN PlayersNationality P ON N.NationalityId = P.NationalityId 
						WHERE N.Nationality = @Nationality)
						)
END
