CREATE TABLE [dbo].[AnimalHobby]
(
	HId int not null,
	AId int not null,
	Primary key (HId, AId),
	Foreign key(HId) references Hobbies(Id),
	Foreign key(AId) references Animal(Id)
)