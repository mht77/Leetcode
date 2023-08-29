select person_name
from Queue
where person_id in
    (select Q1.person_id
    from Queue Q1 inner join Queue Q2 on Q1.turn >= Q2.turn
    group by Q1.person_id
    having sum(Q2.weight) <= 1000
    order by sum(Q2.weight)
    )
order by turn desc
limit 1