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

	/*me tira error por fk, tendriamos que agregar la constraint despues de crear las tablas,
	por ahora lo anulo, despues lo agrego.

	nro_afiliado numeric(18,0) default null REFERENCES NEXTGDD.Afiliado(nro_afiliado),
	nro_matricula numeric(18,0) default null REFERENCES NEXTGDD.Profesional(matricula),
	id_administrador numeric(18,0) default null REFERENCES NEXTGDD.Profesional(matricula),
	*/

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

CREATE TABLE NEXTGDD.Administrativo (
    
	id_administrativo int PRIMARY KEY IDENTITY,
	id_persona numeric (18,0) REFERENCES NEXTGDD.Persona(id_persona)
	)

CREATE TABLE NEXTGDD.Profesional (
--SACAR EL IDENTITY SOLO CUANDO SE TERMINE LA MIGRACION    
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
--SACAR EL IDENTITY SOLO CUANDO SE TERMINE LA MIGRACION
	nro_afiliado numeric (20,0) PRIMARY KEY , 
	cant_familiares tinyint,
	cod_plan numeric(18,0) REFERENCES NextGDD.Plan_Medico(cod_plan),
    nro_consulta int,
	activo bit DEFAULT 1,
	fecha_baja_logica datetime DEFAULT NULL,
	id_persona numeric (18,0) REFERENCES NEXTGDD.Persona(id_persona),
	grupo_afiliado numeric (18,0) ,        --numero raiz de afiliado 
	integrante_grupo numeric (2,0)         --01:principal, 02: conyuge, 03:hijo
	)
	 
CREATE TABLE NEXTGDD.Compra_Bono (
	id_compra int PRIMARY KEY IDENTITY (1000,1), 
	cant smallint,
	id_afiliado numeric(20,0) REFERENCES NextGDD.Afiliado,
	precio_total int 
	)

CREATE TABLE NEXTGDD.Bono_Consulta (

    nro_bono numeric (18,0) IDENTITY(1,1) PRIMARY KEY,
    fecha_impresion datetime,
    compra_fecha datetime, 
    cod_plan numeric (18,0) REFERENCES NextGDD.Plan_Medico(cod_plan), 
	nro_afiliado numeric (20,0) REFERENCES NextGDD.Afiliado(nro_afiliado) 
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
   rango_fecha_desde datetime,
   rango_fecha_hasta datetime,
   matricula numeric (18,0) NOT NULL,
   cod_especialidad numeric (18,0) NOT NULL,
   FOREIGN KEY (matricula, cod_especialidad) REFERENCES NextGDD.Profesional_X_Especialidad(matricula, cod_especialidad)
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

   nro_historial numeric (18,0) PRIMARY KEY,
   fecha_modificacion datetime,
   motivo_modificacion varchar (255),
   nro_afiliado numeric (20,0) REFERENCES NextGDD.afiliado(nro_afiliado),
   cod_plan_viejo numeric (18,0) REFERENCES NextGDD.Plan_Medico(cod_plan),
    cod_plan_nuevo numeric (18,0) REFERENCES NextGDD.Plan_Medico(cod_plan)  
   )

CREATE TABLE NEXTGDD.Rango_Atencion (

   cod_agenda numeric (18,0) REFERENCES NextGDD.Agenda(cod_agenda),
   rango_atencion numeric (18,0) ,
   hora_inicial time,
   hora_final time,
   dia_semanal_inicial numeric(8,0), 
   dia_semanal_final numeric(8,0),
   PRIMARY KEY (cod_agenda, rango_atencion) 
   )
GO

/***************Validacion de Procedure, Function,Triggers*********************/
/****las validaciones nos permite ejecutar todo el script,una vez ya ejecutado por primera vez****/

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

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.modificar_Afiliado_Domic'))
    DROP PROCEDURE NEXTGDD.modificar_Afiliado_Domic
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.modificar_Afiliado_Telef'))
    DROP PROCEDURE NEXTGDD.modificar_Afiliado_Telef
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.darDeBajaRol'))
    DROP PROCEDURE NEXTGDD.darDeBajaRol
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.modificar_Afiliado_Mail'))
    DROP PROCEDURE NEXTGDD.modificar_Afiliado_Mail
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.modificar_Afiliado_Plan'))
    DROP PROCEDURE NEXTGDD.modificar_Afiliado_Plan
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

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.darDeBajaAfiliado'))
    DROP PROCEDURE NEXTGDD.darDeBajaAfiliado
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.obtenerRangoHorario'))
    DROP FUNCTION NEXTGDD.obtenerRangoHorario
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.obtenerRangoClinica'))
    DROP FUNCTION NEXTGDD.obtenerRangoClinica
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.buscarCodigoAgenda'))
    DROP FUNCTION NEXTGDD.buscarCodigoAgenda
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.registrarConsulta'))
    DROP PROCEDURE NEXTGDD.registrarConsulta
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.registrarDiagnostico'))
    DROP PROCEDURE NEXTGDD.registrarDiagnostico
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.registrarAgenda'))
    DROP PROCEDURE NEXTGDD.registrarAgenda
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.registrarRangoHorario'))
    DROP PROCEDURE NEXTGDD.registrarRangoHorario
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Pacientes'))
    DROP VIEW NEXTGDD.Pacientes
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'NEXTGDD.Medicos'))
    DROP VIEW NEXTGDD.Medicos	
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
 
 /*Es de suponer que un afiliado a lo largo de su historia puede sufrir modificaciones
en alguno de sus datos, como ser su direcci�n, tel�fono, mail, plan m�dico, etc (no as�
su nombre, apellido, dni y fecha de nacimiento). Si fuese necesario modificar el plan del
afiliado, es necesario que se registre cuando se ha producido dicha modificaci�n y el
motivo que la origin�, de manera de poder obtener un historial de dichos cambios.
Dicho historial debe poder ser consultado de alguna manera dentro del sistema.*/

 CREATE PROCEDURE NEXTGDD.modificar_Afiliado_Domic(@id numeric(20,0), @nuevo_dom varchar(255))
  AS BEGIN
  
DECLARE @pers numeric (18,0)

 IF EXISTS( SELECT * FROM NEXTGDD.Afiliado WHERE nro_afiliado = @id)
    BEGIN TRY
	  BEGIN TRANSACTION   
         	SET @pers = (SELECT id_persona FROM NEXTGDD.Afiliado WHERE nro_afiliado = @id )

            UPDATE NEXTGDD.Persona
            SET  domicilio = @nuevo_dom
            WHERE  id_persona= @pers
           

	COMMIT TRANSACTION
    RETURN 0
  END TRY
  
  BEGIN CATCH
    ROLLBACK TRANSACTION
    
    RETURN -1
  END CATCH

ELSE
  RETURN -2

END
GO

 
 CREATE PROCEDURE NEXTGDD.modificar_Afiliado_Telef(@id numeric(20,0), @nuevo_telef numeric(18,0))
 AS BEGIN
  
DECLARE @pers numeric (18,0)

 IF EXISTS( SELECT * FROM NEXTGDD.Afiliado WHERE nro_afiliado = @id)
    BEGIN TRY
	  BEGIN TRANSACTION   
         	SET @pers = (SELECT id_persona FROM NEXTGDD.Afiliado WHERE nro_afiliado = @id )

            UPDATE NEXTGDD.Persona
            SET  telefono = @nuevo_telef
            WHERE  id_persona= @pers
           

	COMMIT TRANSACTION
    RETURN 0
  END TRY
  
  BEGIN CATCH
    ROLLBACK TRANSACTION
    
    RETURN -1
  END CATCH

ELSE
  RETURN -2

END
GO


 CREATE PROCEDURE NEXTGDD.modificar_Afiliado_Mail(@id numeric(20,0), @nuevo_mail varchar(255))
 AS BEGIN
  
DECLARE @pers numeric (18,0)

 IF EXISTS( SELECT * FROM NEXTGDD.Afiliado WHERE nro_afiliado = @id)
    BEGIN TRY
	  BEGIN TRANSACTION   
         	SET @pers = (SELECT id_persona FROM NEXTGDD.Afiliado WHERE nro_afiliado = @id )

            UPDATE NEXTGDD.Persona
            SET  mail = @nuevo_mail
            WHERE  id_persona= @pers
           

	COMMIT TRANSACTION
    RETURN 0
  END TRY
  
  BEGIN CATCH
    ROLLBACK TRANSACTION 
    RETURN -1
   END CATCH

 ELSE
    RETURN -2
	
END
GO


CREATE PROCEDURE NEXTGDD.modificar_Afiliado_Plan(@id numeric(20,0), @nuevo_plan numeric (18,0),@motivo varchar (255))
 AS BEGIN
  
DECLARE @plan_viejo numeric (18,0)

 IF EXISTS( SELECT * FROM NEXTGDD.Afiliado WHERE nro_afiliado = @id)
    BEGIN TRY
	  BEGIN TRANSACTION   
	        SET @plan_viejo = (SELECT cod_plan FROM NEXTGDD.Afiliado WHERE nro_afiliado = @id )
           
		    UPDATE NEXTGDD.Afiliado
            SET  cod_plan = @nuevo_plan
            WHERE  nro_afiliado= @id
           
		   INSERT INTO NEXTGDD.Historial (fecha_modificacion, motivo_modificacion, nro_afiliado, cod_plan_viejo,cod_plan_nuevo)
		   VALUES (GETDATE(),@motivo,@id,@plan_viejo,@nuevo_plan)

	COMMIT TRANSACTION
    RETURN 0
  END TRY
  
  BEGIN CATCH
    ROLLBACK TRANSACTION 
    RETURN -1
   END CATCH

 ELSE
    RETURN -2
	
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
		  --PRINT 'CONTRASENA INCORRECTA'	   
			--Agrego un login fallido
            UPDATE NEXTGDD.Usuario
            SET logins_fallidos = logins_fallidos + 1
            WHERE username = @user
    
	        --si ya tiene 3 logins fallidos dar de baja al usuario
    
	       UPDATE NEXTGDD.Usuario
           SET habilitado = 0
           WHERE username = @user
           AND logins_fallidos = 3
		   
		   SET @ret = -2
		   
		   END
        END

   ELSE
	    --PRINT 'NO EXISTE EL USUARIO o EL USUARIO ESTA INHABILITADO'
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

CREATE FUNCTION NEXTGDD.obtenerRangoHorario(@fecha datetime,@profesional varchar(255),@especialidad varchar(255),@dia numeric(18,0),@hora time) 
RETURNS TABLE
AS
	RETURN (select isnull(count(*),0) as 'cantidad rangos'
		   from NEXTGDD.Profesional pr,NEXTGDD.Persona p,NEXTGDD.Especialidad e,NEXTGDD.Agenda a,NEXTGDD.Rango_Atencion r
	       where p.nombre+' '+p.apellido LIKE @profesional and e.descripcion LIKE @especialidad and pr.id_persona=p.id_persona
			     and a.matricula=pr.matricula and e.cod_especialidad=a.cod_especialidad and r.cod_agenda=a.cod_agenda
				 and @fecha>=a.rango_fecha_desde and @fecha<=a.rango_fecha_hasta 
			     and r.dia_semanal_inicial<=@dia and r.dia_semanal_final>=@dia and r.hora_inicial<=@hora and r.hora_final>=@hora)
GO
 
CREATE FUNCTION NEXTGDD.obtenerRangoClinica(@diaSemana numeric(18,0)) 
RETURNS TABLE
AS
	RETURN select hora_inicial,hora_final from NEXTGDD.Rango_Atencion_Clinica where @diaSemana>=dia_inicial and @diaSemana<=dia_final;
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

CREATE PROCEDURE NEXTGDD.registrarAgenda (@nomProfesional varchar(255),@nomEspecialidad varchar(255),@fechaD datetime,@fechaH datetime)
AS
BEGIN
	DECLARE @cod_esp numeric(18,0)=(select cod_especialidad from NEXTGDD.Especialidad where descripcion LIKE @nomEspecialidad)
	DECLARE @matricula numeric(18,0)=(select pr.matricula from NEXTGDD.Profesional pr, NEXTGDD.Persona p where p.nombre+' '+p.apellido LIKE @nomProfesional and p.id_persona=pr.id_persona)
	INSERT NEXTGDD.Agenda(rango_fecha_desde,rango_fecha_hasta,matricula,cod_especialidad) values
			(@fechaD,@fechaH,@matricula,@cod_esp)
END;
GO

CREATE PROCEDURE NEXTGDD.registrarRangoHorario (@cod_rango numeric(18,0),@codAgenda numeric(18,0),@diaD numeric(18,0),@diaH numeric(18,0),@horaD time,@horaH time)
AS
BEGIN
	INSERT NEXTGDD.Rango_Atencion (rango_atencion,cod_agenda,hora_final,hora_inicial,dia_semanal_inicial,dia_semanal_final) values
			(@cod_rango,@codAgenda,@horaD,@horaH,@diaD,@diaH)
END;
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
  /* Intenta crear un usuario con los datos especificados Para eso debe crear una entrada en la tabla Usuario y una en la table Usuario_X_Rol
     Si alguna de las dos inserciones falla, todo se vuelve para atras Devuelve el codigo del nuevo usuario o -1 en caso de error */
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
    -- No hago nada si hubo un error (el username est� duplicado)
    RETURN -1
  END CATCH

END
GO


CREATE PROCEDURE NEXTGDD.agregarAfiliadoPrincipal(@nombre varchar(255), @apellido varchar(255), @fecha_nac datetime, @sexo char(1), @tipo_doc varchar(50),
                                               @nrodocumento numeric(18,0), @domicilio varchar(255), @telefono numeric(18,0), @estado_civil numeric(18,0),
                                               @mail varchar(255), @cant_familiares numeric(18,0), @cod_medico numeric(18,0), @ret numeric(20,0) output)
AS BEGIN

DECLARE @pers numeric (18,0)
DECLARE @nro_afiliado numeric (20,0) 
DECLARE @usr VARCHAR(255)
DECLARE @TransactionName varchar (20)= 'Transaccion1'

 BEGIN TRY
	BEGIN TRANSACTION @TransactionName
			
		INSERT INTO NEXTGDD.Persona (nombre, apellido, nro_documento, fecha_nac, domicilio , telefono, mail, tipo_doc, sexo)
	                         VALUES (@nombre, @apellido, @nrodocumento, @fecha_nac, @domicilio, @telefono,@mail, @tipo_doc, @sexo)

SET @pers = SCOPE_IDENTITY()
SET @nro_afiliado =  cast (@pers as varchar)+ '01'

		 INSERT INTO NEXTGDD.Afiliado (nro_afiliado, cant_familiares, cod_plan, nro_consulta, activo, fecha_baja_logica, id_persona,grupo_afiliado,integrante_grupo )
	                VALUES ( @nro_afiliado, @cant_familiares , @cod_medico, 0 , 1, null, @pers, @pers, 01 ) 
	
     SET @usr = CONVERT(VARCHAR(255),@nrodocumento)
	 DECLARE @pass varchar (100)
	 SET @pass = CONVERT(VARCHAR(100),@nro_afiliado)

--utilizamos el numero de documento como el username y el nro de afiliado como la contrasena 

     	INSERT INTO NEXTGDD.Usuario (username, password, habilitado, logins_fallidos)
		VALUES (@usr, HASHBYTES('SHA2_256', @pass), 1, 0)


		INSERT INTO NEXTGDD.Usuario_X_Rol(id_rol, username)
		VALUES (2, @usr)

	  SET @ret= @nro_afiliado
     
	  COMMIT TRANSACTION @TransactionName

 END TRY
  
      BEGIN CATCH
         -- No hago nada si hubo un error ( duplicado)
      SET @ret= -1
     		 
      ROLLBACK TRANSACTION @TransactionName
      END CATCH
END
GO


CREATE PROCEDURE NEXTGDD.agregarAfiliadoFamilia(@nombre varchar(255), @apellido varchar(255), @fecha_nac datetime, @sexo char(1), @tipo_doc varchar(50),
                                               @nrodocumento numeric(18,0), @domicilio varchar(255), @telefono numeric(18,0), @estado_civil numeric(18,0),
                                               @mail varchar(255), @cant_familiares numeric(18,0),@nro_afiliado_princ numeric(18,0), 
											   @nro_afiliado_integrante numeric(2,0),@ret numeric(20,0) output)
AS BEGIN

DECLARE @integrante_grupo numeric(2,0);
DECLARE @pers numeric (18,0)
DECLARE @cod_plan numeric (18,0)
DECLARE @nro_afiliado numeric (20,0) 
DECLARE @usr VARCHAR(255)
DECLARE @grupo_afiliado numeric (18,0)
DECLARE @pass varchar (100)
DECLARE @TransactionName varchar (50)= 'Transaccion1'
 BEGIN TRY
	BEGIN TRANSACTION
			
		INSERT INTO NEXTGDD.Persona (nombre, apellido, nro_documento, fecha_nac, domicilio , telefono, mail, tipo_doc, sexo)
	                         VALUES (@nombre, @apellido, @nrodocumento, @fecha_nac, @domicilio, @telefono,@mail, @tipo_doc, @sexo)


SET @pers = SCOPE_IDENTITY()

SELECT @grupo_afiliado = grupo_afiliado, @cod_plan= cod_plan  FROM NEXTGDD.Afiliado WHERE nro_afiliado= @nro_afiliado_princ

 --select * from NEXTGDD.Afiliado 
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
  SET @usr = CONVERT(VARCHAR(255),@nrodocumento)
  SET @pass = CONVERT(VARCHAR(255),@nro_afiliado)
--utilizamos el numero de documento como el username y el nro de afiliado como la contrasena 

  INSERT INTO NEXTGDD.Usuario (username, password, habilitado, logins_fallidos)
  VALUES (@usr, HASHBYTES('SHA2_256', @pass), 1, 0)


  INSERT INTO NEXTGDD.Usuario_X_Rol(id_rol, username)
  VALUES (2, @usr)

  SET @ret= @nro_afiliado
     
  COMMIT TRANSACTION @TransactionName
                	    
 END TRY
  
      BEGIN CATCH
         -- No hago nada si hubo un error ( duplicado)
      SET @ret= -1
     		 
      ROLLBACK TRANSACTION @TransactionName
      END CATCH
END
GO

--en base a un numero de afiliado muestra todo el historial del grupo familiar 
--ver la pantalla
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


CREATE PROCEDURE NEXTGDD.darDeBajaAfiliado(@nro_afiliado numeric(20,0), @fecha_baja datetime)
AS BEGIN

    BEGIN TRY
	  BEGIN TRANSACTION   
          UPDATE NEXTGDD.Afiliado 
	      SET  activo = 0, fecha_baja_logica = @fecha_baja
	      WHERE nro_afiliado = @nro_afiliado
              
	  COMMIT TRANSACTION
      RETURN 0
    END TRY
  
   BEGIN CATCH
    ROLLBACK TRANSACTION
    
    RETURN -1
  END CATCH

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

/*
DROP FUNCTION NEXTGDD.listado1
GO

DROP FUNCTION NEXTGDD.listado1Ambos
GO
*/

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

/*
DROP FUNCTION NEXTGDD.listado2
GO
*/

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
/*
DROP FUNCTION NEXTGDD.listado3
GO
*/

CREATE FUNCTION NEXTGDD.listado4(@anio numeric(18,0),@mesInicio numeric(18,0),@mesFin numeric(18,0))
RETURNS TABLE
AS
	RETURN
		select top 5 (p.nombre+' '+p.apellido) as 'Nombre Afiliado',count(*) as 'Bonos Comprados',
					 (CASE WHEN(select isnull(count(*),0) from NEXTGDD.Afiliado a2
								where a2.grupo_afiliado=a.grupo_afiliado and a2.nro_afiliado<>a.nro_afiliado)=0
						   THEN 'No'
						   ELSE 'Si'
						   END) as 'Pertenece a Grupo Familiar'
		from NEXTGDD.Afiliado a,NEXTGDD.Persona p,NEXTGDD.Bono_Consulta bc
		where a.id_persona=p.id_persona and bc.nro_afiliado=a.nro_afiliado 
			  and year(bc.compra_fecha)=@anio and month(bc.compra_fecha)>=@mesInicio and month(bc.compra_fecha)<=@mesFin
		group by p.nombre,p.apellido,a.nro_afiliado,a.grupo_afiliado
		order by 2 DESC; 
GO

/*
DROP FUNCTION NEXTGDD.listado4
GO
*/

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

/*
DROP FUNCTION NEXTGDD.listado5
GO
*/

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

SET IDENTITY_INSERT NEXTGDD.Bono_Consulta ON

INSERT NEXTGDD.Bono_Consulta (nro_bono,nro_afiliado,fecha_impresion,compra_fecha,cod_plan)
		
		(select Bono_Consulta_Numero,(select nro_afiliado from NEXTGDD.Afiliado WHERE id_persona= Paciente_Dni), Bono_Consulta_Fecha_Impresion, Compra_Bono_Fecha, Plan_Med_Codigo 
		from gd_esquema.Maestra 
		where Bono_Consulta_Fecha_Impresion is not null and Compra_Bono_Fecha is not null)

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

EXEC NEXTGDD.agregar_usuario @username = 'profesional', @password = 'w23e',@codigo_rol= 3, @habilitado= 0, @id_persona = 3116603
GO

--select * from NEXTGDD.Turno t,NEXTGDD.Profesional pr,NEXTGDD.Agenda a,NEXTGDD.Persona p,ne
--where t.cod_agenda=a.cod_agenda and a.matricula=pr.matricula and p.id_persona=pr.id_persona
--order by t.fecha DESC