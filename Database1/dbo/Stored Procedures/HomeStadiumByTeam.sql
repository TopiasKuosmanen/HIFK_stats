CREATE PROCEDURE [dbo].[HomeStadiumByTeam]
	@Team NVARCHAR(50)
AS
BEGIN
	SELECT S.Name
	FROM Stadium S JOIN Opponent O ON S.Id = O.Stadium
	WHERE O.Team = @Team
END