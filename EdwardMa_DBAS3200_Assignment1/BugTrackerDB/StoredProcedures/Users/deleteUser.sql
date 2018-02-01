CREATE PROCEDURE [dbo].[deleteUser]
	-- declaring procedure parameter(s)
	@p_UserName VARCHAR(80)
AS
	DELETE FROM Users
	WHERE UserName = @p_UserName