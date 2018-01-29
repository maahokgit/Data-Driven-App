CREATE PROCEDURE [dbo].[getBug]
AS
	SELECT * FROM Bugs b
	INNER JOIN BugLog bL ON bL.BugID = b.BugID