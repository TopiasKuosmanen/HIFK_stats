CREATE PROCEDURE [dbo].[AddNewStadium]
	@StadiumName NVARCHAR(50),
	@Capacity INT,
	@Turf NVARCHAR(10)
AS
BEGIN
IF @Turf = 'Yes'
BEGIN
	INSERT INTO dbo.Stadium (Name, Capacity, Turf)
	VALUES (@StadiumName, @Capacity, 'True')
END
IF @Turf = 'No'
BEGIN
	INSERT INTO dbo.Stadium (Name, Capacity, Turf)
	VALUES (@StadiumName, @Capacity, 'False')
END
END
