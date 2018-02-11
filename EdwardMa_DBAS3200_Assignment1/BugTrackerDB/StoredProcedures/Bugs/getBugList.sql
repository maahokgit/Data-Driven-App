CREATE PROCEDURE [dbo].[getBugList]
	@p_AppName VARCHAR(40),
	@p_StatusCodeDesc VARCHAR(40)
AS
	BEGIN
		DECLARE 
			@v_AppID AS INT,
			@v_StatusCodeID AS INT
		
		SET @v_AppID = (SELECT AppID FROM Applications WHERE AppName = @p_AppName)
		--if statusCodeDesc = All Status then...
		IF (@p_StatusCodeDesc = 'All Status' OR @p_StatusCodeDesc = '<Select Status>')
			BEGIN
				SELECT 
					b.BugID, b.BugDate, b.BugDetails, b.BugDesc, b.RepSteps, b.FixDate
				FROM dbo.Bugs b
				INNER JOIN dbo.BugLog bl ON bl.BugID = b.bugID
				WHERE b.AppID = @v_AppID;
			END
		--if not...
		ELSE
			BEGIN
				SET @v_StatusCodeID = (SELECT StatusCodeID FROM StatusCodes WHERE StatusCodeDesc = @p_StatusCodeDesc)
				SELECT 
					b.BugID, b.BugDate, b.BugDetails, b.BugDesc, b.RepSteps, b.FixDate
				FROM dbo.Bugs b
				INNER JOIN dbo.BugLog bl ON bl.BugID = b.bugID
				WHERE b.AppID = @v_AppID AND bl.StatusCodeID = @v_StatusCodeID;
			END
	END
GO



	               -- BugID = Int32.Parse(reader["BugID"].ToString());
                --BugDate = DateTime.Parse(reader["BugDate"].ToString());
                --BugDetails = reader["UserEmail"].ToString();
                --BugDesc = reader["BugDesc"].ToString();
                --RepSteps = reader["RepSteps"].ToString();
                --FixDate = DateTime.Parse(reader["FixDate"].ToString());

	               -- //[BugID]      INT          IDENTITY (1, 1) NOT NULL,
                --//[AppID]      INT          NOT NULL,
                --//[UserID]     INT          NOT NULL,
                --//[BugSignOff] INT          NULL,
                --//[BugDate]    DATETIME     DEFAULT (getdate()) NOT NULL,
                --//[BugDetails] NTEXT        NULL,
                --//[BugDesc]    VARCHAR (40) NULL,
                --//[RepSteps]   NTEXT        NULL,
                --//[FixDate]    DATETIME     DEFAULT (getdate()) NULL,
