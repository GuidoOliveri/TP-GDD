USE [GD2C2016]
GO

/**** CREACION DE SCHEMA ****/

IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'NEXTGDD')
BEGIN
    EXEC ('CREATE SCHEMA NEXTGDD AUTHORIZATION gd')
END

GO

/******** VALIDACION DE TABLAS ********/

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Rango_Atencion_Clinica'))
    DROP TABLE NEXTGDD.Rango_Atencion_Clinica

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

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Rango_Fechas'))
    DROP TABLE NEXTGDD.Rango_Fechas

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

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Cancelacion_Por_Fecha'))
    DROP TABLE NEXTGDD.Cancelacion_Por_Fecha

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

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Plan_Medico'))
    DROP TABLE NEXTGDD.Plan_Medico

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Persona'))
    DROP TABLE 	NEXTGDD.Persona

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Estado_Civil'))
    DROP TABLE NEXTGDD.Estado_Civil
	
GO

/**** CREACION DE TABLAS ****/

CREATE TABLE NEXTGDD.Rango_Atencion_Clinica(
	id_rango_clinica tinyint IDENTITY,
	dia_inicial numeric(18,0),
	dia_final numeric(18,0),
	hora_inicial time,
	hora_final time
	)

CREATE TABLE NEXTGDD.Estado_Civil (

   id tinyint PRIMARY KEY IDENTITY,
   nombre varchar (50) 
   ) 

CREATE TABLE NEXTGDD.Persona (

	id_persona numeric (18,0) PRIMARY KEY identity,
	nombre varchar (255) not null, 
	apellido varchar (255) not null,
	domicilio varchar (255) not null ,
	telefono numeric (18,0) not null,
	mail varchar (255) not null,
	fecha_nac datetime not null,
	sexo char (1) not null default 'X',
	estado_civil tinyint not null default 6 REFERENCES NEXTGDD.Estado_Civil(id),
	nro_documento numeric(18,0) NOT NULL,
	tipo_doc varchar (50) NOT NULL DEFAULT 'D.N.I.',

	CONSTRAINT check_s2 check (sexo IN ('H', 'M','X')),
	CONSTRAINT tipodoc_2 check (tipo_doc IN ('L.E.', 'Pasaporte','D.N.I.','L.C','C.I.')),
	CONSTRAINT unique_tipo_nro_Doc unique (nro_documento,tipo_doc)
	)


CREATE TABLE NEXTGDD.Usuario (
   
    username varchar (50) PRIMARY KEY,
    password varbinary (255) NOT NULL,   --OK en SHA 256 
	logins_fallidos smallint NOT NULL DEFAULT 0,
	habilitado bit NOT NULL DEFAULT 1,
	id_persona numeric (18,0) REFERENCES NEXTGDD.Persona(id_persona)
    )

CREATE TABLE NEXTGDD.Rol (

    id_rol tinyint PRIMARY KEY IDENTITY,  
	nombre varchar (255) NOT NULL,
	habilitado bit NOT NULL DEFAULT 1
)
    

CREATE TABLE NEXTGDD.Usuario_X_Rol (

    username varchar (50) REFERENCES NextGDD.Usuario(username),
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

CREATE TABLE NEXTGDD.Profesional (
	matricula numeric (18,0) IDENTITY(1000,1) PRIMARY KEY,
	id_persona numeric (18,0) REFERENCES NEXTGDD.Persona(id_persona),
    activo bit DEFAULT 0
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
	nro_afiliado numeric (20,0) PRIMARY KEY , 
	cant_familiares tinyint,
	cod_plan numeric(18,0) REFERENCES NextGDD.Plan_Medico(cod_plan),
    nro_consulta int,
	activo bit DEFAULT 1,
	fecha_baja_logica datetime DEFAULT NULL,
	id_persona numeric (18,0) REFERENCES NEXTGDD.Persona(id_persona),
	grupo_afiliado numeric (18,0) ,       
	integrante_grupo numeric (2,0)        
	)
	 
CREATE TABLE NEXTGDD.Compra_Bono (
	id_compra int PRIMARY KEY IDENTITY (1000,1), 
	cant smallint,
	compra_fecha datetime,
	precio_total int,
	id_afiliado numeric(20,0) REFERENCES NextGDD.Afiliado
	)

CREATE TABLE NEXTGDD.Bono_Consulta (

    nro_bono numeric (18,0) IDENTITY(1,1) PRIMARY KEY,
    fecha_impresion datetime,
    cod_plan numeric (18,0) REFERENCES NextGDD.Plan_Medico(cod_plan), 
	nro_afiliado numeric (20,0) REFERENCES NextGDD.Afiliado(nro_afiliado), 
	id_compra int REFERENCES NextGDD.Compra_Bono(id_compra) 
    ) 
	
CREATE TABLE NEXTGDD.Tipo_cancelacion (

    tipo_cancelacion tinyint IDENTITY PRIMARY KEY, 
	nombre varchar (255)
   )

CREATE TABLE NEXTGDD.Cancelacion (

    cod_cancelacion numeric (18,0) PRIMARY KEY IDENTITY, 
	tipo_cancelacion tinyint REFERENCES NEXTGDD.Tipo_cancelacion(tipo_cancelacion) ,
	motivo varchar (255)
   )

CREATE TABLE NEXTGDD.Agenda (

   cod_agenda numeric (18,0) IDENTITY PRIMARY KEY,
   matricula numeric (18,0) NOT NULL,
   cod_especialidad numeric (18,0) NOT NULL,
   FOREIGN KEY (matricula, cod_especialidad) REFERENCES NextGDD.Profesional_X_Especialidad(matricula, cod_especialidad)
   )

CREATE TABLE NEXTGDD.Cancelacion_Por_Fecha (

    cod_canc_fecha numeric (18,0) PRIMARY KEY IDENTITY, 
	fecha_desde datetime,
	fecha_hasta datetime,
	cod_agenda numeric (18,0) REFERENCES NEXTGDD.Agenda(cod_agenda) 
   )

CREATE TABLE NEXTGDD.Turno (

   nro_turno numeric (18,0) PRIMARY KEY IDENTITY,
   fecha datetime,
   nro_afiliado numeric (20,0) REFERENCES NextGDD.afiliado(nro_afiliado),
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
   
   cod_diagnostico numeric (18,0) PRIMARY KEY IDENTITY (1000,1),
   fecha_diagnostico datetime,
   descripcion varchar (255),
   sintoma varchar (255) REFERENCES NextGDD.Sintoma (sintoma),
   enfermedad varchar (255) REFERENCES NextGDD.Enfermedad (enfermedad),
   )

CREATE TABLE NEXTGDD.Consulta (
 
   cod_consulta numeric (18,0) PRIMARY KEY IDENTITY (1000,1),
   fecha_consulta datetime,
   cod_diagnostico numeric (18,0) REFERENCES NextGDD.Diagnostico(cod_diagnostico),
   nro_bono numeric (18,0) REFERENCES NextGDD.Bono_Consulta(nro_bono),
   nro_turno numeric (18,0) REFERENCES NextGDD.Turno(nro_turno)
   )

CREATE TABLE NEXTGDD.Historial (

   nro_historial numeric (18,0) PRIMARY KEY IDENTITY (1000,1),
   fecha_modificacion datetime,
   motivo_modificacion varchar (255),
   nro_afiliado numeric (20,0) REFERENCES NextGDD.afiliado(nro_afiliado),
   cod_plan_viejo numeric (18,0) REFERENCES NextGDD.Plan_Medico(cod_plan),
    cod_plan_nuevo numeric (18,0) REFERENCES NextGDD.Plan_Medico(cod_plan)  
   )

CREATE TABLE NEXTGDD.Rango_Fechas (

   cod_agenda numeric (18,0) REFERENCES NEXTGDD.Agenda(cod_agenda),
   cod_fecha numeric (18,0),
   fecha_desde datetime,
   fecha_hasta datetime,
   PRIMARY KEY (cod_agenda, cod_fecha) 
   )
GO

CREATE TABLE NEXTGDD.Rango_Atencion (

   cod_agenda numeric (18,0),
   cod_fecha numeric (18,0),
   rango_atencion numeric (18,0),
   hora_inicial time,
   hora_final time,
   dia_semanal_inicial numeric(18,0), 
   dia_semanal_final numeric(18,0),
   PRIMARY KEY (cod_agenda,cod_fecha,rango_atencion),
   FOREIGN KEY (cod_agenda,cod_fecha) REFERENCES NEXTGDD.Rango_Fechas(cod_agenda,cod_fecha) 
   )
GO

/***************Validacion de Procedure, Function,Triggers*********************/

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.login'))
    DROP PROCEDURE NEXTGDD.login

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.crearTurno'))
    DROP PROCEDURE NEXTGDD.crearTurno
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.agregar_funcionalidad'))
    DROP PROCEDURE NEXTGDD.agregar_funcionalidad
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.eliminar_Funcionalidad_Rol'))
    DROP PROCEDURE NEXTGDD.eliminar_Funcionalidad_Rol
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.agregar_Rol'))
    DROP PROCEDURE NEXTGDD.agregar_Rol
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.modificar_Nombre_Rol'))
    DROP PROCEDURE NEXTGDD.modificar_Nombre_Rol
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.agregarAfiliadoFamilia'))
    DROP PROCEDURE NEXTGDD.agregarAfiliadoFamilia

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.agregar_usuario'))
    DROP PROCEDURE NEXTGDD.agregar_usuario
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.darDeBajaRol'))
    DROP PROCEDURE NEXTGDD.darDeBajaRol
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.modificar_Afiliado_SnPlan'))
    DROP PROCEDURE NEXTGDD.modificar_Afiliado_SnPlan
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.modificar_Afiliado_CnPlan'))
    DROP PROCEDURE NEXTGDD.modificar_Afiliado_CnPlan
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.agregarAfiliadoPrincipal'))
    DROP PROCEDURE NEXTGDD.agregarAfiliadoPrincipal
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.mostrarHistorial'))
    DROP PROCEDURE NEXTGDD.mostrarHistorial
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.mostrarHistorial_ga'))
    DROP PROCEDURE NEXTGDD.mostrarHistorial_ga
GO


IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.mostrarHistorialAfil_grupo'))
    DROP PROCEDURE NEXTGDD.mostrarHistorialAfil_grupo
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.darDeBajaAfiliado'))
    DROP PROCEDURE NEXTGDD.darDeBajaAfiliado
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.validarConRangoHorario'))
    DROP FUNCTION NEXTGDD.validarConRangoHorario
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.obtenerRangoClinica'))
    DROP FUNCTION NEXTGDD.obtenerRangoClinica
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.buscarCodigoAgenda'))
    DROP FUNCTION NEXTGDD.buscarCodigoAgenda
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.buscarProfesionales'))
    DROP FUNCTION NEXTGDD.buscarProfesionales
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.tieneRangosHorarios'))
    DROP FUNCTION NEXTGDD.tieneRangosHorarios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.validarTurnoDisponible'))
    DROP FUNCTION NEXTGDD.validarTurnoDisponible
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.buscarTurnosDelDia'))
    DROP FUNCTION NEXTGDD.buscarTurnosDelDia
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.validarUsoDelTurno'))
    DROP FUNCTION NEXTGDD.validarUsoDelTurno
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.buscarBonosDisponibles'))
    DROP FUNCTION NEXTGDD.buscarBonosDisponibles
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.buscarAfiliadosAtendidos'))
    DROP FUNCTION NEXTGDD.buscarAfiliadosAtendidos
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.buscarConsultasAtendidas'))
    DROP FUNCTION NEXTGDD.buscarConsultasAtendidas
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.filtrarConsultasPorAfiliado'))
    DROP FUNCTION NEXTGDD.filtrarConsultasPorAfiliado
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.buscarEspecialidades'))
    DROP FUNCTION NEXTGDD.buscarEspecialidades
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.validarAgendaUnica'))
    DROP FUNCTION NEXTGDD.validarAgendaUnica
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.registrarConsulta'))
    DROP PROCEDURE NEXTGDD.registrarConsulta
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.registrarDiagnostico'))
    DROP PROCEDURE NEXTGDD.registrarDiagnostico
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.restringirHorarios'))
    DROP FUNCTION NEXTGDD.restringirHorarios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.restringirFechas'))
    DROP FUNCTION NEXTGDD.restringirFechas
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.registrarAgenda'))
    DROP PROCEDURE NEXTGDD.registrarAgenda
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.buscarCodigoRangoFecha'))
    DROP FUNCTION NEXTGDD.buscarCodigoRangoFecha
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.verSuperposicionDeRangos'))
    DROP FUNCTION NEXTGDD.verSuperposicionDeRangos
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.obtenerRangosHorarios'))
    DROP FUNCTION NEXTGDD.obtenerRangosHorarios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.registrarRangoHorario'))
    DROP PROCEDURE NEXTGDD.registrarRangoHorario
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.registrarCompra'))
    DROP PROCEDURE NEXTGDD.registrarCompra
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.comprarBono'))
    DROP PROCEDURE NEXTGDD.comprarBono
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.cancelarTurno'))
    DROP PROCEDURE NEXTGDD.cancelarTurno
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.registrarCancelacionDePeriodo'))
    DROP PROCEDURE NEXTGDD.registrarCancelacionDePeriodo
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Pacientes'))
    DROP VIEW NEXTGDD.Pacientes
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Pacientes'))
    DROP VIEW NEXTGDD.Pacientes_Afil
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Medicos'))
    DROP VIEW NEXTGDD.Medicos	
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Pacientes_Afil'))
    DROP VIEW NEXTGDD.Pacientes_Afil
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.verificarCancelacionesProfesional'))
    DROP FUNCTION NEXTGDD.verificarCancelacionesProfesional
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.informacionCompraBonos'))
    DROP VIEW NEXTGDD.informacionCompraBonos
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.listado1'))
    DROP FUNCTION NEXTGDD.listado1
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.listado1Ambos'))
    DROP FUNCTION NEXTGDD.listado1Ambos
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.listado2'))
    DROP FUNCTION NEXTGDD.listado2
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.listado3'))
    DROP FUNCTION NEXTGDD.listado3
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.listado4'))
    DROP FUNCTION NEXTGDD.listado4
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.listado5'))
    DROP FUNCTION NEXTGDD.listado5	
GO

/*********************Creacion de Stored Procedure, Function,Triggers, vistas************************/

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
	WHERE Medico_Dni IS NOT NULL
GO

CREATE VIEW NEXTGDD.Pacientes_Afil (Nro_Afiliado, Nombre, Apellido,Tipo_Doc, Nro_Doc, Direccion, Telefono, Mail,Plan_Medico,Fecha_Nac,Estado_Civil,Cant_Hijos, Activo)
AS
select nro_afiliado, p.nombre,apellido, tipo_doc, nro_documento, domicilio, telefono, mail, m.descripcion, fecha_nac ,e.nombre , cant_familiares, activo
from NEXTGDD.Persona p Join NEXTGDD.Afiliado a ON(p.id_persona= a.id_persona) 
     Join NEXTGDD.Plan_Medico m ON (m.cod_plan= a.cod_plan)
	 Join NEXTGDD.Estado_Civil e ON (e.id= p.estado_civil)
GO


CREATE PROCEDURE NEXTGDD.modificar_Afiliado_CnPlan(@id numeric(20,0),@nuevo_dom varchar(255), @nuevo_telef numeric(18,0) ,@nuevo_mail varchar(255),
                                                 @nuevo_est_civil varchar(255),@nuevocant_famil smallint, @nuevo_plan varchar(255),
												 @motivo varchar (255), @fecha datetime ,@ret smallint output)
 AS BEGIN
  
  
DECLARE @pers numeric (18,0)
DECLARE @domicActual varchar (255)
DECLARE @mailActual varchar (255)
DECLARE @cant_famActual smallint 
DECLARE @planActual  numeric (18,0)
DECLARE @id_plan_N numeric (18,0)
DECLARE @telefActual  numeric (18,0)
DECLARE @estado_civilActual tinyint
DECLARE @id_estcivilNuev tinyint 

 IF EXISTS( SELECT * FROM NEXTGDD.Afiliado WHERE nro_afiliado = @id)
   BEGIN
    BEGIN TRY
	  BEGIN TRANSACTION   
         	
		   SELECT @pers = id_persona,@cant_famActual= cant_familiares, @planActual = cod_plan FROM NEXTGDD.Afiliado WHERE nro_afiliado = @id 
           
		   SELECT  @domicActual= domicilio, @estado_civilActual = estado_civil, @telefActual= telefono,@mailActual= mail  FROM NEXTGDD.Persona
           
           SELECT @id_plan_N= cod_plan FROM NEXTGDD.Plan_Medico WHERE descripcion= @nuevo_plan 
	       
		   SELECT @id_estcivilNuev=id FROM NEXTGDD.Estado_Civil Where nombre = @nuevo_est_civil

	   IF @domicActual <> @nuevo_dom
	      BEGIN
		    UPDATE NEXTGDD.Persona
            SET  domicilio = @nuevo_dom
            WHERE  id_persona= @pers
          END   
	   
	   IF @telefActual<> @nuevo_telef
	      BEGIN	   
		    UPDATE NEXTGDD.Persona
            SET  telefono = @nuevo_telef
            WHERE  id_persona= @pers
          END
       
	   IF @mailActual <> @nuevo_mail
	      BEGIN
		    UPDATE NEXTGDD.Persona
            SET  mail = @nuevo_mail
            WHERE  id_persona= @pers
          END

      IF  @estado_civilActual <>@id_estcivilNuev
	       BEGIN  
		  	UPDATE NEXTGDD.Persona
            SET  estado_civil  =  @id_estcivilNuev
            WHERE  id_persona= @pers
		   END
       
	  IF  @cant_famActual  <> @nuevocant_famil
	       BEGIN  
		   UPDATE NEXTGDD.Afiliado
            SET  cant_familiares  = @nuevocant_famil 
            WHERE  id_persona= @pers
		   END

	       
       UPDATE NEXTGDD.Afiliado
       SET  cod_plan = @id_plan_N
       WHERE  nro_afiliado= @id
           
	  INSERT INTO NEXTGDD.Historial (fecha_modificacion, motivo_modificacion, nro_afiliado, cod_plan_viejo,cod_plan_nuevo)
		                        VALUES (@fecha,@motivo,@id,@planActual,@id_plan_N)

	COMMIT TRANSACTION
    SET @ret = 0

  END TRY
  
  BEGIN CATCH
    ROLLBACK TRANSACTION 
    SET @ret = -1

   END CATCH
END
 ELSE
    SET @ret = -2
	
END
GO



CREATE PROCEDURE NEXTGDD.modificar_Afiliado_SnPlan(@id numeric(20,0),@nuevo_dom varchar(255), @nuevo_telef numeric(18,0) ,@nuevo_mail varchar(255),
                                                   @nuevo_est_civil varchar(255),@nuevocant_famil smallint, @ret smallint output)
 AS BEGIN
  
  
DECLARE @pers numeric (18,0)
DECLARE @domicActual varchar (255)
DECLARE @mailActual varchar (255)
DECLARE @cant_famActual smallint 
DECLARE @telefActual  numeric (18,0)
DECLARE @estado_civilActual tinyint
DECLARE @id_estcivilNuev tinyint

 IF EXISTS( SELECT * FROM NEXTGDD.Afiliado WHERE nro_afiliado = @id)
    BEGIN
	BEGIN TRY
	  BEGIN TRANSACTION   
         	
		   SELECT @pers = id_persona,@cant_famActual= cant_familiares FROM NEXTGDD.Afiliado WHERE nro_afiliado = @id 
           
		   SELECT  @domicActual= domicilio, @estado_civilActual = estado_civil, @telefActual= telefono,@mailActual= mail  FROM NEXTGDD.Persona
           
		   SELECT @id_estcivilNuev=id FROM NEXTGDD.Estado_Civil Where nombre = @nuevo_est_civil

	   IF @domicActual <> @nuevo_dom
	      BEGIN
		    UPDATE NEXTGDD.Persona
            SET  domicilio = @nuevo_dom
            WHERE  id_persona= @pers
          END   
	   
	   IF @telefActual<> @nuevo_telef
	      BEGIN	   
		    UPDATE NEXTGDD.Persona
            SET  telefono = @nuevo_telef
            WHERE  id_persona= @pers
          END
       
	   IF @mailActual <> @nuevo_mail
	      BEGIN
		    UPDATE NEXTGDD.Persona
            SET  mail = @nuevo_mail
            WHERE  id_persona= @pers
          END

      IF  @estado_civilActual <> @id_estcivilNuev
	       BEGIN  
		  	UPDATE NEXTGDD.Persona
            SET  estado_civil  =  @id_estcivilNuev
            WHERE  id_persona= @pers
		   END
       
	  IF  @cant_famActual  <> @nuevocant_famil
	       BEGIN  
		   UPDATE NEXTGDD.Afiliado
            SET  cant_familiares  = @nuevocant_famil 
            WHERE  nro_afiliado= @id
		   END

	COMMIT TRANSACTION
    SET @ret = 0

  END TRY
  
  BEGIN CATCH
    ROLLBACK TRANSACTION 
    SET @ret = -1

   END CATCH
END
 ELSE
    SET @ret = -2
	
END
GO



CREATE PROCEDURE NEXTGDD.login(@user VARCHAR(100), @pass varchar(100), @ret smallint output)
 AS 
  BEGIN

  IF EXISTS( SELECT 1 FROM NEXTGDD.Usuario   WHERE username = @user AND habilitado = 1)
  
     BEGIN

	    IF ( SELECT password FROM NEXTGDD.Usuario WHERE username = @user) = HASHBYTES('SHA2_256', @pass)
		    BEGIN
			  UPDATE NEXTGDD.Usuario
              SET logins_fallidos = 0
              WHERE username = @user
				set @ret = 0
			END
           
		  ELSE
		   BEGIN 

            UPDATE NEXTGDD.Usuario
            SET logins_fallidos = logins_fallidos + 1
            WHERE username = @user
    
    
	       UPDATE NEXTGDD.Usuario
           SET habilitado = 0
           WHERE username = @user
           AND logins_fallidos = 3
		   
		   SET @ret = -2
		   
		   END
        END

   ELSE
		SET @ret= -1
END
GO

CREATE PROCEDURE NEXTGDD.crearTurno (@nroAf numeric(18,0),@nombreEsp varchar(255),@nomProf varchar(255),@fecha datetime)
AS
BEGIN
	DECLARE @codAgenda numeric (18,0)=(select cod_agenda 
									   from NEXTGDD.Agenda a,NEXTGDD.Profesional p,NEXTGDD.Profesional_X_Especialidad pe,NEXTGDD.Especialidad e,NEXTGDD.Persona persona
									   where (persona.nombre+' '+persona.apellido)=@nomProf and persona.id_persona=p.id_persona
											 and e.descripcion=@nombreEsp and
									         pe.matricula=p.matricula and pe.cod_especialidad=e.cod_especialidad
											 and a.cod_especialidad=pe.cod_especialidad and a.matricula=pe.matricula)
	INSERT NEXTGDD.Turno (nro_afiliado,cod_agenda,fecha) values
			(@nroAf,@codAgenda,@fecha)
END;
GO

CREATE FUNCTION NEXTGDD.buscarProfesionales(@especialidad varchar(255))
RETURNS TABLE
AS
	RETURN select distinct (p.nombre+' '+p.apellido) as nombre 
			from NEXTGDD.Persona p,NEXTGDD.Profesional pr,NEXTGDD.Profesional_X_Especialidad pe,NEXTGDD.Especialidad e 
			where pr.id_persona=p.id_persona and pe.matricula=pr.matricula and pe.cod_especialidad=e.cod_especialidad 
			and e.descripcion LIKE @especialidad and pr.activo=1
GO

CREATE FUNCTION NEXTGDD.obtenerRangoClinica(@diaSemana numeric(18,0)) 
RETURNS TABLE
AS
	RETURN select hora_inicial as 'horaD',hora_final as 'horaH' from NEXTGDD.Rango_Atencion_Clinica where @diaSemana>=dia_inicial and @diaSemana<=dia_final;
GO

CREATE FUNCTION NEXTGDD.validarTurnoDisponible(@fecha datetime,@profesional varchar(255))
RETURNS varchar(255)
AS
BEGIN
	RETURN (select CASE WHEN (isnull(count(*),0)=0)
					THEN 'true'
					ELSE 'false'
					END 
		   from NEXTGDD.Turno t,NEXTGDD.Agenda a, NEXTGDD.Profesional p,NEXTGDD.Persona pers 
  		   where t.fecha LIKE @fecha and (pers.nombre+' '+pers.apellido) LIKE @profesional
		   and pers.id_persona=p.id_persona and a.matricula=p.matricula and t.cod_agenda=a.cod_agenda)
END;
GO

CREATE FUNCTION NEXTGDD.verificarCancelacionesProfesional(@fecha datetime,@profesional varchar(255),@especialidad varchar(255))
RETURNS varchar(255)
AS
BEGIN
	RETURN (select CASE WHEN (isnull(count(*),0)<>0)
					THEN 'Cancelo la fecha'
					ELSE 'No cancelo la fecha'
					END 
		   from NEXTGDD.Agenda a, NEXTGDD.Profesional p,NEXTGDD.Persona pers,NEXTGDD.Especialidad e,NEXTGDD.Cancelacion_Por_Fecha c
  		   where (pers.nombre+' '+pers.apellido) LIKE @profesional and e.descripcion LIKE @especialidad
				 and pers.id_persona=p.id_persona and a.matricula=p.matricula and a.cod_especialidad=e.cod_especialidad
				 and c.cod_agenda=a.cod_agenda and CONVERT(date,@fecha)>=CONVERT(date,c.fecha_desde) 
				 and CONVERT(date,@fecha)<=CONVERT(date,c.fecha_hasta) )
END;
GO

CREATE FUNCTION NEXTGDD.restringirFechas(@especialidad varchar(255),@profesional varchar(255))
RETURNS TABLE
AS
	RETURN (select rf.fecha_desde as 'fechaD',rf.fecha_hasta as 'fechaH'
		   from NEXTGDD.Profesional pr,NEXTGDD.Persona p,NEXTGDD.Especialidad e,NEXTGDD.Agenda a,NEXTGDD.Rango_Fechas rf 
		   where (p.nombre+' '+p.apellido) LIKE @profesional and e.descripcion LIKE @especialidad
				 and pr.id_persona=p.id_persona and a.matricula=pr.matricula and e.cod_especialidad=a.cod_especialidad
				 and rf.cod_agenda=a.cod_agenda)
GO

CREATE FUNCTION NEXTGDD.restringirHorarios(@especialidad varchar(255),@profesional varchar(255),@fecha datetime)
RETURNS TABLE
AS
	RETURN (select r.hora_inicial as 'horaD',r.hora_final as 'horaH'
		   from NEXTGDD.Profesional pr,NEXTGDD.Persona p,NEXTGDD.Especialidad e,NEXTGDD.Agenda a, NEXTGDD.Rango_Atencion r,NEXTGDD.Rango_Fechas rf 
		   where (p.nombre+' '+p.apellido) LIKE @profesional and e.descripcion LIKE @especialidad
				 and pr.id_persona=p.id_persona and a.matricula=pr.matricula and e.cod_especialidad=a.cod_especialidad 
				 and rf.cod_agenda=a.cod_agenda and CONVERT(date,@fecha)>=CONVERT(date,rf.fecha_desde) 
				 and CONVERT(date,@fecha)<=CONVERT(date,rf.fecha_hasta) and str(rf.cod_agenda)+str(rf.cod_fecha)=str(r.cod_agenda)+str(r.cod_fecha)
				 and DATEPART(dw,@fecha)-1<=r.dia_semanal_final and DATEPART(dw,@fecha)-1>=r.dia_semanal_inicial)
GO

CREATE FUNCTION NEXTGDD.tieneRangosHorarios(@especialidad varchar(255),@profesional varchar(255))
RETURNS varchar(255)
AS
BEGIN
	RETURN (select CASE WHEN (isnull(count(*),0)=0)
					THEN 'false'
					ELSE 'true'
					END 
		   from NEXTGDD.Profesional pr,NEXTGDD.Persona p,NEXTGDD.Especialidad e,NEXTGDD.Agenda a, NEXTGDD.Rango_Atencion r 
		   where (p.nombre+' '+p.apellido) LIKE @profesional and e.descripcion LIKE @especialidad
				 and pr.id_persona=p.id_persona and a.matricula=pr.matricula and e.cod_especialidad=a.cod_especialidad 
				 and r.cod_agenda=a.cod_agenda)
END;
GO

CREATE FUNCTION NEXTGDD.validarConRangoHorario(@fecha datetime,@profesional varchar(255),@especialidad varchar(255),@dia numeric(18,0),@hora time) 
RETURNS varchar(255)
AS
BEGIN
	RETURN (select CASE WHEN (isnull(count(*),0)=0)
					THEN 'fuera del rango horario'
					ELSE 'dentro de rango horario'
					END 
		   from NEXTGDD.Profesional pr,NEXTGDD.Persona p,NEXTGDD.Especialidad e,NEXTGDD.Agenda a,NEXTGDD.Rango_Atencion r
	       where p.nombre+' '+p.apellido LIKE @profesional and e.descripcion LIKE @especialidad and pr.id_persona=p.id_persona
			     and a.matricula=pr.matricula and e.cod_especialidad=a.cod_especialidad and r.cod_agenda=a.cod_agenda
				 --and @fecha>=a.rango_fecha_desde and @fecha<=a.rango_fecha_hasta 
			     and r.dia_semanal_inicial<=@dia and r.dia_semanal_final>=@dia and r.hora_inicial<=@hora and r.hora_final>=@hora)
END;
GO

CREATE PROCEDURE NEXTGDD.registrarConsulta (@fechaLlegada datetime,@nomProf varchar(255),@fechaTurno datetime,@nroBono numeric(18,0))
AS
BEGIN
	DECLARE @nro_turno numeric(18,0)=(select t.nro_turno
									  from NEXTGDD.Turno t,NEXTGDD.Agenda ag,NEXTGDD.Profesional pr,NEXTGDD.Persona p
									  where t.fecha=@fechaTurno and 
											p.nombre+' '+p.apellido LIKE @nomProf and
											p.id_persona=pr.id_persona and pr.matricula=ag.matricula and
											t.cod_agenda=ag.cod_agenda)
	INSERT NEXTGDD.Consulta (fecha_consulta,nro_bono,nro_turno) values
			(@fechaLlegada,@nroBono,@nro_turno)
END;
GO

CREATE FUNCTION NEXTGDD.buscarTurnosDelDia(@profesional varchar(255),@fechaSistema datetime)
RETURNS TABLE
AS
	RETURN select t.fecha as fecha 
			from NEXTGDD.Agenda a,NEXTGDD.Turno t,NEXTGDD.Profesional p,NEXTGDD.Persona pe 
			where t.cod_agenda=a.cod_agenda and a.matricula=p.matricula and p.id_persona=pe.id_persona 
				  and (pe.nombre+' '+pe.apellido LIKE @profesional) 
				  --verifica que no haya sido cancelado--
				  and isnull(t.cod_cancelacion,0)=0 
				  and CONVERT(date,t.fecha)=CONVERT(date,@fechaSistema)
			group by t.fecha 
GO

CREATE FUNCTION NEXTGDD.validarUsoDelTurno(@fecha datetime,@profesional varchar(255)) 
RETURNS varchar(255)
AS
BEGIN
	RETURN (select CASE WHEN (isnull(count(*),0)=0)
					THEN 'El turno no fue utilizado'
					ELSE 'El turno ya fue usado'
					END 
		   from NEXTGDD.Turno t,NEXTGDD.Agenda ag,NEXTGDD.Profesional p,NEXTGDD.Consulta c,NEXTGDD.Persona pe 
		   where (pe.nombre+' '+pe.apellido) LIKE @profesional and pe.id_persona=p.id_persona and p.matricula=ag.matricula 
				 and t.cod_agenda=ag.cod_agenda and t.fecha LIKE @fecha
				 and c.nro_turno=t.nro_turno)
END;
GO

CREATE FUNCTION NEXTGDD.buscarBonosDisponibles(@profesional varchar(255),@fecha datetime)
RETURNS TABLE
AS
	RETURN select b.nro_bono as bono 
			from NEXTGDD.Turno t,NEXTGDD.Afiliado a,NEXTGDD.Afiliado a2,NEXTGDD.Bono_Consulta b,NEXTGDD.Agenda ag,
				 NEXTGDD.Profesional pr,NEXTGDD.Persona p 
			where (p.nombre+' '+p.apellido) LIKE @profesional and pr.id_persona=p.id_persona 
				  and pr.matricula=ag.matricula and t.cod_agenda=ag.cod_agenda 
				  and t.fecha LIKE @fecha and t.nro_afiliado=a.nro_afiliado 
				  --puede usar el de un familiar que pertenezca al mismo plan--
				  and b.nro_afiliado=a2.nro_afiliado and a2.grupo_afiliado=a.grupo_afiliado and a.cod_plan=a2.cod_plan 
				  --se verfica que no se haya usado, a menos que el turno figure cancelado--
				  and (select isnull(count(*),0) from NEXTGDD.Consulta c,NEXTGDD.Turno t2 where c.nro_bono=b.nro_bono and
				  t2.nro_turno=c.nro_turno and isnull(t2.cod_cancelacion,0)=0)=0
GO

CREATE PROCEDURE NEXTGDD.registrarDiagnostico (@medico numeric(18,0),@fechaConsulta datetime,@fechaAtencion datetime,@enfermedad varchar(255),@sintoma varchar(255),@descripcion varchar(255))
AS
BEGIN
	DECLARE @diagnostico numeric(18,0)
	INSERT NEXTGDD.Diagnostico (fecha_diagnostico,descripcion,sintoma,enfermedad) values
			(@fechaAtencion,@descripcion,@sintoma,@enfermedad)
	SET @diagnostico=(select top 1 cod_diagnostico from NEXTGDD.Diagnostico order by cod_diagnostico DESC)
	UPDATE NEXTGDD.Consulta
			SET cod_diagnostico=@diagnostico
			WHERE nro_turno=(select distinct t.nro_turno 
							from NEXTGDD.Turno t,NEXTGDD.Agenda a,NEXTGDD.Profesional pr
							where t.fecha=@fechaConsulta and
								  t.cod_agenda=a.cod_agenda and
								  a.matricula=pr.matricula and pr.id_persona=@medico)
END;
GO

CREATE FUNCTION NEXTGDD.buscarAfiliadosAtendidos(@idMedico varchar(255),@fechaSistema datetime)
RETURNS TABLE
AS
	RETURN select (p.nombre+' '+p.apellido) as nombre 
			from NEXTGDD.Afiliado a,NEXTGDD.Persona p,NEXTGDD.Profesional pr,NEXTGDD.Turno t,NEXTGDD.Agenda ag 
			where p.id_persona=a.id_persona and t.nro_afiliado=a.nro_afiliado and t.cod_agenda=ag.cod_agenda 
				  and pr.matricula=ag.matricula and pr.id_persona LIKE @idMedico 
				  and CONVERT(date,t.fecha)=CONVERT(date,@fechaSistema)
			group by p.nombre,p.apellido 
GO

CREATE FUNCTION NEXTGDD.buscarConsultasAtendidas(@idMedico varchar(255),@fechaSistema datetime)
RETURNS TABLE
AS
	RETURN select t.fecha as consulta 
			from NEXTGDD.Profesional pr,NEXTGDD.Consulta c,NEXTGDD.Turno t,NEXTGDD.Agenda a 
			where pr.id_persona LIKE @idMedico and pr.matricula=a.matricula and c.nro_turno=t.nro_turno 
				  and t.cod_agenda=a.cod_agenda
				  --Se fija las consultas que no tienen diagnostico--
				  and isnull(c.cod_diagnostico,0)=0
				  --Filtra por fecha actual--
				  and CONVERT(date,t.fecha)=CONVERT(date,@fechaSistema)
GO

CREATE PROCEDURE NEXTGDD.registrarCompra (@cant numeric(18,0),@idAfiliado varchar(255),@precioTotal numeric(18,0), @compraFecha datetime)
AS
BEGIN
	INSERT NEXTGDD.Compra_Bono(cant,id_afiliado,precio_total, compra_fecha) values
			(@cant,@idAfiliado,@precioTotal, @compraFecha)
END;
GO

CREATE PROCEDURE NEXTGDD.comprarBono (@fechaImpresion datetime,@compraFecha dateTime,
			@codPlan numeric(18,0), @nroAfiliado numeric(18,0), @idCompra numeric (18,0))
AS
BEGIN
	INSERT NEXTGDD.Bono_Consulta(fecha_impresion, cod_plan, nro_afiliado, id_compra) values
			(@fechaImpresion,@codPlan, @nroAfiliado, @idCompra)
END;
GO

CREATE PROCEDURE NEXTGDD.cancelarTurno(@nroTurno numeric(18,0), @tipoCancelacion tinyInt, @motivo varchar(255)) 
AS BEGIN
IF EXISTS (SELECT * FROM NEXTGDD.Turno WHERE nro_turno = @nroTurno)
	INSERT NEXTGDD.Cancelacion(tipo_cancelacion, motivo) values
			(@tipoCancelacion,@motivo)
	UPDATE  NEXTGDD.Turno 
	SET cod_cancelacion = (select top 1 cod_cancelacion from NEXTGDD.Cancelacion order by 1 desc)
	WHERE Turno.nro_turno = @nroTurno
END
GO

CREATE PROCEDURE NEXTGDD.registrarCancelacionDePeriodo(@fechaDesde datetime, @fechaHasta datetime,
	 @codAgenda numeric (18,0))
	  
AS BEGIN
	INSERT NEXTGDD.Cancelacion_Por_Fecha(fecha_desde, fecha_hasta, cod_agenda) values
			(@fechaDesde,@fechaHasta,@codAgenda)
	END
GO

CREATE FUNCTION NEXTGDD.filtrarConsultasPorAfiliado(@idMedico varchar(255),@afiliado varchar(255),@fechaSistema datetime)
RETURNS TABLE
AS
	RETURN select t.fecha as consulta 
			from NEXTGDD.Profesional pr,NEXTGDD.Consulta c,NEXTGDD.Turno t,NEXTGDD.Agenda a,NEXTGDD.Afiliado af,NEXTGDD.Persona p 
			where pr.id_persona LIKE @idMedico and pr.matricula=a.matricula and c.nro_turno=t.nro_turno 
				  and t.cod_agenda=a.cod_agenda and t.nro_afiliado=af.nro_afiliado and af.id_persona=p.id_persona 
				  and (p.nombre+' '+p.apellido) LIKE @afiliado 
				  --Se fija las consultas que no tienen diagnostico--
				  and isnull(c.cod_diagnostico,0)=0
				  --Filtra por fecha actual--
				  and CONVERT(date,t.fecha)=CONVERT(date,@fechaSistema)
			group by t.fecha 
GO

CREATE FUNCTION NEXTGDD.buscarCodigoAgenda(@nomProfesional varchar(255),@nomEsp varchar(255))
returns numeric(18,0)
BEGIN
	RETURN (select a.cod_agenda
			from NEXTGDD.Agenda a,NEXTGDD.Profesional pr, NEXTGDD.Persona p,NEXTGDD.Especialidad e
			where p.nombre+' '+p.apellido LIKE @nomProfesional and p.id_persona=pr.id_persona and pr.matricula=a.matricula
				  and e.descripcion LIKE @nomEsp and e.cod_especialidad=a.cod_especialidad)
END;
GO

CREATE FUNCTION NEXTGDD.buscarCodigoRangoFecha(@codAgenda numeric (18,0),@fechaD datetime,@fechaH datetime)
returns numeric(18,0)
BEGIN
	RETURN (select distinct rf.cod_fecha
			from NEXTGDD.Rango_Fechas rf
			where rf.cod_agenda=@codAgenda and
				  CONVERT(date,rf.fecha_desde)=CONVERT(date,@fechaD) and
				  CONVERT(date,rf.fecha_hasta)=CONVERT(date,@fechaH))
END;
GO

--Si no existe crea una nueva agenda
CREATE PROCEDURE NEXTGDD.registrarAgenda (@nomProfesional varchar(255),@nomEspecialidad varchar(255),@fechaD datetime,@fechaH datetime)
AS
BEGIN
	UPDATE NEXTGDD.Profesional SET activo=1 where id_persona=(select p.id_persona from NEXTGDD.Persona p where p.nombre+' '+p.apellido LIKE @nomProfesional)
	DECLARE @codAgenda numeric(18,0)=(select NEXTGDD.buscarCodigoAgenda(@nomProfesional,@nomEspecialidad))
	IF isnull(@codAgenda,0)=0
	BEGIN
		INSERT NEXTGDD.Agenda(matricula,cod_especialidad) 
			(select pr.matricula,e.cod_especialidad
			 from NEXTGDD.Especialidad e,NEXTGDD.Profesional pr, NEXTGDD.Persona p 
			 where e.descripcion LIKE @nomEspecialidad and p.nombre+' '+p.apellido LIKE @nomProfesional and p.id_persona=pr.id_persona)
		INSERT NEXTGDD.Rango_Fechas (cod_agenda,cod_fecha,fecha_desde,fecha_hasta)
				values ((select NEXTGDD.buscarCodigoAgenda(@nomProfesional,@nomEspecialidad)),1,@fechaD,@fechaH)
	END
	ELSE
	BEGIN
		IF (select isnull(count(*),0)
			from NEXTGDD.Rango_Fechas rf
			where rf.cod_agenda=@codAgenda and CONVERT(date,rf.fecha_desde)=CONVERT(date,@fechaD) 
				and CONVERT(date,rf.fecha_hasta)=CONVERT(date,@fechaH))=0
		BEGIN
			INSERT NEXTGDD.Rango_Fechas (cod_agenda,cod_fecha,fecha_desde,fecha_hasta)
					values (@codAgenda,(select isnull(count(*),0)+1 from NEXTGDD.Rango_Fechas r2 where r2.cod_agenda=@codAgenda),@fechaD,@fechaH)
		END
	END
END;
GO

CREATE PROCEDURE NEXTGDD.registrarRangoHorario (@codAgenda numeric(18,0),@codFecha numeric(18,0),@diaD numeric(18,0),@diaH numeric(18,0),@horaD time,@horaH time)
AS
BEGIN
	DECLARE @cod_Rango numeric(18,0)=(select isnull(count(*),0) from NEXTGDD.Rango_Atencion where cod_agenda=@codAgenda)+1
	INSERT NEXTGDD.Rango_Atencion (rango_atencion,cod_fecha ,cod_agenda,hora_final,hora_inicial,dia_semanal_inicial,dia_semanal_final) values
			(@cod_rango,@codFecha,@codAgenda,@horaH,@horaD,@diaD,@diaH)
END;
GO

CREATE FUNCTION NEXTGDD.buscarEspecialidades(@profesional varchar(255))
RETURNS Table
AS
	RETURN (select e.descripcion as especialidad 
			from NEXTGDD.Persona persona,NEXTGDD.Profesional p,NEXTGDD.Profesional_X_Especialidad pe,NEXTGDD.Especialidad e 
			where (persona.nombre+' '+persona.apellido) LIKE @profesional and persona.id_persona=p.id_persona 
			  and pe.matricula=p.matricula and e.cod_especialidad=pe.cod_especialidad)
GO

CREATE FUNCTION NEXTGDD.verSuperposicionDeRangos(@fechaDesde1 datetime,@fechaHasta1 datetime,@fechaDesde2 datetime,@fechaHasta2 datetime)
returns int
BEGIN
	RETURN (CASE WHEN (@fechaHasta2>@fechaDesde1 and @fechaHasta2<@fechaHasta1) 
					  or (@fechaDesde2>@fechaDesde1 and @fechaDesde2<@fechaHasta1) 
					  or (@fechaDesde2<=@fechaDesde1 and @fechaHasta2>=@fechaHasta1) THEN 0
				 ELSE 1
				 END)
END;
GO

--Me dice si ya tiene una agenda para ese rango de fechas, y en ese caso devuelve las dos fechas de uno de los rangos con los que se superpone
CREATE FUNCTION NEXTGDD.validarAgendaUnica(@especialidad varchar(255),@profesional varchar(255),@fechaDesde datetime,@fechaHasta datetime) 
RETURNS varchar(255)
AS
BEGIN
	RETURN (select FORMAT((select top 1 rf.fecha_desde),'dd/MM/yyyy hh:mm:ss')+'|'+FORMAT((select top 1 rf.fecha_hasta),'dd/MM/yyyy hh:mm:ss')
		   from NEXTGDD.Agenda a,NEXTGDD.Profesional pr,NEXTGDD.Persona p,NEXTGDD.Especialidad e,NEXTGDD.Rango_Fechas rf 
		   where p.nombre+' '+p.apellido LIKE @profesional and p.id_persona=pr.id_persona and a.matricula=pr.matricula 
		         and a.cod_especialidad=e.cod_especialidad and e.descripcion LIKE @especialidad and rf.cod_agenda=a.cod_agenda
				 and (select NEXTGDD.verSuperposicionDeRangos(rf.fecha_desde,rf.fecha_hasta,@fechaDesde,@fechaHasta))=0
		   group by rf.fecha_desde,rf.fecha_hasta)
END;
GO

CREATE FUNCTION NEXTGDD.obtenerRangosHorarios(@cod_agenda numeric(18,0),@fechaDesde datetime,@fechaHasta datetime)
RETURNS TABLE
AS
	RETURN select ra.dia_semanal_inicial as 'DD',ra.dia_semanal_final as 'DH',ra.hora_inicial as 'HD',ra.hora_final as 'HH' 
			from NEXTGDD.Rango_Atencion ra,NEXTGDD.Rango_Fechas rf 
			where ra.cod_agenda=@cod_agenda and str(ra.cod_fecha)+str(ra.cod_agenda)=str(rf.cod_fecha)+str(rf.cod_agenda) and 
				  CONVERT(date, rf.fecha_desde) LIKE CONVERT(date,@fechaDesde) and 
				  CONVERT(date,rf.fecha_hasta) LIKE CONVERT(date,@fechaHasta)
GO

CREATE PROCEDURE NEXTGDD.agregar_funcionalidad(@rol varchar(255), @func varchar(255)) AS
BEGIN
	INSERT INTO NEXTGDD.Funcionalidad_X_Rol(id_rol,id_funcionalidad )
		VALUES ((SELECT id_rol FROM NEXTGDD.Rol WHERE nombre = @rol), (SELECT id_funcionalidad FROM NEXTGDD.Funcionalidad WHERE nombre = @func))
END
GO

CREATE PROCEDURE NEXTGDD.eliminar_Funcionalidad_Rol(@id_rol tinyint, @id_func tinyint, @ret smallint output) 
AS BEGIN
IF EXISTS (SELECT * FROM NEXTGDD.Funcionalidad_X_Rol WHERE id_rol= @id_rol and id_funcionalidad= @id_func )

   BEGIN TRY
	BEGIN TRANSACTION
			
	DELETE  NEXTGDD.Funcionalidad_X_Rol 
	WHERE id_rol= @id_rol and id_funcionalidad= @id_func
	SET @ret =0
	COMMIT TRANSACTION
    
  END TRY
  
  BEGIN CATCH
    ROLLBACK TRANSACTION
    -- No hago nada si hubo un error 
    SET @ret =-1
  END CATCH
END
GO

CREATE PROCEDURE NEXTGDD.agregar_Rol(@nombreRol varchar(255), @ret smallint output)
AS BEGIN

IF NOT EXISTS ( SELECT * FROM NEXTGDD.Rol WHERE nombre = @nombreRol)
	BEGIN
	INSERT INTO NEXTGDD.Rol (nombre) VALUES (@nombreRol)
	SET @ret = SCOPE_IDENTITY()
	END
ELSE 
  SET @ret = -1
END
GO

CREATE PROCEDURE NEXTGDD.modificar_Nombre_Rol(@id_rol tinyint,@nuevo_nombreRol varchar(255), @ret smallint output)
AS BEGIN

IF NOT EXISTS ( SELECT * FROM NEXTGDD.Rol WHERE nombre = @nuevo_nombreRol)
   BEGIN
	UPDATE  NEXTGDD.Rol 
	SET nombre = @nuevo_nombreRol
	WHERE id_rol= @id_rol
	END
ELSE 
  SET @ret = -1
END
GO


CREATE PROCEDURE NEXTGDD.darDeBajaRol(@id_rol tinyint, @ret smallint output)
AS BEGIN

IF EXISTS ( SELECT * FROM NEXTGDD.Rol WHERE id_rol= @id_rol)
   BEGIN TRY
	BEGIN TRANSACTION
			
	UPDATE  NEXTGDD.Rol 
	SET habilitado = 0
	WHERE id_rol= @id_rol
	

	DELETE NEXTGDD.Usuario_X_Rol
	WHERE id_rol =@id_rol

	COMMIT TRANSACTION
    SET @ret =0
  END TRY
  
  BEGIN CATCH
    ROLLBACK TRANSACTION
    -- No hago nada si hubo un error 
    SET @ret =-1
  END CATCH

END
GO

CREATE PROCEDURE NEXTGDD.agregar_usuario (@username VARCHAR(50), @password VARCHAR(255), @codigo_rol TINYINT, @habilitado BIT,  @id_persona INT) 
AS BEGIN

  BEGIN TRY
	BEGIN TRANSACTION
			
		INSERT INTO NEXTGDD.Usuario (username, password, habilitado, logins_fallidos)
		VALUES (@username, HASHBYTES('SHA2_256', @password), @habilitado, 0)


		INSERT INTO NEXTGDD.Usuario_X_Rol(id_rol, username)
		VALUES (@codigo_rol, @username)

	COMMIT TRANSACTION
    RETURN 0
  END TRY
  
  BEGIN CATCH
    ROLLBACK TRANSACTION
    -- No hago nada si hubo un error (el username está duplicado)
    RETURN -1
  END CATCH

END
GO


CREATE PROCEDURE NEXTGDD.agregarAfiliadoPrincipal(@nombre varchar(255), @apellido varchar(255), @fecha_nac datetime, @sexo char(1), @tipo_doc varchar(50),
                                               @nrodocumento numeric(18,0), @domicilio varchar(255), @telefono numeric(18,0), @estado_civil varchar(255),
                                               @mail varchar(255), @cant_familiares numeric(18,0), @cod_medico  varchar(255), @ret numeric(20,0) output)
AS BEGIN

DECLARE @pers numeric (18,0)
DECLARE @nro_afiliado numeric (20,0) 
DECLARE @usr VARCHAR(255)
DECLARE @TransactionName varchar (20)= 'Transaccion1'
DECLARE @plan_medico numeric (18,0)
DECLARE @est_civ tinyint

SET @plan_medico= (Select cod_plan FROM NEXTGDD.Plan_Medico WHERE descripcion=  @cod_medico )
SET @est_civ= (Select id FROM NEXTGDD.Estado_Civil WHERE nombre= @estado_civil )

 BEGIN TRY
	BEGIN TRANSACTION @TransactionName
			
		INSERT INTO NEXTGDD.Persona (nombre, apellido, nro_documento, fecha_nac, domicilio , telefono, mail, tipo_doc, sexo,estado_civil)
	                         VALUES (@nombre, @apellido, @nrodocumento, @fecha_nac, @domicilio, @telefono,@mail, @tipo_doc, @sexo, @est_civ )

SET @pers = SCOPE_IDENTITY()
SET @nro_afiliado =  cast (@pers as varchar)+ '01'

		 INSERT INTO NEXTGDD.Afiliado (nro_afiliado, cant_familiares, cod_plan, nro_consulta, activo, fecha_baja_logica, id_persona,grupo_afiliado,integrante_grupo )
	                VALUES ( @nro_afiliado, @cant_familiares , @plan_medico, 0 , 1, null, @pers, @pers, 01 ) 
	
     SET @usr = CONVERT(VARCHAR(255),@nro_afiliado)
	 DECLARE @pass varchar (100)
	 SET @pass = @usr


     	INSERT INTO NEXTGDD.Usuario (username, password, habilitado, logins_fallidos,id_persona)
		VALUES (@usr+'@NEXTGDD', HASHBYTES('SHA2_256', @pass), 1, 0, @pers)

		INSERT INTO NEXTGDD.Usuario_X_Rol(id_rol, username)
		VALUES (2, @usr+'@NEXTGDD')

	  SET @ret= @nro_afiliado
     
	  COMMIT TRANSACTION @TransactionName

 END TRY
 
      BEGIN CATCH

      SET @ret= -1
     		 
      ROLLBACK TRANSACTION @TransactionName
      END CATCH
END
GO


CREATE PROCEDURE NEXTGDD.agregarAfiliadoFamilia(@nombre varchar(255), @apellido varchar(255), @fecha_nac datetime, @sexo char(1), @tipo_doc varchar(50),
                                               @nrodocumento numeric(18,0), @domicilio varchar(255), @telefono numeric(18,0), @estado_civil varchar(255),
                                               @mail varchar(255), @cant_familiares numeric(18,0),@grupo_afiliado numeric(18,0), 
											   @nro_afiliado_integrante numeric(2,0),@ret numeric(20,0) output)
AS BEGIN

DECLARE @integrante_grupo numeric(2,0);
DECLARE @pers numeric (18,0)
DECLARE @cod_plan numeric (18,0)
DECLARE @nro_afiliado numeric (20,0) 
DECLARE @usr VARCHAR(255)
DECLARE @pass varchar (100)
DECLARE @TransactionName1 varchar (50)= 'Transaccion1'
DECLARE @est_civ tinyint


 BEGIN TRY
	BEGIN TRANSACTION @TransactionName1
			
     SET @est_civ= (Select id FROM NEXTGDD.Estado_Civil WHERE nombre= @estado_civil )

	 INSERT INTO NEXTGDD.Persona (nombre, apellido, nro_documento, fecha_nac, domicilio , telefono, mail, tipo_doc, sexo, estado_civil)
	                 VALUES (@nombre, @apellido, @nrodocumento, @fecha_nac, @domicilio, @telefono,@mail, @tipo_doc, @sexo, @est_civ)


SET @pers = SCOPE_IDENTITY()

SELECT  @cod_plan= cod_plan  FROM NEXTGDD.Afiliado WHERE grupo_afiliado=@grupo_afiliado and  integrante_grupo = 01

   IF @nro_afiliado_integrante = 1
         BEGIN
		   SET @nro_afiliado =  cast (@grupo_afiliado as varchar)+ '02'
		
		   INSERT INTO NEXTGDD.Afiliado (nro_afiliado, cant_familiares, cod_plan, nro_consulta, activo, fecha_baja_logica, id_persona,grupo_afiliado,integrante_grupo )
	                VALUES (@nro_afiliado, @cant_familiares , @cod_plan, 0 , 1, null, @pers, @grupo_afiliado, 02) 
	
       
          END  
	  ELSE BEGIN
		   
	     SET @integrante_grupo = (SELECT max(integrante_grupo) FROM NEXTGDD.Afiliado WHERE grupo_afiliado= @grupo_afiliado)
		   
		    IF   @integrante_grupo < 03  BEGIN
	            
		       SET @nro_afiliado =  cast (@grupo_afiliado as varchar)+ '03'
		       
			   INSERT INTO NEXTGDD.Afiliado (nro_afiliado, cant_familiares, cod_plan, nro_consulta, activo, fecha_baja_logica, id_persona,grupo_afiliado,integrante_grupo )
	           VALUES (@nro_afiliado, @cant_familiares , @cod_plan, 0 , 1, null, @pers, @grupo_afiliado, 03) 
	         END
	        
	        	ELSE IF  ((@integrante_grupo >= 03)  AND ( @integrante_grupo < 9) ) BEGIN
		        
		           SET @integrante_grupo = @integrante_grupo + 1 
		           SET @nro_afiliado =  cast (@grupo_afiliado as varchar)+'0' +cast (@integrante_grupo as varchar)

		           INSERT INTO NEXTGDD.Afiliado (nro_afiliado, cant_familiares, cod_plan, nro_consulta, activo, fecha_baja_logica, id_persona,grupo_afiliado,integrante_grupo )
	               VALUES (@nro_afiliado, @cant_familiares , @cod_plan, 0 , 1, null, @pers, @grupo_afiliado, @integrante_grupo) 
			    END

				   ELSE  BEGIN
		        
		            SET @integrante_grupo = @integrante_grupo + 1
		            SET @nro_afiliado =  cast (@grupo_afiliado as varchar)+ cast (@integrante_grupo as varchar)

		            INSERT INTO NEXTGDD.Afiliado (nro_afiliado, cant_familiares, cod_plan, nro_consulta, activo, fecha_baja_logica, id_persona,grupo_afiliado,integrante_grupo )
	                VALUES (@nro_afiliado, @cant_familiares , @cod_plan, 0 , 1, null, @pers, @grupo_afiliado, @integrante_grupo) 
			       END

		   END	
  SET @usr = CONVERT(VARCHAR(255),@nro_afiliado)
  SET @pass = @usr
   
  INSERT INTO NEXTGDD.Usuario (username, password, habilitado, logins_fallidos,id_persona)
  VALUES (@usr+'@NEXTGDD', HASHBYTES('SHA2_256', @pass), 1, 0, @pers)


  INSERT INTO NEXTGDD.Usuario_X_Rol(id_rol, username)
  VALUES (2, @usr+'@NEXTGDD')

  SET @ret= @nro_afiliado
     
  COMMIT TRANSACTION @TransactionName1
                	    
 END TRY
  
      BEGIN CATCH

      SET @ret= -1
     		 
      ROLLBACK TRANSACTION @TransactionName1
      END CATCH
END
GO

CREATE PROCEDURE NEXTGDD.mostrarHistorial(@nroafiliado numeric(20,0) )
AS
BEGIN

SELECT nro_historial,fecha_modificacion,motivo_modificacion, nro_afiliado, cod_plan_viejo, cod_plan_nuevo
FROM NEXTGDD.Historial
WHERE nro_afiliado IN (SELECT c.nro_afiliado FROM NEXTGDD.Afiliado c WHERE c.grupo_afiliado= (SELECT d.grupo_afiliado FROM Afiliado d WHERE d.nro_afiliado= @nroafiliado ))

END
GO

CREATE PROCEDURE NEXTGDD.mostrarHistorial_ga(@grupoafiliado numeric(20,0) )
AS
BEGIN

SELECT nro_historial,fecha_modificacion,motivo_modificacion, nro_afiliado, cod_plan_viejo, cod_plan_nuevo
FROM NEXTGDD.Historial
WHERE nro_afiliado IN (SELECT c.nro_afiliado FROM NEXTGDD.Afiliado c WHERE c.grupo_afiliado = @grupoafiliado)
END
GO

CREATE PROCEDURE NEXTGDD.mostrarHistorialAfil_grupo(@nroafiliado numeric(20,0) ,@grupoafiliado numeric(18,0) )
AS
BEGIN

SELECT nro_historial,fecha_modificacion,motivo_modificacion, nro_afiliado, cod_plan_viejo, cod_plan_nuevo
FROM NEXTGDD.Historial
WHERE nro_afiliado IN (SELECT c.nro_afiliado FROM NEXTGDD.Afiliado c WHERE c.grupo_afiliado = @grupoafiliado) 
and nro_afiliado =@nroafiliado
END
GO

CREATE PROCEDURE NEXTGDD.darDeBajaAfiliado(@nro_afiliado numeric(20,0), @fecha_baja datetime, @ret smallint OUTPUT)
AS BEGIN           

IF EXISTS (SELECT * FROM NEXTGDD.Afiliado WHERE nro_afiliado= @nro_afiliado)
   BEGIN
    BEGIN TRY
	  BEGIN TRANSACTION   
        
        DECLARE @fechaTurnos DATETIME 
		IF (1 = (SELECT activo FROM NEXTGDD.Afiliado WHERE nro_afiliado= @nro_afiliado))
		  BEGIN
		  UPDATE NEXTGDD.Afiliado 
	      SET  activo = 0, fecha_baja_logica = @fecha_baja
	      WHERE nro_afiliado = @nro_afiliado

		   SET @fechaTurnos = DATEADD(day, 1, @fecha_baja)
		 
		   DELETE FROM NEXTGDD.Turno
		    WHERE nro_afiliado = @nro_afiliado AND fecha >=  @fechaTurnos
	
          SET @ret= 0
		  END
        ELSE
		SET @ret = -3
	   COMMIT TRANSACTION
    END TRY
  
   BEGIN CATCH
    ROLLBACK TRANSACTION
    
      SET @ret= -1
  END CATCH
END
ELSE
SET @ret= -2
END
GO

/***************LISTADOS******************/

CREATE FUNCTION NEXTGDD.listado1(@anio numeric(18,0),@mesInicio numeric(18,0),@mesFin numeric(18,0),@tipoCanc varchar(255))
RETURNS TABLE
AS
	RETURN
		select top 5 e.descripcion as 'Especialidad', count(*) 'Cantidad cancelaciones'
		from NEXTGDD.Especialidad e,NEXTGDD.Turno t,NEXTGDD.Cancelacion c,NEXTGDD.Agenda a,NEXTGDD.Tipo_cancelacion tc
		where c.cod_cancelacion=t.cod_cancelacion and tc.nombre=@tipoCanc and tc.tipo_cancelacion=c.tipo_cancelacion
			  and t.cod_agenda=a.cod_agenda and a.cod_especialidad=e.cod_especialidad
			  and year(t.fecha)=@anio and MONTH(t.fecha)>=@mesInicio and MONTH(t.fecha)<=@mesFin
		group by e.descripcion
		order by count(*) DESC
GO

/*tipoCanc: Afiliado/Profesional */

CREATE FUNCTION NEXTGDD.listado1Ambos(@anio numeric(18,0),@mesInicio numeric(18,0),@mesFin numeric(18,0))
RETURNS TABLE
AS
	RETURN
		select top 5 e.descripcion as 'Especialidad', count(*) 'Cantidad cancelaciones'
		from NEXTGDD.Especialidad e,NEXTGDD.Turno t,NEXTGDD.Cancelacion c,NEXTGDD.Agenda a
		where c.cod_cancelacion=t.cod_cancelacion and t.cod_agenda=a.cod_agenda and a.cod_especialidad=e.cod_especialidad
			  and year(t.fecha)=@anio and MONTH(t.fecha)>=@mesInicio and MONTH(t.fecha)<=@mesFin
		group by e.descripcion
		order by count(*) DESC
GO


CREATE FUNCTION NEXTGDD.listado2(@anio numeric(18,0),@mesInicio numeric(18,0),@mesFin numeric(18,0),@plan varchar(255))
RETURNS TABLE
AS
	RETURN
		select top 5 (p.nombre+' '+p.apellido) as 'Profesional',e.descripcion as 'Especialidad',count(*) as 'Veces consultado'
		from NEXTGDD.Profesional pr,NEXTGDD.Consulta c,NEXTGDD.Agenda a,NEXTGDD.Turno t,NEXTGDD.Especialidad e,
		     NEXTGDD.Afiliado af,NEXTGDD.Plan_Medico pl,NEXTGDD.Persona p
		where c.nro_turno=t.nro_turno and t.cod_agenda=a.cod_agenda and a.matricula=pr.matricula 
		   	  and a.cod_especialidad=e.cod_especialidad and af.nro_afiliado=t.nro_afiliado
			  and af.cod_plan=pl.cod_plan and pl.descripcion=@plan and p.id_persona=pr.id_persona and
			  YEAR(t.fecha)=@anio and MONTH(t.fecha)>=@mesInicio and MONTH(t.fecha)<=@mesFin
		group by e.descripcion,p.nombre,p.apellido,pr.id_persona
		order by count(*) DESC
GO


CREATE FUNCTION NEXTGDD.listado3(@anio numeric(18,0),@mesInicio numeric(18,0),@mesFin numeric(18,0),@espec varchar(255))
RETURNS TABLE
AS
	RETURN
		select top 5 (p.nombre+' '+p.apellido) as 'Profesional',(isnull(count(*),0)*30)/60 as 'Horas trabajadas'
		from NEXTGDD.Profesional pr,NEXTGDD.Agenda a,NEXTGDD.Persona p,NEXTGDD.Turno t,NEXTGDD.Especialidad e,NEXTGDD.Consulta c
		where pr.id_persona=p.id_persona and pr.matricula=a.matricula and a.cod_especialidad=e.cod_especialidad
			  and e.descripcion=@espec and t.cod_agenda=a.cod_agenda and c.nro_turno=t.nro_turno
			  and YEAR(t.fecha)=@anio and MONTH(t.fecha)>=@mesInicio and MONTH(t.fecha)<=@mesFin
		group by p.nombre,p.apellido,pr.matricula
		order by 2 ASC;
GO

/*evalua segun la cantidad de consultas, no el rango horario*/

CREATE FUNCTION NEXTGDD.listado4(@anio numeric(18,0),@mesInicio numeric(18,0),@mesFin numeric(18,0))
RETURNS TABLE
AS
	RETURN
		select top 5 (p.nombre+' '+p.apellido) as 'Nombre Afiliado',sum(cb.cant) as 'Bonos Comprados',
					 (CASE WHEN(select isnull(count(*),0) from NEXTGDD.Afiliado a2
								where a2.grupo_afiliado=a.grupo_afiliado and a2.nro_afiliado<>a.nro_afiliado)=0
						   THEN 'No'
						   ELSE 'Si'
						   END) as 'Tiene familiares'
		from NEXTGDD.Afiliado a,NEXTGDD.Persona p,NEXTGDD.Compra_Bono cb
		where a.id_persona=p.id_persona and cb.id_afiliado=a.nro_afiliado 
			  and year(cb.compra_fecha)=@anio and month(cb.compra_fecha)>=@mesInicio and month(cb.compra_fecha)<=@mesFin
		group by p.nombre,p.apellido,a.nro_afiliado,a.grupo_afiliado
		order by 2 DESC; 
GO


CREATE FUNCTION NEXTGDD.listado5(@anio numeric(18,0),@mesInicio numeric(18,0),@mesFin numeric(18,0))
RETURNS TABLE
AS
	RETURN
		select top 5 e.descripcion as 'Especialidad',count(e.cod_especialidad) as 'Cantidad de Bonos'
		from NEXTGDD.Consulta c,NEXTGDD.Especialidad e,NEXTGDD.Turno t,NEXTGDD.Agenda a
		where c.nro_turno=t.nro_turno and t.cod_agenda=a.cod_agenda and a.cod_especialidad=e.cod_especialidad
			  and year(t.fecha)=@anio and month(t.fecha)>=@mesInicio and MONTH(t.fecha)<=@mesFin
		group by e.cod_especialidad,e.descripcion
		order by count(e.cod_especialidad) DESC
GO


/************************************/
/************ Migracion *************/


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

INSERT NEXTGDD.Rango_Atencion_Clinica (dia_inicial,dia_final,hora_inicial,hora_final) values
		(0,4,CONVERT(time,'07:00:00'),CONVERT(time,'20:00:00'))
INSERT NEXTGDD.Rango_Atencion_Clinica (dia_inicial,dia_final,hora_inicial,hora_final) values
		(5,5,CONVERT(time,'10:00:00'),CONVERT(time,'15:00:00'))

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


INSERT INTO NEXTGDD.Afiliado (nro_afiliado, id_persona, cod_plan, nro_consulta, grupo_afiliado, integrante_grupo, cant_familiares)
	SELECT cast(id_persona as varchar)  + '01',id_persona, Plan_Med_Codigo, count(distinct Bono_Consulta_Numero), id_persona, 01,0
	FROM NEXTGDD.Persona , gd_esquema.Maestra
	WHERE nro_documento = Paciente_Dni 
	group by id_persona, Plan_Med_Codigo, Paciente_Dni
	
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

EXEC NEXTGDD.agregar_Rol @nombreRol = 'Administrativo', @ret = 0 

EXEC NEXTGDD.agregar_Rol @nombreRol = 'Afiliado', @ret = 0

EXEC NEXTGDD.agregar_Rol @nombreRol = 'Profesional', @ret = 0

GO

INSERT INTO NEXTGDD.Funcionalidad (nombre)
	VALUES ('ABM de roles'),
	       ('ABM de afiliados'),
	       ('ABM de profesionales'),
		   ('ABM de usuarios'),
	       ('ABM de especialidades medicas'),
	       ('ABM de planes'),
		   ('Compra de bonos'),
	       ('Pedido de turno'),
	       ('Registrar agenda profesional'),		 
	       ('Registro de llegada para atencion medica'),
	       ('Registro de resultado para atencion medica'),	       
	       ('Cancelar atencion medica'),
	       ('Consultar listado estadistico')
GO

EXEC NEXTGDD.agregar_funcionalidad  @rol = 'Administrativo' , @func = 'ABM de roles';

EXEC NEXTGDD.agregar_funcionalidad  @rol = 'Administrativo' , @func = 'ABM de afiliados';

EXEC NEXTGDD.agregar_funcionalidad 	@rol = 'Administrativo', @func = 'ABM de profesionales';

EXEC NEXTGDD.agregar_funcionalidad 	@rol = 'Administrativo', @func = 'ABM de especialidades medicas';

EXEC NEXTGDD.agregar_funcionalidad 	@rol = 'Administrativo', @func = 'ABM de planes';

EXEC NEXTGDD.agregar_funcionalidad 	@rol = 'Administrativo', @func = 'ABM de usuarios';

EXEC NEXTGDD.agregar_funcionalidad 	@rol = 'Administrativo', @func = 'Registrar agenda profesional';

EXEC NEXTGDD.agregar_funcionalidad 	@rol = 'Administrativo', @func = 'Compra de bonos';	

EXEC NEXTGDD.agregar_funcionalidad 	@rol = 'Afiliado', @func = 'Compra de bonos';

EXEC NEXTGDD.agregar_funcionalidad 	@rol = 'Administrativo', @func = 'Pedido de turno';

EXEC NEXTGDD.agregar_funcionalidad 	@rol = 'Afiliado', @func = 'Pedido de turno';

EXEC NEXTGDD.agregar_funcionalidad 	@rol = 'Administrativo', @func = 'Registro de llegada para atencion medica';

EXEC NEXTGDD.agregar_funcionalidad 	@rol = 'Administrativo', @func = 'Registro de resultado para atencion medica';

EXEC NEXTGDD.agregar_funcionalidad 	@rol = 'Profesional', @func = 'Registro de resultado para atencion medica';

EXEC NEXTGDD.agregar_funcionalidad 	@rol = 'Administrativo', @func = 'Cancelar atencion medica';

EXEC NEXTGDD.agregar_funcionalidad	@rol = 'Afiliado', @func = 'Cancelar atencion medica';

EXEC NEXTGDD.agregar_funcionalidad	@rol = 'Profesional', @func = 'Cancelar atencion medica';

EXEC NEXTGDD.agregar_funcionalidad 	@rol = 'Administrativo', @func = 'Consultar listado estadistico';
	       
GO 

SET IDENTITY_INSERT NEXTGDD.Profesional OFF

GO

CREATE VIEW NEXTGDD.informacionCompraBonos
AS
	select distinct Paciente_Dni as 'dni',Bono_Consulta_Numero as 'bono',
			Bono_Consulta_Fecha_Impresion as 'fecha_impresion',Compra_Bono_Fecha as 'fecha_compra',
			Plan_Med_Codigo 'plan_codigo', Plan_Med_Precio_Bono_Consulta as 'precio'
	from gd_esquema.Maestra,NEXTGDD.Afiliado a,NEXTGDD.Persona p
	where not(Compra_Bono_Fecha IS NULL) and p.nombre+' '+p.apellido=Paciente_Nombre+' '+Paciente_Apellido and
		  p.id_persona=a.id_persona and not(Bono_Consulta_Fecha_Impresion IS NULL)
GO

INSERT NEXTGDD.Compra_Bono (cant,id_afiliado,precio_total,compra_fecha)
		(select count(*),a.nro_afiliado,precio*count(*),fecha_compra
		from NEXTGDD.informacionCompraBonos,NEXTGDD.Afiliado a
		where a.id_persona=dni 
		group by a.nro_afiliado,fecha_compra,precio)

GO

SET IDENTITY_INSERT NEXTGDD.Bono_Consulta ON

INSERT NEXTGDD.Bono_Consulta (nro_bono,nro_afiliado,fecha_impresion,cod_plan,id_compra)
		
		(select i.bono,a.nro_afiliado,
				i.fecha_impresion,i.plan_codigo,c.id_compra
		from NEXTGDD.informacionCompraBonos i,NEXTGDD.Compra_Bono c,NEXTGDD.Afiliado a
		where i.fecha_compra=c.compra_fecha and i.dni=a.id_persona and c.id_afiliado=a.nro_afiliado)

SET IDENTITY_INSERT NEXTGDD.Bono_Consulta OFF

GO

INSERT NEXTGDD.Agenda (matricula, cod_especialidad)
		(select matricula,cod_especialidad
		 from NEXTGDD.Profesional_X_Especialidad);
GO

SET IDENTITY_INSERT NEXTGDD.Turno ON

INSERT NEXTGDD.Turno (nro_turno,fecha,nro_afiliado,cod_agenda) 
	(  select Turno_Numero,  Turno_Fecha,  (select nro_afiliado from NEXTGDD.Afiliado WHERE id_persona= Paciente_Dni),
		(SELECT cod_agenda FROM NEXTGDD.Agenda where cod_especialidad= Especialidad_Codigo 
		and matricula = (Select matricula from NEXTGDD.Profesional where id_persona = Medico_Dni) )
		
		from gd_esquema.Maestra
		where Bono_Consulta_Fecha_Impresion is null and Compra_Bono_Fecha is  null )

GO

SET IDENTITY_INSERT NEXTGDD.Turno OFF

INSERT NEXTGDD.Rango_Fechas (cod_agenda,cod_fecha,fecha_desde,fecha_hasta)
    ( select a.cod_agenda,1,
			(select top 1 t.fecha
			 from NEXTGDD.Turno t
			 where t.cod_agenda=a.cod_agenda
			 order by t.fecha ASC),
			 (select top 1 t.fecha
			 from NEXTGDD.Turno t
			 where t.cod_agenda=a.cod_agenda
			 order by t.fecha DESC)
	  from NEXTGDD.Agenda a)

INSERT NEXTGDD.Rango_Atencion (cod_agenda,cod_fecha,rango_atencion,dia_semanal_inicial,dia_semanal_final,hora_inicial,hora_final)
		(select a.cod_agenda,1,
				(select isnull(count(distinct DATEPART(dw,t3.fecha)),0)
				 from NEXTGDD.Turno t3
				 where t3.cod_agenda=a.cod_agenda and 
					DATEPART(dw,t3.fecha) in
					(select DATEPART(dw,t2.fecha)
					from NEXTGDD.Turno t2
					where a.cod_agenda=t2.cod_agenda
					group by t2.cod_agenda,DATEPART(dw,t2.fecha)
					having DATEPART(dw,t.fecha)>=DATEPART(dw,t2.fecha))
				 group by t3.cod_agenda),
				DATEPART(dw,t.fecha)-1,DATEPART(dw,t.fecha)-1,
				(select top 1 CONVERT(time,t2.fecha)
				from NEXTGDD.Turno t2
				where t2.cod_agenda=a.cod_agenda and DATEPART(dw,t2.fecha)=DATEPART(dw,t.fecha)
				order by t2.fecha ASC),
				(select top 1 CONVERT(time,t2.fecha)
				from NEXTGDD.Turno t2
				where t2.cod_agenda=a.cod_agenda and DATEPART(dw,t2.fecha)=DATEPART(dw,t.fecha)
				order by t2.fecha DESC)
		 from NEXTGDD.Agenda a,NEXTGDD.Turno t
		 where a.cod_agenda=t.cod_agenda
		 group by DATEPART(dw,t.fecha),a.cod_agenda)

SET IDENTITY_INSERT NEXTGDD.Diagnostico ON


INSERT NEXTGDD.Diagnostico (cod_diagnostico,fecha_diagnostico, sintoma,enfermedad)
	   (select Bono_Consulta_Numero,Turno_Fecha, Consulta_Sintomas, Consulta_Enfermedades
		from gd_esquema.Maestra
		where Compra_Bono_Fecha is null and Bono_Consulta_Numero is not null );
GO

SET IDENTITY_INSERT NEXTGDD.Diagnostico OFF

SET IDENTITY_INSERT NEXTGDD.Profesional ON

INSERT NEXTGDD.Consulta (cod_diagnostico, fecha_consulta, nro_bono ,nro_turno)
	   (select Bono_Consulta_Numero,Turno_Fecha, Bono_Consulta_Numero, Turno_Numero
		from gd_esquema.Maestra
		where Compra_Bono_Fecha is null and Bono_Consulta_Numero is not null );
GO


/************************************/

/****** Inserto el usuario admin *****/

EXEC NEXTGDD.agregar_usuario @username = 'admin', @password = 'w23e',@codigo_rol= 1, @habilitado= 1, @id_persona = null
GO

EXEC NEXTGDD.agregar_usuario @username = 'afiliado', @password = 'w23e',@codigo_rol= 2, @habilitado= 1, @id_persona = 1123960
GO

EXEC NEXTGDD.agregar_usuario @username = 'profesional', @password = 'w23e',@codigo_rol= 3, @habilitado= 1, @id_persona = 3116603
GO
