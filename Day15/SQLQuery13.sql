create trigger Id on test
after insert
as
select 'Row Created';