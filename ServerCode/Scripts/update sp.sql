CREATE PROCEDURE dbo.spuStudent
    @StudentID INT,
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @DateOfBirth DATE,
    @Gender NVARCHAR(10),
    @Email NVARCHAR(100),
    @Phone NVARCHAR(20),
    @Address NVARCHAR(100),
    @CityID INT = NULL
AS
BEGIN
    UPDATE Students
    SET
        FirstName = @FirstName,
        LastName = @LastName,
        DateOfBirth = @DateOfBirth,
        Gender = @Gender,
        Email = @Email,
        Phone = @Phone,
        Address = @Address,
        CityID = @CityID
    WHERE StudentID = @StudentID;
END
