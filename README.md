This creates tables and populates them with some default data.
---------------------------------------------------------------
DROP TABLE Favorites;  
GO  
DROP TABLE Tickets;
GO
DROP TABLE UserPerm;
GO
CREATE TABLE Tickets (
id INTEGER PRIMARY KEY NOT NULL IDENTITY(1,1),
openedUserID NVARCHAR(40),
title NVARCHAR(40),
resolvedUserID NVARCHAR(40),
resolution NVARCHAR(200),
isOpen BIT,
problemDescription NVARCHAR(200),
openDate DATETIME NOT NULL DEFAULT SYSDATETIME(),
closeDate DATETIME
);
CREATE TABLE Favorites(
pkId INTEGER PRIMARY KEY NOT NULL IDENTITY(1,1),
UserID NVARCHAR(40),
id INTEGER FOREIGN KEY (id) REFERENCES Tickets(id) ON DELETE CASCADE
);
Create Table UserPerm(
Username nvarchar(40),
AccessLevel nvarchar(30),
);
Insert into UserPerm
Values('Ash', 'Admin'),
('Nick', 'Admin'),
('Austin', 'Admin'),
('Ryan', 'Admin'),
('Tommy', 'User');
INSERT INTO Tickets (openedUserID, title, resolvedUserID, resolution, isOpen, problemDescription, closeDate)
VALUES ('Nick', 'I cannot login', 'Preston', 'get new computer', 0, 'when i login it fails', dateadd(hour, 36, SYSDATETIME())),
('Austin', 'Computer broken', '','', 1, 'power button does nothing when press', null),
('Nick', 'Gitbash not working right', 'Ryan','undo push somehow', 0, 'i pushed to main', dateadd(hour, 1, SYSDATETIME())),
('Ryan', 'dummy data1', '','', 1, 'dummy data4', null),
('Preston', 'dummy data2', '','', 1, 'dummy data5', null),
('Austin', 'dummy data3', 'Nick','resolution data1', 0, 'dummy data6', dateadd(hour, 5, SYSDATETIME()));
