select distinct CITY from STATION where (CITY NOT LIKE '[aeiou]%') AND  (CITY NOT LIKE '%[aeiou]') group by CITY;