select round(count(distinct A1.player_id)/(select count(distinct player_id) from Activity), 2) as fraction
from Activity A1
where (A1.player_id, date_sub(A1.event_date, interval 1 day )) IN
(select player_id, min(event_date) from Activity group by player_id)