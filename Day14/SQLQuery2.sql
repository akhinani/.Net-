SELECT * FROM BankDD

SELECT a.ACNO AS ACCOUNT, a.[Account Holder name] ,a.Balance,
a.[Ref No] as [REF ACCOUNT NUMBER],b.[Account Holder Name] as [Reference Account Number]
FROM BankDD a left join BankDD b on a.[Ref No] = b.ACNO