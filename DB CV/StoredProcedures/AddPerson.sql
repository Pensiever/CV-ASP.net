CREATE PROCEDURE [dbo].[AddPerson]
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
	INSERT INTO [Personal Info] ([Name], Surname, Adress, gsm, Email, [Misc], FirstQuality, SecondQuality, ThirdQuality, FirstFault, SecondFault, ThirdFault, LastDegree) VALUES (@name, @surname, @adress, @gsm, @email, @misc, @firstQuality, @secondQuality, @thirdQuality, @firstFault, @secondFault, @thirdFault, @lastDegree)
END
