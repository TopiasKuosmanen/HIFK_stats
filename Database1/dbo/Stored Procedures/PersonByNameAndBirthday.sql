CREATE PROCEDURE [dbo].[PersonByNameAndBirthday]
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@Birthday DATETIME
AS
BEGIN
	SELECT P.Id
	FROM dbo.Player P
	WHERE P.LastName = @LastName AND P.FirstName = @FirstName AND P.BirthDate = @Birthday
	UNION
	SELECT S.Id
	FROM dbo.Staff S
	WHERE S.LastName = @LastName AND S.FirstName = @FirstName AND S.BirthDate = @Birthday
END