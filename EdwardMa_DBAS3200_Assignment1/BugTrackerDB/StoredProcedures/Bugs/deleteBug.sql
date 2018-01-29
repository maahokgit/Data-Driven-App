CREATE PROCEDURE [dbo].[deleteBug]
	-- declaring procedure parameters
	@p_BugID INT
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM Bugs
			WHERE BugID = @p_BugID

			UPDATE BugLog
			SET StatusCodeID = 4
			WHERE BugID = @p_BugID;

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        -- Rollback any active or uncommittable transactions before
        IF @@TRANCOUNT > 0
        BEGIN
            ROLLBACK TRANSACTION;

        END
    END CAT