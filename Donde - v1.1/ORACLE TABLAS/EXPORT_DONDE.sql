--------------------------------------------------------
-- Archivo creado  - lunes-noviembre-14-2016   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table BARRIO
--------------------------------------------------------

  CREATE TABLE "BARRIO" 
   (	"ID_BARRIO" NUMBER(10,0), 
	"NOMBRE" VARCHAR2(20 BYTE), 
	"RELA_LOCALIDAD" NUMBER(10,0)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table CONTACTO_PER
--------------------------------------------------------

  CREATE TABLE "CONTACTO_PER" 
   (	"ID_CONTACTO" NUMBER(10,0), 
	"RELA_TCONTACTO" NUMBER(10,0), 
	"RELA_PERSONA" NUMBER(10,0), 
	"VALOR" VARCHAR2(20 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table CONTACTO_SITIO
--------------------------------------------------------

  CREATE TABLE "CONTACTO_SITIO" 
   (	"ID_SCONTACTO" NUMBER(10,0), 
	"RELA_TCONTACTO" NUMBER(10,0), 
	"RELA_SITIO" NUMBER(10,0), 
	"VALOR" VARCHAR2(20 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table DIRECCION_PER
--------------------------------------------------------

  CREATE TABLE "DIRECCION_PER" 
   (	"ID_DIRECCION" NUMBER(10,0), 
	"CALLE" VARCHAR2(20 BYTE), 
	"NUMERO" NUMBER(10,0), 
	"SECTOR" VARCHAR2(10 BYTE), 
	"MANZANA" VARCHAR2(10 BYTE), 
	"CASA" VARCHAR2(10 BYTE), 
	"TORRE" VARCHAR2(10 BYTE), 
	"PISO" VARCHAR2(5 BYTE), 
	"DEPTO" VARCHAR2(5 BYTE), 
	"RELALA_PERSONA" NUMBER(10,0), 
	"RELA_BARRIO" NUMBER(10,0)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table DIRECCION_SITIO
--------------------------------------------------------

  CREATE TABLE "DIRECCION_SITIO" 
   (	"ID_DIRECCION" NUMBER(10,0), 
	"CALLE" VARCHAR2(20 BYTE), 
	"NUMERO" NUMBER(10,0), 
	"SECTOR" VARCHAR2(10 BYTE), 
	"MANZANA" VARCHAR2(10 BYTE), 
	"CASA" VARCHAR2(10 BYTE), 
	"TORRE" VARCHAR2(10 BYTE), 
	"PISO" VARCHAR2(10 BYTE), 
	"DEPTO" VARCHAR2(10 BYTE), 
	"RELA_BARRIO" NUMBER(10,0)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table LOCALIDAD
--------------------------------------------------------

  CREATE TABLE "LOCALIDAD" 
   (	"ID_LOCALIDA" NUMBER(10,0), 
	"NOMBRE" VARCHAR2(20 BYTE), 
	"RELA_PROVINCIA" NUMBER(10,0)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table PAIS
--------------------------------------------------------

  CREATE TABLE "PAIS" 
   (	"ID_PAIS" NUMBER(10,0), 
	"NOMBRE" VARCHAR2(20 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table PERSONA_CAB
--------------------------------------------------------

  CREATE TABLE "PERSONA_CAB" 
   (	"ID_PERSONA" NUMBER(10,0), 
	"PER_NOMBRES" VARCHAR2(100 BYTE), 
	"PER_APELLIDOS" VARCHAR2(100 BYTE), 
	"DNI" NUMBER(8,0), 
	"PER_CUILT" NUMBER(11,0), 
	"SEXO" NUMBER(1,0), 
	"ESTADO_CIVIL" NUMBER(1,0), 
	"F_NACIMIENTO" DATE
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;

   COMMENT ON COLUMN "PERSONA_CAB"."SEXO" IS '"1 MASCULINO, 0 FEMENINO"';
   COMMENT ON COLUMN "PERSONA_CAB"."ESTADO_CIVIL" IS '"0 SOLTERO/A, 1 CASADO/A,  2 DIVORCIADO/A, 3 VIUDO/A, 4NO DEFINIDO"';
--------------------------------------------------------
--  DDL for Table PERSONA_SITIO
--------------------------------------------------------

  CREATE TABLE "PERSONA_SITIO" 
   (	"ID_PER_SITIO" NUMBER(10,0), 
	"RELA_PERSONA" NUMBER(10,0), 
	"RELA_SITIO" NUMBER(10,0)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table PROVINCIA
--------------------------------------------------------

  CREATE TABLE "PROVINCIA" 
   (	"ID_PROVINCIA" NUMBER(10,0), 
	"NOMBRE" VARCHAR2(20 BYTE), 
	"CODIGO_POSTAL" NUMBER(10,0), 
	"RELA_PAIS" NUMBER(10,0)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table RUBRO
--------------------------------------------------------

  CREATE TABLE "RUBRO" 
   (	"ID_RUBRO" NUMBER(10,0), 
	"CODIGO" NUMBER(10,0), 
	"DESCRIPCION" VARCHAR2(30 BYTE), 
	"RELA_SITIO" VARCHAR2(10 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table SITIO_CAB
--------------------------------------------------------

  CREATE TABLE "SITIO_CAB" 
   (	"ID_SITIO" NUMBER(10,0), 
	"SITIO_NOMBRES" VARCHAR2(100 BYTE), 
	"F_ALTA" DATE
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table TIPO_CONTACTO
--------------------------------------------------------

  CREATE TABLE "TIPO_CONTACTO" 
   (	"ID_TIPOCONTACTO" NUMBER(10,0), 
	"DESCRIPCION" VARCHAR2(20 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table TIPO_RUBRO
--------------------------------------------------------

  CREATE TABLE "TIPO_RUBRO" 
   (	"ID_TIPORUBRO" NUMBER(10,0), 
	"CODIGO" NUMBER(10,0), 
	"DESCRIPCION" VARCHAR2(30 BYTE), 
	"RELA_RUBRO" NUMBER(10,0)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table USUARIOS
--------------------------------------------------------

  CREATE TABLE "USUARIOS" 
   (	"ID_USUARIOS" NUMBER(10,0), 
	"USUARIO" VARCHAR2(20 BYTE), 
	"CONTRASEŅA" VARCHAR2(20 BYTE), 
	"RELA_PERSONA" NUMBER(10,0)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Sequence S_PERSONA
--------------------------------------------------------

   CREATE SEQUENCE  "S_PERSONA"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 61 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence S_RUBRO
--------------------------------------------------------

   CREATE SEQUENCE  "S_RUBRO"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 41 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence S_SITIO
--------------------------------------------------------

   CREATE SEQUENCE  "S_SITIO"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 41 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence S_TIPORUBRO
--------------------------------------------------------

   CREATE SEQUENCE  "S_TIPORUBRO"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 41 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Index PERSONA_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "PERSONA_PK" ON "PERSONA_CAB" ("ID_PERSONA") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index TIPO_RUBRO_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "TIPO_RUBRO_PK" ON "TIPO_RUBRO" ("ID_TIPORUBRO") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index SITIO_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "SITIO_PK" ON "SITIO_CAB" ("ID_SITIO") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index TIPO_CONTACTO_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "TIPO_CONTACTO_PK" ON "TIPO_CONTACTO" ("ID_TIPOCONTACTO") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index RUBRO_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "RUBRO_PK" ON "RUBRO" ("ID_RUBRO") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index SITIO_DIRECCION_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "SITIO_DIRECCION_PK" ON "DIRECCION_SITIO" ("ID_DIRECCION") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index IDX_CUIL
--------------------------------------------------------

  CREATE UNIQUE INDEX "IDX_CUIL" ON "PERSONA_CAB" ("PER_CUILT") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index USUARIOS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "USUARIOS_PK" ON "USUARIOS" ("ID_USUARIOS") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index BARRIO_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "BARRIO_PK" ON "BARRIO" ("ID_BARRIO") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index CONTACTO_SITIO_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "CONTACTO_SITIO_PK" ON "CONTACTO_SITIO" ("ID_SCONTACTO") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index LOCALIDAD_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "LOCALIDAD_PK" ON "LOCALIDAD" ("ID_LOCALIDA") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index PROVINCIA_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "PROVINCIA_PK" ON "PROVINCIA" ("ID_PROVINCIA") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index PERSONA_SITIO_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "PERSONA_SITIO_PK" ON "PERSONA_SITIO" ("ID_PER_SITIO") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index CONTACTO_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "CONTACTO_PK" ON "CONTACTO_PER" ("ID_CONTACTO") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index PAIS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "PAIS_PK" ON "PAIS" ("ID_PAIS") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index DIRECCION_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "DIRECCION_PK" ON "DIRECCION_PER" ("ID_DIRECCION") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Trigger TGR_INS_PERSONA
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "TGR_INS_PERSONA" 
BEFORE INSERT ON PERSONA_CAB 
REFERENCING OLD AS OLD NEW AS NEW 
FOR EACH ROW
BEGIN
  SELECT S_PERSONA.NEXTVAL INTO :NEW.ID_PERSONA FROM DUAL;
END;

/
ALTER TRIGGER "TGR_INS_PERSONA" ENABLE;
--------------------------------------------------------
--  DDL for Trigger TGR_INS_RUBRO
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "TGR_INS_RUBRO" 
BEFORE INSERT ON RUBRO 
REFERENCING OLD AS OLD NEW AS NEW 
FOR EACH ROW
BEGIN
  SELECT S_RUBRO.NEXTVAL INTO :NEW.ID_RUBRO FROM DUAL;
END;

/
ALTER TRIGGER "TGR_INS_RUBRO" ENABLE;
--------------------------------------------------------
--  DDL for Trigger TGR_INS_SITIO
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "TGR_INS_SITIO" 
BEFORE INSERT ON SITIO_CAB 
REFERENCING OLD AS OLD NEW AS NEW 
FOR EACH ROW
BEGIN
  SELECT S_SITIO.NEXTVAL INTO :NEW.ID_SITIO FROM DUAL;
END;

/
ALTER TRIGGER "TGR_INS_SITIO" ENABLE;
--------------------------------------------------------
--  DDL for Trigger TGR_INS_TIPORUBRO
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "TGR_INS_TIPORUBRO" 
BEFORE INSERT ON TIPO_RUBRO 
REFERENCING OLD AS OLD NEW AS NEW 
FOR EACH ROW
BEGIN
  SELECT S_TIPORUBRO.NEXTVAL INTO :NEW.ID_TIPORUBRO FROM DUAL;
END;

/
ALTER TRIGGER "TGR_INS_TIPORUBRO" ENABLE;
--------------------------------------------------------
--  Constraints for Table USUARIOS
--------------------------------------------------------

  ALTER TABLE "USUARIOS" ADD CONSTRAINT "USUARIOS_PK" PRIMARY KEY ("ID_USUARIOS")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
  ALTER TABLE "USUARIOS" MODIFY ("CONTRASEŅA" NOT NULL ENABLE);
  ALTER TABLE "USUARIOS" MODIFY ("USUARIO" NOT NULL ENABLE);
  ALTER TABLE "USUARIOS" MODIFY ("ID_USUARIOS" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table PERSONA_SITIO
--------------------------------------------------------

  ALTER TABLE "PERSONA_SITIO" MODIFY ("ID_PER_SITIO" NOT NULL ENABLE);
  ALTER TABLE "PERSONA_SITIO" MODIFY ("RELA_PERSONA" NOT NULL ENABLE);
  ALTER TABLE "PERSONA_SITIO" MODIFY ("RELA_SITIO" NOT NULL ENABLE);
  ALTER TABLE "PERSONA_SITIO" ADD CONSTRAINT "PERSONA_SITIO_PK" PRIMARY KEY ("ID_PER_SITIO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table CONTACTO_PER
--------------------------------------------------------

  ALTER TABLE "CONTACTO_PER" MODIFY ("ID_CONTACTO" NOT NULL ENABLE);
  ALTER TABLE "CONTACTO_PER" MODIFY ("RELA_TCONTACTO" NOT NULL ENABLE);
  ALTER TABLE "CONTACTO_PER" MODIFY ("RELA_PERSONA" NOT NULL ENABLE);
  ALTER TABLE "CONTACTO_PER" ADD CONSTRAINT "CONTACTO_PK" PRIMARY KEY ("ID_CONTACTO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table RUBRO
--------------------------------------------------------

  ALTER TABLE "RUBRO" MODIFY ("CODIGO" NOT NULL ENABLE);
  ALTER TABLE "RUBRO" MODIFY ("DESCRIPCION" NOT NULL ENABLE);
  ALTER TABLE "RUBRO" ADD CONSTRAINT "RUBRO_PK" PRIMARY KEY ("ID_RUBRO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table DIRECCION_PER
--------------------------------------------------------

  ALTER TABLE "DIRECCION_PER" MODIFY ("ID_DIRECCION" NOT NULL ENABLE);
  ALTER TABLE "DIRECCION_PER" ADD CONSTRAINT "DIRECCION_PK" PRIMARY KEY ("ID_DIRECCION")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
  ALTER TABLE "DIRECCION_PER" MODIFY ("RELALA_PERSONA" NOT NULL ENABLE);
  ALTER TABLE "DIRECCION_PER" MODIFY ("CALLE" NOT NULL ENABLE);
  ALTER TABLE "DIRECCION_PER" MODIFY ("NUMERO" NOT NULL ENABLE);
  ALTER TABLE "DIRECCION_PER" MODIFY ("SECTOR" NOT NULL ENABLE);
  ALTER TABLE "DIRECCION_PER" MODIFY ("MANZANA" NOT NULL ENABLE);
  ALTER TABLE "DIRECCION_PER" MODIFY ("CASA" NOT NULL ENABLE);
  ALTER TABLE "DIRECCION_PER" MODIFY ("TORRE" NOT NULL ENABLE);
  ALTER TABLE "DIRECCION_PER" MODIFY ("PISO" NOT NULL ENABLE);
  ALTER TABLE "DIRECCION_PER" MODIFY ("DEPTO" NOT NULL ENABLE);
  ALTER TABLE "DIRECCION_PER" MODIFY ("RELA_BARRIO" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table LOCALIDAD
--------------------------------------------------------

  ALTER TABLE "LOCALIDAD" MODIFY ("ID_LOCALIDA" NOT NULL ENABLE);
  ALTER TABLE "LOCALIDAD" MODIFY ("NOMBRE" NOT NULL ENABLE);
  ALTER TABLE "LOCALIDAD" MODIFY ("RELA_PROVINCIA" NOT NULL ENABLE);
  ALTER TABLE "LOCALIDAD" ADD CONSTRAINT "LOCALIDAD_PK" PRIMARY KEY ("ID_LOCALIDA")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table PERSONA_CAB
--------------------------------------------------------

  ALTER TABLE "PERSONA_CAB" MODIFY ("ID_PERSONA" NOT NULL ENABLE);
  ALTER TABLE "PERSONA_CAB" MODIFY ("PER_NOMBRES" NOT NULL ENABLE);
  ALTER TABLE "PERSONA_CAB" MODIFY ("PER_APELLIDOS" NOT NULL ENABLE);
  ALTER TABLE "PERSONA_CAB" MODIFY ("SEXO" NOT NULL ENABLE);
  ALTER TABLE "PERSONA_CAB" MODIFY ("ESTADO_CIVIL" NOT NULL ENABLE);
  ALTER TABLE "PERSONA_CAB" MODIFY ("F_NACIMIENTO" NOT NULL ENABLE);
  ALTER TABLE "PERSONA_CAB" ADD CONSTRAINT "PERSONA_PK" PRIMARY KEY ("ID_PERSONA")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table DIRECCION_SITIO
--------------------------------------------------------

  ALTER TABLE "DIRECCION_SITIO" MODIFY ("ID_DIRECCION" NOT NULL ENABLE);
  ALTER TABLE "DIRECCION_SITIO" ADD CONSTRAINT "SITIO_DIRECCION_PK" PRIMARY KEY ("ID_DIRECCION")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table BARRIO
--------------------------------------------------------

  ALTER TABLE "BARRIO" MODIFY ("ID_BARRIO" NOT NULL ENABLE);
  ALTER TABLE "BARRIO" ADD CONSTRAINT "BARRIO_PK" PRIMARY KEY ("ID_BARRIO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
  ALTER TABLE "BARRIO" MODIFY ("RELA_LOCALIDAD" NOT NULL ENABLE);
  ALTER TABLE "BARRIO" MODIFY ("NOMBRE" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table TIPO_CONTACTO
--------------------------------------------------------

  ALTER TABLE "TIPO_CONTACTO" MODIFY ("ID_TIPOCONTACTO" NOT NULL ENABLE);
  ALTER TABLE "TIPO_CONTACTO" MODIFY ("DESCRIPCION" NOT NULL ENABLE);
  ALTER TABLE "TIPO_CONTACTO" ADD CONSTRAINT "TIPO_CONTACTO_PK" PRIMARY KEY ("ID_TIPOCONTACTO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table TIPO_RUBRO
--------------------------------------------------------

  ALTER TABLE "TIPO_RUBRO" MODIFY ("ID_TIPORUBRO" NOT NULL ENABLE);
  ALTER TABLE "TIPO_RUBRO" ADD CONSTRAINT "TIPO_RUBRO_PK" PRIMARY KEY ("ID_TIPORUBRO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
  ALTER TABLE "TIPO_RUBRO" MODIFY ("CODIGO" NOT NULL ENABLE);
  ALTER TABLE "TIPO_RUBRO" MODIFY ("DESCRIPCION" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table PROVINCIA
--------------------------------------------------------

  ALTER TABLE "PROVINCIA" MODIFY ("ID_PROVINCIA" NOT NULL ENABLE);
  ALTER TABLE "PROVINCIA" MODIFY ("NOMBRE" NOT NULL ENABLE);
  ALTER TABLE "PROVINCIA" MODIFY ("CODIGO_POSTAL" NOT NULL ENABLE);
  ALTER TABLE "PROVINCIA" ADD CONSTRAINT "PROVINCIA_PK" PRIMARY KEY ("ID_PROVINCIA")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
  ALTER TABLE "PROVINCIA" MODIFY ("RELA_PAIS" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table PAIS
--------------------------------------------------------

  ALTER TABLE "PAIS" MODIFY ("NOMBRE" NOT NULL ENABLE);
  ALTER TABLE "PAIS" MODIFY ("ID_PAIS" NOT NULL ENABLE);
  ALTER TABLE "PAIS" ADD CONSTRAINT "PAIS_PK" PRIMARY KEY ("ID_PAIS")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table SITIO_CAB
--------------------------------------------------------

  ALTER TABLE "SITIO_CAB" MODIFY ("ID_SITIO" NOT NULL ENABLE);
  ALTER TABLE "SITIO_CAB" MODIFY ("SITIO_NOMBRES" NOT NULL ENABLE);
  ALTER TABLE "SITIO_CAB" ADD CONSTRAINT "SITIO_PK" PRIMARY KEY ("ID_SITIO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
  ALTER TABLE "SITIO_CAB" MODIFY ("F_ALTA" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table CONTACTO_SITIO
--------------------------------------------------------

  ALTER TABLE "CONTACTO_SITIO" ADD CONSTRAINT "CONTACTO_SITIO_PK" PRIMARY KEY ("ID_SCONTACTO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
  ALTER TABLE "CONTACTO_SITIO" MODIFY ("RELA_TCONTACTO" NOT NULL ENABLE);
  ALTER TABLE "CONTACTO_SITIO" MODIFY ("VALOR" NOT NULL ENABLE);
  ALTER TABLE "CONTACTO_SITIO" MODIFY ("RELA_SITIO" NOT NULL ENABLE);
  ALTER TABLE "CONTACTO_SITIO" MODIFY ("ID_SCONTACTO" NOT NULL ENABLE);
--------------------------------------------------------
--  Ref Constraints for Table BARRIO
--------------------------------------------------------

  ALTER TABLE "BARRIO" ADD CONSTRAINT "FK_LOCALIDAD_BARRIO" FOREIGN KEY ("RELA_LOCALIDAD")
	  REFERENCES "LOCALIDAD" ("ID_LOCALIDA") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table CONTACTO_PER
--------------------------------------------------------

  ALTER TABLE "CONTACTO_PER" ADD CONSTRAINT "FK_PERSONA_CONTACTO" FOREIGN KEY ("RELA_PERSONA")
	  REFERENCES "PERSONA_CAB" ("ID_PERSONA") ENABLE;
  ALTER TABLE "CONTACTO_PER" ADD CONSTRAINT "PK_CONTACTO_TCONTACTO" FOREIGN KEY ("RELA_TCONTACTO")
	  REFERENCES "TIPO_CONTACTO" ("ID_TIPOCONTACTO") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table CONTACTO_SITIO
--------------------------------------------------------

  ALTER TABLE "CONTACTO_SITIO" ADD CONSTRAINT "FK_CONTACTO_TCONTACTO" FOREIGN KEY ("RELA_TCONTACTO")
	  REFERENCES "TIPO_CONTACTO" ("ID_TIPOCONTACTO") ENABLE;
  ALTER TABLE "CONTACTO_SITIO" ADD CONSTRAINT "FK_SITIO_CONTACTO" FOREIGN KEY ("RELA_SITIO")
	  REFERENCES "SITIO_CAB" ("ID_SITIO") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table DIRECCION_PER
--------------------------------------------------------

  ALTER TABLE "DIRECCION_PER" ADD CONSTRAINT "FK_DIRECCION_BARRIO" FOREIGN KEY ("RELA_BARRIO")
	  REFERENCES "BARRIO" ("ID_BARRIO") ENABLE;
  ALTER TABLE "DIRECCION_PER" ADD CONSTRAINT "FK_PERSONA_DIRECCION" FOREIGN KEY ("RELALA_PERSONA")
	  REFERENCES "PERSONA_CAB" ("ID_PERSONA") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table DIRECCION_SITIO
--------------------------------------------------------

  ALTER TABLE "DIRECCION_SITIO" ADD CONSTRAINT "FK_BARRIO_DIRECCION" FOREIGN KEY ("RELA_BARRIO")
	  REFERENCES "DIRECCION_SITIO" ("ID_DIRECCION") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table LOCALIDAD
--------------------------------------------------------

  ALTER TABLE "LOCALIDAD" ADD CONSTRAINT "FK_PROVINCIA_LOCALIDAD" FOREIGN KEY ("RELA_PROVINCIA")
	  REFERENCES "PROVINCIA" ("ID_PROVINCIA") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table PERSONA_SITIO
--------------------------------------------------------

  ALTER TABLE "PERSONA_SITIO" ADD CONSTRAINT "FK_PERSONA_PER_SITIO" FOREIGN KEY ("RELA_PERSONA")
	  REFERENCES "PERSONA_CAB" ("ID_PERSONA") ENABLE;
  ALTER TABLE "PERSONA_SITIO" ADD CONSTRAINT "FK_SITIO_PER_SITIO" FOREIGN KEY ("RELA_SITIO")
	  REFERENCES "SITIO_CAB" ("ID_SITIO") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table PROVINCIA
--------------------------------------------------------

  ALTER TABLE "PROVINCIA" ADD CONSTRAINT "FK_PAIS_PROVINCIA" FOREIGN KEY ("RELA_PAIS")
	  REFERENCES "PAIS" ("ID_PAIS") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table USUARIOS
--------------------------------------------------------

  ALTER TABLE "USUARIOS" ADD CONSTRAINT "FK_USUARIO_PER" FOREIGN KEY ("RELA_PERSONA")
	  REFERENCES "PERSONA_CAB" ("ID_PERSONA") ENABLE;
