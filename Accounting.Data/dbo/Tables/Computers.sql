CREATE TABLE [dbo].[Computers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [DisplayName] NVARCHAR(100) NOT NULL, 
    [DomenName] NVARCHAR(50) NULL, 
    [DateInstallOS] DATETIME2 NULL, 
    [ComputerType] NVARCHAR(50) NOT NULL
)
