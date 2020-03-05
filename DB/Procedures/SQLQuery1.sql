CREATE TABLE tb_Student(
StudentId INT NOT NULL IDENTITY(1,1),
FirstName VARCHAR(30) NOT NULL,
LastName VARCHAR(30) NOT NULL,
Email VARCHAR(100),
Phone VARCHAR(30),
AddressLine1 VARCHAR(50),
AddressLine2 VARCHAR(50),
City VARCHAR(30),
County VARCHAR(20),
GradLevel VARCHAR(10) NOT NULL,
Course VARCHAR(20) NOT NULL,
StudentNumber INT NOT NULL,
PRIMARY KEY CLUSTERED (StudentId))

CREATE TABLE tb_Login(
UserId INT NOT NULL IDENTITY(1,1),
UserName VARCHAR(50),
UserPassword VARCHAR(25),
PRIMARY KEY (UserId));


SET IDENTITY_INSERT tb_Login ON


INSERT INTO tb_Login (UserId, UserName, UserPassword)
VALUES
(1, 'paulo', 'paulohu'),
(2, 'mayara', 'mayarar'),
(3, 'jose', 'formiga');
