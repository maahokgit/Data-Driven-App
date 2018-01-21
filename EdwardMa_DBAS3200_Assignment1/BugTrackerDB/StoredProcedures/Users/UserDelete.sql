CREATE PROCEDURE [dbo].[UserDelete]
	-- declaring procedure parameter(s)
	@p_UserName VARCHAR(80)
AS
	DELETE FROM Users
	WHERE UserName = @p_UserName