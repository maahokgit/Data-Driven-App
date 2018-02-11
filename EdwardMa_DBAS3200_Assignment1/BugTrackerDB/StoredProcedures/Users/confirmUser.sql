CREATE PROCEDURE [dbo].[confirmUser]
	@p_UserName VARCHAR(80),
	@count INT output
AS
	BEGIN
		SELECT @count = COUNT(*) FROM Users WHERE UserName = @p_UserName;
		RETURN @count
	END