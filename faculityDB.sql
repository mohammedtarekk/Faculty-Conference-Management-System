--------------------------------------------------------
--  File created - Thursday-April-16-2020   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Sequence ADMIN_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "ADMIN_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 21 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence AUTHOR_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "AUTHOR_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 22 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence PAPER_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "PAPER_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 21 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence REVIEWER_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "REVIEWER_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 21 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Table ADMIN
--------------------------------------------------------

  CREATE TABLE "ADMIN" 
   (	"ADMIN_ID" NUMBER(10,0), 
	"ADMIN_FNAME" VARCHAR2(50), 
	"ADMIN_SNAME" VARCHAR2(50), 
	"ADMIN_DBIRTH" VARCHAR2(100), 
	"ADMIN_EMAIL" VARCHAR2(100), 
	"ADMIN_ADDRESS" VARCHAR2(100), 
	"ADMIN_PASSWORD" VARCHAR2(100)
   ) ;
--------------------------------------------------------
--  DDL for Table AUTHOR
--------------------------------------------------------

  CREATE TABLE "AUTHOR" 
   (	"AUTHOR_ID" NUMBER(10,0), 
	"AUTHOR_FNAME" VARCHAR2(50), 
	"AUTHOR_SNAME" VARCHAR2(50), 
	"AUTHOR_DBIRTH" VARCHAR2(100), 
	"AUTHOR_EMAIL" VARCHAR2(100), 
	"AUTHOR_ADDRESS" VARCHAR2(100), 
	"AUTHOR_PASSWORD" VARCHAR2(100)
   ) ;
--------------------------------------------------------
--  DDL for Table AUTHOR_PHONES
--------------------------------------------------------

  CREATE TABLE "AUTHOR_PHONES" 
   (	"AUTHOR_ID" NUMBER(10,0), 
	"AUTHOR_PHONE" VARCHAR2(20)
   ) ;
--------------------------------------------------------
--  DDL for Table CONFERENCE
--------------------------------------------------------

  CREATE TABLE "CONFERENCE" 
   (	"CONFERENCE_ID" NUMBER(10,0), 
	"CONFERENCE_DATE" VARCHAR2(100), 
	"CONFERENCE_PLACE" VARCHAR2(100), 
	"CONFERENCE_DESCRIPTION" VARCHAR2(500), 
	"CONFERENCE_DURATION" NUMBER(10,0), 
	"AUTHOR_ID" NUMBER(10,0)
   ) ;
--------------------------------------------------------
--  DDL for Table DATES
--------------------------------------------------------

  CREATE TABLE "DATES" 
   (	"DAY_DATE" VARCHAR2(100), 
	"DAY_NAME" VARCHAR2(100), 
	"DAY_STATE" VARCHAR2(100)
   ) ;
--------------------------------------------------------
--  DDL for Table PAPER
--------------------------------------------------------

  CREATE TABLE "PAPER" 
   (	"PAPER_ID" NUMBER(10,0), 
	"PAPER_TITLE" VARCHAR2(50), 
	"PAPER_CONTENT" VARCHAR2(1000), 
	"RESEARCH_ID" NUMBER(10,0), 
	"AUTHOR_ID" NUMBER(10,0)
   ) ;
--------------------------------------------------------
--  DDL for Table RESEARCH_CATEGORYFIELD
--------------------------------------------------------

  CREATE TABLE "RESEARCH_CATEGORYFIELD" 
   (	"CATEGORY_ID" NUMBER(10,0), 
	"CATEGORY_NAME" VARCHAR2(50), 
	"CATEGORY_DESCRIBTION" VARCHAR2(200)
   ) ;
--------------------------------------------------------
--  DDL for Table REVIEW
--------------------------------------------------------

  CREATE TABLE "REVIEW" 
   (	"PAPER_ID" NUMBER(10,0), 
	"REVIEWER_ID" NUMBER(10,0), 
	"REV_STATE" VARCHAR2(100)
   ) ;
--------------------------------------------------------
--  DDL for Table REVIEWER
--------------------------------------------------------

  CREATE TABLE "REVIEWER" 
   (	"REVIEWER_ID" NUMBER(10,0), 
	"REVIEWER_FNAME" VARCHAR2(50), 
	"REVIEWER_SNAME" VARCHAR2(50), 
	"REVIEWER_DBIRTH" VARCHAR2(100), 
	"REVIEWER_EMAIL" VARCHAR2(100), 
	"REVIEWER_ADDRESS" VARCHAR2(100), 
	"REVIEWER_PASSWORD" VARCHAR2(100)
   ) ;
--------------------------------------------------------
--  DDL for Table REVIEWER_PHONES
--------------------------------------------------------

  CREATE TABLE "REVIEWER_PHONES" 
   (	"REVIEWER_ID" NUMBER(10,0), 
	"REVIEWER_PHONE" VARCHAR2(20)
   ) ;

---------------------------------------------------
--   DATA FOR TABLE AUTHOR
--   FILTER = none used
---------------------------------------------------
REM INSERTING into AUTHOR
Insert into AUTHOR (AUTHOR_ID,AUTHOR_FNAME,AUTHOR_SNAME,AUTHOR_DBIRTH,AUTHOR_EMAIL,AUTHOR_ADDRESS,AUTHOR_PASSWORD) values (1,'m','m','m','m','m','m');
Insert into AUTHOR (AUTHOR_ID,AUTHOR_FNAME,AUTHOR_SNAME,AUTHOR_DBIRTH,AUTHOR_EMAIL,AUTHOR_ADDRESS,AUTHOR_PASSWORD) values (2,'mm','mm','mm','mm','mm','mm');

---------------------------------------------------
--   END DATA FOR TABLE AUTHOR
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE DATES
--   FILTER = none used
---------------------------------------------------
REM INSERTING into DATES

---------------------------------------------------
--   END DATA FOR TABLE DATES
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE PAPER
--   FILTER = none used
---------------------------------------------------
REM INSERTING into PAPER
Insert into PAPER (PAPER_ID,PAPER_TITLE,PAPER_CONTENT,RESEARCH_ID,AUTHOR_ID) values (2,'meeting','we will hold meeting at 5 pm isa',1,1);
Insert into PAPER (PAPER_ID,PAPER_TITLE,PAPER_CONTENT,RESEARCH_ID,AUTHOR_ID) values (3,'medo','hhhhhhhhhhhhhh',1,1);
Insert into PAPER (PAPER_ID,PAPER_TITLE,PAPER_CONTENT,RESEARCH_ID,AUTHOR_ID) values (4,'testtest','hiiiiiiiiiiiii',2,0);
Insert into PAPER (PAPER_ID,PAPER_TITLE,PAPER_CONTENT,RESEARCH_ID,AUTHOR_ID) values (1,'medo','medo&yousef',1,2);
Insert into PAPER (PAPER_ID,PAPER_TITLE,PAPER_CONTENT,RESEARCH_ID,AUTHOR_ID) values (5,'test3','byeeeeeeeeeeee',3,1);

---------------------------------------------------
--   END DATA FOR TABLE PAPER
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE REVIEWER
--   FILTER = none used
---------------------------------------------------
REM INSERTING into REVIEWER
Insert into REVIEWER (REVIEWER_ID,REVIEWER_FNAME,REVIEWER_SNAME,REVIEWER_DBIRTH,REVIEWER_EMAIL,REVIEWER_ADDRESS,REVIEWER_PASSWORD) values (1,'r','r','r','r','r','r');

---------------------------------------------------
--   END DATA FOR TABLE REVIEWER
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE AUTHOR_PHONES
--   FILTER = none used
---------------------------------------------------
REM INSERTING into AUTHOR_PHONES

---------------------------------------------------
--   END DATA FOR TABLE AUTHOR_PHONES
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE ADMIN
--   FILTER = none used
---------------------------------------------------
REM INSERTING into ADMIN
Insert into ADMIN (ADMIN_ID,ADMIN_FNAME,ADMIN_SNAME,ADMIN_DBIRTH,ADMIN_EMAIL,ADMIN_ADDRESS,ADMIN_PASSWORD) values (1,'a','a','a','a','aa','a');

---------------------------------------------------
--   END DATA FOR TABLE ADMIN
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE CONFERENCE
--   FILTER = none used
---------------------------------------------------
REM INSERTING into CONFERENCE

---------------------------------------------------
--   END DATA FOR TABLE CONFERENCE
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE REVIEW
--   FILTER = none used
---------------------------------------------------
REM INSERTING into REVIEW

---------------------------------------------------
--   END DATA FOR TABLE REVIEW
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE RESEARCH_CATEGORYFIELD
--   FILTER = none used
---------------------------------------------------
REM INSERTING into RESEARCH_CATEGORYFIELD
Insert into RESEARCH_CATEGORYFIELD (CATEGORY_ID,CATEGORY_NAME,CATEGORY_DESCRIBTION) values (1,'CS',' Computer Sciences');
Insert into RESEARCH_CATEGORYFIELD (CATEGORY_ID,CATEGORY_NAME,CATEGORY_DESCRIBTION) values (2,'Eco','Economy');
Insert into RESEARCH_CATEGORYFIELD (CATEGORY_ID,CATEGORY_NAME,CATEGORY_DESCRIBTION) values (3,'Bio','Biology');

---------------------------------------------------
--   END DATA FOR TABLE RESEARCH_CATEGORYFIELD
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE REVIEWER_PHONES
--   FILTER = none used
---------------------------------------------------
REM INSERTING into REVIEWER_PHONES

---------------------------------------------------
--   END DATA FOR TABLE REVIEWER_PHONES
---------------------------------------------------
--------------------------------------------------------
--  Constraints for Table ADMIN
--------------------------------------------------------

  ALTER TABLE "ADMIN" MODIFY ("ADMIN_ID" NOT NULL ENABLE);
 
  ALTER TABLE "ADMIN" ADD PRIMARY KEY ("ADMIN_ID") ENABLE;
--------------------------------------------------------
--  Constraints for Table AUTHOR
--------------------------------------------------------

  ALTER TABLE "AUTHOR" MODIFY ("AUTHOR_ID" NOT NULL ENABLE);
 
  ALTER TABLE "AUTHOR" ADD PRIMARY KEY ("AUTHOR_ID") ENABLE;
--------------------------------------------------------
--  Constraints for Table AUTHOR_PHONES
--------------------------------------------------------

  ALTER TABLE "AUTHOR_PHONES" MODIFY ("AUTHOR_ID" NOT NULL ENABLE);
 
  ALTER TABLE "AUTHOR_PHONES" ADD PRIMARY KEY ("AUTHOR_ID") ENABLE;
--------------------------------------------------------
--  Constraints for Table CONFERENCE
--------------------------------------------------------

  ALTER TABLE "CONFERENCE" MODIFY ("CONFERENCE_ID" NOT NULL ENABLE);
 
  ALTER TABLE "CONFERENCE" ADD PRIMARY KEY ("CONFERENCE_ID") ENABLE;
--------------------------------------------------------
--  Constraints for Table DATES
--------------------------------------------------------

  ALTER TABLE "DATES" MODIFY ("DAY_DATE" NOT NULL ENABLE);
 
  ALTER TABLE "DATES" ADD PRIMARY KEY ("DAY_DATE") ENABLE;
--------------------------------------------------------
--  Constraints for Table PAPER
--------------------------------------------------------

  ALTER TABLE "PAPER" MODIFY ("PAPER_ID" NOT NULL ENABLE);
 
  ALTER TABLE "PAPER" ADD PRIMARY KEY ("PAPER_ID") ENABLE;
--------------------------------------------------------
--  Constraints for Table RESEARCH_CATEGORYFIELD
--------------------------------------------------------

  ALTER TABLE "RESEARCH_CATEGORYFIELD" MODIFY ("CATEGORY_ID" NOT NULL ENABLE);
 
  ALTER TABLE "RESEARCH_CATEGORYFIELD" ADD PRIMARY KEY ("CATEGORY_ID") ENABLE;
--------------------------------------------------------
--  Constraints for Table REVIEW
--------------------------------------------------------

  ALTER TABLE "REVIEW" ADD CONSTRAINT "PK_REVIEW" PRIMARY KEY ("PAPER_ID", "REVIEWER_ID") ENABLE;
 
  ALTER TABLE "REVIEW" MODIFY ("PAPER_ID" NOT NULL ENABLE);
 
  ALTER TABLE "REVIEW" MODIFY ("REVIEWER_ID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table REVIEWER
--------------------------------------------------------

  ALTER TABLE "REVIEWER" MODIFY ("REVIEWER_ID" NOT NULL ENABLE);
 
  ALTER TABLE "REVIEWER" ADD PRIMARY KEY ("REVIEWER_ID") ENABLE;
--------------------------------------------------------
--  Constraints for Table REVIEWER_PHONES
--------------------------------------------------------

  ALTER TABLE "REVIEWER_PHONES" MODIFY ("REVIEWER_ID" NOT NULL ENABLE);
 
  ALTER TABLE "REVIEWER_PHONES" ADD PRIMARY KEY ("REVIEWER_ID") ENABLE;



--------------------------------------------------------
--  Ref Constraints for Table CONFERENCE
--------------------------------------------------------

  ALTER TABLE "CONFERENCE" ADD FOREIGN KEY ("CONFERENCE_DATE")
	  REFERENCES "DATES" ("DAY_DATE") ENABLE;

--------------------------------------------------------
--  Ref Constraints for Table PAPER
--------------------------------------------------------

  ALTER TABLE "PAPER" ADD FOREIGN KEY ("RESEARCH_ID")
	  REFERENCES "RESEARCH_CATEGORYFIELD" ("CATEGORY_ID") ENABLE;

--------------------------------------------------------
--  Ref Constraints for Table REVIEW
--------------------------------------------------------

  ALTER TABLE "REVIEW" ADD FOREIGN KEY ("PAPER_ID")
	  REFERENCES "PAPER" ("PAPER_ID") ENABLE;


--------------------------------------------------------
--  DDL for Procedure ADMIN_SIGNUP
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "ADMIN_SIGNUP" (
Admin_Fname in varchar2 , Admin_Sname in varchar2 , Admin_DoB in varchar2, 
Admin_Email in varchar2 ,Admin_Add in varchar2 ,Admin_pass in varchar2 
)
as
begin
insert into Admin (Admin_id, Admin_fname,Admin_sname, Admin_password,Admin_dbirth, Admin_email, Admin_address)
values(Admin_Seq.nextval, Admin_fname, Admin_sname,Admin_pass, Admin_dob,Admin_email, Admin_add);

End;

/

--------------------------------------------------------
--  DDL for Procedure AUTHOR_SIGNUP
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "AUTHOR_SIGNUP" (
Aut_Fname in varchar2 , Aut_Sname in varchar2 , Aut_DoB in varchar2, 
Aut_Email in varchar2 ,Aut_Add in varchar2 ,Aut_pass in varchar2 
)
as
begin
insert into author (author_id, author_fname, author_sname, author_password, author_dbirth, author_email, author_address)
values(Author_Seq.nextval, aut_fname, aut_sname, aut_pass, aut_dob, aut_email, aut_add);

End;

/

--------------------------------------------------------
--  DDL for Procedure GET_ADMINS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GET_ADMINS" (CID out sys_refcursor)
as
begin
open  CID  for
Select Admin_ID,Admin_Password from Admin;
End;

/

--------------------------------------------------------
--  DDL for Procedure GET_AUTHORS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GET_AUTHORS" (CID out sys_refcursor)
as
begin
open  CID  for
Select Author_ID,Author_Password from author;
End;

/

--------------------------------------------------------
--  DDL for Procedure GET_CATID
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GET_CATID" 
(cat_id out number,cat_name in VARCHAR2)
as
begin
select Category_ID
into cat_id
from RESEARCH_CATEGORYFIELD
where category_name= cat_name;
end;

/

--------------------------------------------------------
--  DDL for Procedure GET_REVIEWERS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GET_REVIEWERS" (CID out sys_refcursor)
as
begin
open  CID  for
Select Reviewer_ID,Reviewer_Password from reviewer;
End;

/

--------------------------------------------------------
--  DDL for Procedure REVIEWER_SIGNUP
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "REVIEWER_SIGNUP" (
Rev_Fname in varchar2 , Rev_Sname in varchar2 , Rev_DoB in varchar2, 
Rev_Email in varchar2 ,Rev_Add in varchar2 ,Rev_pass in varchar2 
)
as
begin
insert into Reviewer (Reviewer_id, Reviewer_fname, Reviewer_sname, Reviewer_password, Reviewer_dbirth, Reviewer_email, Reviewer_address)
values(Author_Seq.nextval, Rev_fname, Rev_sname,Rev_pass, Rev_dob, Rev_email, Rev_add);

End;

/

