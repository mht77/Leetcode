select E1.employee_id, E1.name, count(*) as reports_count, round(avg(E2.age), 0) as average_age
from Employees E1 inner join Employees E2 on E2.reports_to = E1.employee_id
group by E1.employee_id, E1.name
order by employee_id