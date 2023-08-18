select S.student_id, S.student_name, S2.subject_name, count(E.student_id) as attended_exams
from Students S cross join Subjects S2 left join Examinations E on S.student_id = E.student_id and E.subject_name = S2.subject_name
group by S.student_id, S.student_name, S2.subject_name
order by S.student_id, S2.subject_name