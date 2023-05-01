create or alter procedure showsp_Getsalary 
 @empid int output,  @salary money output
 
as
begin
select salary = @salary from EMPP where empid =@empid 
end;




