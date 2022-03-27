CREATE PROCEDURE [dbo].[AddSkill]
	@skill VARCHAR(200),
	@cvId int
AS
BEGIN
	INSERT INTO [Technical Skills] (Skill, [CV Id]) VALUES (@skill, @cvId)
END