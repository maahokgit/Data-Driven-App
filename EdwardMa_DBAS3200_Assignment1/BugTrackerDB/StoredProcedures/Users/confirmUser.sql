CREATE PROCEDURE [dbo].[confirmUser]
	@p_UserName VARCHAR(80),
	@count int output
AS
	BEGIN
		SELECT @count = count(*) FROM Users WHERE UserName = @p_UserName;
		RETURN @count
	END