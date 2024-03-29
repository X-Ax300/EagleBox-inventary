USE [master]
GO
/****** Object:  Database [GestorInventario]    Script Date: 3/13/2024 9:09:09 AM ******/
CREATE DATABASE [GestorInventario]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GestorInventario', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\GestorInventario.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GestorInventario_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\GestorInventario_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [GestorInventario] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GestorInventario].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GestorInventario] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GestorInventario] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GestorInventario] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GestorInventario] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GestorInventario] SET ARITHABORT OFF 
GO
ALTER DATABASE [GestorInventario] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GestorInventario] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GestorInventario] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GestorInventario] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GestorInventario] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GestorInventario] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GestorInventario] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GestorInventario] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GestorInventario] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GestorInventario] SET  ENABLE_BROKER 
GO
ALTER DATABASE [GestorInventario] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GestorInventario] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GestorInventario] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GestorInventario] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GestorInventario] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GestorInventario] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GestorInventario] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GestorInventario] SET RECOVERY FULL 
GO
ALTER DATABASE [GestorInventario] SET  MULTI_USER 
GO
ALTER DATABASE [GestorInventario] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GestorInventario] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GestorInventario] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GestorInventario] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GestorInventario] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GestorInventario] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'GestorInventario', N'ON'
GO
ALTER DATABASE [GestorInventario] SET QUERY_STORE = ON
GO
ALTER DATABASE [GestorInventario] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [GestorInventario]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 3/13/2024 9:09:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[IDAdmin] [int] NOT NULL,
	[NameAdmin] [varchar](25) NOT NULL,
	[SurNameAdmin] [varchar](25) NOT NULL,
	[MailAdmin] [varchar](25) NOT NULL,
	[PasswordAdmin] [varchar](50) NOT NULL,
	[RegisterDateAdmin] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDAdmin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 3/13/2024 9:09:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[IDClient] [int] NOT NULL,
	[NameClient] [varchar](25) NOT NULL,
	[SurNameClient] [varchar](25) NOT NULL,
	[MailClient] [varchar](25) NOT NULL,
	[PasswordClient] [varchar](50) NOT NULL,
	[RegisterDateClient] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDClient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventario]    Script Date: 3/13/2024 9:09:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventario](
	[SaleID] [int] NOT NULL,
	[ProductName] [varchar](25) NOT NULL,
	[Price] [money] NOT NULL,
	[ProductDescription] [varchar](max) NOT NULL,
	[QuantityAvailable] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SaleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 3/13/2024 9:09:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[SaleID] [int] NOT NULL,
	[ProductName] [varchar](125) NOT NULL,
	[QuantitySold] [int] NOT NULL,
	[SaleDate] [datetime] NOT NULL,
	[PricePerUnit] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SaleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Inventario] ADD  DEFAULT ((0)) FOR [QuantityAvailable]
GO
/****** Object:  StoredProcedure [dbo].[sp_agregar_empleado]    Script Date: 3/13/2024 9:09:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_agregar_empleado]
    @ID INT,
    @Nombre VARCHAR(25),
    @Apellido VARCHAR(25),
    @Correo VARCHAR(25),
    @Contraseña VARCHAR(50),
    @FechaRegistro DATETIME
AS
BEGIN
    INSERT INTO Clientes (IDClient, NameClient, SurNameClient, MailClient, PasswordClient, RegisterDateClient)
    VALUES (@ID, @Nombre, @Apellido, @Correo, @Contraseña, @FechaRegistro)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_agregar_empleadoAdmin]    Script Date: 3/13/2024 9:09:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_agregar_empleadoAdmin]
    @ID INT,
    @Nombre VARCHAR(25),
    @Apellido VARCHAR(25),
    @Correo VARCHAR(25),
    @Contraseña VARCHAR(50),
    @FechaRegistro DATETIME
AS
BEGIN
    INSERT INTO Admins (IDAdmin, NameAdmin, SurNameAdmin, MailAdmin, PasswordAdmin, RegisterDateAdmin)
    VALUES (@ID, @Nombre, @Apellido, @Correo, @Contraseña, @FechaRegistro)
END
GO
USE [master]
GO
ALTER DATABASE [GestorInventario] SET  READ_WRITE 
GO
