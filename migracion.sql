USE [GD2C2012]
GO
/****** Object:  Schema [gd_esquema]    Script Date: 04/15/2012 01:58:54 ******/
CREATE SCHEMA [MR_ANDERSON] AUTHORIZATION [gd]
GO
--Creacion de tablas

begin transaction trn_creacion_tablas

	create table MR_ANDERSON.Datos_Clientes
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

	create table MR_ANDERSON.Cupones
	(
		codigo 			 nvarchar(50) primary key,
		precio			 numeric(18,2),
		precio_fict 	 numeric(18,2),
		cantidad	     numeric(18,0),
		descripcion	     nvarchar(255)		
	)


	create table MR_ANDERSON.Cupones_Transacciones
	(
		codigo 			 nvarchar(50),
		fecha 			 datetime,
		fecha_venc 		 datetime,
		fecha_compra	 datetime,
		fecha_devolucion datetime,
		fecha_entregado  datetime,

		foreign key (codigo) references MR_ANDERSON.Cupones(codigo)

	)


	create table MR_ANDERSON.Giftcard
	(
		fecha 		datetime,
		monto		numeric(18,2),
		cliente_origen numeric(18,0) constraint dni1 foreign key  references MR_ANDERSON.Datos_Clientes(dni),
		cliente_destino numeric(18,0) constraint dni2 foreign key  references MR_ANDERSON.Datos_Clientes(dni)

	)

	create table MR_ANDERSON.Cargas
	(
		dni numeric(18,0),
		carga_credito numeric(18,2),
		carga_fecha datetime,

		foreign key (dni) references MR_ANDERSON.Datos_Clientes(dni)
	)

	create table MR_ANDERSON.Datos_Proveedores (

		provee_cuit nvarchar(20),
		provee_rs nvarchar(100),
		provee_dom nvarchar(100),
		provee_ciudad nvarchar(255),
		provee_telefono numeric(18,0),
		provee_rubro nvarchar(100),
		primary key(provee_cuit,provee_rs)
	)

	create table MR_ANDERSON.Factura (

		factura_nro numeric(18,0) PRIMARY KEY,
		factura_fecha datetime,
		fecha_inicio_periodo datetime,
		fecha_fin_periodo datetime,
		provee_cuit nvarchar(20),
		provee_rs nvarchar(100),
		FOREIGN KEY (provee_cuit,provee_rs) references MR_ANDERSON.Datos_Proveedores(provee_cuit,provee_rs)
	)

	create table MR_ANDERSON.Renglon_Factura (

		factura_nro numeric(18,0),
		cupon nvarchar(50),
		FOREIGN KEY (factura_nro) references MR_ANDERSON.Factura(factura_nro),
		FOREIGN KEY (cupon) references MR_ANDERSON.Cupones(codigo),
		cantidad numeric(18,0)

	)

	create table MR_ANDERSON.Credito (

		cli_dni numeric(18,0) PRIMARY KEY,
		valor_credito numeric(18,2),
		fecha_ultima_cargada datetime

	)


	create table MR_ANDERSON.Login (

		username nvarchar(20) PRIMARY KEY,
		user_password nvarchar(255),
		lastlogin datetime,
		rol_asignado numeric(18,0),
		intentos_fallidos numeric(18,0),
		inhabilitado bit,

	)

commit transaction trn_creacion_tablas

--- Termina la creacion de tablas, arranca el relleno 	de datos


begin tran trn_inserts_tablas

	insert into MR_ANDERSON.Datos_Clientes (dni, nombre, apellido, direccion, telefono, mail, fecha_nac, ciudad)
		
		select distinct master.Cli_Dni, master.Cli_Nombre, master.Cli_Apellido, 
			   master.Cli_Direccion, master.Cli_Telefono, master.Cli_Mail, master.Cli_Fecha_Nac, master.Cli_Ciudad
			from gd_esquema.Maestra master 


	insert into MR_ANDERSON.Cupones(codigo, precio, precio_fict, cantidad, descripcion)
		
		select distinct master.Groupon_Codigo, master.Groupon_Precio, master.Groupon_Precio_Ficticio,
				master.Groupon_Cantidad, master.Groupon_Descripcion
			from gd_esquema.Maestra master
			where master.Groupon_Codigo is not null


	insert into MR_ANDERSON.Cupones_Transacciones(codigo,fecha,fecha_venc,
									  fecha_compra,fecha_devolucion,fecha_entregado)
			select master.Groupon_Codigo,master.Groupon_Fecha,
			 	   master.Groupon_Fecha_Venc, master.Groupon_Fecha_Compra,
			 	   master.Groupon_Devolucion_Fecha, master.Groupon_Entregado_Fecha
				from gd_esquema.Maestra master
				

	insert into MR_ANDERSON.Giftcard(fecha, monto, cliente_origen,cliente_destino)

		select master.GiftCard_Fecha, master.GiftCard_Monto,
		 		master.Cli_Dni, master.Cli_Dest_Dni
			from gd_esquema.Maestra master

			where master.Cli_Dest_Dni is not null and master.Cli_Dni is not null



	insert into MR_ANDERSON.Datos_Proveedores(provee_cuit,provee_rs,provee_dom,provee_ciudad,provee_telefono,provee_rubro)
		select distinct master.Provee_CUIT,master.Provee_RS,master.Provee_Dom,master.Provee_Ciudad,master.Provee_Telefono,master.Provee_Rubro
		from gd_esquema.Maestra master
		where master.Provee_CUIT is not null


	insert into MR_ANDERSON.Cargas(dni,carga_credito,carga_fecha)
		select master.Cli_Dni,master.carga_credito,master.carga_fecha
		from gd_esquema.Maestra master
		where master.Cli_Dni is not null and master.carga_credito is not null and master.carga_fecha is not null
		
	-- Insertamos el administrador a la tabla de Login (pass: gdadmin2012)
	insert into MR_ANDERSON.Login(username,user_password,lastlogin,rol_asignado,intentos_fallidos,inhabilitado) 
		VALUES('administrador','914B8A5A8AD525437A7723C688AED4E72E7F7893184BF087C6E91C93E102891B',NULL,1,NULL,0)

--Testing (FALTA)

	--insert into MR_ANDERSON.Credito(cli_dni,valor_credito,fecha_ultima_cargada)
		--select master.Cli_Dni

	--insert into MR_ANDERSON.Factura()
	--	select TOP 100 Factura_Nro, Factura_Fecha, Groupon_Fecha_Compra, Provee_RS, Provee_CUIT
	--from gd_esquema.Maestra
	--where Factura_Nro is not null and Factura_Fecha is not null
	--order by Factura_Nro

	--insert into MR_ANDERSON.Renglon_Factura()

	--insert into MR_ANDERSON.login()

commit tran trn_inserts_tablas