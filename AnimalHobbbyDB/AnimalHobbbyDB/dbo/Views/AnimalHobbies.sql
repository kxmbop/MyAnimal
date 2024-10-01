CREATE VIEW [dbo].[AnimalHobbies]
	AS SELECT a.AnimalName from Animal a
	inner join AnimalHobby ah on ah.AId = a.Id
	right join Hobbies h on h.Id = ah.HId