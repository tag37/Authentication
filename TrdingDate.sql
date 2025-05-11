SET STATISTICS TIME ON
DECLARE @CURRENT_DATE DATE = CONVERT(DATE, GETDATE());
DECLARE @MaxDate DATE = DATEADD(MONTH,2,@CURRENT_DATE);

WITH Calendar AS (
    SELECT @CURRENT_DATE AS calendar_date
    UNION ALL
    SELECT DATEADD(DAY, 1, calendar_date)
    FROM Calendar
    WHERE calendar_date <= @MaxDate
)


--SELECT 
--        *
--    FROM
--        (SELECT DISTINCT mic FROM TradingHoliday) mh
--    CROSS JOIN
--        Calendar c
--	LEFT JOIN
--        TradingHoliday h
--        ON h.mic = mh.mic AND h.holiday_date = c.calendar_date
--	where mh.mic = 'mic1'

--		OPTION (MAXRECURSION 1000);
, NonHolidayDates AS (
    SELECT DISTINCT
        mh.mic,
        c.calendar_date
    FROM
        (SELECT DISTINCT mic FROM TradingHoliday) mh
    CROSS JOIN
        Calendar c
    LEFT JOIN
        TradingHoliday h
        ON h.mic = mh.mic AND h.holiday_date = c.calendar_date
    WHERE
        h.holiday_date IS NULL		
)

--select * from NonHolidayDates where mic = 'mic1'
--OPTION (MAXRECURSION 1000);
, RankedNonHolidays AS (
    SELECT
        mic,
        calendar_date,
        ROW_NUMBER() OVER (PARTITION BY mic ORDER BY calendar_date) AS rn
    FROM
        NonHolidayDates
)

SELECT
    mic,
    calendar_date,
	rn
FROM
    RankedNonHolidays
WHERE
    rn <= 2
	--and mic = 'mic2'
ORDER BY
    mic,
    calendar_date
	OPTION (MAXRECURSION 100);

SET STATISTICS TIME OFF