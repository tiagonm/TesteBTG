select ReportsTo,count(*) as QtdeRepostadores,avg(Age) as MediaIdade from TablePerson
where ReportsTo is not null
group by ReportsTo
