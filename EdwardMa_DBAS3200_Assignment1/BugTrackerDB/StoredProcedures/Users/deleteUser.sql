CREATE PROCEDURE [dbo].[insertUser]
	-- declaring procedure parameter(s)
	@p_UserName VARCHAR(80),
	@p_UserEmail VARCHAR(80),
	@p_UserTel VARCHAR(40)
AS
	INSERT INTO Users(UserName, UserEmail, UserTel) 
	VALUES (@p_UserName, @p_UserEmail, @p_UserTel)