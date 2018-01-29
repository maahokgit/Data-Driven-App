CREATE PROCEDURE [dbo].[deleteBug]
	-- declaring procedure parameters
	@p_BugID INT,
	@p_UserID INT
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM Bugs
			WHERE BugID = @p_BugID

			INSERT INTO BugLog(BugLogDate, StatusCodeID, UserID, BugID)
			VALUES(GETDATE(), 4, @p_UserID, @p_BugID)

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        -- Rollback any active or uncommittable transactions before
        IF @@TRANCOUNT > 0
        BEGIN
            ROLLBACK TRANSACTION;
        END
    END CATCH
END

/*
	[BugLogID]     INT      IDENTITY (1, 1) NOT NULL,
    [BugLogDate]   DATETIME DEFAULT (getdate()) NOT NULL,
    [StatusCodeID] INT      NOT NULL,
    [UserID]       INT      NOT NULL,
    [BugLogDesc]   NTEXT    NULL,
    [BugID]        INT      NOT NULL,
*/