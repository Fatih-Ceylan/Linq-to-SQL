create table Accounts 
(
AccountNumber int primary key,
AccountName nvarchar(50),
AccountBalance int

)
go

insert into Accounts values (1,'John Doe',1000)

select * from Accounts

Update Accounts set AccountBalance = AccountBalance -500 where AccountNumber=1