CREATE PROCEDURE [dbo].[UpdatePerson]
	@id INT,
	@name VARCHAR(50),
	@surname VARCHAR(50),
	@adress VARCHAR(200),
	@gsm INT,
	@email VARCHAR(50),
	@misc NVARCHAR(MAX),
	@firstQuality VARCHAR(50),
	@secondQuality VARCHAR(50),
	@thirdQuality VARCHAR(50),
	@firstFault VARCHAR(50),
	@secondFault VARCHAR(50),
	@thirdFault VARCHAR(50),
	@lastDegree VARCHAR(50)
AS
BEGIN
	UPDATE [Personal Info] SET [Name] = @name, Surname = @surname, Adress = @adress, gsm = @gsm, Email = @email, [Misc] = @misc, FirstQuality = @firstQuality, SecondQuality = @secondQuality, ThirdQuality = @thirdQuality, FirstFault = @firstFault, SecondFault = @secondFault, ThirdFault = @thirdFault, LastDegree = @lastDegree
	WHERE Id = @id
END