-- Insert Stored Procedure
Create procedure InsertEmployee
@FirstName nvarchar(50),
@LastName nvarchar(50),
@Gender nvarchar(50),
@Salary int,
@DepartmentId int
as
Begin
     Insert into Employees(FirstName, LastName, Gender, Salary, DepartmentId)
     values (@FirstName, @LastName, @Gender, @Salary, @DepartmentId)
End
GO

-- Update Stored Procedure
Create procedure UpdateEmployee
@ID int,
@FirstName nvarchar(50),
@LastName nvarchar(50),
@Gender nvarchar(50),
@Salary int,
@DepartmentId int
as
Begin
     Update Employees Set
     FirstName = @FirstName, LastName = @LastName, Gender = @Gender,
     Salary = @Salary, DepartmentId = @DepartmentId
     where ID = @ID
End
GO

-- Delete Stored Procedure
Create procedure DeleteEmployee
@ID int
as
Begin
     Delete from Employees where ID = @ID
End
GO