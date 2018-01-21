﻿CREATE TABLE [dbo].[BugLog]
(
	[BugLogID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[BugLogDate] DATETIME DEFAULT GETDATE() NOT NULL,
	[StatusCodeID] INT NOT NULL,
	[UserID] INT NOT NULL,
	[BugLogDesc] NTEXT NULL,
	[BugID] INT NOT NULL, 
    CONSTRAINT [FK_BugLog_StatusCode] FOREIGN KEY ([StatusCodeID]) REFERENCES [StatusCodes]([StatusCodeID]),
	CONSTRAINT [FK_BugLog_Users] FOREIGN KEY ([UserID]) REFERENCES [Users]([UserID]),
	CONSTRAINT [FK_BugLog_Bugs] FOREIGN KEY ([BugID]) REFERENCES [Bugs]([BugID])
)
