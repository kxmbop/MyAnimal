create table Animal
(
	Id int primary key identity,
	AnimalName varchar(50),
	AnimalType varchar(50),
	AnimalOwner varchar(50),
	AnimalOwnerContact varchar(50),
	AnimalHobby varchar(50),
	DOB DateTime
)