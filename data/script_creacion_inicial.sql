USE [GD2C2016]
GO

/**** CREACION DE SCHEMA ****/

IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'NEXTGDD')
BEGIN
    EXEC ('CREATE SCHEMA NEXTGDD AUTHORIZATION gd')
END

GO

/*
CREATE SCHEMA NEXTGDD AUTHORIZATION gd
GO
*/

/******** VALIDACION DE TABLAS ********/

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Funcionalidad_X_Rol'))
    DROP TABLE NEXTGDD.Funcionalidad_X_Rol

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Usuario_X_Rol'))
    DROP TABLE NEXTGDD.Usuario_x_Rol

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Usuario'))
    DROP TABLE NEXTGDD.Usuario

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Rol'))
    DROP TABLE NEXTGDD.Rol

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Funcionalidad'))
    DROP TABLE NEXTGDD.Funcionalidad


IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Rango_Atencion'))
    DROP TABLE NEXTGDD.Rango_Atencion

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Agenda_X_Turno'))
    DROP TABLE NEXTGDD.Agenda_X_Turno

	
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Historial'))
    DROP TABLE NEXTGDD.Historial

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Consulta'))
    DROP TABLE NEXTGDD.Consulta

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Diagnostico'))
    DROP TABLE NEXTGDD.Diagnostico

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Sintoma'))
    DROP TABLE NEXTGDD.Sintoma

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Enfermedad'))
    DROP TABLE NEXTGDD.Enfermedad

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Turno'))
    DROP TABLE NEXTGDD.Turno

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Agenda'))
    DROP TABLE NEXTGDD.Agenda

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Cancelacion'))
    DROP TABLE NEXTGDD.Cancelacion

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Tipo_Cancelacion'))
    DROP TABLE NEXTGDD.Tipo_Cancelacion

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Bono_Consulta'))
    DROP TABLE NEXTGDD.Bono_Consulta

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Compra_Bono'))
    DROP TABLE NEXTGDD.Compra_Bono

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Afiliado'))
    DROP TABLE NEXTGDD.Afiliado
		
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Profesional_X_Especialidad'))
    DROP TABLE NEXTGDD.Profesional_X_Especialidad
	
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Especialidad'))
    DROP TABLE NEXTGDD.Especialidad

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Tipo_Especialidad'))
    DROP TABLE NEXTGDD.Tipo_Especialidad

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Profesional'))
    DROP TABLE NEXTGDD.Profesional
	
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Administrativo'))
    DROP TABLE NEXTGDD.Administrativo

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Plan_Medico'))
    DROP TABLE NEXTGDD.Plan_Medico

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Persona'))
    DROP TABLE 	NEXTGDD.Persona

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Estado_Civil'))
    DROP TABLE NEXTGDD.Estado_Civil

GO

/**** CREACION DE TABLAS ****/

CREATE TABLE NEXTGDD.Estado_Civil (

   id tinyint PRIMARY KEY IDENTITY,
   nombre varchar (50) 
   ) 

CREATE TABLE NEXTGDD.Persona (

	id_persona int PRIMARY KEY identity,
	nombre varchar (255) not null, 
	apellido varchar (255) not null,
	domicilio varchar (255) not null ,
	telefono numeric (18,0) not null,
	mail varchar (255) not null,
	fecha_nac datetime not null,
	sexo char (1) not null default 'X',
	estado_civil tinyint not null default 6 REFERENCES NEXTGDD.Estado_Civil(id),
	nro_documento numeric(18,0) NOT NULL,
	tipo_doc varchar (50) NOT NULL DEFAULT 'DNI',

	/*me tira error por fk, tendriamos que agregar la constraint despues de crear las tablas,
	por ahora lo anulo, despues lo agrego.

	nro_afiliado numeric(18,0) default null REFERENCES NEXTGDD.Afiliado(nro_afiliado),
	nro_matricula numeric(18,0) default null REFERENCES NEXTGDD.Profesional(matricula),
	id_administrador numeric(18,0) default null REFERENCES NEXTGDD.Profesional(matricula),
	*/

	CONSTRAINT check_s2 check (sexo IN ('H', 'M','X')),
	CONSTRAINT unique_tipo_nro_Doc unique (nro_documento,tipo_doc)
	)


CREATE TABLE NEXTGDD.Usuario (
   
    username varchar (255) PRIMARY KEY,
    password varbinary (255) NOT NULL,   --OK en SHA 256 
	logins_fallidos smallint NOT NULL DEFAULT 0,
	habilitado bit NOT NULL DEFAULT 1,
	id_persona int REFERENCES NEXTGDD.Persona(id_persona)
    )

CREATE TABLE NEXTGDD.Rol (

    id_rol tinyint PRIMARY KEY IDENTITY,  
	nombre varchar (255) NOT NULL,
	habilitado bit NOT NULL DEFAULT 1
)
    

CREATE TABLE NEXTGDD.Usuario_X_Rol (

    username varchar (255) REFERENCES NextGDD.Usuario(username),
    id_rol tinyint REFERENCES NextGDD.Rol(id_rol),
    PRIMARY KEY (username, id_rol)
    )


CREATE TABLE NextGDD.Funcionalidad (

   id_funcionalidad tinyint PRIMARY KEY identity,
   nombre varchar (255) not null
    )

 CREATE TABLE NEXTGDD.Funcionalidad_X_Rol (

    id_rol tinyint REFERENCES NextGDD.Rol(id_rol),
    id_funcionalidad tinyint REFERENCES NextGDD.Funcionalidad(id_funcionalidad),
    PRIMARY KEY (id_rol, id_funcionalidad)
    )
	
CREATE TABLE NEXTGDD.Plan_Medico (
 
   cod_plan numeric (18,0) PRIMARY KEY,
   descripcion varchar (255),
   cuota numeric (18,0),
   precio_bono_consulta numeric (18,0),
   precio_bono_farmacia numeric (18,0),
   )

CREATE TABLE NEXTGDD.Administrativo (
    
	id_administrativo int PRIMARY KEY IDENTITY,
	id_persona int REFERENCES NEXTGDD.Persona(id_persona)
	)

CREATE TABLE NEXTGDD.Profesional (
--SACAR EL IDENTITY SOLO CUANDO SE TERMINE LA MIGRACION    
	matricula numeric (18,0) IDENTITY(1000,1) PRIMARY KEY,
	id_persona int REFERENCES NEXTGDD.Persona(id_persona)
    )

CREATE TABLE NEXTGDD.Tipo_Especialidad (
   
   tipo_especialidad numeric (18,0) PRIMARY KEY,
   descripcion varchar (255)
      )

CREATE TABLE NEXTGDD.Especialidad (

   cod_especialidad numeric (18,0) PRIMARY KEY,
   descripcion varchar (255),
   tipo_especialidad numeric (18,0) REFERENCES NextGDD.Tipo_Especialidad (tipo_especialidad)
   )

CREATE TABLE NEXTGDD.Profesional_X_Especialidad (

   matricula numeric (18,0) REFERENCES NextGDD.Profesional(matricula),
   cod_especialidad numeric (18,0) REFERENCES NextGDD.Especialidad(cod_especialidad),
   PRIMARY KEY (matricula, cod_especialidad) 
   )
   
CREATE TABLE NEXTGDD.Afiliado (
--SACAR EL IDENTITY SOLO CUANDO SE TERMINE LA MIGRACION
	nro_afiliado numeric (18,0) IDENTITY(100,1) PRIMARY KEY , 
	cant_familiares tinyint,
	cod_plan numeric(18,0) REFERENCES NextGDD.Plan_Medico(cod_plan),
	--
	activo bit DEFAULT 1,
	fecha_baja_logica datetime DEFAULT NULL,
	id_persona int REFERENCES NEXTGDD.Persona(id_persona),
	grupo_afiliado numeric (18,0) ,        --numero raiz de afiliado 
	integrante_grupo numeric (2,0)         --01:principal, 02: conyuge, 03:hijo
	)
	 
CREATE TABLE NEXTGDD.Compra_Bono (
	id_compra int PRIMARY KEY identity, 
	cant smallint,
	id_afiliado numeric(18,0) REFERENCES NextGDD.Afiliado,
	precio_total int 
	)

CREATE TABLE NEXTGDD.Bono_Consulta (

    nro_bono numeric (18,0) IDENTITY(1,1) PRIMARY KEY,
    fecha_impresion datetime,
    compra_fecha datetime, 
    nro_consulta numeric (18,0),
    cod_plan numeric (18,0) REFERENCES NextGDD.Plan_Medico(cod_plan), 
	nro_afiliado numeric (18,0) REFERENCES NextGDD.Afiliado(nro_afiliado) 
    ) 
	
CREATE TABLE NEXTGDD.Tipo_cancelacion (

    tipo_cancelacion tinyint IDENTITY PRIMARY KEY, 
	nombre varchar (255)
   )

CREATE TABLE NEXTGDD.Cancelacion (

    cod_cancelacion numeric (18,0) PRIMARY KEY, 
	tipo_cancelacion tinyint REFERENCES NEXTGDD.Tipo_cancelacion(tipo_cancelacion) ,
	motivo varchar (255)
   )

CREATE TABLE NEXTGDD.Agenda (

   cod_agenda numeric (18,0) IDENTITY PRIMARY KEY,
   matricula numeric (18,0) NOT NULL,
   cod_especialidad numeric (18,0) NOT NULL,
   FOREIGN KEY (matricula, cod_especialidad) REFERENCES NextGDD.Profesional_X_Especialidad(matricula, cod_especialidad)
   )

CREATE TABLE NEXTGDD.Turno (

   nro_turno numeric (18,0) PRIMARY KEY,
   fecha datetime,
   nro_afiliado numeric (18,0) REFERENCES NextGDD.afiliado(nro_afiliado),
   cod_agenda numeric (18,0) REFERENCES NextGDD.Agenda(cod_agenda),
   cod_cancelacion numeric (18,0) REFERENCES NextGDD.Cancelacion(cod_cancelacion)
   )


CREATE TABLE NEXTGDD.Sintoma (

   sintoma varchar (255) PRIMARY KEY,
   descripcion varchar (255)
   )

CREATE TABLE NEXTGDD.Enfermedad (

   enfermedad varchar (255) PRIMARY KEY,
   descripcion varchar (255)
   )

CREATE TABLE NEXTGDD.Diagnostico (
   
   cod_diagnostico numeric (18,0) IDENTITY PRIMARY KEY,
   descripcion varchar (255),
   sintoma varchar (255) REFERENCES NextGDD.Sintoma (sintoma),
   enfermedad varchar (255) REFERENCES NextGDD.Enfermedad (enfermedad),
   )

CREATE TABLE NEXTGDD.Consulta (
 
   cod_consulta numeric (18,0) IDENTITY PRIMARY KEY,
   cod_diagnostico numeric (18,0) REFERENCES NextGDD.Diagnostico(cod_diagnostico),
   nro_bono numeric (18,0) REFERENCES NextGDD.Bono_Consulta(nro_bono),
   nro_turno numeric (18,0) REFERENCES NextGDD.Turno(nro_turno)
   )

CREATE TABLE NEXTGDD.Historial (

   nro_historial numeric (18,0) PRIMARY KEY,
   fecha_modificacion datetime,
   motivo_modificacion varchar (255),
   nro_afiliado numeric (18,0) REFERENCES NextGDD.afiliado(nro_afiliado),
   cod_plan_viejo numeric (18,0) REFERENCES NextGDD.Plan_Medico(cod_plan),
    cod_plan_nuevo numeric (18,0) REFERENCES NextGDD.Plan_Medico(cod_plan)  
   )

CREATE TABLE NEXTGDD.Agenda_X_Turno (

   cod_agenda numeric (18,0) REFERENCES NextGDD.Agenda(cod_agenda),
   fecha datetime,
   cod_cancelacion numeric (18,0) REFERENCES NextGDD.Cancelacion(cod_cancelacion),
   PRIMARY KEY (cod_agenda,fecha)
   )


CREATE TABLE NEXTGDD.Rango_Atencion (

   cod_agenda numeric (18,0) REFERENCES NextGDD.Agenda(cod_agenda),
   rango_atencion numeric (18,0) ,
   hora_inicial numeric (18,0),
   hora_final numeric (18,0),
   dia_semanal_inicial varchar (255), 
   dia_semanal_final varchar (255),
   PRIMARY KEY (cod_agenda, rango_atencion) 
   )
GO
/************ Migracion *************/

--select * from gd_esquema.Maestra
--SET STATISTICS TIME ON

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Pacientes'))
    DROP VIEW NEXTGDD.Pacientes

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Medicos'))
    DROP VIEW NEXTGDD.Medicos	
GO

CREATE VIEW NEXTGDD.Pacientes AS
	SELECT DISTINCT Paciente_Dni,Paciente_Nombre, Paciente_Apellido,
					Paciente_Fecha_Nac,
					Paciente_Direccion, Paciente_Telefono, Paciente_Mail,
					Plan_Med_Codigo
	FROM gd_esquema.Maestra
	WHERE Paciente_Dni IS NOT NULL
GO 

CREATE VIEW NEXTGDD.Medicos AS
	SELECT DISTINCT Medico_Dni,Medico_Nombre, Medico_Apellido,
					Medico_Fecha_Nac,
					Medico_Direccion, Medico_Telefono, Medico_Mail
	FROM gd_esquema.Maestra
	WHERE Medico_Nombre IS NOT NULL
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.agregar_funcionalidad'))
    DROP PROCEDURE NEXTGDD.agregar_funcionalidad
GO

CREATE PROCEDURE NEXTGDD.agregar_funcionalidad(@rol varchar(255), @func varchar(255)) AS
BEGIN
	INSERT INTO NEXTGDD.Funcionalidad_X_Rol(id_rol,id_funcionalidad )
		VALUES ((SELECT id_rol FROM NEXTGDD.Rol WHERE nombre = @rol),
		        (SELECT id_funcionalidad FROM NEXTGDD.Funcionalidad WHERE nombre = @func))
END
GO

SET IDENTITY_INSERT NEXTGDD.Tipo_Cancelacion ON
INSERT INTO NEXTGDD.Tipo_Cancelacion (tipo_cancelacion, nombre) VALUES (1, 'Nada')
INSERT INTO NEXTGDD.Tipo_Cancelacion (tipo_cancelacion, nombre) VALUES (2, 'Problemas Familiares')
INSERT INTO NEXTGDD.Tipo_Cancelacion (tipo_cancelacion, nombre) VALUES (3, 'Percance')
INSERT INTO NEXTGDD.Tipo_Cancelacion (tipo_cancelacion, nombre) VALUES (4, 'Paro Nacional')
INSERT INTO NEXTGDD.Tipo_Cancelacion (tipo_cancelacion, nombre) VALUES (5, 'Asueto')
INSERT INTO NEXTGDD.Tipo_Cancelacion (tipo_cancelacion, nombre) VALUES (6, 'otro')
SET IDENTITY_INSERT NEXTGDD.Tipo_Cancelacion OFF

GO

INSERT NEXTGDD.Estado_Civil(nombre)
VALUES ('Soltero/a'),    --1
       ('Casado/a'),     --2 
	   ('Viudo/a'),      --3
	   ('Concubinato'),  --4
	   ('Divorciado/a'), --5
	    ('X')            --6


INSERT NEXTGDD.Plan_Medico (cod_plan,descripcion,cuota,precio_bono_consulta,precio_bono_farmacia)
	   (select  distinct Plan_Med_Codigo,Plan_Med_Descripcion,null,Plan_Med_Precio_Bono_Consulta,Plan_Med_Precio_Bono_Farmacia
	   from gd_esquema.Maestra );
GO

INSERT NEXTGDD.Enfermedad(enfermedad)
	   (select distinct Consulta_Enfermedades
	   from gd_esquema.Maestra
	   where not(Consulta_Enfermedades is null) );
GO

INSERT NEXTGDD.Sintoma(sintoma)
	   (select distinct Consulta_Sintomas
	   from gd_esquema.Maestra
	   where not(Consulta_Sintomas is null));
GO

INSERT NEXTGDD.Tipo_Especialidad (tipo_especialidad,descripcion)
		(select distinct Tipo_Especialidad_Codigo,Tipo_Especialidad_Descripcion
		from gd_esquema.Maestra 
		where ISNULL(Tipo_Especialidad_Codigo,0)<>0	);
GO

INSERT NEXTGDD.Especialidad (cod_especialidad,descripcion,tipo_especialidad)
		(select distinct Especialidad_Codigo,Especialidad_Descripcion,Tipo_Especialidad_Codigo
		from gd_esquema.Maestra 
		where ISNULL(Especialidad_Codigo,0)<>0 );
GO

SET IDENTITY_INSERT NEXTGDD.Persona ON

INSERT INTO NEXTGDD.Persona (id_persona, nombre, apellido, nro_documento, fecha_nac, domicilio, telefono, mail)
	SELECT Paciente_Dni, Paciente_Nombre, Paciente_Apellido, Paciente_Dni, Paciente_Fecha_Nac, Paciente_Direccion, 
	       Paciente_Telefono, Paciente_Mail
	FROM NEXTGDD.Pacientes

INSERT INTO NEXTGDD.Persona (id_persona, nombre, apellido, nro_documento, fecha_nac, domicilio, telefono, mail)
	SELECT Medico_Dni, Medico_Nombre, Medico_Apellido, Medico_Dni,
	       Medico_Fecha_Nac, Medico_Direccion, Medico_Telefono,
	       Medico_Mail
	FROM NEXTGDD.Medicos

SET IDENTITY_INSERT NEXTGDD.Persona OFF

INSERT INTO NEXTGDD.Afiliado (id_persona, grupo_afiliado, integrante_grupo, cant_familiares)
	SELECT id_persona, id_persona, 01,0
	FROM NEXTGDD.Persona
	WHERE nro_documento IN (SELECT Paciente_Dni FROM NEXTGDD.Pacientes)


INSERT INTO NEXTGDD.Profesional (id_persona)
	SELECT id_persona
	FROM NEXTGDD.Persona
	WHERE nro_documento IN (SELECT Medico_Dni FROM NEXTGDD.Medicos)

SET IDENTITY_INSERT NEXTGDD.Profesional ON --De esta manera lo dejamos para que se ingrese la matricula manualmente

GO


INSERT NEXTGDD.Profesional_X_Especialidad (cod_especialidad,matricula)
		(select distinct Especialidad_Codigo, (SELECT matricula FROM NEXTGDD.Profesional where id_persona = Medico_Dni )
		from gd_esquema.Maestra
		where ISNULL(Especialidad_Codigo,0)<>0 )
GO

INSERT NEXTGDD.Rol (nombre) values ('Administrativo');
INSERT NEXTGDD.Rol (nombre) values ('Afiliado');
INSERT NEXTGDD.Rol (nombre) values ('Profesional');

INSERT INTO NEXTGDD.Funcionalidad (nombre)
	VALUES ('ABM de roles'),
	       ('ABM de afiliados'),
	       ('ABM de profesionales'),
	       ('ABM de especialidades medicas'),
	       ('ABM de planes'),
		   ('Compra de bonos'),
	       ('Pedido de turno'),
	       ('Registrar agenda profesional'),		 
	       ('Registro de llegada para atencion medica'),
	       ('Registro de resultado para atencion medica'),
	       ('Registrar diagnostico'),
	       ('Cancelar atencion medica'),
	       ('Consultar listado estadistico')


EXEC NEXTGDD.agregar_funcionalidad  @rol = 'Administrativo' , @func = 'ABM de roles';

EXEC NEXTGDD.agregar_funcionalidad  @rol = 'Administrativo' , @func = 'ABM de afiliados';

EXEC NEXTGDD.agregar_funcionalidad 	@rol = 'Administrativo', @func = 'ABM de profesionales';

EXEC NEXTGDD.agregar_funcionalidad 	@rol = 'Administrativo', @func = 'ABM de especialidades medicas';

EXEC NEXTGDD.agregar_funcionalidad 	@rol = 'Administrativo', @func = 'ABM de planes';

EXEC NEXTGDD.agregar_funcionalidad 	@rol = 'Administrativo', @func = 'Registrar agenda profesional';

EXEC NEXTGDD.agregar_funcionalidad	@rol = 'Profesional', @func = 'Registrar agenda profesional';

EXEC NEXTGDD.agregar_funcionalidad 	@rol = 'Administrativo', @func = 'Compra de bonos';	

EXEC NEXTGDD.agregar_funcionalidad 	@rol = 'Afiliado', @func = 'Compra de bonos';

EXEC NEXTGDD.agregar_funcionalidad 	@rol = 'Administrativo', @func = 'Pedido de turno';

EXEC NEXTGDD.agregar_funcionalidad 	@rol = 'Afiliado', @func = 'Pedido de turno';

EXEC NEXTGDD.agregar_funcionalidad 	@rol = 'Administrativo', @func = 'Registro de llegada para atencion medica';

EXEC NEXTGDD.agregar_funcionalidad 	@rol = 'Profesional', @func = 'Registro de resultado para atencion medica';

EXEC NEXTGDD.agregar_funcionalidad 	@rol = 'Administrativo', @func = 'Cancelar atencion medica';

EXEC NEXTGDD.agregar_funcionalidad	@rol = 'Afiliado', @func = 'Cancelar atencion medica';

EXEC NEXTGDD.agregar_funcionalidad	@rol = 'Profesional', @func = 'Cancelar atencion medica';

EXEC NEXTGDD.agregar_funcionalidad 	@rol = 'Administrativo', @func = 'Consultar listado estadistico';
	       
GO 

SET IDENTITY_INSERT NEXTGDD.Profesional OFF

SET IDENTITY_INSERT NEXTGDD.Bono_Consulta ON

INSERT NEXTGDD.Bono_Consulta (nro_bono,nro_afiliado,fecha_impresion,compra_fecha,cod_plan,nro_consulta)
		
		(select Bono_Consulta_Numero,(select nro_afiliado from NEXTGDD.Afiliado WHERE id_persona= Paciente_Dni), Bono_Consulta_Fecha_Impresion, Compra_Bono_Fecha, Plan_Med_Codigo,null  
		from gd_esquema.Maestra 
		where Bono_Consulta_Fecha_Impresion is not null and Compra_Bono_Fecha is not null)

SET IDENTITY_INSERT NEXTGDD.Bono_Consulta OFF

SET IDENTITY_INSERT NEXTGDD.Profesional ON

GO


INSERT NEXTGDD.Turno (nro_turno,fecha,nro_afiliado) --Faltaria Codigo agenda
		
		(select Turno_Numero,Turno_Fecha,(select nro_afiliado from NEXTGDD.Afiliado WHERE id_persona= Paciente_Dni)
		from gd_esquema.Maestra 
		where Bono_Consulta_Fecha_Impresion is null and Compra_Bono_Fecha is  null )

GO
SET IDENTITY_INSERT NEXTGDD.Profesional OFF

SET IDENTITY_INSERT NEXTGDD.Diagnostico ON

INSERT NEXTGDD.Diagnostico (cod_diagnostico, descripcion,sintoma,enfermedad)
	   (select Bono_Consulta_Numero, NULL, Consulta_Sintomas, Consulta_Enfermedades
		from gd_esquema.Maestra
		where Compra_Bono_Fecha is null and Bono_Consulta_Numero is not null );
GO

SET IDENTITY_INSERT NEXTGDD.Diagnostico OFF

SET IDENTITY_INSERT NEXTGDD.Profesional ON

INSERT NEXTGDD.Consulta (cod_diagnostico, nro_bono, nro_turno)
	   (select Bono_Consulta_Numero, Bono_Consulta_Numero, Turno_Numero
		from gd_esquema.Maestra
		where Compra_Bono_Fecha is null and Bono_Consulta_Numero is not null );
GO

---
select  Paciente_Dni,Bono_Consulta_Numero -- count (Bono_Consulta_Numero)
		from gd_esquema.Maestra
		where Compra_Bono_Fecha is null and Bono_Consulta_Numero is not null
		order by Paciente_Dni

		group by Paciente_Dni
/*
select * from NEXTGDD.Consulta
INSERT NEXTGDD.Profesional_X_Especialidad (matricula,cod_especialidad)
		(select (select matricula 
				 from NEXTGDD.Profesional
				 where nombre+apellido+domicilio+mail=Medico_Nombre+Medico_Apellido+Medico_Direccion+Medico_Mail
				      and fecha_nac=Medico_Fecha_Nac and telefono=Medico_Telefono),
				Especialidad_Codigo
		 from gd_esquema.Maestra
		 where isnull(Especialidad_Codigo,0)<>0
		 group by Medico_Nombre,Medico_Apellido,Medico_Direccion,Medico_Mail,Medico_Fecha_Nac,Medico_Telefono,Especialidad_Codigo);
GO
*/

INSERT NEXTGDD.Agenda (matricula, cod_especialidad)
		(select matricula,cod_especialidad
		 from NEXTGDD.Profesional_X_Especialidad);
GO



select Paciente_Dni, Turno_Numero, Turno_Fecha, Bono_Consulta_Numero, Bono_Consulta_Fecha_Impresion, Compra_Bono_Fecha, Plan_Med_Codigo
from gd_esquema.Maestra order by Paciente_Dni, Turno_Numero, Bono_Consulta_Numero

select Paciente_Dni, Turno_Numero, Turno_Fecha,Consulta_Enfermedades,Consulta_Sintomas, Bono_Consulta_Numero, Bono_Consulta_Fecha_Impresion, Compra_Bono_Fecha
from gd_esquema.Maestra 
where Turno_Numero  is not null
order by Turno_Numero, Bono_Consulta_Numero

select  Paciente_Dni, Turno_Numero, Turno_Fecha,Consulta_Enfermedades,Consulta_Sintomas, Bono_Consulta_Numero, Bono_Consulta_Fecha_Impresion, Compra_Bono_Fecha 
from gd_esquema.Maestra
where turno_numero is  null
order by Turno_Numero

select * from NEXTGDD.Turno

---tira error ; ver como solucionarlo
/*
INSERT NEXTGDD.Agenda_X_Turno (cod_agenda,fecha)
		(select cod_agenda,fecha
		 from NEXTGDD.Turno);
GO	 
*/
/*
INSERT NEXTGDD.Diagnostico (sintoma,enfermedad)
		(select Consulta_Sintomas,Consulta_Enfermedades
		 from gd_esquema.Maestra
		 where not(Consulta_Sintomas IS NULL and Consulta_Enfermedades IS NULL));
GO
*/
/*
select * from gd_esquema.Maestra
INSERT NEXTGDD.Consulta (nro_bono,nro_turno)
	   (select (select b.nro_bono
			    from NEXTGDD.Bono_Consulta b
				where b.fecha_impresion=Bono_Consulta_Fecha_Impresion and
					  isnull(b.compra_fecha,0)=isnull(Compra_Bono_Fecha,0) and
					  b.nro_consulta=Bono_Consulta_Numero and
					  b.cod_plan= Plan_Med_Codigo and
					  b.nro_afiliado= (select a.nro_afiliado from NEXTGDD.Afiliado a,NEXTGDD.Tipo_Documento d where Paciente_Dni=d.nro_documento and d.nro_afiliado=a.nro_afiliado and ISNULL(d.matricula,0)=0)
				group by b.nro_bono),
			   (select t.nro_turno
				from NEXTGDD.Turno t
				where t.fecha=Turno_fecha and
				  	  t.nro_afiliado= (select a.nro_afiliado 
									   from NEXTGDD.Afiliado a,NEXTGDD.Tipo_Documento d 
									   where Paciente_Dni=d.nro_documento and d.nro_afiliado=a.nro_afiliado and isnull(d.matricula,0)=0)
					  and t.cod_agenda = (select a.cod_agenda
					 					  from NEXTGDD.Agenda a,NEXTGDD.Profesional p,NEXTGDD.Tipo_Documento d
										  where a.cod_especialidad=Especialidad_Codigo and a.matricula=p.matricula and (d.matricula=p.matricula and isnull(d.matricula,0)<>0) and d.nro_documento=Medico_Dni)			
				group by t.nro_turno)
		from gd_esquema.Maestra
		where not(Consulta_Sintomas IS NULL and Consulta_Enfermedades IS NULL) );
GO
*/
/************************************/

/****** Inserto el usuario admin *****/

DECLARE @hash VARBINARY(255);
SELECT @hash = HASHBYTES('SHA2_256', 'w23e')

INSERT INTO NEXTGDD.Usuario(username, password)
VALUES ('admin', @hash)

GO

/***************Validacion de Procedure, Function,Triggers*********************/
/****las validaciones nos permite ejecutar todo el script,una vez ya ejecutado por primera vez****/

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.ingreso'))
    DROP PROCEDURE NEXTGDD.ingreso

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.crearTurno'))
    DROP PROCEDURE NEXTGDD.crearTurno

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.verificarRangoDeAtencion'))
    DROP FUNCTION NEXTGDD.verificarRangoDeAtencion

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.pedirTurno'))
    DROP TRIGGER NEXTGDD.pedirTurno

GO
/*********************Stored Procedure************************/

--CREATE PROCEDURE NEXTGDD.logins (@userName VARCHAR(255), @password VARBINARY(255)) 
 
CREATE PROCEDURE NEXTGDD.ingreso(@user VARCHAR(100), @pass VARBINARY(100))

 AS 
  BEGIN

  DECLARE @ret BIT
  DECLARE @logins_fallidos SMALLINT

  SELECT @ret=COUNT(*), @logins_fallidos=MAX(logins_fallidos)
    FROM NEXTGDD.Usuario
   WHERE username = @user
     AND password = HASHBYTES('SHA2_256', @pass)
     AND habilitado = 1

  IF @ret = 0  BEGIN
    --Agrego un login fallido
    
	UPDATE NEXTGDD.Usuario
       SET logins_fallidos = logins_fallidos + 1
     WHERE username = @user
    
	--si ya tiene 3 logins fallidos dar de baja al usuario
    
	UPDATE NEXTGDD.Usuario
       SET habilitado = 0
     WHERE username = @user
       AND logins_fallidos = 3
  END
  
     ELSE
     --reseteo la cantidad de fallos
	    UPDATE NEXTGDD.Usuario
        SET logins_fallidos = 0
        WHERE username = @user

     --Devuelvo los roles correspondientes al usuario 

       SELECT @ret AS login_valido, R_U.id_rol, R.nombre
       FROM NEXTGDD.Usuario_x_Rol R_U, NEXTGDD.ROl R, NEXTGDD.Usuario U
       WHERE R_U.id_rol = R.id_rol
             AND U.username = @user
             AND U.username = R_U.username 
	
END

GO


CREATE PROCEDURE NEXTGDD.crearTurno (@nroAf numeric(18,0),@nombreEsp varchar(255),@nomProf varchar(255),@apellidoP varchar(255),@fecha datetime)
AS
BEGIN
	DECLARE @nroTurno numeric(18,0)=(select isnull(count(*),0)+1 from NEXTGDD.Turno);
	DECLARE @codAgenda numeric (18,0)=(select cod_agenda 
									   from NEXTGDD.Agenda a,NEXTGDD.Profesional p,NEXTGDD.Profesional_X_Especialidad pe,NEXTGDD.Especialidad e
									   where p.nombre=@nomProf and p.apellido=@apellidoP and e.descripcion=@nombreEsp and
									         pe.matricula=p.matricula and pe.cod_especialidad=e.cod_especialidad
											 and a.cod_especialidad=pe.cod_especialidad and a.matricula=pe.matricula)
	INSERT NEXTGDD.Turno (nro_turno,nro_afiliado,cod_agenda,fecha,cod_cancelacion) values
			(@nroTurno,@nroAf,@codAgenda,@fecha,null)
END;
GO


CREATE TRIGGER NEXTGDD.pedirTurno ON NEXTGDD.Turno INSTEAD OF insert
AS
BEGIN
	IF (select isnull(count(t.cod_agenda+t.fecha),0) 
	    from inserted i,NEXTGDD.Turno t
		where i.cod_agenda+i.fecha=t.cod_agenda+t.fecha
		group by t.cod_agenda,t.fecha)=0 
	BEGIN
		IF GD2C2016.NEXTGDD.verificarRangoDeAtencion((select fecha from inserted),(select cod_agenda from inserted))=1
		BEGIN
			INSERT NEXTGDD.Turno (nro_turno,fecha,nro_afiliado,cod_agenda,cod_cancelacion) 
			(select nro_turno,fecha,nro_afiliado,cod_agenda,cod_cancelacion
			 from inserted)
			RETURN
		END
		raiserror('El turno esta fuera del rango de atencion del profesional',1,1)
		RETURN
	END
	raiserror('Ya hay un turno en ese horario',1,1)
	RETURN
END;
GO 

CREATE FUNCTION NEXTGDD.verificarRangoDeAtencion (@fecha datetime,@cod_agenda numeric(18,0))
returns int
AS
BEGIN
	RETURN (select isnull(count(cod_agenda+rango_atencion),0)
			from NEXTGDD.Rango_Atencion 
	        where cod_agenda=@cod_agenda
				  and (SELECT DATEPART(HOUR, @fecha))<hora_final
				  and (SELECT DATEPART(HOUR, @fecha))>hora_inicial
				  /*FALTA VER DIA SEMANAL-->CAMBIAR DIA DE SEMANA POR NUMERO*/
			group by cod_agenda,rango_atencion)
			/*DEVUELVE 1 SI ESTA DENTRO DE ALGUN RANGO
			  SINO DEVUELVE 0*/ 
END;
GO

/*DROP FUNCTION NEXTGDD.verificarRangoDeAtencion*/
/*DROP TRIGGER NEXTGDD.pedirTurno*/
/*DROP PROCEDURE NEXTGDD.crearTurno*/
