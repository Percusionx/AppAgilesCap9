:setvar DatabaseName "InvoiceManagement29239"
:setvar DatabaseUserName ""
GO

USE [$(DatabaseName)]

DECLARE @usercount int
SELECT @usercount=COUNT(name) FROM sys.database_principals WHERE name = '$(DatabaseUserName)'
IF @usercount = 0
	CREATE USER $(DatabaseUserName) FOR LOGIN $(DatabaseUserName)
GO

EXEC sp_addrolemember N'db_datareader', N'$(DatabaseUserName)'
EXEC sp_addrolemember N'db_datawriter', N'$(DatabaseUserName)'
EXEC sp_addrolemember N'aspnet_Membership_FullAccess', N'$(DatabaseUserName)'
EXEC sp_addrolemember N'aspnet_Roles_FullAccess', N'$(DatabaseUserName)'
GO

