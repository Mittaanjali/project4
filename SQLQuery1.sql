create database Rainbowschool4Db
use Rainbowschool4Db
CREATE TABLE Students (
    StudentID INT PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50), 
);
drop table Students

INSERT INTO Students (StudentId,FirstName, LastName) VALUES 
(1,'Rishi', 'Kumar'),
(2,'John', 'Smith'),
(3,'Abhi', 'Ram');

 --Create Subjects Table
drop table Subjects
CREATE TABLE Subjects (
    SubjectID INT PRIMARY KEY,
    SubjectName NVARCHAR(50),  
);

INSERT INTO Subjects (SubjectId,SubjectName) VALUES
(1,'Math'),
(2,'Science'),
(3,'History');

-- Create Marks Table

CREATE TABLE Marks (
    MarkId INT primary key,
    StudentID INT,
    SubjectID INT,
    Mark INT,
    CONSTRAINT FK_StudentID FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    CONSTRAINT FK_SubjectID FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)   
);


INSERT INTO Marks (MarkId,StudentID, SubjectID, Mark) VALUES
(1,1, 1, 90),
(2,1, 2, 85),
(3,2, 1, 78),
(4,2, 2, 92),
(5,3, 3, 88);

select * from Students
select * from Subjects
select * from Marks