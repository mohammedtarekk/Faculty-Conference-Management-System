
  CREATE OR REPLACE PROCEDURE "HR"."AUTHOR_SIGNUP" (
Aut_Fname in varchar2 , Aut_Sname in varchar2 , Aut_DoB in varchar2, 
Aut_Email in varchar2 ,Aut_Add in varchar2 ,Aut_pass in varchar2 
)
as
begin
insert into author (author_id, author_fname, author_sname, author_password, author_dbirth, author_email, author_address)
values(Author_Seq.nextval, aut_fname, aut_sname, aut_pass, aut_dob, aut_email, aut_add);

End;
/
 
  CREATE OR REPLACE PROCEDURE "HR"."GET_AUTHORS" (CID out sys_refcursor)
as
begin
open  CID  for
Select Author_ID,Author_Password from author;
End;
/
 
  CREATE OR REPLACE PROCEDURE "HR"."GET_REVIEWERS" (CID out sys_refcursor)
as
begin
open  CID  for
Select Reviewer_ID,Reviewer_Password from reviewer;
End;
/
 
  CREATE OR REPLACE PROCEDURE "HR"."REVIEWER_SIGNUP" (
Rev_Fname in varchar2 , Rev_Sname in varchar2 , Rev_DoB in varchar2, 
Rev_Email in varchar2 ,Rev_Add in varchar2 ,Rev_pass in varchar2 
)
as
begin
insert into Reviewer (Reviewer_id, Reviewer_fname, Reviewer_sname, Reviewer_password, Reviewer_dbirth, Reviewer_email, Reviewer_address)
values(Author_Seq.nextval, Rev_fname, Rev_sname,Rev_pass, Rev_dob, Rev_email, Rev_add);

End;
/
 