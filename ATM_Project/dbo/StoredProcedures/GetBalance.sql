CREATE PROCEDURE [dbo].[GetBalance]
	@Id int
AS
begin
	select [dbo].[People].[Balance]
	from dbo.People
	where [dbo].[People].[Id] = @Id;
end