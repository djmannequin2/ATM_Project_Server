CREATE PROCEDURE [dbo].[SetBalance]
	@Id int,
	@Balance money
AS
begin
	update dbo.People
	set [dbo].[People].[Balance] = @Balance
	where [dbo].[People].[Id] = @Id;
end
