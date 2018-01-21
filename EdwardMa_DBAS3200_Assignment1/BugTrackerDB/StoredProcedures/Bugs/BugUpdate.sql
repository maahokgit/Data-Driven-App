CREATE PROCEDURE [dbo].[BugUpdate]
	--declaring procedure parameters
	@p_BugID INT,
	@p_BugSignOff INT,
	@p_RepSets NTEXT,
	@p_FixDate DATETIME
AS
	IF @p_FixDate = '' OR @p_FixDate is null
	SET	@p_FixDate = GETDATE()

	UPDATE Bugs
	SET BugSignOff = @p_BugSignOff,
		RepSteps = @p_RepSets,
		FixDate = @p_FixDate
