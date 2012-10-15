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

