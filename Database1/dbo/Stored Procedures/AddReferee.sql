CREATE PROCEDURE [dbo].[AddReferee]
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@Birthday DATETIME
AS
BEGIN
	INSERT INTO dbo.Referee (FirstName, LastName, BirthDate)
	VALUES (@FirstName, @LastName, @Birthday)
END
