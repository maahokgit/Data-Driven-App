CREATE PROCEDURE [dbo].[confirmUser]
	@p_UserID INT
AS
	IF EXISTS(SELECT UserID FROM Users WHERE UserID = @p_UserID)
		BEGIN
			RETURN 1 --true
		END
	ELSE
		BEGIN
			RETURN 0 -- false
			-- run insertUser Procedure
		END