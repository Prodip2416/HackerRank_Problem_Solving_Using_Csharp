SELECT CAST(round(sum(lat_n),2) as decimal (10,2)), CAST(round(sum(long_w),2) as decimal (10,2)) FROM station;