--create database PhonebookBD;

use PhonebookBD;
CREATE TABLE Contact
(
    Id INT IDENTITY PRIMARY KEY NOT NULL,
    Name VARCHAR(255) NOT NULL,
	Surname VARCHAR(255) NOT NULL,
    Age INT NULL,
	Email VARCHAR(255) NOT NULL,
	PhoneNumber VARCHAR(255) NOT NULL,
	Address VARCHAR(255) NULL,
	City VARCHAR(255) NULL,
	Region VARCHAR(255) NULL,
	PostalCode INT NULL,
    Country VARCHAR(255) NULL
);

INSERT Contact VALUES('Person1', 'Person1', '35', 'Person1@mail.ru', '8(916)999-99-99', '', 'Moscow', 'Moscow', '', 'Russia');
INSERT Contact VALUES('Person2', 'Person2', '25', 'Person2@mail.ru', '8(916)888-99-99', '', 'Moscow', 'Moscow', '', 'Russia');
INSERT Contact VALUES('Person3', 'Person3', '33', 'Person3@mail.ru', '8(916)777-99-99', '', 'London', 'London', '', 'Great Britain');
