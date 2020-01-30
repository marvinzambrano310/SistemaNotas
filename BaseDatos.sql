/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     29/01/2020 10:15:17                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DOCENTE') and o.name = 'FK_DOCENTE_IMPARTE_ASIGANTU')
alter table DOCENTE
   drop constraint FK_DOCENTE_IMPARTE_ASIGANTU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ENSENA') and o.name = 'FK_ENSENA_ENSENA_CURSO')
alter table ENSENA
   drop constraint FK_ENSENA_ENSENA_CURSO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ENSENA') and o.name = 'FK_ENSENA_ENSENA2_ASIGANTU')
alter table ENSENA
   drop constraint FK_ENSENA_ENSENA2_ASIGANTU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ESTUDIANTE') and o.name = 'FK_ESTUDIAN_TIENE2_MATRICUL')
alter table ESTUDIANTE
   drop constraint FK_ESTUDIAN_TIENE2_MATRICUL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MATRICULA') and o.name = 'FK_MATRICUL_INGRESA_ADMINIST')
alter table MATRICULA
   drop constraint FK_MATRICUL_INGRESA_ADMINIST
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MATRICULA') and o.name = 'FK_MATRICUL_PERTENECE_CURSO')
alter table MATRICULA
   drop constraint FK_MATRICUL_PERTENECE_CURSO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MATRICULA') and o.name = 'FK_MATRICUL_TIENE_ESTUDIAN')
alter table MATRICULA
   drop constraint FK_MATRICUL_TIENE_ESTUDIAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('NOTAS') and o.name = 'FK_NOTAS_OBTIENE_MATRICUL')
alter table NOTAS
   drop constraint FK_NOTAS_OBTIENE_MATRICUL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMINISTRADOR')
            and   type = 'U')
   drop table ADMINISTRADOR
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ASIGANTURAS')
            and   type = 'U')
   drop table ASIGANTURAS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CURSO')
            and   type = 'U')
   drop table CURSO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DOCENTE')
            and   name  = 'IMPARTE_FK'
            and   indid > 0
            and   indid < 255)
   drop index DOCENTE.IMPARTE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DOCENTE')
            and   type = 'U')
   drop table DOCENTE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ENSENA')
            and   name  = 'ENSENA_FK'
            and   indid > 0
            and   indid < 255)
   drop index ENSENA.ENSENA_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ENSENA')
            and   name  = 'ENSENA2_FK'
            and   indid > 0
            and   indid < 255)
   drop index ENSENA.ENSENA2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ENSENA')
            and   type = 'U')
   drop table ENSENA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ESTUDIANTE')
            and   name  = 'TIENE2_FK'
            and   indid > 0
            and   indid < 255)
   drop index ESTUDIANTE.TIENE2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ESTUDIANTE')
            and   type = 'U')
   drop table ESTUDIANTE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MATRICULA')
            and   name  = 'PERTENECE_FK'
            and   indid > 0
            and   indid < 255)
   drop index MATRICULA.PERTENECE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MATRICULA')
            and   name  = 'TIENE_FK'
            and   indid > 0
            and   indid < 255)
   drop index MATRICULA.TIENE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MATRICULA')
            and   name  = 'INGRESA_FK'
            and   indid > 0
            and   indid < 255)
   drop index MATRICULA.INGRESA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MATRICULA')
            and   type = 'U')
   drop table MATRICULA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('NOTAS')
            and   name  = 'OBTIENE_FK'
            and   indid > 0
            and   indid < 255)
   drop index NOTAS.OBTIENE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NOTAS')
            and   type = 'U')
   drop table NOTAS
go

/*==============================================================*/
/* Table: ADMINISTRADOR                                         */
/*==============================================================*/
create table ADMINISTRADOR (
   IDADMIN              varchar(10)          not null,
   NOMBRE1ADMIN         varchar(15)          not null,
   NOMBRE2ADMIN         varchar(15)          not null,
   APELPADMIN           varchar(15)          not null,
   APELMADMIN           varchar(15)          not null,
   DIRADMIN             varchar(25)          null,
   CLAVEADMIN           varchar(6)           null,
   constraint PK_ADMINISTRADOR primary key nonclustered (IDADMIN)
)
go

/*==============================================================*/
/* Table: ASIGANTURAS                                           */
/*==============================================================*/
create table ASIGANTURAS (
   IDASIGNATURA         varchar(3)           not null,
   NOMBRE               varchar(45)          not null,
   constraint PK_ASIGANTURAS primary key nonclustered (IDASIGNATURA)
)
go

/*==============================================================*/
/* Table: CURSO                                                 */
/*==============================================================*/
create table CURSO (
   IDCURSO              varchar(3)           not null,
   NOMBRECURSO          varchar(20)          not null,
   JORNADA              char(2)              not null,
   ESPECIALIDAD         varchar(20)          not null,
   PARALELO             char(2)              not null,
   constraint PK_CURSO primary key nonclustered (IDCURSO)
)
go

/*==============================================================*/
/* Table: DOCENTE                                               */
/*==============================================================*/
create table DOCENTE (
   IDDOCENTE            varchar(10)          not null,
   IDASIGNATURA         varchar(3)           not null,
   NOMBRE1DOC           varchar(15)          not null,
   NOMBRE2DOC           varchar(15)          not null,
   APELPDOC             varchar(15)          not null,
   APELMDOC             varchar(15)          not null,
   DIRDOCENTE           varchar(25)          not null,
   CELULARDOC           varchar(10)          not null,
   TELEFONODOC          varchar(7)           null,
   EMAILDOC             varchar(25)          not null,
   FECHNACDOC           datetime             not null,
   CLAVEDOC             varchar(6)           not null,
   constraint PK_DOCENTE primary key nonclustered (IDDOCENTE)
)
go

/*==============================================================*/
/* Index: IMPARTE_FK                                            */
/*==============================================================*/
create index IMPARTE_FK on DOCENTE (
IDASIGNATURA ASC
)
go

/*==============================================================*/
/* Table: ENSENA                                                */
/*==============================================================*/
create table ENSENA (
   IDCURSO              varchar(3)           not null,
   IDASIGNATURA         varchar(3)           not null,
   constraint PK_ENSENA primary key nonclustered (IDCURSO, IDASIGNATURA)
)
go

/*==============================================================*/
/* Index: ENSENA2_FK                                            */
/*==============================================================*/
create index ENSENA2_FK on ENSENA (
IDASIGNATURA ASC
)
go

/*==============================================================*/
/* Index: ENSENA_FK                                             */
/*==============================================================*/
create index ENSENA_FK on ENSENA (
IDCURSO ASC
)
go

/*==============================================================*/
/* Table: ESTUDIANTE                                            */
/*==============================================================*/
create table ESTUDIANTE (
   IDESTUDIANTE         varchar(10)          not null,
   IDMATRICULA          numeric(5)           not null,
   NOMBRE1ESTUD         varchar(15)          not null,
   NOMBRE2ESTUD         varchar(15)          not null,
   APELPESTUD           varchar(15)          not null,
   APELMESTUD           varchar(15)          not null,
   GENEROESTUD          char(1)              not null,
   DIRECCIONESTUD       varchar(25)          not null,
   FECHNACESTUD         datetime             not null,
   CELULAREST           varchar(10)          not null,
   TELEFONOEST          varchar(7)           not null,
   EMAILEST             varchar(25)          not null,
   CLAVEEST             varchar(6)           not null,
   constraint PK_ESTUDIANTE primary key nonclustered (IDESTUDIANTE)
)
go

/*==============================================================*/
/* Index: TIENE2_FK                                             */
/*==============================================================*/
create index TIENE2_FK on ESTUDIANTE (
IDMATRICULA ASC
)
go

/*==============================================================*/
/* Table: MATRICULA                                             */
/*==============================================================*/
create table MATRICULA (
   IDMATRICULA          numeric(5)           not null,
   IDADMIN              varchar(10)          not null,
   IDESTUDIANTE         varchar(10)          null,
   IDCURSO              varchar(3)           not null,
   FECHA                datetime             not null,
   ANOLECTIVOMAT        datetime             not null,
   constraint PK_MATRICULA primary key nonclustered (IDMATRICULA)
)
go

/*==============================================================*/
/* Index: INGRESA_FK                                            */
/*==============================================================*/
create index INGRESA_FK on MATRICULA (
IDADMIN ASC
)
go

/*==============================================================*/
/* Index: TIENE_FK                                              */
/*==============================================================*/
create index TIENE_FK on MATRICULA (
IDESTUDIANTE ASC
)
go

/*==============================================================*/
/* Index: PERTENECE_FK                                          */
/*==============================================================*/
create index PERTENECE_FK on MATRICULA (
IDCURSO ASC
)
go

/*==============================================================*/
/* Table: NOTAS                                                 */
/*==============================================================*/
create table NOTAS (
   IDNOTAS              numeric(10)          not null,
   IDMATRICULA          numeric(5)           not null,
   PARCIAL1             numeric(2,2)         null,
   PARCIAL2             numeric(2,2)         null,
   SUPLETORIO           numeric(2,2)         null,
   PROMEDIO             numeric(2,2)         null,
   OBSERVACIONES        varchar(10)          null,
   ANOLECTIVO           datetime             null,
   constraint PK_NOTAS primary key nonclustered (IDNOTAS)
)
go

/*==============================================================*/
/* Index: OBTIENE_FK                                            */
/*==============================================================*/
create index OBTIENE_FK on NOTAS (
IDMATRICULA ASC
)
go

alter table DOCENTE
   add constraint FK_DOCENTE_IMPARTE_ASIGANTU foreign key (IDASIGNATURA)
      references ASIGANTURAS (IDASIGNATURA)
go

alter table ENSENA
   add constraint FK_ENSENA_ENSENA_CURSO foreign key (IDCURSO)
      references CURSO (IDCURSO)
go

alter table ENSENA
   add constraint FK_ENSENA_ENSENA2_ASIGANTU foreign key (IDASIGNATURA)
      references ASIGANTURAS (IDASIGNATURA)
go

alter table ESTUDIANTE
   add constraint FK_ESTUDIAN_TIENE2_MATRICUL foreign key (IDMATRICULA)
      references MATRICULA (IDMATRICULA)
go

alter table MATRICULA
   add constraint FK_MATRICUL_INGRESA_ADMINIST foreign key (IDADMIN)
      references ADMINISTRADOR (IDADMIN)
go

alter table MATRICULA
   add constraint FK_MATRICUL_PERTENECE_CURSO foreign key (IDCURSO)
      references CURSO (IDCURSO)
go

alter table MATRICULA
   add constraint FK_MATRICUL_TIENE_ESTUDIAN foreign key (IDESTUDIANTE)
      references ESTUDIANTE (IDESTUDIANTE)
go

alter table NOTAS
   add constraint FK_NOTAS_OBTIENE_MATRICUL foreign key (IDMATRICULA)
      references MATRICULA (IDMATRICULA)
go

