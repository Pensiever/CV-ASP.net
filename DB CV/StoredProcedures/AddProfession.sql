CREATE PROCEDURE [dbo].[AddProfession]
	@periodBegin DATE,
	@periodEnd DATE,
	@employer NVARCHAR(50),
	@position NVARCHAR(50),
	@cvId INT
AS
BEGIN
	INSERT INTO [Professional Experience] (PeriodBegin, PeriodEnd, Employer, Position, [CV Id]) VALUES (@periodBegin, @periodEnd, @employer, @position, @cvId)
END