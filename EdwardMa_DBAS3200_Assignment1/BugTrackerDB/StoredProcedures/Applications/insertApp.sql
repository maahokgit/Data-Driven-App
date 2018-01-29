CREATE PROCEDURE [dbo].[insertApp]
	-- declaring procedure parameter(s)
	@p_AppName VARCHAR(40), 
	@p_AppVersion VARCHAR(40), 
	@p_AppDesc VARCHAR(255)
AS
	INSERT INTO Applications (AppName, AppVersion, AppDe