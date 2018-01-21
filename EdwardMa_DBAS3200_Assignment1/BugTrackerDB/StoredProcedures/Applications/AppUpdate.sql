CREATE PROCEDURE [dbo].[AppUpdate]
	-- declaring procedure parameter(s)
	@p_AppName VARCHAR(40), 
	@p_AppVersion VARCHAR(40), 
	@p_AppDesc VARCHAR(255)
AS
	UPDATE Applications
	SET AppVersion = @p_AppVersion, AppDesc = @p_AppDesc
	WHERE AppName = @p_AppName