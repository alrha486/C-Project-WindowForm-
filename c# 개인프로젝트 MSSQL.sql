use Hospital

select *from board 
create table board(
title varchar(100),
writer varchar(100),
text_ varchar(8000),
day_ varchar(100)
)

select *from doctor
create table doctor(
doc_name varchar(100),
doc_age varchar(100),
doc_add varchar(100),
doc_ph varchar(100),
doc_duty varchar(100)
)

select *from member
create table member(
m_name varchar(100),
m_num varchar(100),
m_add varchar(100),
m_age varchar(100),
m_ph  varchar(100),
m_id varchar(100),
m_pw varchar(100)
)

select *from reservation
create table reservation(
section varchar(100),
name varchar(100),
p_num varchar(100),
p_add varchar(500),
ph varchar(100),
d_name varchar(100),
r_date varchar(100),
symptom varchar(500)
)