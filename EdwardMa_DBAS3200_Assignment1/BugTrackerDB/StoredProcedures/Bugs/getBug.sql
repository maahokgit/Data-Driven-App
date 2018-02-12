CREATE PROCEDURE [dbo].[getAllBugs]
AS
	SELECT 
		b.BugID, b.BugDate, b.BugDetails, b.BugDesc, b.RepSteps, b.FixDate, s.StatusCodeDesc, bl.StatusCodeID
	FROM dbo.Bugs b
	INNER JOIN dbo.BugLog bl ON bl.BugID = b.BugID
	INNER JOIN dbo.StatusCodes s ON s.StatusCodeID = bl.StatusCodeID

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