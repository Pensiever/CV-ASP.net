CREATE PROCEDURE [dbo].[DeleteSkill]
	@id INT
AS
BEGIN
	DELETE FROM [Technical Skills] WHERE Id = @id
END