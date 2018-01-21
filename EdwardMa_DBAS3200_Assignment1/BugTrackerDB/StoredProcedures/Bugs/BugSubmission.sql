CREATE PROCEDURE [dbo].[BugSubmission]
	--declaring procedure parameters
	@p_AppID INT,
	@p_UserID INT,
	@p_BugSignOff INT,
	@p_BugDate DATETIME,
	@p_BugDetails NTEXT,
	@p_RepSets NTEXT,
	@p_FixDate DATETIME
AS
	IF @p_BugDate = '' OR @p_bugDate is null
	SET	@p_BugDate = GETDATE()

	INSERT INTO Bugs(AppID, UserID, BugSignOff, BugDate, BugDetails, RepSteps, FixDate)
	VALUES(@p_AppID,@p_UserID,@p_BugSignOff,@p_BugDate, @p_BugDetails, @p_RepSets, @p_FixDate)

/*	Reference for Bug Table Structure
	[BugID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[AppID] INT NOT NULL,
	[UserID] INT NOT NULL,
	[BugSignOff] INT NULL,
	[BugDate] DATETIME DEFAULT GETDATE() NOT NULL,
	[BugDetails] NTEXT NULL,
	[RepSteps] NTEXT NULL,
	[FixDate] DATETIME DEFAULT GETDATE() NULL
*/