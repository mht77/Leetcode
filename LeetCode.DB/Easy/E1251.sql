select P.product_id, round(sum(P.price*U.units)/sum(units), 2) as average_price
from Prices P inner join UnitsSold U on P.product_id = U.product_id
                                            and P.start_date <= U.purchase_date
                                            and U.purchase_date <= P.end_date
group by P.product_id