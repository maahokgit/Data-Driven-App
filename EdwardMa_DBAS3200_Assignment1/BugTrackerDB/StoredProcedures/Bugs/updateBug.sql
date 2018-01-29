CREATE PROCEDURE [dbo].[updateBug]
	--declaring procedure parameters
	@p_BugID INT,
	@p_BugSignOff INT,
	@p_RepSets NTEXT,
	@p_BugDetails NTEXT,
	@p_BugDesc NTEXT,
	@p_FixDate DATETIME = NULL,
	@p_StatusCodeID INT,
	@p_UserID INT
AS
BEGIN
	SET NOCOUNT ON;

	IF @p_StatusCodeID = 4
	SET @p_FixDate = GETDATE();

	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE Bugs
			SET BugSignOff = @p_BugSignOff,
				BugDesc = @p_BugDesc,
				BugDetails = @p_BugDetails,
				RepSteps = @p_RepSets,
				FixDate = @p_FixDate
			WHERE BugID = @p_BugID;

			INSERT INTO BugLog(BugLogDate, StatusCodeID, UserID, BugLogDesc, BugID)
			VALUES(GETDATE(),@p_StatusCodeID, @p_UserID, @p_BugDesc, @p_BugID);
			
		COMMIT TRANSACTION
	END TRY
    BEGIN CATCH
        -- Rollback any active or uncommittable transactions before
        IF @@TRANCOUNT > 0
        BEGIN
            ROLLBACK TRANSACTION;

        END
    END CATCH;
END;
