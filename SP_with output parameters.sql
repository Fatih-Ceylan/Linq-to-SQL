-- Step 1 : Create the stored procedure
Create procedure GetEmployeesByDepartment
@DepartmentId int,
@DepartmentName nvarchar(50) out
as
Begin
     Select @DepartmentName = Name
     from Departments where ID = @DepartmentId

     Select * from Employees
     where DepartmentId = @DepartmentId

End
-- Step 2: Calling above SP and see the results
declare @DeptName nvarchar(50)
execute GetEmployeesByDepartment 2,@DeptName out
select @DeptName as Department