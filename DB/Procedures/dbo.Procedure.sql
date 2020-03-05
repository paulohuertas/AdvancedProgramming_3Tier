CREATE PROCEDURE spAddStudent

@FirstName VARCHAR(30), 
@LastName VARCHAR(30), 
@Email VARCHAR(100), 
@Phone VARCHAR(30), 
@AddressLine1 VARCHAR(50), 
@AddressLine2 VARCHAR(50), 
@City VARCHAR(30), 
@County VARCHAR(20),
@GradLevel VARCHAR(10),
@Course VARCHAR(20), 
@StudentNumber INT,
@ActionType VARCHAR(20)

AS
	BEGIN
		IF @ActionType = 'Save'
		BEGIN
			IF NOT EXISTS (SELECT * FROM tb_Student WHERE StudentNumber = @StudentNumber)
			BEGIN
			INSERT INTO tb_Student
				(FirstName, LastName, Email, Phone, AddressLine1, AddressLine2, City, County, GradLevel, Course, StudentNumber)
			VALUES
				(@FirstName, @LastName, @Email, @Phone, @AddressLine1, @AddressLine2, @City, @County, @GradLevel, @Course, @StudentNumber)
			END
		END
	END