WITH TradingHourDotCount AS (
    SELECT *,
           LEN(fin_id) - LEN(REPLACE(fin_id, '.', '')) AS DotCount
    FROM TradingHour
),
MinDotPerMicID AS (
    SELECT mic_id, MIN(DotCount) MinDotCount, min(start_time) start_time, MAX(end_time) end_time 
    FROM TradingHourDotCount D
    GROUP BY mic_id
),
FilteredRecords AS (
    SELECT distinct M.mic_id,M.start_time,M.end_time,D.timezone
    FROM TradingHourDotCount D
    INNER JOIN MinDotPerMicID M
    ON d.mic_id = m.mic_id AND d.DotCount = m.MinDotCount
)
SELECT * FROM FilteredRecords;