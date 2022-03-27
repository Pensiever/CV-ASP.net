CREATE PROCEDURE [dbo].[DeleteProfession]
	@id INT
AS
BEGIN
	DELETE FROM [Professional Experience] WHERE Id = @id
END