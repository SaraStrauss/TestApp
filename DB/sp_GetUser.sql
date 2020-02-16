create procedure SP_GetUser(@email varchar(50))
as begin
Select * from Users
where Users.Email=@email
end