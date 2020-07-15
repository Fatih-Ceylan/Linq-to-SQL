--SQL Script to create Employees Table
Create Table Employees
(
     ID int primary key identity,
     Name nvarchar(50),
     Gender nvarchar(50),
     AnnualSalary int,
     HourlyPay int,
     HoursWorked int,
     Discriminator nvarchar(50)
)
GO

Insert into Employees values ('Mark', 'Male', 60000, NULL, NULL, 'PermanentEmployee')
Insert into Employees values ('Steve', 'Male', NULL, 50, 160, 'ContractEmployee')
Insert into Employees values ('Ben', 'Male', NULL, 40, 120, 'ContractEmployee')
Insert into Employees values ('Philip', 'Male', 45000, NULL, NULL, 'PermanentEmployee')
Insert into Employees values ('Mary', 'Female', 30000, NULL, NULL, 'PermanentEmployee')
Insert into Employees values ('Valarie', 'Female', NULL, 30, 140, 'ContractEmployee')
Insert into Employees values ('John', 'Male', 80000, NULL, NULL, 'PermanentEmployee')