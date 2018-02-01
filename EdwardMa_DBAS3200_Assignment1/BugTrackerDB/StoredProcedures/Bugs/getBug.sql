CREATE PROCEDURE [dbo].[getBug]
AS
	SELECT 
		b.BugID, 
		b.AppID, 
		b.UserID, 
		bL.BugLogID, 
		b.BugDate, 
		b.BugDetails,
		b.RepSteps,
		b.FixDate,
		bL.BugLogDate,
		bL.StatusCodeID,
		bL.BugLogDesc
	FROM Bugs b
	INNER JOIN BugLog bL ON bL.BugID = b.BugID

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