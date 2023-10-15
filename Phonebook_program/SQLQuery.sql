--create database PhonebookBD;

use PhonebookBD;
CREATE TABLE Contact
(
    Id INT identity primary key not null,
    Name VARCHAR(255) NOT NULL,
	Surname VARCHAR(255) NOT NULL,
    Age INT null,
	Email VARCHAR(255) not null,
	PhoneNumber VARCHAR(255) not null,
	Address VARCHAR(255) null,
	City VARCHAR(255) null,
	Region VARCHAR(255) null,
	PostalCode INT null,
    Country VARCHAR(255) null
);

--insert Contact Values('Person1', 'Person1', '25', 'Person1@mail.ru', '8(916)999-99-99', '', 'Moscow', 'Moscow', '', 'Russia')
insert Contact Values('Person2', 'Person2', '25', 'Person2@mail.ru', '8(916)888-99-99', '', 'Moscow', 'Moscow', '', 'Russia')
insert Contact Values('Person3', 'Person4', '25', 'Person3@mail.ru', '8(916)777-99-99', '', 'London', 'London', '', 'Great Britain')