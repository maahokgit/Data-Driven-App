﻿CREATE TABLE [dbo].[Applications]
(
	[AppID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[AppName] VARCHAR(40) NOT NULL,
	[AppVersion] VARCHAR(40) NOT NULL,
	[AppDesc] VARCHAR(255) NOT NULL
)