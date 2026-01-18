CREATE DATABASE StudentDB;
GO

USE StudentDB;
GO
select * from Students
CREATE TABLE Students
(
    StudentID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100),
    Age INT,
    Department VARCHAR(100),
    Email VARCHAR(150)
);
