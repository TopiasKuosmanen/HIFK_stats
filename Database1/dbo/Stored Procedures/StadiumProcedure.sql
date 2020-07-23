CREATE PROCEDURE [dbo].[StadiumProcedure]

AS
BEGIN
	SELECT * FROM Stadium
	ORDER BY Name
END