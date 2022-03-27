CREATE PROCEDURE [dbo].[DeletePerson]
	@id INT
AS
BEGIN
	DELETE FROM [Personal Info] WHERE Id = @id
END