CREATE TABLE Comments(
CommentID int not null identity(1,1) primary key,
Comment nvarchar(200) not null,
Created datetime2 not null,
CaseId int FOREIGN KEY REFERENCES Cases(CaseId)
)