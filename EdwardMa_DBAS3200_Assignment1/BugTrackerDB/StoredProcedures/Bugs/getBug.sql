CREATE PROCEDURE [dbo].[getAllBugs]
AS
	SELECT 
		b.BugID, b.BugDate, b.BugDetails, b.BugDesc, b.RepSteps, b.FixDate
	FROM dbo.Bugs b
	INNER JOIN dbo.BugLog bl ON bl.BugID = b.BugID

	/*
		BugID
		AppID
		UserID
		BugLogID
		BugDate
		BugDetails
		BugDesc
		RepSteps
		FixDate
		BugLogDate
		StatusCodeID
		UserID
		BugLogDesc
	*/