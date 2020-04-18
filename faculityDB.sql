--------------------------------------------------------
--  File created - Sunday-April-19-2020   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Sequence ADMIN_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "ADMIN_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 21 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence AUTHOR_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "AUTHOR_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 21 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence PAPER_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "PAPER_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 21 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence REVIEWER_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "REVIEWER_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 41 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ_CON
--------------------------------------------------------

   CREATE SEQUENCE  "SEQ_CON"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 61 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ_PAPER
--------------------------------------------------------

   CREATE SEQUENCE  "SEQ_PAPER"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 61 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ_REV
--------------------------------------------------------

   CREATE SEQUENCE  "SEQ_REV"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 101 CACHE 20 NOORDER  NOCYCLE ;
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
	"PAPER_TITLE" VARCHAR2(500), 
	"CONFERENCE_DURATION" NUMBER(10,0), 
	"PAPER_ID" NUMBER(10,0)
   ) ;
--------------------------------------------------------
--  DDL for Table DATES
--------------------------------------------------------

  CREATE TABLE "DATES" 
   (	"DAY_DATE" VARCHAR2(100), 
	"DAY_NAME" VARCHAR2(100), 
	"DAY_STATE" CHAR(1) DEFAULT 1
   ) ;
 

   COMMENT ON COLUMN "DATES"."DAY_STATE" IS '1 = available 0 = not available';
--------------------------------------------------------
--  DDL for Table PAPER
--------------------------------------------------------

  CREATE TABLE "PAPER" 
   (	"PAPER_ID" NUMBER(10,0), 
	"PAPER_TITLE" VARCHAR2(50), 
	"PAPER_CONTENT" VARCHAR2(1000), 
	"RESEARCH_ID" NUMBER(10,0), 
	"AUTHOR_ID" NUMBER(10,0), 
	"IS_ASSIGNED" CHAR(1) DEFAULT 0
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
	"REVIEWER_PASSWORD" VARCHAR2(100), 
	"ASSIGNED_PAPERS" NUMBER DEFAULT 0
   ) ;
--------------------------------------------------------
--  DDL for Table REVIEWER_DATES
--------------------------------------------------------

  CREATE TABLE "REVIEWER_DATES" 
   (	"REVIEWER_ID" NUMBER, 
	"REV_DATE" VARCHAR2(10)
   ) ;
--------------------------------------------------------
--  DDL for Table REVIEWER_PHONES
--------------------------------------------------------

  CREATE TABLE "REVIEWER_PHONES" 
   (	"REVIEWER_ID" NUMBER(10,0), 
	"REVIEWER_PHONE" VARCHAR2(20)
   ) ;

---------------------------------------------------
--   DATA FOR TABLE REVIEWER
--   FILTER = none used
---------------------------------------------------
REM INSERTING into REVIEWER
Insert into REVIEWER (REVIEWER_ID,REVIEWER_FNAME,REVIEWER_SNAME,REVIEWER_DBIRTH,REVIEWER_EMAIL,REVIEWER_ADDRESS,REVIEWER_PASSWORD,ASSIGNED_PAPERS) values (1,'r','r','r','r','r','r',2);
Insert into REVIEWER (REVIEWER_ID,REVIEWER_FNAME,REVIEWER_SNAME,REVIEWER_DBIRTH,REVIEWER_EMAIL,REVIEWER_ADDRESS,REVIEWER_PASSWORD,ASSIGNED_PAPERS) values (2,'r2','r2','r2','r2','r2','r2',1);
Insert into REVIEWER (REVIEWER_ID,REVIEWER_FNAME,REVIEWER_SNAME,REVIEWER_DBIRTH,REVIEWER_EMAIL,REVIEWER_ADDRESS,REVIEWER_PASSWORD,ASSIGNED_PAPERS) values (3,'r3','r3','r3','r3','r3','r3',1);
Insert into REVIEWER (REVIEWER_ID,REVIEWER_FNAME,REVIEWER_SNAME,REVIEWER_DBIRTH,REVIEWER_EMAIL,REVIEWER_ADDRESS,REVIEWER_PASSWORD,ASSIGNED_PAPERS) values (4,'r4','r4','r4','r4','r4','r4',0);

---------------------------------------------------
--   END DATA FOR TABLE REVIEWER
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
--   DATA FOR TABLE CONFERENCE
--   FILTER = none used
---------------------------------------------------
REM INSERTING into CONFERENCE
Insert into CONFERENCE (CONFERENCE_ID,CONFERENCE_DATE,CONFERENCE_PLACE,PAPER_TITLE,CONFERENCE_DURATION,PAPER_ID) values (1,'19/4/2020','Fahmy Tolba HAll','medo',2,1);

---------------------------------------------------
--   END DATA FOR TABLE CONFERENCE
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE REVIEW
--   FILTER = none used
---------------------------------------------------
REM INSERTING into REVIEW
Insert into REVIEW (PAPER_ID,REVIEWER_ID,REV_STATE) values (3,1,'Waiting');
Insert into REVIEW (PAPER_ID,REVIEWER_ID,REV_STATE) values (1,1,'Accepted');
Insert into REVIEW (PAPER_ID,REVIEWER_ID,REV_STATE) values (2,2,'Rejected');
Insert into REVIEW (PAPER_ID,REVIEWER_ID,REV_STATE) values (4,3,'Waiting');
Insert into REVIEW (PAPER_ID,REVIEWER_ID,REV_STATE) values (4,1,'Waiting');

---------------------------------------------------
--   END DATA FOR TABLE REVIEW
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE AUTHOR
--   FILTER = none used
---------------------------------------------------
REM INSERTING into AUTHOR
Insert into AUTHOR (AUTHOR_ID,AUTHOR_FNAME,AUTHOR_SNAME,AUTHOR_DBIRTH,AUTHOR_EMAIL,AUTHOR_ADDRESS,AUTHOR_PASSWORD) values (1,'m','m','m','m','m','m');
Insert into AUTHOR (AUTHOR_ID,AUTHOR_FNAME,AUTHOR_SNAME,AUTHOR_DBIRTH,AUTHOR_EMAIL,AUTHOR_ADDRESS,AUTHOR_PASSWORD) values (2,'mm','mm','mm','mm','mm','mm');
Insert into AUTHOR (AUTHOR_ID,AUTHOR_FNAME,AUTHOR_SNAME,AUTHOR_DBIRTH,AUTHOR_EMAIL,AUTHOR_ADDRESS,AUTHOR_PASSWORD) values (3,'Ali','Ahmed','20/10/1990','Ali@gmail.com','blalball','ali');
Insert into AUTHOR (AUTHOR_ID,AUTHOR_FNAME,AUTHOR_SNAME,AUTHOR_DBIRTH,AUTHOR_EMAIL,AUTHOR_ADDRESS,AUTHOR_PASSWORD) values (4,'Ahmed','Khaled','20/9/1995','Ahmed@gmail.com','blalball','ahmed');

---------------------------------------------------
--   END DATA FOR TABLE AUTHOR
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE AUTHOR_PHONES
--   FILTER = none used
---------------------------------------------------
REM INSERTING into AUTHOR_PHONES
Insert into AUTHOR_PHONES (AUTHOR_ID,AUTHOR_PHONE) values (1,'01141931203');
Insert into AUTHOR_PHONES (AUTHOR_ID,AUTHOR_PHONE) values (2,'01001419267');
Insert into AUTHOR_PHONES (AUTHOR_ID,AUTHOR_PHONE) values (3,'01061057079');

---------------------------------------------------
--   END DATA FOR TABLE AUTHOR_PHONES
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE DATES
--   FILTER = none used
---------------------------------------------------
REM INSERTING into DATES
Insert into DATES (DAY_DATE,DAY_NAME,DAY_STATE) values ('19/4/2020','sunday','0');
Insert into DATES (DAY_DATE,DAY_NAME,DAY_STATE) values ('20/4/2020','monday','0');
Insert into DATES (DAY_DATE,DAY_NAME,DAY_STATE) values ('21/4/2020','tuesday','0');
Insert into DATES (DAY_DATE,DAY_NAME,DAY_STATE) values ('22/4/2020','wednesday','1');
Insert into DATES (DAY_DATE,DAY_NAME,DAY_STATE) values ('23/4/2020','thursday','1');

---------------------------------------------------
--   END DATA FOR TABLE DATES
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE PAPER
--   FILTER = none used
---------------------------------------------------
REM INSERTING into PAPER
Insert into PAPER (PAPER_ID,PAPER_TITLE,PAPER_CONTENT,RESEARCH_ID,AUTHOR_ID,IS_ASSIGNED) values (2,'meeting','we will hold meeting at 5 pm isa',1,3,'1');
Insert into PAPER (PAPER_ID,PAPER_TITLE,PAPER_CONTENT,RESEARCH_ID,AUTHOR_ID,IS_ASSIGNED) values (3,'medo','hhhhhhhhhhhhhh',1,1,'0');
Insert into PAPER (PAPER_ID,PAPER_TITLE,PAPER_CONTENT,RESEARCH_ID,AUTHOR_ID,IS_ASSIGNED) values (4,'testtest','hiiiiiiiiiiiii',2,2,'1');
Insert into PAPER (PAPER_ID,PAPER_TITLE,PAPER_CONTENT,RESEARCH_ID,AUTHOR_ID,IS_ASSIGNED) values (1,'medo','medo1',1,1,'1');
Insert into PAPER (PAPER_ID,PAPER_TITLE,PAPER_CONTENT,RESEARCH_ID,AUTHOR_ID,IS_ASSIGNED) values (5,'test3','byeeeeeeeeeeee',3,3,'0');
Insert into PAPER (PAPER_ID,PAPER_TITLE,PAPER_CONTENT,RESEARCH_ID,AUTHOR_ID,IS_ASSIGNED) values (6,'AI','AI Content byeeeeeeeeeeee',1,4,'0');

---------------------------------------------------
--   END DATA FOR TABLE PAPER
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE REVIEWER_PHONES
--   FILTER = none used
---------------------------------------------------
REM INSERTING into REVIEWER_PHONES
Insert into REVIEWER_PHONES (REVIEWER_ID,REVIEWER_PHONE) values (1,'0111111111');
Insert into REVIEWER_PHONES (REVIEWER_ID,REVIEWER_PHONE) values (2,'0222222222');
Insert into REVIEWER_PHONES (REVIEWER_ID,REVIEWER_PHONE) values (3,'0333333333');
Insert into REVIEWER_PHONES (REVIEWER_ID,REVIEWER_PHONE) values (4,'0444444444');

---------------------------------------------------
--   END DATA FOR TABLE REVIEWER_PHONES
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE REVIEWER_DATES
--   FILTER = none used
---------------------------------------------------
REM INSERTING into REVIEWER_DATES
Insert into REVIEWER_DATES (REVIEWER_ID,REV_DATE) values (3,'20/4/2020');
Insert into REVIEWER_DATES (REVIEWER_ID,REV_DATE) values (4,'21/4/2020');
Insert into REVIEWER_DATES (REVIEWER_ID,REV_DATE) values (2,'19/4/2020');
Insert into REVIEWER_DATES (REVIEWER_ID,REV_DATE) values (1,'22/4/2020');
Insert into REVIEWER_DATES (REVIEWER_ID,REV_DATE) values (1,'21/4/2020');
Insert into REVIEWER_DATES (REVIEWER_ID,REV_DATE) values (3,'22/4/2020');

---------------------------------------------------
--   END DATA FOR TABLE REVIEWER_DATES
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
 
  ALTER TABLE "DATES" MODIFY ("DAY_STATE" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table PAPER
--------------------------------------------------------

  ALTER TABLE "PAPER" MODIFY ("PAPER_ID" NOT NULL ENABLE);
 
  ALTER TABLE "PAPER" ADD PRIMARY KEY ("PAPER_ID") ENABLE;
 
  ALTER TABLE "PAPER" MODIFY ("PAPER_TITLE" NOT NULL ENABLE);
 
  ALTER TABLE "PAPER" MODIFY ("PAPER_CONTENT" NOT NULL ENABLE);
 
  ALTER TABLE "PAPER" MODIFY ("RESEARCH_ID" NOT NULL ENABLE);
 
  ALTER TABLE "PAPER" MODIFY ("AUTHOR_ID" NOT NULL ENABLE);
 
  ALTER TABLE "PAPER" MODIFY ("IS_ASSIGNED" NOT NULL ENABLE);
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
 
  ALTER TABLE "REVIEWER" MODIFY ("ASSIGNED_PAPERS" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table REVIEWER_DATES
--------------------------------------------------------

  ALTER TABLE "REVIEWER_DATES" MODIFY ("REVIEWER_ID" NOT NULL ENABLE);
 
  ALTER TABLE "REVIEWER_DATES" MODIFY ("REV_DATE" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table REVIEWER_PHONES
--------------------------------------------------------

  ALTER TABLE "REVIEWER_PHONES" MODIFY ("REVIEWER_ID" NOT NULL ENABLE);
 
  ALTER TABLE "REVIEWER_PHONES" ADD PRIMARY KEY ("REVIEWER_ID") ENABLE;
--------------------------------------------------------
--  DDL for Index PK_REVIEW
--------------------------------------------------------

  CREATE UNIQUE INDEX "PK_REVIEW" ON "REVIEW" ("PAPER_ID", "REVIEWER_ID") 
  ;



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

