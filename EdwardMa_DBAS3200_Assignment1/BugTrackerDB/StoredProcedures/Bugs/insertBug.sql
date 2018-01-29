CREATE PROCEDURE [dbo].[insertBug]
	--declaring procedure parameters
	@p_AppID INT,
	@p_UserID INT,
	@p_BugSignOff INT,
	@p_BugDate DATETIME,
	@p_BugDesc VARCHAR(40),
	@p_BugDetails NTEXT,
	@p_RepSets NTEXT,
	@p_FixDate DATETIME,
	@p_StatusCodeID INT,
	@v_BugID INT = NULL
AS
    SET NOCOUNT ON;

	IF @p_BugDate = '' OR @p_bugDate is null
	SET	@p_BugDate = GETDATE()

	IF @p_StatusCodeID = 1
	SET @p_FixDate = GETDATE()

BEGIN
    BEGIN TRY
        BEGIN TRANSACTION
        	INSERT INTO Bugs(AppID, UserID, BugSignOff, BugDate, BugDesc, BugDetails, RepSteps, FixDate)
			VALUES(@p_AppID,@p_UserID,@p_BugSignOff,@p_BugDate,@p_BugDesc, @p_BugDetails, @p_RepSets, @p_FixDate);

			SELECT BugID INTO [@v_BugID] FROM Bugs WHERE AppID = @p_AppID;

			INSERT INTO BugLog(BugLogDate, StatusCodeID, UserID, BugLogDesc, BugID)
			VALUES(@p_BugDate,@p_StatusCodeID, @p_UserID, @p_BugDesc, @v_BugID);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Rollback any active or uncommittable transactions before
        IF @@TRANCOUNT > 0
        BEGIN
            ROLLBACK TRANSACTION;
        END
    END CATCH;
END;
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