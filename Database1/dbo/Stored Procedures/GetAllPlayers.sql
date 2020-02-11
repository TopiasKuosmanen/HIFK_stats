CREATE PROCEDURE [dbo].[GetAllPlayers]
@GameDate DATETIME
AS
BEGIN
	SELECT *
	FROM Player
	WHERE ContractEndDate > @GameDate AND YearOfAccession <= Year(@Gamedate)
	ORDER BY Number
END
