Create Table Students
(
     ID int primary key identity,
     FirstName nvarchar(50),
     LastName nvarchar(50),
     Gender nvarchar(50)
)
GO

Insert into Students values ('Mark', 'Hastings', 'Male')
Insert into Students values ('Steve', 'Pound', 'Male')
Insert into Students values ('Ben', 'Hoskins', 'Male')
Insert into Students values ('Philip', 'Hastings', 'Male')
Insert into Students values ('Mary', 'Lambeth', 'Female')
insert into Students values ('Ayþe','Güleç','Female')
GO