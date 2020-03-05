CREATE PROCEDURE [dbo].[spDeleteRecord]
	@StudentNumber INT,
	@ActionType NVARCHAR(20)
AS
	BEGIN
		IF @ActionType = 'Delete'
			DELETE FROM tb_Student
			WHERE StudentNumber = @StudentNumber
	END
