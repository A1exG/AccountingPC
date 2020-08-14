CREATE PROCEDURE [dbo].[spSale_Insert]
	@Id int output,
	@CashierId nvarchar(128),
	@SaleDate Datetime2,
	@SubTotal money,
	@Tax money,
	@Total money

AS
BEGIN
	SET nocount on;

	INSERT INTO dbo.Sale(CashierId, SaleDate, SubTotal, Tax, Total)
	VALUES (@CashierId, @SaleDate, @SubTotal, @Tax, @Total)

	SELECT @Id = SCOPE_IDENTITY();
END
