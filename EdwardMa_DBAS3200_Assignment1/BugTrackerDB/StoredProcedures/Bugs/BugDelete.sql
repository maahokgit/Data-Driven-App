CREATE PROCEDURE [dbo].[BugDelete]
	-- declaring procedure parameters
	@p_BugID INT
AS
	DELETE FROM Bugs
	WHERE BugID = @p_BugID