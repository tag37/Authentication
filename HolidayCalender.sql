-- Replace with your actual table
-- CREATE TABLE your_table (mic VARCHAR(10), holiday_date DATE);

DECLARE @micList TABLE (mic VARCHAR(10));
DECLARE @i INT = 0;

-- Step 1: Generate 10 random MICs (e.g., country codes)
WHILE @i < 100
BEGIN
    INSERT INTO @micList (mic)
    SELECT LEFT(NEWID(), 6);  -- 6-char random alphanumeric
    SET @i += 1;
END;

-- Step 2: Generate 200 random holiday entries across these MICs
DECLARE @counter INT = 0;
DECLARE @randomMic VARCHAR(10);
DECLARE @randomDate DATE;

WHILE @counter < 200
BEGIN
    -- Pick a random MIC from the list
    SELECT TOP 1 @randomMic = mic FROM @micList ORDER BY NEWID();

    -- Generate a random date between 2025-05-28 and 2027-05-28
    SET @randomDate = DATEADD(DAY, ABS(CHECKSUM(NEWID())) % DATEDIFF(DAY, '2025-05-28', '2026-05-28'), '2025-05-28');

    -- Insert into target table
    INSERT INTO TradingHoliday (mic, holiday_date)
    VALUES (@randomMic, @randomDate);

    SET @counter += 1;
END;


-- select * from TradingHoliday TH  order by mic, holiday_Date
--delete from TradingHoliday where mic not like '%mic%' 
--order by mic

-- select * from TradingHoliday 