CREATE PROCEDURE [dbo].[getBugDetails]
	@p_bugDesc NVARCHAR(40)
AS
	SELECT 
		b.BugID, b.BugDate, b.BugDetails, b.RepSteps, b.FixDate
	FROM dbo.Bugs b
	INNER JOIN dbo.BugLog bl ON bl.BugID = b.BugID
	WHERE b.BugDesc = @p_bugDesc;
