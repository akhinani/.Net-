create table test
(Id int,Name varchar(20));

select * from test;

insert into test values(101,'Akhi')
insert into test values(102,'Nani')
insert into test values(103,'Bhas')
insert into test values(104,'Therath')
insert into test values(105,'Sait')

truncate table test

update test set Name = 'Sai'
where Id = 105
