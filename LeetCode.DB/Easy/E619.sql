select max(num) as num
from (select num from MyNumbers
        group by num
        having count(num) = 1
        order by num desc) as MNn