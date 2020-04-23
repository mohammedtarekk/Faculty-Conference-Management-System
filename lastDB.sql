--------------------------------------------------------
--  File created - Thursday-April-23-2020   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Sequence ADMIN_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "ADMIN_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 2 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence AUTHOR_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "AUTHOR_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 26 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence CON_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "CON_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence PAPER_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "PAPER_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 14 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence REVIEWER_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "REVIEWER_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 8 CACHE 20 NOORDER  NOCYCLE ;
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
	"HALL" VARCHAR2(100)
   ) ;
--------------------------------------------------------
--  DDL for Table PAPER
--------------------------------------------------------

  CREATE TABLE "PAPER" 
   (	"PAPER_ID" NUMBER(10,0), 
	"PAPER_TITLE" VARCHAR2(50), 
	"PAPER_CONTENT" VARCHAR2(1000), 
	"RESEARCH_ID" NUMBER(10,0), 
	"AUTHOR_ID" NUMBER(10,0), 
	"IS_ASSIGNED" CHAR(1) DEFAULT 0, 
	"HASCONFERENCE" NUMBER DEFAULT 0
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
--   DATA FOR TABLE DATES
--   FILTER = none used
---------------------------------------------------
REM INSERTING into DATES

---------------------------------------------------
--   END DATA FOR TABLE DATES
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
--   DATA FOR TABLE REVIEWER
--   FILTER = none used
---------------------------------------------------
REM INSERTING into REVIEWER
Insert into REVIEWER (REVIEWER_ID,REVIEWER_FNAME,REVIEWER_SNAME,REVIEWER_DBIRTH,REVIEWER_EMAIL,REVIEWER_ADDRESS,REVIEWER_PASSWORD,ASSIGNED_PAPERS) values (7,'admin','1','17/12/1969','admin@gmail.com','cairo','admin',0);
Insert into REVIEWER (REVIEWER_ID,REVIEWER_FNAME,REVIEWER_SNAME,REVIEWER_DBIRTH,REVIEWER_EMAIL,REVIEWER_ADDRESS,REVIEWER_PASSWORD,ASSIGNED_PAPERS) values (1,'r','r','17/12/1969','r@gmail.com','cairo','rr',5);
Insert into REVIEWER (REVIEWER_ID,REVIEWER_FNAME,REVIEWER_SNAME,REVIEWER_DBIRTH,REVIEWER_EMAIL,REVIEWER_ADDRESS,REVIEWER_PASSWORD,ASSIGNED_PAPERS) values (2,'r2','r2','17/12/1969','r2@gmail.com','cairo','r2',2);
Insert into REVIEWER (REVIEWER_ID,REVIEWER_FNAME,REVIEWER_SNAME,REVIEWER_DBIRTH,REVIEWER_EMAIL,REVIEWER_ADDRESS,REVIEWER_PASSWORD,ASSIGNED_PAPERS) values (4,'r4','r4','17/12/1969','r4@gmail.com','cairo','r4',0);
Insert into REVIEWER (REVIEWER_ID,REVIEWER_FNAME,REVIEWER_SNAME,REVIEWER_DBIRTH,REVIEWER_EMAIL,REVIEWER_ADDRESS,REVIEWER_PASSWORD,ASSIGNED_PAPERS) values (5,'mostafa','nasr','17/12/1969','mostafa@hotmail.com','7 hafez ibrahem','m',0);
Insert into REVIEWER (REVIEWER_ID,REVIEWER_FNAME,REVIEWER_SNAME,REVIEWER_DBIRTH,REVIEWER_EMAIL,REVIEWER_ADDRESS,REVIEWER_PASSWORD,ASSIGNED_PAPERS) values (6,'medo','kmal','17/12/1969','yousef@hotmail.com','cairo','m',0);
Insert into REVIEWER (REVIEWER_ID,REVIEWER_FNAME,REVIEWER_SNAME,REVIEWER_DBIRTH,REVIEWER_EMAIL,REVIEWER_ADDRESS,REVIEWER_PASSWORD,ASSIGNED_PAPERS) values (3,'r3','r3','17/12/1969','r3@gmail.com','cairo','r3',1);

---------------------------------------------------
--   END DATA FOR TABLE REVIEWER
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
--   DATA FOR TABLE REVIEWER_PHONES
--   FILTER = none used
---------------------------------------------------
REM INSERTING into REVIEWER_PHONES
Insert into REVIEWER_PHONES (REVIEWER_ID,REVIEWER_PHONE) values (1,'0111111111');
Insert into REVIEWER_PHONES (REVIEWER_ID,REVIEWER_PHONE) values (2,'0222222222');
Insert into REVIEWER_PHONES (REVIEWER_ID,REVIEWER_PHONE) values (3,'0333333333');
Insert into REVIEWER_PHONES (REVIEWER_ID,REVIEWER_PHONE) values (4,'0444444444');
Insert into REVIEWER_PHONES (REVIEWER_ID,REVIEWER_PHONE) values (5,'0235895178');
Insert into REVIEWER_PHONES (REVIEWER_ID,REVIEWER_PHONE) values (6,'02105498751');

---------------------------------------------------
--   END DATA FOR TABLE REVIEWER_PHONES
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
--   DATA FOR TABLE AUTHOR
--   FILTER = none used
---------------------------------------------------
REM INSERTING into AUTHOR
Insert into AUTHOR (AUTHOR_ID,AUTHOR_FNAME,AUTHOR_SNAME,AUTHOR_DBIRTH,AUTHOR_EMAIL,AUTHOR_ADDRESS,AUTHOR_PASSWORD) values (6,'author','author','17/2/1960','author@gmail.com','cairo','author');
Insert into AUTHOR (AUTHOR_ID,AUTHOR_FNAME,AUTHOR_SNAME,AUTHOR_DBIRTH,AUTHOR_EMAIL,AUTHOR_ADDRESS,AUTHOR_PASSWORD) values (1,'m','m','m','m','m','mm');
Insert into AUTHOR (AUTHOR_ID,AUTHOR_FNAME,AUTHOR_SNAME,AUTHOR_DBIRTH,AUTHOR_EMAIL,AUTHOR_ADDRESS,AUTHOR_PASSWORD) values (2,'mm','mm','mm','mm','mm','mm');
Insert into AUTHOR (AUTHOR_ID,AUTHOR_FNAME,AUTHOR_SNAME,AUTHOR_DBIRTH,AUTHOR_EMAIL,AUTHOR_ADDRESS,AUTHOR_PASSWORD) values (3,'Ahmed','Khaled','20/9/1995','Ahmed@gmail.com','blalball','ahmed');
Insert into AUTHOR (AUTHOR_ID,AUTHOR_FNAME,AUTHOR_SNAME,AUTHOR_DBIRTH,AUTHOR_EMAIL,AUTHOR_ADDRESS,AUTHOR_PASSWORD) values (4,'mohamed','ahmed','2000','yousef@hotmail.com','nasr city','m');
Insert into AUTHOR (AUTHOR_ID,AUTHOR_FNAME,AUTHOR_SNAME,AUTHOR_DBIRTH,AUTHOR_EMAIL,AUTHOR_ADDRESS,AUTHOR_PASSWORD) values (5,'kmal','medo','2000','yousef@hotamil.com','egypt','m');

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
Insert into AUTHOR_PHONES (AUTHOR_ID,AUTHOR_PHONE) values (4,'01008075453');
Insert into AUTHOR_PHONES (AUTHOR_ID,AUTHOR_PHONE) values (5,'20122689523');

---------------------------------------------------
--   END DATA FOR TABLE AUTHOR_PHONES
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

---------------------------------------------------
--   DATA FOR TABLE PAPER
--   FILTER = none used
---------------------------------------------------
REM INSERTING into PAPER
Insert into PAPER (PAPER_ID,PAPER_TITLE,PAPER_CONTENT,RESEARCH_ID,AUTHOR_ID,IS_ASSIGNED,HASCONFERENCE) values (2,'meeting','we will hold meeting at 5 pm isa',1,3,'1',0);
Insert into PAPER (PAPER_ID,PAPER_TITLE,PAPER_CONTENT,RESEARCH_ID,AUTHOR_ID,IS_ASSIGNED,HASCONFERENCE) values (3,'medo','hhhhhhhhhhhhhh',1,1,'1',0);
Insert into PAPER (PAPER_ID,PAPER_TITLE,PAPER_CONTENT,RESEARCH_ID,AUTHOR_ID,IS_ASSIGNED,HASCONFERENCE) values (4,'testtest','hiiiiiiiiiiiii',2,2,'1',0);
Insert into PAPER (PAPER_ID,PAPER_TITLE,PAPER_CONTENT,RESEARCH_ID,AUTHOR_ID,IS_ASSIGNED,HASCONFERENCE) values (1,'medo','medo1',1,1,'1',1);
Insert into PAPER (PAPER_ID,PAPER_TITLE,PAPER_CONTENT,RESEARCH_ID,AUTHOR_ID,IS_ASSIGNED,HASCONFERENCE) values (5,'test3','byeeeeeeeeeeee',3,3,'1',0);
Insert into PAPER (PAPER_ID,PAPER_TITLE,PAPER_CONTENT,RESEARCH_ID,AUTHOR_ID,IS_ASSIGNED,HASCONFERENCE) values (6,'AI','AI Content byeeeeeeeeeeee',1,4,'0',0);
Insert into PAPER (PAPER_ID,PAPER_TITLE,PAPER_CONTENT,RESEARCH_ID,AUTHOR_ID,IS_ASSIGNED,HASCONFERENCE) values (7,'hii','hhhuh',3,1,'1',1);
Insert into PAPER (PAPER_ID,PAPER_TITLE,PAPER_CONTENT,RESEARCH_ID,AUTHOR_ID,IS_ASSIGNED,HASCONFERENCE) values (8,'asdas','asdasdasdasd',2,1,'1',0);
Insert into PAPER (PAPER_ID,PAPER_TITLE,PAPER_CONTENT,RESEARCH_ID,AUTHOR_ID,IS_ASSIGNED,HASCONFERENCE) values (11,'AI','In the near term, the goal of keeping AI’s impact on society beneficial motivates research in many areas, from economics and law to technical topics such as verification, validity, security and control. Whereas it may be little more than a minor nuisance if your laptop crashes or gets hacked, it becomes all the more important that an AI system does what you want it to do if it controls your car, your airplane, your pacemaker, your automated trading system or your power grid. Another short-term challenge is preventing a devastating arms race in lethal autonomous weapons. 
',2,5,'0',0);
Insert into PAPER (PAPER_ID,PAPER_TITLE,PAPER_CONTENT,RESEARCH_ID,AUTHOR_ID,IS_ASSIGNED,HASCONFERENCE) values (13,'Covid-19','THE TOP MYTHS ABOUT ADVANCED AI 
A captivating conversation is taking place about the future of artificial intelligence and what it will/should mean for humanity. There are fascinating controversies where the world’s leading experts disagree, such as: AI’s future impact on the job market; if/when human-level AI will be developed; whether this will lead to an intelligence explosion; and whether this is something we should welcome or fear. But there are also many examples of of boring pseudo-controversies caused by people misunderstanding and talking past each other. To help ourselves focus on the interesting controversies and open questions — and not on the misunderstandings — let’s  clear up some of the most common myths.',3,4,'0',0);
Insert into PAPER (PAPER_ID,PAPER_TITLE,PAPER_CONTENT,RESEARCH_ID,AUTHOR_ID,IS_ASSIGNED,HASCONFERENCE) values (12,'Operating System','Stephen Hawking, Elon Musk, Steve Wozniak, Bill Gates, and many other big names in science and technology have recently expressed concern in the media and via open letters about the risks posed by AI, joined by many leading AI researchers. Why is the subject suddenly in the headlines? 
The idea that the quest for strong AI would ultimately succeed was long thought of as science fiction, centuries or more away. However, thanks to recent breakthroughs, many AI milestones, which experts viewed as decades away merely five years ago, have now been reached, making many experts take seriously the possibility of superintelligence in our lifetime. While some experts still guess that human-level AI is centuries away, most AI researches at the 2015 Puerto',3,4,'0',0);
Insert into PAPER (PAPER_ID,PAPER_TITLE,PAPER_CONTENT,RESEARCH_ID,AUTHOR_ID,IS_ASSIGNED,HASCONFERENCE) values (10,'Database','DOAJ is a community-curated online directory that indexes and provides access to high quality, open access, peer-reviewed journals. DOAJ is independent. All funding is via donations, 22% of which comes from sponsors and 78% from members and publisher members. All DOAJ services are free of charge including being indexed in DOAJ. All data is freely available. 
An article database is an online tool that allows you to search within a group of journals for articles on a particular topic. There are many different databases to choose from, and each individual database covers only a certain type and number of journals 
The Journal and Article Locator is a tool that allows you to search for journals by title. Go to the Library homepage and click the "Databases and Journals" tab. Then select "Journal and Article Locator." Search for the journal name 
Google is not a database, but it''s mostly made up of databases. Especially it''s main service, which is a search engine.',1,5,'0',0);
Insert into PAPER (PAPER_ID,PAPER_TITLE,PAPER_CONTENT,RESEARCH_ID,AUTHOR_ID,IS_ASSIGNED,HASCONFERENCE) values (9,'werytr','rygxnhjmgjimrimuyrimy',1,1,'0',0);

---------------------------------------------------
--   END DATA FOR TABLE PAPER
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE ADMIN
--   FILTER = none used
---------------------------------------------------
REM INSERTING into ADMIN
Insert into ADMIN (ADMIN_ID,ADMIN_FNAME,ADMIN_SNAME,ADMIN_DBIRTH,ADMIN_EMAIL,ADMIN_ADDRESS,ADMIN_PASSWORD) values (1,'admin','1','17/2/1999','admin@gmail.com','cairo','a');

---------------------------------------------------
--   END DATA FOR TABLE ADMIN
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
 
  ALTER TABLE "CONFERENCE" MODIFY ("CONFERENCE_DATE" NOT NULL ENABLE);
 
  ALTER TABLE "CONFERENCE" MODIFY ("CONFERENCE_PLACE" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table DATES
--------------------------------------------------------

  ALTER TABLE "DATES" MODIFY ("DAY_DATE" NOT NULL ENABLE);
 
  ALTER TABLE "DATES" MODIFY ("HALL" NOT NULL ENABLE);
 
  ALTER TABLE "DATES" ADD PRIMARY KEY ("DAY_DATE", "HALL") ENABLE;
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
 
  ALTER TABLE "PAPER" MODIFY ("HASCONFERENCE" NOT NULL ENABLE);
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

  ALTER TABLE "CONFERENCE" ADD CONSTRAINT "CONFERENCE_DATES_FK1" FOREIGN KEY ("CONFERENCE_DATE", "CONFERENCE_PLACE")
	  REFERENCES "DATES" ("DAY_DATE", "HALL") ENABLE;

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
--  DDL for View EMP_DETAILS_VIEW
--------------------------------------------------------

  CREATE OR REPLACE VIEW "EMP_DETAILS_VIEW" ("EMPLOYEE_ID", "JOB_ID", "MANAGER_ID", "DEPARTMENT_ID", "LOCATION_ID", "COUNTRY_ID", "FIRST_NAME", "LAST_NAME", "SALARY", "COMMISSION_PCT", "DEPARTMENT_NAME", "JOB_TITLE", "CITY", "STATE_PROVINCE", "COUNTRY_NAME", "REGION_NAME") AS 
  SELECT
  e.employee_id,
  e.job_id,
  e.manager_id,
  e.department_id,
  d.location_id,
  l.country_id,
  e.first_name,
  e.last_name,
  e.salary,
  e.commission_pct,
  d.department_name,
  j.job_title,
  l.city,
  l.state_province,
  c.country_name,
  r.region_name
FROM
  employees e,
  departments d,
  jobs j,
  locations l,
  countries c,
  regions r
WHERE e.department_id = d.department_id
  AND d.location_id = l.location_id
  AND l.country_id = c.country_id
  AND c.region_id = r.region_id
  AND j.job_id = e.job_id
WITH READ ONLY;
--------------------------------------------------------
--  DDL for Function GET
--------------------------------------------------------

  CREATE OR REPLACE FUNCTION "GET" 
(value NUMBER)
RETURN NUMBER
IS
c number;
BEGIN
select count(*) 
into c
from employees
where department_id= value;
return c;
end;

/

--------------------------------------------------------
--  DDL for Procedure ADD_CONFERENCE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "ADD_CONFERENCE" 
(con_date in varchar2,con_place in varchar2,con_des in varchar2,con_dur in number,pap_id in number)
as
begin
insert into conference values(Con_Seq.nextval, con_date, con_place, con_des, con_dur, pap_id);
end;

/

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

--------------------------------------------------------
--  DDL for Procedure SECURE_DML
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "SECURE_DML" 
IS
BEGIN
  IF TO_CHAR (SYSDATE, 'HH24:MI') NOT BETWEEN '08:00' AND '18:00'
        OR TO_CHAR (SYSDATE, 'DY') IN ('SAT', 'SUN') THEN
	RAISE_APPLICATION_ERROR (-20205,
		'You may only make changes during normal office hours');
  END IF;
END secure_dml;

/

--------------------------------------------------------
--  DDL for Procedure UPDATE_PAPER
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "UPDATE_PAPER" 
(pid in INTEGER,ptit in VARCHAR2,pcat in INTEGER,pcon in VARCHAR2)
as
begin
update paper set 
Paper_Title=ptit,
RESEARCH_ID=pcat,
Paper_Content=pcon 
where Paper_id= pid;
end;

/

