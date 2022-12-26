use EmployeeDb;

CREATE TABLE Departments(
	ID int not null primary key,
	Name nvarchar(250)
);

GO

CREATE TABLE Employeers(
	ID int not null primary key,
	Department int REFERENCES Departments(ID),
	FirstName nvarchar(100),
	MiddleName nvarchar(100),
	LastName nvarchar(100),
	DateBirth date,
	Position nvarchar(100),
	Phone nvarchar(10),
	Email nvarchar(50)
);

GO