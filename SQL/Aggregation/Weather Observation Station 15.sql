SELECT 
CAST(LONG_W as decimal (10,4)) 
FROM STATION 
WHERE LAT_N = 
    (SELECT MAX(LAT_N) FROM STATION WHERE LAT_N<137.2345);