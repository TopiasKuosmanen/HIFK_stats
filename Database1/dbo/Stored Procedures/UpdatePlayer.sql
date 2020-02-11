CREATE PROCEDURE [dbo].[UpdatePlayer]
	@Id INT,
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@Number INT,
	@YearOfAccession INT,
	@ContractEndDate DATETIME,
	@BirthDate DATETIME
AS
BEGIN
	UPDATE Player
	SET FirstName = @FirstName, LastName = @LastName, Number = @Number, YearOfAccession = @YearOfAccession,
	ContractEndDate = @ContractEndDate, BirthDate = @BirthDate
	WHERE Id = @Id
END