select customer_id, count(customer_id) as count_no_trans
from Visits left join Transactions on Visits.visit_id = Transactions.visit_id
where ISNULL(transaction_id)
group by customer_id