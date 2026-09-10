# SAM - Sistema de Gestión de Taller Automotriz

Sistema de escritorio desarrollado en **C# (.NET Framework 4.7.2)** y **Windows Forms** para la administración integral de talleres automotrices, control de clientes, vehículos, mecánicos y órdenes de servicio[cite: 1]. Está diseñado bajo una arquitectura en **3 capas** (Presentación, Negocio, Datos) desacopladas mediante **Entity Framework 6 (Database First)** y **Microsoft SQL Server**[cite: 1].

---

## Tecnologías Utilizadas

* **Lenguaje:** C# (.NET Framework 4.7.2)
* **Interfaz Gráfica:** Windows Forms
* **ORM:** Entity Framework 6 (Database First)
* **Base de Datos:** Microsoft SQL Server 2019 o superior
* **IDE Recomendado:** Visual Studio 2019 o Visual Studio 2022
* **Herramienta de Gestión:** SQL Server Management Studio (SSMS)

---

## Guía de Despliegue y Ejecución

Sigue estos 3 pasos para poner en marcha la solución localmente sin errores de conexión.

### Paso 1. Crear y Poblar la Base de Datos

Abre **SQL Server Management Studio (SSMS)**, conéctate a tu servidor local, abre una nueva consulta (`Ctrl + N`), copia el siguiente bloque completo y ejecútalo (`F5`)[cite: 1]:

```sql
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'dbSamTallerAutomotriz')
BEGIN
    CREATE DATABASE [dbSamTallerAutomotriz];
END
GO

USE [dbSamTallerAutomotriz]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Administrador](
	[IdAdministrador] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Dni] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Telefono] [nvarchar](50) NOT NULL,
	[Contraseña] [nvarchar](50) NOT NULL,
	[Estado] [char](50) NOT NULL,
	[Eliminado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdAdministrador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Provincia](
	[IdProvincia] [int] IDENTITY(1,1) NOT NULL,
	[NombreProvincia] [nvarchar](50) NOT NULL,
	[Eliminado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProvincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Distrito](
	[IdDistrito] [int] IDENTITY(1,1) NOT NULL,
	[NombreDistrito] [nvarchar](50) NOT NULL,
	[IdProvincia] [int] NOT NULL,
	[Eliminado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdDistrito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Cliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Dni] [nvarchar](50) NOT NULL,
	[Telefono] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[TipoCliente] [nvarchar](50) NOT NULL,
	[Estado] [char](50) NOT NULL,
	[Eliminado] [bit] NOT NULL,
	[IdDistrito] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Marca](
	[IdMarca] [int] IDENTITY(1,1) NOT NULL,
	[NombreMarca] [nvarchar](50) NOT NULL,
	[Eliminado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TipoVehiculo](
	[IdTipoVehiculo] [int] IDENTITY(1,1) NOT NULL,
	[NombreTipoVehiculo] [nvarchar](50) NOT NULL,
	[Eliminado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTipoVehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TipoEspecialidad](
	[IdEspecialidad] [int] IDENTITY(1,1) NOT NULL,
	[NombreEspecialidad] [nvarchar](50) NOT NULL,
	[Eliminado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEspecialidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Mecanico](
	[IdMecanico] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Dni] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Telefono] [nvarchar](50) NOT NULL,
	[IdEspecialidad] [int] NOT NULL,
	[Estado] [char](50) NOT NULL,
	[Eliminado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdMecanico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Vehiculo](
	[IdVehiculo] [int] IDENTITY(1,1) NOT NULL,
	[Año] [int] NOT NULL,
	[Color] [nvarchar](50) NOT NULL,
	[Placa] [nvarchar](50) NOT NULL,
	[Estado] [char](50) NOT NULL,
	[Eliminado] [bit] NOT NULL,
	[IdTipoVehiculo] [int] NOT NULL,
	[IdMarca] [int] NOT NULL,
	[IdCliente] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdVehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Orden](
	[IdOrden] [int] IDENTITY(1,1) NOT NULL,
	[FechaIngreso] [datetime] NOT NULL,
	[FechaSalida] [datetime] NOT NULL,
	[DescripcionServicio] [nvarchar](50) NOT NULL,
	[CostoTotal] [float] NOT NULL,
	[TipoServicio] [nvarchar](50) NOT NULL,
	[IdVehiculo] [int] NOT NULL,
	[IdAdministrador] [int] NOT NULL,
	[IdMecanico] [int] NOT NULL,
	[Estado] [char](50) NOT NULL,
	[Eliminado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdOrden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Distrito_TO_Cliente] FOREIGN KEY([IdDistrito])
REFERENCES [dbo].[Distrito] ([IdDistrito])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Distrito_TO_Cliente]
GO

ALTER TABLE [dbo].[Distrito]  WITH CHECK ADD  CONSTRAINT [FK_Provincia_TO_Distrito] FOREIGN KEY([IdProvincia])
REFERENCES [dbo].[Provincia] ([IdProvincia])
GO
ALTER TABLE [dbo].[Distrito] CHECK CONSTRAINT [FK_Provincia_TO_Distrito]
GO

ALTER TABLE [dbo].[Mecanico]  WITH CHECK ADD  CONSTRAINT [FK_TipoEspecialidad_TO_Mecanico] FOREIGN KEY([IdEspecialidad])
REFERENCES [dbo].[TipoEspecialidad] ([IdEspecialidad])
GO
ALTER TABLE [dbo].[Mecanico] CHECK CONSTRAINT [FK_TipoEspecialidad_TO_Mecanico]
GO

ALTER TABLE [dbo].[Orden]  WITH CHECK ADD  CONSTRAINT [FK_Administrador_TO_Orden] FOREIGN KEY([IdAdministrador])
REFERENCES [dbo].[Administrador] ([IdAdministrador])
GO
ALTER TABLE [dbo].[Orden] CHECK CONSTRAINT [FK_Administrador_TO_Orden]
GO

ALTER TABLE [dbo].[Orden]  WITH CHECK ADD  CONSTRAINT [FK_Mecanico_TO_Orden] FOREIGN KEY([IdMecanico])
REFERENCES [dbo].[Mecanico] ([IdMecanico])
GO
ALTER TABLE [dbo].[Orden] CHECK CONSTRAINT [FK_Mecanico_TO_Orden]
GO

ALTER TABLE [dbo].[Orden]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculo_TO_Orden] FOREIGN KEY([IdVehiculo])
REFERENCES [dbo].[Vehiculo] ([IdVehiculo])
GO
ALTER TABLE [dbo].[Orden] CHECK CONSTRAINT [FK_Vehiculo_TO_Orden]
GO

ALTER TABLE [dbo].[Vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_TO_Vehiculo] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([IdCliente])
GO
ALTER TABLE [dbo].[Vehiculo] CHECK CONSTRAINT [FK_Cliente_TO_Vehiculo]
GO

ALTER TABLE [dbo].[Vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_Marca_TO_Vehiculo] FOREIGN KEY([IdMarca])
REFERENCES [dbo].[Marca] ([IdMarca])
GO
ALTER TABLE [dbo].[Vehiculo] CHECK CONSTRAINT [FK_Marca_TO_Vehiculo]
GO

ALTER TABLE [dbo].[Vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_TipoVehiculo_TO_Vehiculo] FOREIGN KEY([IdTipoVehiculo])
REFERENCES [dbo].[TipoVehiculo] ([IdTipoVehiculo])
GO
ALTER TABLE [dbo].[Vehiculo] CHECK CONSTRAINT [FK_TipoVehiculo_TO_Vehiculo]
GO

INSERT INTO [dbo].[Administrador] ([Nombre], [Apellido], [Dni], [Email], [Telefono], [Contraseña], [Estado], [Eliminado])
VALUES ('admin', 'Principal', '70000001', 'admin@taller.com', '999999991', 'admin123', 'Activo', 0);

INSERT INTO [dbo].[Provincia] ([NombreProvincia], [Eliminado]) VALUES 
('Lima', 0),
('Callao', 0);

INSERT INTO [dbo].[Distrito] ([NombreDistrito], [IdProvincia], [Eliminado]) VALUES 
('Miraflores', 1, 0),
('San Isidro', 1, 0),
('Santiago de Surco', 1, 0),
('Bellavista', 2, 0);

INSERT INTO [dbo].[TipoVehiculo] ([NombreTipoVehiculo], [Eliminado]) VALUES 
('Sedán', 0),
('Camioneta SUV', 0),
('Hatchback', 0);

INSERT INTO [dbo].[Marca] ([NombreMarca], [Eliminado]) VALUES 
('Toyota', 0),
('Hyundai', 0),
('Nissan', 0),
('Honda', 0);

INSERT INTO [dbo].[TipoEspecialidad] ([NombreEspecialidad], [Eliminado]) VALUES 
('Mecánica General', 0),
('Sistema Eléctrico', 0),
('Frenos y Suspensión', 0);

INSERT INTO [dbo].[Mecanico] ([Nombre], [Apellido], [Dni], [Email], [Telefono], [IdEspecialidad], [Estado], [Eliminado]) VALUES 
('Carlos', 'Mendoza', '45871236', 'cmendoza@taller.com', '987654321', 1, 'Activo', 0),
('Jorge', 'Salazar', '41258963', 'jsalazar@taller.com', '974125896', 2, 'Activo', 0);

INSERT INTO [dbo].[Cliente] ([Nombre], [Apellido], [Dni], [Telefono], [Email], [Direccion], [TipoCliente], [Estado], [Eliminado], [IdDistrito]) VALUES 
('Juan', 'Pérez', '72345678', '965874123', 'jperez@gmail.com', 'Av. Benavides 1234', 'Persona Natural', 'Activo', 0, 1);

INSERT INTO [dbo].[Vehiculo] ([Año], [Color], [Placa], [Estado], [Eliminado], [IdTipoVehiculo], [IdMarca], [IdCliente]) VALUES 
(2021, 'Gris Metálico', 'ABC-123', 'Activo', 0, 1, 1, 1);

INSERT INTO [dbo].[Orden] ([FechaIngreso], [FechaSalida], [DescripcionServicio], [CostoTotal], [TipoServicio], [IdVehiculo], [IdAdministrador], [IdMecanico], [Estado], [Eliminado]) VALUES 
(GETDATE(), DATEADD(day, 2, GETDATE()), 'Mantenimiento preventivo 10k km', 350.00, 'Mantenimiento', 1, 1, 1, 'En Proceso', 0);
GO
```

---

### Paso 2. Ajustar la Cadena de Conexión en Visual Studio

1. Abre la solución **`SamTallerAutomotriz.sln`** en Visual Studio.
2. En el panel **Explorador de soluciones**, abre el archivo **`App.config`** ubicado dentro del proyecto **`Presentacion`** y en **`Datos`**.
3. En la sección `<connectionStrings>`, ajusta el parámetro `Data Source` con el nombre de tu servidor o instancia local de SQL Server:

```xml
<connectionStrings>
  <add name="BDEFEntities" 
       connectionString="metadata=res://*/ModelEF.csdl|res://*/ModelEF.ssdl|res://*/ModelEF.msl;provider=System.Data.SqlClient;provider connection string=&quot;Data Source=.;Initial Catalog=dbSamTallerAutomotriz;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" 
       providerName="System.Data.EntityClient" />
</connectionStrings>
```

> **Valores estándar según tu instalación:**
> * Instancia local por defecto: `Data Source=.` o `Data Source=localhost`
> * SQL Server Express: `Data Source=.\SQLEXPRESS`
> * Instancia nombrada de equipo: `Data Source=NOMBRE-DE-TU-EQUIPO`

---

### Paso 3. Compilar y Ejecutar

1. En el panel **Explorador de soluciones**, haz clic derecho sobre el proyecto **`Presentacion`** y selecciona **Establecer como proyecto de inicio** (el nombre debe quedar resaltado en negrita).
2. En el menú superior de Visual Studio, dirígete a **Compilar > Recompilar solución**.
3. Verifica en la barra inferior que la compilación concluya con **0 errores**.
4. Presiona la tecla **`F5`** (o el botón verde **Iniciar**) para abrir la aplicación.

---

## Credenciales de Acceso

El script de base de datos incluye un usuario administrador listo para usar[cite: 1]:

| Rol | Usuario | Contraseña |
| :--- | :--- | :--- |
| **Administrador** | `admin`[cite: 1] | `admin123`[cite: 1] |

*(También puedes registrar un usuario nuevo en cualquier momento desde la pantalla de login mediante la opción "¿No tiene una cuenta de administrador? créela haciendo clic aquí").*

---

## Estructura del Proyecto

* **`Presentacion`:** Interfaz gráfica construida con Windows Forms, validaciones de formularios y archivo de ejecución `App.config`.
* **`Negocio`:** Capa de lógica del dominio, aplicación de reglas operativas del taller y validaciones previas al guardado.
* **`Datos`:** Mapeo relacional con Entity Framework (`ModelEF.edmx`), clases de persistencia y consultas CRUD a la base de datos SQL Server[cite: 1].
