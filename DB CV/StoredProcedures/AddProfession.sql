CREATE PROCEDURE [dbo].[AddProfession]
	@periodBegin DATE,
	@periodEnd DATE,
	@employer VARCHAR(50),
	@position VARCHAR(50),
	@cvId INT
AS
BEGIN
	INSERT INTO [Professional Experience] (PeriodBegin, PeriodEnd, Employer, Position, [CV Id]) VALUES (@periodBegin, @periodEnd, @employer, @position, @cvId)
END