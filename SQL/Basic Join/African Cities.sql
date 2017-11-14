select c.NAME
from CITY as c
left join COUNTRY as ct on c.COUNTRYCODE=ct.CODE
where ct.CONTINENT='Africa';