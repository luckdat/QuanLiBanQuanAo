CREATE DATABASE ASM1;
USE ASM1;

CREATE TABLE student (
    id INT PRIMARY KEY IDENTITY(1,1),
	username varchar(50),
	password varchar(255)
);
INSERT INTO student(username, password) VALUES ('luc', '123');

CREATE TABLE class(
	classId INT PRIMARY KEY IDENTITY(1,1),
	subject varchar(50),
	id INT FOREIGN KEY (id) REFERENCES student(id)
);
INSERT INTO class (subject, id) VALUES ('sdlc', 2);

CREATE TABLE attendance(
	attendanceId INT PRIMARY KEY IDENTITY(1,1),
	classId INT FOREIGN KEY (classId) REFERENCES class(classId),
	id INT FOREIGN KEY (id) REFERENCES student(id),
	status varchar(55)
);
INSERT INTO attendance ( classId, id, status) VALUES (3, 2, 'absent12');

select * from student
select * from class
select * from attendance