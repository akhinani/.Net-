DECLARE @@salary INT; 
DECLARE salary_cursor CURSOR
FOR
SELECT salary FROM EMPP 
ORDER BY salary;

OPEN salary_cursor;
FETCH NEXT FROM salary_cursor
INTO @@salary;

WHILE @@FETCH_STATUS = 0 
BEGIN
 
FETCH NEXT FROM salary_cursor
INTO @@salary; 
END
CLOSE salary_cursor

DEALLOCATE salary_cursor;

exec @@salary =@@salary output