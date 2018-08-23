USE [master]
GO
/****** Object:  Database [ProyectoAna]    Script Date: 8/23/2018 12:46:50 AM ******/
CREATE DATABASE [ProyectoAna]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProyectoAna', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ProyectoAna.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ProyectoAna_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ProyectoAna_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ProyectoAna] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProyectoAna].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProyectoAna] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProyectoAna] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProyectoAna] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProyectoAna] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProyectoAna] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProyectoAna] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProyectoAna] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProyectoAna] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProyectoAna] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProyectoAna] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProyectoAna] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProyectoAna] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProyectoAna] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProyectoAna] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProyectoAna] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProyectoAna] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProyectoAna] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProyectoAna] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProyectoAna] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProyectoAna] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProyectoAna] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProyectoAna] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProyectoAna] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProyectoAna] SET  MULTI_USER 
GO
ALTER DATABASE [ProyectoAna] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProyectoAna] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProyectoAna] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProyectoAna] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ProyectoAna] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ProyectoAna]
GO
/****** Object:  Table [dbo].[Ciclo]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ciclo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Encargado]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Encargado](
	[Identificacion] [varchar](50) NOT NULL,
	[NombreCompleto] [varchar](100) NULL,
	[CorreoElectronico] [varchar](100) NULL,
	[Ocupacion] [varchar](100) NULL,
	[Parentesco] [varchar](50) NULL,
 CONSTRAINT [PK_Encargado] PRIMARY KEY CLUSTERED 
(
	[Identificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EntrevistaEncargado]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EntrevistaEncargado](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Recomendaciones] [varchar](500) NULL,
	[ConvocadoPorEncargado] [bit] NULL,
	[ConvocadoPorInstitucion] [bit] NULL,
	[FechaCreacion] [datetime] NULL DEFAULT (getdate()),
	[IdMotivo] [int] NULL,
	[Situacion] [varchar](500) NULL,
	[Acciones] [varchar](500) NULL,
	[Intervencion] [varchar](500) NULL,
	[IdExpediente] [int] NULL,
	[TipoInstrumento] [varchar](50) NULL,
 CONSTRAINT [PK_EntEncargado] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EntrevistaEncargado_Archivos]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EntrevistaEncargado_Archivos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdEntrevista] [int] NOT NULL,
	[Archivo] [varbinary](1) NULL,
	[Nombre] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EntrevistaEstudiante]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EntrevistaEstudiante](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Recomendaciones] [varchar](500) NULL,
	[DetecciondelProfesional] [bit] NULL,
	[Referencia] [bit] NULL,
	[Solicitud] [bit] NULL,
	[Otros] [bit] NULL,
	[OtrosExplicacion] [varchar](500) NULL,
	[FechaCreacion] [datetime] NULL CONSTRAINT [DF_EntrevistaEstudiante_FechaCreacion]  DEFAULT (getdate()),
	[IdMotivo] [int] NULL,
	[Situacion] [varchar](500) NULL,
	[Acciones] [varchar](500) NULL,
	[Intervencion] [varchar](500) NULL,
	[IdExpediente] [int] NULL,
	[TipoInstrumento] [varchar](50) NULL,
 CONSTRAINT [PK_EntEstudiante] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EntrevistaEstudiante_Archivos]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EntrevistaEstudiante_Archivos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdEntrevista] [int] NOT NULL,
	[Archivo] [varbinary](1) NULL,
	[Nombre] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EntrevistaFuncionario]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EntrevistaFuncionario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Recomendaciones] [varchar](500) NULL,
	[NombreFuncionario] [varchar](500) NULL,
	[Puesto] [varchar](500) NULL,
	[FechaCreacion] [datetime] NULL DEFAULT (getdate()),
	[IdMotivo] [int] NULL,
	[Situacion] [varchar](500) NULL,
	[Acciones] [varchar](500) NULL,
	[Intervencion] [varchar](500) NULL,
	[IdExpediente] [int] NULL,
	[TipoInstrumento] [varchar](50) NULL,
 CONSTRAINT [PK_EntFuncionario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EntrevistaFuncionario_Archivos]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EntrevistaFuncionario_Archivos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdEntrevista] [int] NOT NULL,
	[Archivo] [varbinary](1) NULL,
	[Nombre] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Estudiante]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estudiante](
	[Identificacion] [varchar](50) NOT NULL,
	[NombreCompleto] [varchar](100) NULL,
	[IdSeccion] [int] NULL,
	[Sexo] [varchar](10) NULL,
	[FechaNacimiento] [datetime] NULL,
	[Direccion] [varchar](100) NULL,
	[Foto] [varbinary](1) NULL,
	[IdEncargado] [varchar](100) NOT NULL,
	[IdExpediente] [int] NULL,
 CONSTRAINT [PK_Estudiante] PRIMARY KEY CLUSTERED 
(
	[Identificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Expediente]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Expediente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdEstudiante] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ENTEXPEDIENTE] PRIMARY KEY CLUSTERED 
(
	[IdEstudiante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[InformeVisitaAlHogar]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[InformeVisitaAlHogar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Recomendaciones] [varchar](500) NULL,
	[NombreFuncionario] [varchar](500) NULL,
	[Puesto] [varchar](500) NULL,
	[FechaCreacion] [datetime] NULL DEFAULT (getdate()),
	[IdMotivo] [int] NULL,
	[Situacion] [varchar](500) NULL,
	[Acciones] [varchar](500) NULL,
	[Intervencion] [varchar](500) NULL,
	[IdExpediente] [int] NULL
) ON [PRIMARY]
SET ANSI_PADDING ON
ALTER TABLE [dbo].[InformeVisitaAlHogar] ADD [TipoInstrumento] [varchar](50) NULL

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[InformeVisitaAlHogar_Archivos]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[InformeVisitaAlHogar_Archivos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdEntrevista] [int] NOT NULL,
	[Archivo] [varbinary](1) NULL,
	[Nombre] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Instrumentos]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Instrumentos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FechaCreacion] [datetime] NULL,
	[IdEstudiante] [varchar](50) NULL,
	[IdEncargado] [varchar](50) NULL,
 CONSTRAINT [PK_Instrumentos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MotivoAtencion]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MotivoAtencion](
	[NumeroMotivo] [int] NOT NULL,
	[Descripcion] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_MotivoAtencion] PRIMARY KEY CLUSTERED 
(
	[NumeroMotivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nivel]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Nivel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreNivel] [varchar](100) NULL,
	[Ciclo] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Periodos]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Periodos](
	[Codigo] [int] NOT NULL,
	[Nombre] [varchar](100) NULL,
	[FechaInicio] [datetime] NULL,
	[FechaFinal] [datetime] NULL,
 CONSTRAINT [PK_Periodos] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Provincia](
	[Provincia] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Provincia] PRIMARY KEY CLUSTERED 
(
	[Provincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Referencia_Archivos]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Referencia_Archivos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdEntrevista] [int] NOT NULL,
	[Archivo] [varbinary](1) NULL,
	[Nombre] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ReferenciaExterna]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ReferenciaExterna](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Recomendaciones] [varchar](500) NULL,
	[PersonaRefiere] [varchar](500) NULL,
	[Puesto] [varchar](500) NULL,
	[FechaCreacion] [datetime] NULL DEFAULT (getdate()),
	[IdMotivo] [int] NULL,
	[Situacion] [varchar](500) NULL,
	[Acciones] [varchar](500) NULL,
	[Intervencion] [varchar](500) NULL,
	[IdExpediente] [int] NULL,
	[InstitucionRefiere] [varchar](500) NULL,
	[TipoInstrumento] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Secciones]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Secciones](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[IdNivel] [int] NULL,
 CONSTRAINT [PK_Secciones] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sexo]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sexo](
	[Sexo] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Sexo] PRIMARY KEY CLUSTERED 
(
	[Sexo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Identificacion] [varchar](100) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[Rol] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[PA_ActualizarEncargado]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[PA_ActualizarEncargado]	
@Identificacion varchar(50) ,
@NombreCompleto varchar(100) ,
@CorreoElectronico varchar(100) ,
@Ocupacion varchar(100) ,
@Parentesco varchar(50) 
	
AS

BEGIN
	UPDATE [dbo].[Encargado]
			
	SET 
	[Identificacion]= @Identificacion ,
	[NombreCompleto] = @NombreCompleto  ,
	[CorreoElectronico]=@CorreoElectronico  ,
	[Ocupacion] =@Ocupacion ,
	[Parentesco]=@Parentesco 

	WHERE [Identificacion] = @Identificacion
ENd
GO
/****** Object:  StoredProcedure [dbo].[PA_ActualizarEntrevistaEncargado]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[PA_ActualizarEntrevistaEncargado]	
@Numero INT,
@ResumenSituacion varchar(max),
@Recomendaciones varchar(max)
	
AS

BEGIN
	UPDATE [dbo].EntrevistaEncargado
			
	SET 

	ResumenSituacion= @ResumenSituacion,
	Recomendaciones= @Recomendaciones

	WHERE Numero = @Numero
ENd
GO
/****** Object:  StoredProcedure [dbo].[PA_ActualizarEntrevistaEstudiante]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_ActualizarEntrevistaEstudiante]
	-- Add the parameters for the stored procedure here
@Id int,
@Recomendaciones varchar(500),
@DetecciondelProfesional bit,
@Referencia bit,
@Solicitud bit,
@Otros bit,
@OtrosExplicacion varchar(500),
@Situacion varchar(500),
@Acciones varchar(500),
@Intervencion varchar(500),
@IdMotivo int,
@IdExpediente int,
@TipoInstrumento varchar(50)
AS

BEGIN
  UPDATE dbo.EntrevistaEstudiante
  set
	
        Recomendaciones = @Recomendaciones,
        DetecciondelProfesional = @DetecciondelProfesional,
        Referencia = @Referencia,
        Solicitud = @Solicitud,
        Otros = @Otros,
        OtrosExplicacion = @OtrosExplicacion,
        Situacion = @Situacion,
        Acciones = @Acciones,
        Intervencion = @Intervencion,
        IdMotivo = @IdMotivo,
		IdExpediente = @IdExpediente,
		TipoInstrumento = @TipoInstrumento
        
    where Id = @Id
	
	
END
GO
/****** Object:  StoredProcedure [dbo].[PA_ActualizarEntrevistaFuncionario]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[PA_ActualizarEntrevistaFuncionario]
@Numero INT,
@NombreFuncionario varchar(max),
@Puesto varchar(max),
@Cedula varchar(max),
@Recomendaciones varchar(max),
@Resumen varchar(max),
@AcuerdosAccionesASeguir varchar(max)
	
AS

BEGIN
	UPDATE [dbo].EntrevistaFuncionario
			
	SET 

	
	NombreFuncionario= @NombreFuncionario,
	Puesto= @Puesto,
	Cedula= @Cedula,
	Recomendaciones= Recomendaciones,
	Resumen= Resumen,
	AcuerdosAccionesASeguir= AcuerdosAccionesASeguir

	WHERE Numero = @Numero
ENd


GO
/****** Object:  StoredProcedure [dbo].[PA_ActualizarEstudiante]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_ActualizarEstudiante]	
@Identificacion varchar(50) ,
@NombreCompleto varchar(100) ,
@IdSeccion int,
@Sexo varchar(10) ,
@FechaNacimiento datetime ,
@Direccion varchar(100),
@Foto varbinary,
@IdEncargado varchar(50)
	
AS

BEGIN
	UPDATE [dbo].Estudiante
			
	SET 
	[Identificacion]= @Identificacion ,
	[NombreCompleto] = @NombreCompleto  ,
	[IdSeccion] = @IdSeccion,
	[Sexo]=@Sexo ,
	[FechaNacimiento]=@FechaNacimiento,
	[Direccion]=@Direccion,
	[Foto]=@Foto,
	[IdEncargado] = @IdEncargado

	WHERE [Identificacion] = @Identificacion
ENd

select  * from  Estudiante
GO
/****** Object:  StoredProcedure [dbo].[PA_ActualizarInformeVisita]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[PA_ActualizarInformeVisita]
@Numero INT,
@ProfesionaQueRealizaLaVisita varchar(max),
@Cargo varchar(max),
@AccionesSeguimiento varchar(max),
@SituacionObservada varchar(max),
@Recomendaciones varchar(max),
@Direccion varchar(max)
	
AS

BEGIN
	UPDATE [dbo].InformeVisitaAlHogar
			
	SET 

	
	ProfesionaQueRealizaLaVisita= @ProfesionaQueRealizaLaVisita,
	Cargo= @Cargo,
	AccionesSeguimiento= @AccionesSeguimiento,
	SituacionObservada= @SituacionObservada,
	Recomendaciones= @Recomendaciones,
	Direccion= @Direccion

	WHERE Numero = @Numero
ENd
GO
/****** Object:  StoredProcedure [dbo].[PA_ActualizarMotivoAtencion]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[PA_ActualizarMotivoAtencion]	
@NumeroMotivo int ,
@Descripcion varchar(100) 
	
AS

BEGIN
	UPDATE [dbo].MotivoAtencion
			
	SET 
	[NumeroMotivo]= @NumeroMotivo ,
	[Descripcion] = @Descripcion  
	

	WHERE [NumeroMotivo] = @NumeroMotivo
ENd
GO
/****** Object:  StoredProcedure [dbo].[PA_ActualizarPeriodo]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[PA_ActualizarPeriodo]	
@Codigo int,
@Nombre varchar(100),
@FechaInicio datetime,
@FechaFinal datetime
	
AS

BEGIN
	UPDATE [dbo].Periodos
			
	SET 
	[Codigo]= @Codigo ,
	[Nombre] = @Nombre,
	[FechaInicio]= @FechaInicio,
	[FechaFinal]= @FechaFinal

	

	WHERE [Codigo] = @Codigo
ENd
---fin de actualizar
GO
/****** Object:  StoredProcedure [dbo].[PA_ActualizarReferenciaExterna]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[PA_ActualizarReferenciaExterna]
@Numero int,
@Provincia varchar(50),
@Canton varchar(50),
@Distrito varchar(50),
@OtrasSennas varchar(max),
@CorreoElectronicoEstudiante varchar(100),
@AccionesQueHaRealizadoElCentroEducativo varchar(max),
@PersonaqueRefiere varchar(100),
@Puesto varchar(100),
@SituacionPresenta varchar(max),
@ProfesionaQueRealizaLaVisita varchar(100),
@ObservacionesyRecomendaciones varchar(max),
@InstitucionDondeSeRefiere varchar(100)

AS

BEGIN
	UPDATE [dbo].ReferenciaExterna
			
	SET 

	
	Provincia= @Provincia,
	Canton= @Canton,
	Distrito= @Distrito,
	OtrasSennas= @OtrasSennas,
	CorreoElectronicoEstudiante= @CorreoElectronicoEstudiante,
	AccionesQueHaRealizadoElCentroEducativo= @AccionesQueHaRealizadoElCentroEducativo,
	PersonaqueRefiere= @PersonaqueRefiere,
	Puesto= @Puesto,
	SituacionPresenta= @SituacionPresenta,
	ProfesionaQueRealizaLaVisita= @ProfesionaQueRealizaLaVisita,
	ObservacionesyRecomendaciones= @ObservacionesyRecomendaciones,
	InstitucionDondeSeRefiere= @InstitucionDondeSeRefiere

	WHERE Numero = @Numero
ENd
GO
/****** Object:  StoredProcedure [dbo].[PA_ActualizarSecciones]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[PA_ActualizarSecciones]	
@Id int ,
@Nombre varchar(100), 
@Nivel varchar(100)  
	
AS

BEGIN
	UPDATE [dbo].Secciones
			
	SET 
	[Id]= @Id ,
	[Nombre] = @Nombre,
	[Nivel]= @Nivel

	

	WHERE Id = @Id
ENd
---fin de actualizar
GO
/****** Object:  StoredProcedure [dbo].[PA_EliminarEncargado]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[PA_EliminarEncargado]	
	@Identificacion nvarchar(50)
AS
BEGIN

	DELETE FROM [dbo].[Encargado]
    WHERE Identificacion = @Identificacion

END

GO
/****** Object:  StoredProcedure [dbo].[PA_EliminarEstudiante]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[PA_EliminarEstudiante]	
	@Identificacion nvarchar(50)
AS
BEGIN

	DELETE FROM [dbo].estudiante
    WHERE Identificacion = @Identificacion

END
GO
/****** Object:  StoredProcedure [dbo].[PA_EliminarMotivoAtencion]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[PA_EliminarMotivoAtencion]	
	@NumeroMotivo int
AS
BEGIN

	DELETE FROM [dbo].MotivoAtencion
    WHERE NumeroMotivo = @NumeroMotivo

END
GO
/****** Object:  StoredProcedure [dbo].[PA_EliminarPeriodo]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[PA_EliminarPeriodo]	
	@Codigo int 
AS
BEGIN

	DELETE FROM [dbo].Periodos
    WHERE Codigo = @Codigo

END
GO
/****** Object:  StoredProcedure [dbo].[PA_EliminarSecciones]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Inicia Eliminar Motivo
Create PROCEDURE [dbo].[PA_EliminarSecciones]	
	@Id int 
AS
BEGIN

	DELETE FROM [dbo].Secciones
    WHERE Id = @Id

END

---fin eliminar secciones
GO
/****** Object:  StoredProcedure [dbo].[PA_InsertarEncargado]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[PA_InsertarEncargado]
	-- Add the parameters for the stored procedure here
@Identificacion varchar(50) ,
@NombreCompleto varchar(100) ,
@CorreoElectronico varchar(100) ,
@Ocupacion varchar(100) ,
@Parentesco varchar(50) 
	
AS

BEGIN
	INSERT INTO Encargado(Identificacion,NombreCompleto,CorreoElectronico,Ocupacion,Parentesco)
	VALUES (@Identificacion, @NombreCompleto, @CorreoElectronico,@Ocupacion,@Parentesco)
END

GO
/****** Object:  StoredProcedure [dbo].[PA_InsertarEntrevistaEncargado]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_InsertarEntrevistaEncargado]
	-- Add the parameters for the stored procedure here
@Recomendaciones varchar(500),
@ConvocadoPorInstitucion bit,
@ConvocadoPorEncargado bit,
@Situacion varchar(500),
@Acciones varchar(500),
@Intervencion varchar(500),
@IdMotivo int,
@IdExpediente int,
@TipoInstrumento varchar(50)

AS

BEGIN
	INSERT INTO EntrevistaEncargado(
	  Recomendaciones,
        ConvocadoPorInstitucion,
        ConvocadoPorEncargado,
        Situacion,
        Acciones,
        Intervencion,
        IdMotivo,
		IdExpediente,
		TipoInstrumento
	)
	VALUES (
	@Recomendaciones,
    @ConvocadoPorInstitucion,
	@ConvocadoPorEncargado,
    @Situacion,
    @Acciones,
    @Intervencion,
    @IdMotivo,
	@IdExpediente,
	@TipoInstrumento
	)
	SELECT SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[PA_InsertarEntrevistaEncargadoArchivos]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_InsertarEntrevistaEncargadoArchivos]
	-- Add the parameters for the stored procedure here

@IdEntrevista int,
@Nombre varchar(100),
@Archivo varbinary
AS

BEGIN
	INSERT INTO EntrevistaEncargado_Archivos( IdEntrevista, Archivo, Nombre)
	VALUES ( @IdEntrevista, @Archivo, @Nombre)
END
GO
/****** Object:  StoredProcedure [dbo].[PA_InsertarEntrevistaEstudiante]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_InsertarEntrevistaEstudiante]
	-- Add the parameters for the stored procedure here
@Recomendaciones varchar(500),
@DetecciondelProfesional bit,
@Referencia bit,
@Solicitud bit,
@Otros bit,
@OtrosExplicacion varchar(500),
@Situacion varchar(500),
@Acciones varchar(500),
@Intervencion varchar(500),
@IdMotivo int,
@IdExpediente int,
@TipoInstrumento varchar(50)
AS

BEGIN
	INSERT INTO dbo.EntrevistaEstudiante(
        Recomendaciones,
        DetecciondelProfesional,
        Referencia,
        Solicitud,
        Otros,
        OtrosExplicacion,
        Situacion,
        Acciones,
        Intervencion,
        IdMotivo,
		IdExpediente,
		TipoInstrumento
        
        )
	VALUES (
    @Recomendaciones,
    @DetecciondelProfesional,
    @Referencia,
    @Solicitud,
    @Otros,
    @OtrosExplicacion,
    @Situacion,
    @Acciones,
    @Intervencion,
    @IdMotivo,
	@IdExpediente,@TipoInstrumento
    )
	SELECT SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[PA_InsertarEntrevistaEstudianteArchivos]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_InsertarEntrevistaEstudianteArchivos]
	-- Add the parameters for the stored procedure here

@IdEntrevista int,
@Nombre varchar(100),
@Archivo varbinary
AS

BEGIN
	INSERT INTO EntrevistaEstudiante_Archivos( IdEntrevista, Archivo, Nombre)
	VALUES ( @IdEntrevista, @Archivo, @Nombre)
END
GO
/****** Object:  StoredProcedure [dbo].[PA_InsertarEntrevistaFuncionario]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_InsertarEntrevistaFuncionario]
	-- Add the parameters for the stored procedure here
@Recomendaciones varchar(500),
@NombreFuncionario varchar(500),
@Puesto varchar(500),
@Situacion varchar(500),
@Acciones varchar(500),
@Intervencion varchar(500),
@IdMotivo int,
@IdExpediente int,
@TipoInstrumento varchar(50)
AS

BEGIN
	INSERT INTO dbo.EntrevistaFuncionario(
        Recomendaciones,
        NombreFuncionario,
		Puesto,
        Situacion,
        Acciones,
        Intervencion,
        IdMotivo,
		IdExpediente,
		TipoInstrumento
        
        )
	VALUES (
    @Recomendaciones,
    @NombreFuncionario,
	@Puesto,
    @Situacion,
    @Acciones,
    @Intervencion,
    @IdMotivo,
	@IdExpediente,
	@TipoInstrumento
    )
	SELECT SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[PA_InsertarEntrevistaFuncionarioArchivos]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_InsertarEntrevistaFuncionarioArchivos]
	-- Add the parameters for the stored procedure here

@IdEntrevista int,
@Nombre varchar(100),
@Archivo varbinary
AS

BEGIN
	INSERT INTO [EntrevistaFuncionario_Archivos]( IdEntrevista, Archivo, Nombre)
	VALUES ( @IdEntrevista, @Archivo, @Nombre)
END
GO
/****** Object:  StoredProcedure [dbo].[PA_InsertarEstudiante]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_InsertarEstudiante]
	-- Add the parameters for the stored procedure here
@Identificacion varchar(50) ,
@NombreCompleto varchar(100) ,
@IdSeccion int,
@Sexo varchar(10) ,
@FechaNacimiento datetime ,
@Direccion varchar(100),
@Foto varbinary,
@IdEncargado varchar(50)
	
AS

BEGIN
	INSERT INTO Estudiante(Identificacion,NombreCompleto, IdSeccion, Sexo,FechaNacimiento,Direccion, Foto, IdEncargado)
	VALUES (@Identificacion, @NombreCompleto, @IdSeccion, @Sexo,@FechaNacimiento,@Direccion, @Foto, @IdEncargado)
END

GO
/****** Object:  StoredProcedure [dbo].[PA_InsertarExpediente]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_InsertarExpediente]
	-- Add the parameters for the stored procedure here
@IdEstudiante varchar(50)

	
AS

BEGIN
	INSERT INTO Expediente(IdEstudiante)
	VALUES (@IdEstudiante);
	SELECT SCOPE_IDENTITY()
END

GO
/****** Object:  StoredProcedure [dbo].[PA_InsertarFuncionario]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_InsertarFuncionario]
	-- Add the parameters for the stored procedure here
@Recomendaciones varchar(500),
@NombreFuncionario varchar(500),
@Puesto varchar(500),
@Situacion varchar(500),
@Acciones varchar(500),
@Intervencion varchar(500),
@IdMotivo int,
@IdExpediente int
AS

BEGIN
	INSERT INTO dbo.EntrevistaFuncionario(
        Recomendaciones,
        NombreFuncionario,
		Puesto,
        Situacion,
        Acciones,
        Intervencion,
        IdMotivo,
		IdExpediente
        
        )
	VALUES (
    @Recomendaciones,
    @NombreFuncionario,
	@Puesto,
    @Situacion,
    @Acciones,
    @Intervencion,
    @IdMotivo,
	@IdExpediente
    )
END
GO
/****** Object:  StoredProcedure [dbo].[PA_InsertarInformeArchivos]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_InsertarInformeArchivos]
	-- Add the parameters for the stored procedure here

@IdEntrevista int,
@Nombre varchar(100),
@Archivo varbinary
AS

BEGIN
	INSERT INTO [InformeVisitaAlHogar_Archivos]( IdEntrevista, Archivo, Nombre)
	VALUES ( @IdEntrevista, @Archivo, @Nombre)
END
GO
/****** Object:  StoredProcedure [dbo].[PA_InsertarInformeVisitaAlHogar]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_InsertarInformeVisitaAlHogar]
	-- Add the parameters for the stored procedure here
@Recomendaciones varchar(500),
@NombreFuncionario varchar(500),
@Puesto varchar(500),
@Situacion varchar(500),
@Acciones varchar(500),
@Intervencion varchar(500),
@IdMotivo int,
@IdExpediente int,@TipoInstrumento varchar(50)


AS

BEGIN
	INSERT INTO InformeVisitaAlHogar(
	  Recomendaciones,
        NombreFuncionario,
        Puesto,
        Situacion,
        Acciones,
        Intervencion,
        IdMotivo,
		IdExpediente,
		TipoInstrumento
	)
	VALUES (
	@Recomendaciones,
    @NombreFuncionario,
	@Puesto,
    @Situacion,
    @Acciones,
    @Intervencion,
    @IdMotivo,
	@IdExpediente,
	@TipoInstrumento
	)
	SELECT SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[PA_InsertarMotivoAtencion]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[PA_InsertarMotivoAtencion]
	-- Add the parameters for the stored procedure here
@NumeroMotivo int ,
@Descripcion varchar(100) 
AS

BEGIN
	INSERT INTO MotivoAtencion(NumeroMotivo,Descripcion)
	VALUES (@NumeroMotivo, @Descripcion)
END



---Actualizar Motivo
SET ANSI_NULLS ON

GO
/****** Object:  StoredProcedure [dbo].[PA_InsertarNivel]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_InsertarNivel]
	-- Add the parameters for the stored procedure here

@Nombre varchar(100) ,
@Ciclo int
AS

BEGIN
	INSERT INTO Nivel( NombreNivel, Ciclo)
	VALUES ( @Nombre, @Ciclo)
END
GO
/****** Object:  StoredProcedure [dbo].[PA_InsertarPeriodo]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[PA_InsertarPeriodo]
	-- Add the parameters for the stored procedure here
@Codigo int,
@Nombre varchar(100),
@FechaInicio datetime,
@FechaFinal datetime
AS

BEGIN
	INSERT INTO Periodos(Codigo,Nombre, FechaInicio, FechaFinal)
	VALUES (@Codigo, @Nombre, @FechaInicio, @FechaFinal)
END

GO
/****** Object:  StoredProcedure [dbo].[PA_InsertarReferenciaArchivos]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_InsertarReferenciaArchivos]
	-- Add the parameters for the stored procedure here

@IdEntrevista int,
@Nombre varchar(100),
@Archivo varbinary
AS

BEGIN
	INSERT INTO Referencia_Archivos( IdEntrevista, Archivo, Nombre)
	VALUES ( @IdEntrevista, @Archivo, @Nombre)
END
GO
/****** Object:  StoredProcedure [dbo].[PA_InsertarReferenciaExterna]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_InsertarReferenciaExterna]
	-- Add the parameters for the stored procedure here
@Recomendaciones varchar(500),
@PersonaRefiere varchar(500),
@Puesto varchar(500),
@Situacion varchar(500),
@Acciones varchar(500),
@Intervencion varchar(500),
@IdMotivo int,
@IdExpediente int,
@InstitucionRefiere varchar(500),
@TipoInstrumento varchar(50)
AS

BEGIN
	INSERT INTO dbo.ReferenciaExterna(
        Recomendaciones,
        PersonaRefiere,
		Puesto,
        Situacion,
        Acciones,
        Intervencion,
        IdMotivo,
		IdExpediente,
		InstitucionRefiere,
		TipoInstrumento
        
        )
	VALUES (
    @Recomendaciones,
    @PersonaRefiere,
	@Puesto,
    @Situacion,
    @Acciones,
    @Intervencion,
    @IdMotivo,
	@IdExpediente,
	@InstitucionRefiere,
	@TipoInstrumento
    )
	SELECT SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[PA_InsertarSecciones]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_InsertarSecciones]
	-- Add the parameters for the stored procedure here
@Nombre varchar(100), 
@IdNivel int 

AS

BEGIN
	INSERT INTO Secciones(Nombre, IdNivel)
	VALUES ( @Nombre, @IdNivel)
END


GO
/****** Object:  StoredProcedure [dbo].[PA_InsertarUsuario]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_InsertarUsuario]
	-- Add the parameters for the stored procedure here

@Identificacion varchar(100),
@Password varchar(100),
@Rol int
AS

BEGIN
	INSERT INTO Usuario( Identificacion, Password, Rol)
	VALUES ( @Identificacion, @Password, @Rol)
END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarCiclo]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_SeleccionarCiclo]	
	
AS
BEGIN

	SELECT Id, Nombre
      
	FROM [dbo].Ciclo


END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarCicloPorId]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PA_SeleccionarCicloPorId]	
	@Id int
AS
BEGIN

	SELECT [Id], [Nombre]
	FROM [dbo].Ciclo
	WHERE Id = @Id

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarEncargado]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[PA_SeleccionarEncargado]	
	
AS
BEGIN

	SELECT [Identificacion]
      ,[NombreCompleto],
	  [CorreoElectronico],[Ocupacion],[Parentesco]
	FROM [dbo].Encargado

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarEncargadoPorId]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[PA_SeleccionarEncargadoPorId]	
	@Identificacion varchar(50)
AS
BEGIN

	SELECT [Identificacion],[NombreCompleto], CorreoElectronico, Ocupacion, Parentesco
	FROM [dbo].Encargado
	WHERE Identificacion = @Identificacion

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarEntrevistaEncargadoArchivosPorId]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_SeleccionarEntrevistaEncargadoArchivosPorId]	
	@IdEntrevista int
AS
BEGIN

	SELECT *
	FROM [dbo].EntrevistaEncargado_Archivos
	WHERE IdEntrevista = @IdEntrevista

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarEntrevistaEncargadoPorExpediente]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_SeleccionarEntrevistaEncargadoPorExpediente]	
	@IdExpediente int
AS
BEGIN

	SELECT *
	FROM [dbo].EntrevistaEncargado	
	WHERE IdExpediente = @IdExpediente

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarEntrevistaEncargadoPorId]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_SeleccionarEntrevistaEncargadoPorId]	
	@Id int
AS
BEGIN

	SELECT *
	FROM [dbo].EntrevistaEncargado
	WHERE Id = @Id

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarEntrevistaEstudianteArchivosPorId]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_SeleccionarEntrevistaEstudianteArchivosPorId]	
	@IdEntrevista int
AS
BEGIN

	SELECT *
	FROM [dbo].EntrevistaEstudiante_Archivos
	WHERE IdEntrevista = @IdEntrevista

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarEntrevistaEstudiantePorExpediente]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_SeleccionarEntrevistaEstudiantePorExpediente]	
	@IdExpediente int
AS
BEGIN

	SELECT *
	FROM [dbo].EntrevistaEstudiante
	WHERE IdExpediente = @IdExpediente

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarEntrevistaEstudiantePorId]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_SeleccionarEntrevistaEstudiantePorId]	
	@Id int
AS
BEGIN

	SELECT *
	FROM [dbo].EntrevistaEstudiante
	WHERE Id = @Id

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarEntrevistaFuncionarioArchivosPorId]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_SeleccionarEntrevistaFuncionarioArchivosPorId]	
	@IdEntrevista int
AS
BEGIN

	SELECT *
	FROM [dbo].[EntrevistaFuncionario_Archivos]
	WHERE IdEntrevista = @IdEntrevista

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarEntrevistaFuncionarioPorExpediente]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[PA_SeleccionarEntrevistaFuncionarioPorExpediente]	
	@IdExpediente int
AS
BEGIN

	SELECT *
	FROM [dbo].EntrevistaFuncionario
	WHERE IdExpediente = @IdExpediente

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarEntrevistaFuncionarioPorId]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_SeleccionarEntrevistaFuncionarioPorId]	
	@Id int
AS
BEGIN

	SELECT *
	FROM [dbo].EntrevistaFuncionario
	WHERE Id = @Id

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarEstudiantePorEncargado]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_SeleccionarEstudiantePorEncargado]	
	@Identificacion nvarchar(50)
AS
BEGIN

	SELECT *
	FROM [dbo].Estudiante
	WHERE IdEncargado= @Identificacion

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarEstudiantePorId]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_SeleccionarEstudiantePorId]	
	@Identificacion nvarchar(50)
AS
BEGIN

	SELECT [Identificacion]
      ,[NombreCompleto],
	  [IdSeccion],[Sexo],[FechaNacimiento],[Direccion],[Foto], IdEncargado
	FROM [dbo].Estudiante
	WHERE Identificacion = @Identificacion

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarEstudiantes]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_SeleccionarEstudiantes]	
	
AS
BEGIN

	SELECT [Identificacion]
      ,[NombreCompleto],
	  IdSeccion,[Sexo],[FechaNacimiento],[Direccion],[Foto], IdEncargado
	FROM [dbo].Estudiante

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarExpedientePorId]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_SeleccionarExpedientePorId]	
	@IdEstudiante varchar(50)
AS
BEGIN

	SELECT *
	FROM [dbo].Expediente
	WHERE IdEstudiante = @IdEstudiante

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarExpedientePorIdEncargado]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_SeleccionarExpedientePorIdEncargado]	
	@IdEncargado varchar(50)
AS
BEGIN

	
SELECT *
FROM Expediente
INNER JOIN Estudiante ON Expediente.IdEstudiante = Estudiante.Identificacion
INNER JOIN EncargadO ON Estudiante.IdEncargado = Encargado.Identificacion
WHERE Encargado.Identificacion = @IdEncargado


END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarExpedientePorIdExpediente]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_SeleccionarExpedientePorIdExpediente]	
	@Id int
AS
BEGIN

	SELECT *
	FROM [dbo].Expediente
	WHERE Id = @Id

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarExpedientePorNombreEstudiante]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_SeleccionarExpedientePorNombreEstudiante]	
	@Nombre varchar(50)
AS
BEGIN

	
SELECT *
FROM Expediente
INNER JOIN Estudiante ON Expediente.IdEstudiante = Estudiante.Identificacion
WHERE Estudiante.NombreCompleto LIKE '%'+@Nombre+'%'


END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarInformeArchivosPorId]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_SeleccionarInformeArchivosPorId]	
	@IdEntrevista int
AS
BEGIN

	SELECT *
	FROM [dbo].[InformeVisitaAlHogar_Archivos]
	WHERE IdEntrevista = @IdEntrevista

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarInformeVisitaAlHogarPorExpediente]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[PA_SeleccionarInformeVisitaAlHogarPorExpediente]	
	@IdExpediente int
AS
BEGIN

	SELECT *
	FROM [dbo].InformeVisitaAlHogar
	WHERE IdExpediente = @IdExpediente

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarInformeVisitaAlHogarPorId]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_SeleccionarInformeVisitaAlHogarPorId]	
	@Id int
AS
BEGIN

	SELECT *
	FROM [dbo].InformeVisitaAlHogar
	WHERE Id = @Id

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarMotivoAtencion]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[PA_SeleccionarMotivoAtencion]	
	
AS
BEGIN

	SELECT [NumeroMotivo]
      ,[Descripcion]
	FROM [dbo].MotivoAtencion

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarMotivoAtencionPorId]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[PA_SeleccionarMotivoAtencionPorId]	
	@NumeroMotivo int
AS
BEGIN

	SELECT [NumeroMotivo]
      ,[Descripcion]
	FROM [dbo].MotivoAtencion
	WHERE [NumeroMotivo] = @NumeroMotivo

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarNivel]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_SeleccionarNivel]	
	
AS
BEGIN

	SELECT NombreNivel, Ciclo
      
	FROM [dbo].Nivel


END

GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarNivelPorCiclo]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_SeleccionarNivelPorCiclo]
	@Ciclo int
AS
BEGIN

SELECT Id, NombreNivel, Ciclo

      
   
  FROM [dbo].Nivel
  WHERE   Ciclo= @Ciclo
		   	
END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarNivelPorId]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[PA_SeleccionarNivelPorId]	
	@Id int
AS
BEGIN

	SELECT Id, NombreNivel, Ciclo
	FROM [dbo].Nivel
	WHERE Id = @Id

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarPeridosPorId]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- inicia seleccionar por id
Create PROCEDURE [dbo].[PA_SeleccionarPeridosPorId]	
	@Codigo int
AS
BEGIN

	SELECT [Codigo],[Nombre], FechaInicio, FechaFinal
	FROM [dbo].Periodos
	WHERE Codigo = @Codigo

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarPeriodo]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[PA_SeleccionarPeriodo]	
	
AS
BEGIN

	SELECT [Codigo]
      ,[Nombre], [FechaInicio], [FechaFinal]
	FROM [dbo].Periodos


END

GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarReferenciaArchivosPorId]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_SeleccionarReferenciaArchivosPorId]	
	@IdEntrevista int
AS
BEGIN

	SELECT *
	FROM [dbo].Referencia_Archivos
	WHERE IdEntrevista = @IdEntrevista

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarReferenciaExternaPorId]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_SeleccionarReferenciaExternaPorId]	
	@Id int
AS
BEGIN

	SELECT *
	FROM [dbo].ReferenciaExterna
	WHERE Id = @Id

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarReferenciaPorExpediente]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_SeleccionarReferenciaPorExpediente]	
	@IdExpediente int
AS
BEGIN

	SELECT *
	FROM [dbo].ReferenciaExterna
	WHERE IdExpediente = @IdExpediente

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarSeccion]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_SeleccionarSeccion]	
	
AS
BEGIN

	SELECT [Id]
      ,[Nombre], [IdNivel]
	FROM [dbo].secciones


END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarSeccionesPorId]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_SeleccionarSeccionesPorId]	
	@Id int
AS
BEGIN

	SELECT [Id],[Nombre], IdNivel
	FROM [dbo].Secciones
	WHERE Id = @Id

END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarSeccionPorNivel]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_SeleccionarSeccionPorNivel]
	@IdNivel int
AS
BEGIN

SELECT [Id], [Nombre], IdNivel

      
   
  FROM [dbo].Secciones
  WHERE   IdNivel= @IdNivel
		   	
END
GO
/****** Object:  StoredProcedure [dbo].[PA_SeleccionarUsuarioPorId]    Script Date: 8/23/2018 12:46:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- inicia seleccionar por id
CREATE PROCEDURE [dbo].[PA_SeleccionarUsuarioPorId]
	@Identificacion varchar(100)
AS
BEGIN

	SELECT *
	FROM [dbo].Usuario
	WHERE Identificacion = @Identificacion

END
GO
USE [master]
GO
ALTER DATABASE [ProyectoAna] SET  READ_WRITE 
GO
