create table Datos_Clientes
(
	dni			numeric(18,0) primary key,	
	nombre		nvarchar(255),
	apellido	nvarchar(255),
	direccion	nvarchar(255),
	telefono	numeric(18,0),
	mail		nvarchar(255),
	fecha_nac   datetime,
	ciudad      nvarchar(255)

)

create table Datos_Proveedores (

	provee_cuit nvarchar(20) PRIMARY KEY,
	provee_rs nvarchar(100),
	provee_dom nvarchar(100),
	provee_ciudad nvarchar(255),
	provee_telefono numeric(18,0),
	provee_rubro nvarchar(100)
)

create table Factura (

	factura_nro numeric(18,0) PRIMARY KEY,
	factura_fecha datetime,
	fecha_inicio_periodo datetime,
	fecha_fin_periodo datetime,
	FOREIGN KEY (provee_cuit) references Datos_Proveedores(provee_cuit),
	FOREIGN KEY (prov_rs) references Datos_Proveedores(provee_rs)

)