CREATE PROCEDURE [dbo].[AddPlayerProcedure]
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@Number INT,
	@YearOfAccession INT,
	@ContractEndDate DATE,
	@BirthDate DATETIME
AS
BEGIN
	INSERT INTO dbo.Player (FirstName, LastName, Number, YearOfAccession, ContractEndDate, BirthDate)
	VALUES (@FirstName, @LastName, @Number, @YearOfAccession, @ContractEndDate, @BirthDate)
END

