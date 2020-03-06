CREATE PROCEDURE [dbo].[AddNewLeague]
	@LeagueName NVARCHAR(50)
AS
BEGIN
	INSERT INTO League(LeagueName)
	VALUES (@LeagueName)
END
