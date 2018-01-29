CREATE PROCEDURE [dbo].[updateUser]
	-- declaring procedure parameter(s)
	@p_UserName VARCHAR(80),
	@p_UserEmail VARCHAR(80),
	@p_UserTel VARCHAR(40)
AS
	UPDATE Users
	SET UserEmail = @p_UserEmail,
		UserTel = @p_UserTel
	WHERE UserName = @p_UserName