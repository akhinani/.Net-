CREATE OR ALTER PROCEDURE SHOWBankDD(@acno int)as
BEGIN

SELECT * FROM BankDD where ACNO = @acno;
end;

exec SHOWBankDD 101