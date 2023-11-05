CREATE DATABASE Lab2_6
GO

USE Lab2_6
GO

CREATE TABLE Course (
    id NVARCHAR(100) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
)
GO

CREATE TABLE Student (
    id NVARCHAR(100) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    idCourse NVARCHAR(100) NOT NULL,
    FOREIGN KEY (idCourse) REFERENCES Course (id)
)
GO

CREATE TABLE Score (
    id INT PRIMARY KEY IDENTITY,
    math FLOAT,
    literature FLOAT,
    english FLOAT,
    idStudent NVARCHAR(100) NOT NULL,
    FOREIGN KEY (idStudent) REFERENCES Student (id)
)
GO

-- Insert Data

-- Course
INSERT INTO Course (id, name) 
VALUES (N'KTPM', N'Kĩ thuật phần mềm')
INSERT INTO Course (id, name) 
VALUES (N'KHMT', N'Khoa học máy tính')
INSERT INTO Course (id, name) 
VALUES (N'KTMT', N'Kĩ thuật máy tính')

-- Student
DECLARE @i INT = 0
WHILE @i < 30
BEGIN
    -- Kĩ thuật phần mềm 
    IF @i % 3 = 0 
    BEGIN
        INSERT INTO Student(id, name, idCourse)
        VALUES (CAST(21521600 + @i AS nvarchar(100)),N'Student ' + CAST(@i AS nvarchar(100)), N'KTPM')
        SET @i = @i + 1
    END
    -- Khoa học máy tính
    IF @i % 3 = 1 
    BEGIN
        INSERT INTO Student(id, name, idCourse)
        VALUES (CAST(21521600 + @i AS nvarchar(100)),N'Student ' + CAST(@i AS nvarchar(100)), N'KHMT')
        SET @i = @i + 1
    END
    -- Kĩ thuật máy tính
    IF @i % 3 = 2
    BEGIN
        INSERT INTO Student(id, name, idCourse)
        VALUES (CAST(21521600 + @i AS nvarchar(100)),N'Student ' + CAST(@i AS nvarchar(100)), N'KTMT')
        SET @i = @i + 1
    END
END
GO

-- Score
DECLARE @i INT = 21521600
DECLARE @maxScore INT = 10
DECLARE @minScore INT = 5
WHILE @i < 21521630
BEGIN
    INSERT INTO Score(idStudent, math, literature, english)
    VALUES (CAST(@i AS nvarchar(100)), FLOOR(RAND() * (@maxScore - @minScore) + @minScore), FLOOR(RAND() * (@maxScore - @minScore) + @minScore), FLOOR(RAND() * (@maxScore - @minScore) + @minScore))
    SET @i = @i + 1
END
GO

-- Store proc

CREATE PROC LoadInfoStudent
AS
BEGIN
    SELECT Course.id AS N'Mã lớp', 
    Student.id AS N'MSSV', 
    Student.name AS N'Tên', 
    Score.math AS N'Điểm Toán', 
    Score.literature AS N'Điểm Văn', 
    Score.english AS N'Điểm Anh',
    Round((Score.math + Score.literature + Score.english) / 3, 2) AS N'ĐTB'
    FROM Course, Student, Score
    WHERE Student.idCourse = Course.id
        AND Score.idStudent = Student.id
END
GO 

-- EXEC LoadInfoStudent

CREATE PROC UpdateStudent
@id NVARCHAR(100),
@name NVARCHAR(100),
@idCourse NVARCHAR(100),
@math FLOAT,
@literature FLOAT,
@english FLOAT
AS
BEGIN
    UPDATE Student
    SET name = @name, idCourse = @idCourse
    WHERE id = @id

    UPDATE Score
    SET math = @math, 
        literature = @literature, 
        english = @english
    WHERE idStudent = @id
END
GO

-- EXEC UpdateStudent 
--     @id = N'21521600', 
--     @name = N'Le Qui Tu', 
--     @idCourse = N'KHMT',
--     @math = 10,
--     @literature = 10,
--     @english = 10



CREATE PROC DeleteStudent 
@id NVARCHAR(100)
AS
BEGIN
    DELETE FROM Score
    WHERE idStudent = @id 

    DELETE FROM Student
    WHERE id = @id
END
GO

CREATE PROC AddStudent
@idStudent NVARCHAR(100),
@name NVARCHAR(100),
@idCourse NVARCHAR(100),
@math FLOAT,
@literature FLOAT,
@english FLOAT
AS
BEGIN
    INSERT INTO Student (id, name, idCourse) 
    VALUES (@idStudent, @name, @idCourse)
    
    INSERT INTO Score (math, literature, english, idStudent)
    VALUES (@math, @literature, @english, @idStudent)
END
GO

-- EXEC AddStudent 
--     @idStudent = N'21521600' , 
--     @name = N'Le Qui Tu' ,
--     @idCourse = N'KTPM',
--     @math = 10 ,
--     @literature = 7 ,
--     @english = 9


SELECT * FROM Course
SELECT * FROM Student
SELECT * FROM Score