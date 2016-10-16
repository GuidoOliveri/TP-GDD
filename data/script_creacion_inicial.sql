USE [GD2C2016]
GO

/**** CREACION DE SCHEMA ****/

/***POR PALABRA RESERVADA COLOCO 'NextGDD' **/

CREATE SCHEMA NextGDD AUTHORIZATION gd
GO

/**** CREACION DE TABLAS ****/

CREATE TABLE NextGDD.Usuario (
   
    username varchar (255) PRIMARY KEY,
    password varchar(255) NOT NULL DEFAULT '565339bc4d33d72817b583024112eb7f5cdf3e5eef0252d6ec1b9c9a94e12bb3'  --OK en SHA 256 
    )

CREATE TABLE NextGDD.Rol (

    id_rol varchar (255) PRIMARY KEY 
    )

CREATE TABLE NextGDD.Usuario_x_Rol (

    username varchar (255),
    id_rol varchar (255),
    PRIMARY KEY (username, id_rol)
    )


CREATE TABLE NextGDD.Funcionalidad (

   id_funcionalidad numeric (18,0) PRIMARY KEY,
   descripcion varchar (255) 
    )

 CREATE TABLE NextGDD.Funcionalidad_X_Rol (

    id_rol varchar (255) REFERENCES NextGDD.Rol(id_rol),
    id_funcionalidad numeric (18,0) REFERENCES NextGDD.Funcionalidad(id_funcionalidad),
    PRIMARY KEY (id_rol, id_funcionalidad)
    )
	
CREATE TABLE NextGDD.Plan_Medico (
 
   cod_plan numeric (18,0) PRIMARY KEY,
   descripcion varchar (255),
   cuota numeric (18,0),
   precio_bono_consulta numeric (18,0),
   precio_bono_farmacia numeric (18,0),
   )

CREATE TABLE NextGDD.Administrativo (
    
	id_administrativo numeric (18,0) PRIMARY KEY
	)

CREATE TABLE NextGDD.Profesional (
    
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

CREATE TABLE NextGDD.Tipo_Especialidad (
   
   tipo_especialidad numeric (18,0) PRIMARY KEY,
   descripcion varchar (255)
   )
      
CREATE TABLE NextGDD.Especialidad (

   cod_especialidad numeric (18,0) PRIMARY KEY,
   descripcion varchar (255),
   tipo_especialidad numeric (18,0) REFERENCES NextGDD.Tipo_Especialidad (tipo_especialidad)
   )

CREATE TABLE NextGDD.Profesional_X_Especialidad (

   matricula numeric (18,0) REFERENCES NextGDD.Profesional(matricula),
   cod_especialidad numeric (18,0) REFERENCES NextGDD.Especialidad(cod_especialidad),
   PRIMARY KEY (matricula, cod_especialidad) 
   )

CREATE TABLE NextGDD.Afiliado (

	nro_afiliado numeric (18,0) PRIMARY KEY,
	nombre varchar (255),
	apellido varchar (255),
	tipo_doc varchar (255),
	nro_doc numeric(18,0),
	domicilio varchar (255),
	telefono numeric (18,0),
	mail varchar (255),
	fecha_nac datetime,
	sexo varchar (255),
	estado_civil varchar (255),
	cant_familiares numeric(18, 0),
	cod_plan numeric(18,0) REFERENCES NextGDD.Plan_Medico(cod_plan) 
    )

CREATE TABLE NextGDD.Bono_Consulta (

    nro_bono numeric (18,0) PRIMARY KEY,
    fecha_impresion datetime,
    compra_fecha datetime,
    nro_consulta numeric (18,0),
    cod_plan numeric (18,0) REFERENCES NextGDD.Plan_Medico(cod_plan) 
    )

CREATE TABLE NextGDD.Cancelacion (

    cod_cancelacion numeric (18,0) PRIMARY KEY, 
	tipo_cancelacion varchar(255),
	motivo varchar (255)
   )


CREATE TABLE NextGDD.Agenda (

   cod_agenda numeric (18,0) IDENTITY PRIMARY KEY,
   matricula numeric (18,0) NOT NULL,
   cod_especialidad numeric (18,0) NOT NULL,
   FOREIGN KEY (matricula, cod_especialidad) REFERENCES NextGDD.Profesional_X_Especialidad(matricula, cod_especialidad)
   )

CREATE TABLE NextGDD.Turno (

   nro_turno numeric (18,0) PRIMARY KEY,
   fecha datetime,
   nro_afiliado numeric (18,0) REFERENCES NextGDD.afiliado(nro_afiliado),
   cod_agenda numeric (18,0) REFERENCES NextGDD.Agenda(cod_agenda),
   cod_cancelacion numeric (18,0) REFERENCES NextGDD.Cancelacion(cod_cancelacion)
   )


CREATE TABLE NextGDD.Sintoma (

   sintoma int PRIMARY KEY,
   descripcion varchar (255)
   )

CREATE TABLE NextGDD.Enfermedad (

   enfermedad int PRIMARY KEY,
   descripcion varchar (255)
   )

CREATE TABLE NextGDD.Diagnostico (
   
   cod_diagnostico numeric (18,0) PRIMARY KEY,
   descripcion varchar (255),
   sintoma int REFERENCES NextGDD.Sintoma (sintoma),
   enfermedad int REFERENCES NextGDD.Enfermedad (enfermedad),
   )

CREATE TABLE NextGDD.Consulta (
 
   cod_consulta numeric (18,0) PRIMARY KEY,
   cod_diagnostico numeric (18,0) REFERENCES NextGDD.Diagnostico(cod_diagnostico),
   nro_bono numeric (18,0) REFERENCES NextGDD.Bono_Consulta(nro_bono),
   nro_turno numeric (18,0) REFERENCES NextGDD.Turno(nro_turno)
   )

CREATE TABLE NextGDD.Historial (

   nro_historial numeric (18,0) PRIMARY KEY,
   fecha_modificacion datetime,
   motivo_modificacion varchar (255),
   nro_afiliado numeric (18,0) REFERENCES NextGDD.afiliado(nro_afiliado),
   cod_plan_viejo numeric (18,0) REFERENCES NextGDD.Plan_Medico(cod_plan),
    cod_plan_nuevo numeric (18,0) REFERENCES NextGDD.Plan_Medico(cod_plan)  
   )

CREATE TABLE NextGDD.Agenda_X_Turno (

   cod_agenda numeric (18,0) REFERENCES NextGDD.Agenda(cod_agenda),
   fecha datetime,
   cod_cancelacion numeric (18,0) REFERENCES NextGDD.Cancelacion(cod_cancelacion),
   PRIMARY KEY (cod_agenda,fecha)
   )


CREATE TABLE NextGDD.Rango_Atencion (

   cod_agenda numeric (18,0) REFERENCES NextGDD.Agenda(cod_agenda),
   rango_atencion numeric (18,0) ,
   hora_inicial numeric (18,0),
   hora_final numeric (18,0),
   dia_semanal_inicial varchar (255), 
   dia_semanal_final varchar (255),
   PRIMARY KEY (cod_agenda, rango_atencion) 
   )



