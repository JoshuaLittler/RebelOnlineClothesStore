CREATE PROCEDURE sproc_tblCustomer_Insert
	@FirstName varchar (50),
	@Surname varchar (50),
	@Email varchar (50),
	@HouseNo varchar (6),
	@Street varchar (50),
	@Town varchar (50),
	@PostCode varchar (9),
	@DateOfBirth date,
	@Active bit

AS
	INSERT INTO tblCustomer (FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth, Active)
	values (@FirstName, @Surname, @Email, @HouseNo, @Street, @Town, @PostCode, @DateOfBirth, @Active)
RETURN @@Identity
