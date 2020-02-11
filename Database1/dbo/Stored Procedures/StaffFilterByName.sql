CREATE PROCEDURE [dbo].[StaffFilterByName]
	@StaffName NVARCHAR (50)
AS
BEGIN
	SELECT  *
	FROM Staff
	WHERE LastName LIKE '%' + @StaffName + '%' OR FirstName LIKE '%' + @StaffName + '%'
	ORDER BY LastName
END
