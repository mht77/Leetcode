select w2.id
from Weather w1 left join Weather w2 on adddate(w1.recordDate, INTERVAL 1 DAY) = w2.recordDate
where w2.temperature > w1.temperature or w1.id IS NULL