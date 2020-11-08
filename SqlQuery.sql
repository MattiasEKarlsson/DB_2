CREATE TABLE [Cases](
CaseId int not null identity(1,1) primary key,
ClientName nvarchar(50) not null,
Title nvarchar(50) not null,
Problem nvarchar(500) not null,
[Status] nvarchar (10) not null,
Created datetime2 not null
)