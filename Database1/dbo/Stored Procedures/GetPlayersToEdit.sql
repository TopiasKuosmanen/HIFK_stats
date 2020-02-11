CREATE PROCEDURE [dbo].[GetPlayersToEdit]
	@Name NVARCHAR(50)
AS
BEGIN
	SELECT * FROM Player P
	WHERE P.LastName LIKE '%' + @Name + '%' OR P.FirstName LIKE '%' + @Name + '%'
END