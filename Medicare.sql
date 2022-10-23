USE [master]
GO

/****** Object:  Database [MedicareManagementSystem]    Script Date: 23/10/2022 19:03:21 ******/
CREATE DATABASE [MedicareManagementSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Medicare', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Medicare.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Medicare_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Medicare_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MedicareManagementSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [MedicareManagementSystem] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [MedicareManagementSystem] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [MedicareManagementSystem] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [MedicareManagementSystem] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [MedicareManagementSystem] SET ARITHABORT OFF 
GO

ALTER DATABASE [MedicareManagementSystem] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [MedicareManagementSystem] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [MedicareManagementSystem] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [MedicareManagementSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [MedicareManagementSystem] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [MedicareManagementSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [MedicareManagementSystem] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [MedicareManagementSystem] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [MedicareManagementSystem] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [MedicareManagementSystem] SET  DISABLE_BROKER 
GO

ALTER DATABASE [MedicareManagementSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [MedicareManagementSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [MedicareManagementSystem] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [MedicareManagementSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [MedicareManagementSystem] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [MedicareManagementSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [MedicareManagementSystem] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [MedicareManagementSystem] SET RECOVERY FULL 
GO

ALTER DATABASE [MedicareManagementSystem] SET  MULTI_USER 
GO

ALTER DATABASE [MedicareManagementSystem] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [MedicareManagementSystem] SET DB_CHAINING OFF 
GO

ALTER DATABASE [MedicareManagementSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [MedicareManagementSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [MedicareManagementSystem] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [MedicareManagementSystem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [MedicareManagementSystem] SET QUERY_STORE = OFF
GO

ALTER DATABASE [MedicareManagementSystem] SET  READ_WRITE 
GO

