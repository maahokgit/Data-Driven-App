CREATE PROCEDURE [dbo].[deleteApp] 
	-- declaring procedure parameter(s)
	@p_AppName VARCHAR(40)
AS
	DELETE FROM Applications
	WHERE AppName = @p_AppName