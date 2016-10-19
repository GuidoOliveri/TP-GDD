USE [GD2C2016]
GO

/**** CREACION DE SCHEMA ****/

/***POR PALABRA RESERVADA COLOCO 'NEXTGDD' **/

CREATE SCHEMA NEXTGDD AUTHORIZATION gd
GO

/**** CREACION DE TABLAS ****/

CREATE TABLE NEXTGDD.Usuario (
   
    username varchar (255) PRIMARY KEY,
    password varbinary (255) NOT NULL,   --OK en SHA 256 
	logins_fallidos smallint NOT NULL DEFAULT 0,
	habilitado bit NOT NULL DEFAULT 1
    )

CREATE TABLE NEXTGDD.Rol (

    id_rol int PRIMARY KEY CHECK (id_rol in (1,2,3)),  
	nombre varchar (255),
	habilitado bit NOT NULL DEFAULT 1
    )

CREATE TABLE NEXTGDD.Usuario_x_Rol (

    username varchar (255) REFERENCES NextGDD.Usuario(username),
    id_rol int REFERENCES NextGDD.Rol(id_rol),
    PRIMARY KEY (username, id_rol)
    )


CREATE TABLE NextGDD.Funcionalidad (

   id_funcionalidad numeric (18,0) PRIMARY KEY,
   descripcion varchar (255) 
    )

 CREATE TABLE NEXTGDD.Funcionalidad_X_Rol (

    id_rol int REFERENCES NextGDD.Rol(id_rol),
    id_funcionalidad numeric (18,0) REFERENCES NextGDD.Funcionalidad(id_funcionalidad),
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
    
	id_administrativo numeric (18,0) PRIMARY KEY
	)

CREATE TABLE NEXTGDD.Profesional (
    
	matricula numeric (18,0) PRIMARY KEY,
	nombre varchar (255),
	apellido varchar (255),
	tipo_doc varchar (255),
	nro_doc numeric(18,0),
	domicilio varchar (255),
	telefono numeric (18,0),
	mail varchar (255),
	fecha_nac datetime,
	sexo varchar (255)
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

CREATE TABLE NEXTGDD.Tipo_Documento (
    
	id smallint PRIMARY KEY,
	nombre varchar (255)
	)

CREATE TABLE NEXTGDD.Afiliado (

	nro_afiliado numeric (18,0)  PRIMARY KEY, --asignado por sistema finaliza en: 01 afiliado principal, 02 conyuge, 03 y subsiguientes para el resto de la familia
	nombre varchar (255), 
	apellido varchar (255),
	tipo_doc smallint NOT NULL REFERENCES NEXTGDD.Tipo_Documento(id),
	nro_doc numeric(18,0),
	domicilio varchar (255),
	telefono numeric (18,0),
	mail varchar (255),
	fecha_nac datetime,
	sexo varchar (255),
	estado_civil varchar (255),
	cant_familiares numeric(18, 0),
	cod_plan numeric(18,0) REFERENCES NextGDD.Plan_Medico(cod_plan),
	--
	activo bit DEFAULT 1,
	fecha_baja_logica datetime DEFAULT NULL,
	--
	UNIQUE (nro_doc,tipo_doc)

    )

CREATE TABLE NEXTGDD.Bono_Consulta (

    nro_bono numeric (18,0) PRIMARY KEY,
    fecha_impresion datetime,
    compra_fecha datetime, 
    nro_consulta numeric (18,0),
    cod_plan numeric (18,0) REFERENCES NextGDD.Plan_Medico(cod_plan) 
    )

CREATE TABLE NEXTGDD.Cancelacion (

    cod_cancelacion numeric (18,0) PRIMARY KEY, 
	tipo_cancelacion varchar (255),
	motivo varchar (255)
   )

/**
CREATE TABLE NEXTGDD.Tipo_cancelacion (

    tipo_cancelacion int IDENTITY PRIMARY KEY, 
	nombre varchar (255)
   )
**/

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
   
   cod_diagnostico numeric (18,0) PRIMARY KEY,
   descripcion varchar (255),
   sintoma varchar (255) REFERENCES NextGDD.Sintoma (sintoma),
   enfermedad varchar (255) REFERENCES NextGDD.Enfermedad (enfermedad),
   )

CREATE TABLE NEXTGDD.Consulta (
 
   cod_consulta numeric (18,0) PRIMARY KEY,
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


/*****
***ENCRIPTAR PASSWORD**
SELECT HASHBYTES('SHA2_256', 'CLAVE');

-- o bien así
INSERT INTO SEGURIDAD VALUES HASHBYTES('SHA', 'CLAVE');

***COMPARAR PASSWORD, DESPUES METERLO EN UNA FUNCION(BOTON INGRESAR)***

IF (SELECT COLUMNA FROM SEGURIDAD WHERE ID=1) == (SELECT HASHBYTES('SHA', 'CLAVE')  
BEGIN

--PRINT 'CORRECTO' --Ingresar al sistema

END
ELSE
BEGIN

--PRINT 'INCORRECTO'
UPDATE NEXTGDD.USUARIO
SET int_fallidos= int_fallidos + 1
WHERE username=@un_usuario
END


IF int_fallidos >= 3
BEGIN

inhabilitado = 1

END


***/
