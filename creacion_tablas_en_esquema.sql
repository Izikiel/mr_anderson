
---Creacion de modelo de datos
/* ---------------------------------------------------------------------- */
/* Tables                                                                 */
/* ---------------------------------------------------------------------- */

/* ---------------------------------------------------------------------- */
/* Add table "Roles"                                                      */
/* ---------------------------------------------------------------------- */
CREATE SCHEMA [MR_ANDERSON] AUTHORIZATION [gd]

    CREATE TABLE [Roles] (
        [Rol] NVARCHAR(255) NOT NULL,
        [Habilitado] BIT NOT NULL,
        CONSTRAINT [PK_Roles] PRIMARY KEY ([Rol])
    )
    


    /* ---------------------------------------------------------------------- */
    /* Add table "Funcionalidades_Roles"                                      */
    /* ---------------------------------------------------------------------- */

    CREATE TABLE [Funcionalidades_Roles] (
        [Funcionalidad] VARCHAR(40) NOT NULL,
        [Rol] NVARCHAR(255) NOT NULL
    )
    


    /* ---------------------------------------------------------------------- */
    /* Add table "Login"                                                      */
    /* ---------------------------------------------------------------------- */

    CREATE TABLE [Login] (
        [username] NVARCHAR(100) NOT NULL,
        [user_password] NVARCHAR(255) ,
        [last_login] DATETIME ,
        [intentos_fallidos] NUMERIC(3) NOT NULL,
        [inhabilitado] BIT NOT NULL,
        [Rol] NVARCHAR(255) NOT NULL,
        CONSTRAINT [PK_Login] PRIMARY KEY ([username])
    )
    


    /* ---------------------------------------------------------------------- */
    /* Add table "Direccion"                                                  */
    /* ---------------------------------------------------------------------- */

    CREATE TABLE [Direccion] (
        [calle] NVARCHAR(100) NOT NULL,
        [nro_piso] NUMERIC(3),
        [depto] NVARCHAR(40),
        [localidad] NVARCHAR(100) NOT NULL,
        [username] NVARCHAR(100) NOT NULL,
        CONSTRAINT [PK_Direccion] PRIMARY KEY ([calle], [localidad],[username])
    )
    


    /* ---------------------------------------------------------------------- */
    /* Add table "Datos_Clientes"                                             */
    /* ---------------------------------------------------------------------- */

    CREATE TABLE [Datos_Clientes] (
        [nombre] NVARCHAR(255) NOT NULL,
        [dni] NUMERIC(18) NOT NULL,
        [apellido] NVARCHAR(255) NOT NULL,
        [telefono] NUMERIC(18) unique NOT NULL,
        [mail] NVARCHAR(255) NOT NULL,
        [fecha_nac] DATETIME NOT NULL,
        [username] NVARCHAR(100) NOT NULL,
        CONSTRAINT [dni] PRIMARY KEY ([dni])
    )
    


    /* ---------------------------------------------------------------------- */
    /* Add table "Cliente_Origen"                                             */
    /* ---------------------------------------------------------------------- */

    CREATE TABLE [Cliente_Origen] (
        [dni] NUMERIC(18) NOT NULL,
        CONSTRAINT [PK_Cliente_Origen] PRIMARY KEY ([dni])
    )
    


    /* ---------------------------------------------------------------------- */
    /* Add table "Cliente_Destino"                                            */
    /* ---------------------------------------------------------------------- */

    CREATE TABLE [Cliente_Destino] (
        [dni] NUMERIC(18) NOT NULL,
        CONSTRAINT [PK_Cliente_Destino] PRIMARY KEY ([dni])
    )
    


    /* ---------------------------------------------------------------------- */
    /* Add table "Cargas"                                                     */
    /* ---------------------------------------------------------------------- */

    CREATE TABLE [Cargas] (
        [monto] NUMERIC(18,2) NOT NULL,
        [fecha] DATETIME NOT NULL,
        [dni] NUMERIC(18) NOT NULL,
        [tipo_pago] VARCHAR(40) NOT NULL
    )
    


    /* ---------------------------------------------------------------------- */
    /* Add table "Datos_Proveedores"                                          */
    /* ---------------------------------------------------------------------- */

    CREATE TABLE [Datos_Proveedores] (
        [provee_cuit] NVARCHAR(20) NOT NULL,
        [provee_rs] NVARCHAR(100) NOT NULL,
        [provee_telefono] NUMERIC(18) NOT NULL,
        [provee_rubro] NVARCHAR(100) NOT NULL,
        [username] NVARCHAR(100) NOT NULL,
        [nombre_contacto] VARCHAR(40),
        [provee_email] NVARCHAR(255),
        CONSTRAINT [PK_Datos_Proveedores] PRIMARY KEY ([provee_cuit], [provee_rs])
    )
    


    /* ---------------------------------------------------------------------- */
    /* Add table "Factura"                                                    */
    /* ---------------------------------------------------------------------- */

    CREATE TABLE [Factura] (
        [factura_nro] NUMERIC(18) NOT NULL,
        [factura_fecha] DATETIME NOT NULL,
        [provee_cuit] NVARCHAR(20),
        [provee_rs] NVARCHAR(100),
        CONSTRAINT [PK_Factura] PRIMARY KEY ([factura_nro])
    )
    


    /* ---------------------------------------------------------------------- */
    /* Add table "Datos_Tarjeta"                                              */
    /* ---------------------------------------------------------------------- */

    CREATE TABLE [Datos_Tarjeta] (
        [nro_tarjeta] NUMERIC(30) NOT NULL,
        [fecha_emision] DATETIME NOT NULL,
        [fecha_vencimiento] DATETIME NOT NULL,
        [dni] NUMERIC(18),
        PRIMARY KEY ([nro_tarjeta])
    )
    


    /* ---------------------------------------------------------------------- */
    /* Add table "Cupones"                                                    */
    /* ---------------------------------------------------------------------- */

    CREATE TABLE [Cupones] (
        [codigo] NVARCHAR(50) NOT NULL,
        [precio] NUMERIC(18,2) NOT NULL,
        [precio_fict] NUMERIC(18,2) NOT NULL,
        [cantidad_x_usuario] NUMERIC(18) NOT NULL,
        [descripcion] NVARCHAR(255) NOT NULL,
        [stock_disponible] VARCHAR(40) NOT NULL,
        [provee_cuit] NVARCHAR(20) NOT NULL,
        [provee_rs] NVARCHAR(100) NOT NULL,
        [vencimiento_oferta] DATETIME NOT NULL,
        [vencimiento_canje] VARCHAR(40),
        [fecha_publicacion] DATETIME NOT NULL,
        CONSTRAINT [codigo] PRIMARY KEY ([codigo])
    )
    


    /* ---------------------------------------------------------------------- */
    /* Add table "Giftcard"                                                   */
    /* ---------------------------------------------------------------------- */

    CREATE TABLE [Giftcard] (
        [fecha] DATETIME NOT NULL,
        [monto] NUMERIC(18,2) NOT NULL,
        [cliente_origen] NUMERIC(18) NOT NULL,
        [cliente_destino] NUMERIC(18) NOT NULL
    )
    


    /* ---------------------------------------------------------------------- */
    /* Add table "Factura_Renglon"                                            */
    /* ---------------------------------------------------------------------- */

    CREATE TABLE [Factura_Renglon] (
        [cantidad] NUMERIC(18),
        [factura_nro] NUMERIC(18) NOT NULL,
        [codigo] NVARCHAR(50) NOT NULL,
        CONSTRAINT [PK_Factura_Renglon] PRIMARY KEY ([factura_nro], [codigo])
    )
    


    /* ---------------------------------------------------------------------- */
    /* Add table "Ciudades"                                                   */
    /* ---------------------------------------------------------------------- */

    CREATE TABLE [Ciudades] (
        [ciudad] NVARCHAR(255),
        [dni] NUMERIC(18) NOT NULL,
        [codigo] NVARCHAR(50)
    )
    


    /* ---------------------------------------------------------------------- */
    /* Add table "Compras"                                                    */
    /* ---------------------------------------------------------------------- */

    CREATE TABLE [Compras] (
        [dni] NUMERIC NOT NULL,
        [cantidad] NUMERIC(10) NOT NULL,
        [fecha] DATETIME NOT NULL,
        [codigo] NVARCHAR(50)
    )
    


    /* ---------------------------------------------------------------------- */
    /* Add table "Devoluciones"                                               */
    /* ---------------------------------------------------------------------- */

    CREATE TABLE [Devoluciones] (
        [fecha_devolucion] DATETIME NOT NULL,
        [dni] NUMERIC(18) NOT NULL,
        [codigo] NVARCHAR(50) NOT NULL,
        [motivo] NVARCHAR(255) NOT NULL
    )
    


    /* ---------------------------------------------------------------------- */
    /* Add table "Consumos"                                                   */
    /* ---------------------------------------------------------------------- */

    CREATE TABLE [Consumos] (
        [fecha_consumo] DATETIME NOT NULL,
        [codigo] NVARCHAR(50),
        [dni] NUMERIC(18)
    )
    

GO

    /* ---------------------------------------------------------------------- */
    /* Foreign key constraints                                                */
    /* ---------------------------------------------------------------------- */

    ALTER TABLE [MR_ANDERSON].[Datos_Clientes] ADD CONSTRAINT [Login_Datos_Clientes] 
        FOREIGN KEY ([username]) REFERENCES [MR_ANDERSON].[Login] ([username])
    


    ALTER TABLE [MR_ANDERSON].[Cupones] ADD CONSTRAINT [Datos_Proveedores_Cupones] 
        FOREIGN KEY ([provee_cuit], [provee_rs]) REFERENCES [MR_ANDERSON].[Datos_Proveedores] ([provee_cuit],[provee_rs])
    


    ALTER TABLE [MR_ANDERSON].[Giftcard] ADD CONSTRAINT [Cliente_Destino_Giftcard] 
        FOREIGN KEY ([cliente_destino]) REFERENCES [MR_ANDERSON].[Cliente_Destino] ([dni])
    


    ALTER TABLE [MR_ANDERSON].[Giftcard] ADD CONSTRAINT [Cliente_Origen_Giftcard] 
        FOREIGN KEY ([cliente_origen]) REFERENCES [MR_ANDERSON].[Cliente_Origen] ([dni])
    


    ALTER TABLE [MR_ANDERSON].[Cliente_Origen] ADD CONSTRAINT [Datos_Clientes_Cliente_Origen] 
        FOREIGN KEY ([dni]) REFERENCES [MR_ANDERSON].[Datos_Clientes] ([dni])
    


    ALTER TABLE [MR_ANDERSON].[Cliente_Destino] ADD CONSTRAINT [Datos_Clientes_Cliente_Destino] 
        FOREIGN KEY ([dni]) REFERENCES [MR_ANDERSON].[Datos_Clientes] ([dni])
    


    ALTER TABLE [MR_ANDERSON].[Cargas] ADD CONSTRAINT [Datos_Clientes_Cargas] 
        FOREIGN KEY ([dni]) REFERENCES [MR_ANDERSON].[Datos_Clientes] ([dni])
    


    ALTER TABLE [MR_ANDERSON].[Datos_Proveedores] ADD CONSTRAINT [Login_Datos_Proveedores] 
        FOREIGN KEY ([username]) REFERENCES [MR_ANDERSON].[Login] ([username])
    


    ALTER TABLE [MR_ANDERSON].[Factura] ADD CONSTRAINT [Datos_Proveedores_Factura] 
        FOREIGN KEY ([provee_cuit], [provee_rs]) REFERENCES [MR_ANDERSON].[Datos_Proveedores] ([provee_cuit],[provee_rs])
    


    ALTER TABLE [MR_ANDERSON].[Factura_Renglon] ADD CONSTRAINT [Factura_Factura_Renglon] 
        FOREIGN KEY ([factura_nro]) REFERENCES [MR_ANDERSON].[Factura] ([factura_nro])
    


    ALTER TABLE [MR_ANDERSON].[Factura_Renglon] ADD CONSTRAINT [Cupones_Factura_Renglon] 
        FOREIGN KEY ([codigo]) REFERENCES [MR_ANDERSON].[Cupones] ([codigo])
    


    ALTER TABLE [MR_ANDERSON].[Funcionalidades_Roles] ADD CONSTRAINT [Roles_Funcionalidades_Roles] 
        FOREIGN KEY ([Rol]) REFERENCES [MR_ANDERSON].[Roles] ([Rol])
    


    ALTER TABLE [MR_ANDERSON].[Login] ADD CONSTRAINT [Roles_Login] 
        FOREIGN KEY ([Rol]) REFERENCES [MR_ANDERSON].[Roles] ([Rol])
    


    ALTER TABLE [MR_ANDERSON].[Ciudades] ADD CONSTRAINT [Datos_Clientes_Ciudades] 
        FOREIGN KEY ([dni]) REFERENCES [MR_ANDERSON].[Datos_Clientes] ([dni])
    


    ALTER TABLE [MR_ANDERSON].[Ciudades] ADD CONSTRAINT [Cupones_Ciudades] 
        FOREIGN KEY ([codigo]) REFERENCES [MR_ANDERSON].[Cupones] ([codigo])
    


    ALTER TABLE [MR_ANDERSON].[Direccion] ADD CONSTRAINT [Login_Direccion] 
        FOREIGN KEY ([username]) REFERENCES [MR_ANDERSON].[Login] ([username])
    


    ALTER TABLE [MR_ANDERSON].[Datos_Tarjeta] ADD CONSTRAINT [Datos_Clientes_Datos_Tarjeta] 
        FOREIGN KEY ([dni]) REFERENCES [MR_ANDERSON].[Datos_Clientes] ([dni])
    


    ALTER TABLE [MR_ANDERSON].[Compras] ADD CONSTRAINT [Datos_Clientes_Compras] 
        FOREIGN KEY ([dni]) REFERENCES [MR_ANDERSON].[Datos_Clientes] ([dni])
    


    ALTER TABLE [MR_ANDERSON].[Compras] ADD CONSTRAINT [Cupones_Compras] 
        FOREIGN KEY ([codigo]) REFERENCES [MR_ANDERSON].[Cupones] ([codigo])
    


    ALTER TABLE [MR_ANDERSON].[Devoluciones] ADD CONSTRAINT [Datos_Clientes_Devoluciones] 
        FOREIGN KEY ([dni]) REFERENCES [MR_ANDERSON].[Datos_Clientes] ([dni])
    


    ALTER TABLE [MR_ANDERSON].[Devoluciones] ADD CONSTRAINT [Cupones_Devoluciones] 
        FOREIGN KEY ([codigo]) REFERENCES [MR_ANDERSON].[Cupones] ([codigo])
    


    ALTER TABLE [MR_ANDERSON].[Consumos] ADD CONSTRAINT [Cupones_Consumos] 
        FOREIGN KEY ([codigo]) REFERENCES [MR_ANDERSON].[Cupones] ([codigo])
    


    ALTER TABLE [MR_ANDERSON].[Consumos] ADD CONSTRAINT [Datos_Clientes_Consumos] 
        FOREIGN KEY ([dni]) REFERENCES [MR_ANDERSON].[Datos_Clientes] ([dni])
    


--Migracion de Datos 

begin tran trn_inserts_tablas
        
        insert into MR_ANDERSON.Roles(Rol,Habilitado)
            values('Admin',1)

        insert into MR_ANDERSON.Roles(Rol,Habilitado)
            values('Cliente',1)

        insert into MR_ANDERSON.Roles(Rol,Habilitado)
            values('Proveedor',1)
			
		-- Insertamos el administrador a la tabla de Login (pass: gdadmin2012)	
		insert into MR_ANDERSON.Login(username,user_password,last_login,intentos_fallidos,inhabilitado,Rol) 
			VALUES('administrador','914B8A5A8AD525437A7723C688AED4E72E7F7893184BF087C6E91C93E102891B',NULL,0,0,'Admin')
		
		-- Insertamos los datos de los clientes al Login
        insert into MR_ANDERSON.Login(username,user_password,last_login,intentos_fallidos,inhabilitado,Rol)

            select distinct master.Cli_Dni, NULL,NULL,0,0,'Cliente' 
                from gd_esquema.Maestra master

		-- Insertamos los datos de los proveedores al Login
        insert into MR_ANDERSON.Login(username,user_password,last_login,intentos_fallidos,inhabilitado,Rol)

            select distinct master.Provee_CUIT,NULL,NULL,0,0,'Proveedor' 
                from gd_esquema.Maestra master 
                where master.Provee_CUIT is not NULL


        insert into MR_ANDERSON.Datos_Clientes (dni, nombre, apellido,  telefono, mail, fecha_nac, username )
        
            select distinct master.Cli_Dni, master.Cli_Nombre, master.Cli_Apellido,
                            master.Cli_Telefono, master.Cli_Mail, master.Cli_Fecha_Nac,cast(master.Cli_Dni as NVARCHAR)
                from gd_esquema.Maestra master 

        insert into MR_ANDERSON.Direccion(calle,nro_piso,depto,localidad,username)

            select master.Cli_Direccion,NULL,NULL,master.Cli_Ciudad, cast(Clientes.dni as NVARCHAR)
                from gd_esquema.Maestra master
                join MR_ANDERSON.Datos_Clientes Clientes
                    on   master.Cli_Dni = Clientes.dni
                
                group by master.Cli_Direccion,master.Cli_Ciudad, Clientes.dni


        insert into MR_ANDERSON.Cliente_Origen(dni)

            select distinct master.Cli_Dni 
                from gd_esquema.Maestra master
                where master.Cli_Dni is not NULL

        insert into MR_ANDERSON.Cliente_Destino(dni)

            select distinct master.Cli_Dest_Dni 
                from gd_esquema.Maestra master
                where master.Cli_Dest_Dni is not NULL


        insert into MR_ANDERSON.Giftcard(fecha,monto,cliente_origen,cliente_destino)

            select master.Giftcard_Fecha, master.Giftcard_Monto, master.Cli_Dni, master.Cli_Dest_Dni 
                from gd_esquema.Maestra master

                join MR_ANDERSON.Cliente_Origen origen
                    on   master.Cli_Dni = origen.dni
                
                join MR_ANDERSON.Cliente_Destino destino
                    on   master.Cli_Dest_Dni = destino.dni

        insert into MR_ANDERSON.Cargas(monto,fecha,dni,tipo_pago)

            select master.Carga_Credito, master.Carga_Fecha,master.Cli_Dni, master.Tipo_Pago_Desc 
                from gd_esquema.Maestra master

                join MR_ANDERSON.Datos_Clientes Clientes
                    on   master.Cli_Dni = Clientes.dni
                
                where master.Carga_Credito is not NULL and master.Carga_Fecha is not NULL 
                    and master.Tipo_Pago_Desc is not NULL


        insert into MR_ANDERSON.Datos_Proveedores(provee_cuit,provee_rs,provee_telefono,provee_rubro,username,nombre_contacto,provee_email)

            select master.Provee_CUIT,master.Provee_RS,master.Provee_Telefono,master.Provee_Rubro,
                cast(master.Provee_CUIT as NVARCHAR), NULL,NULL
                from gd_esquema.Maestra master

                group by master.Provee_CUIT,master.Provee_RS,master.Provee_Telefono,master.Provee_Rubro

                having master.Provee_CUIT is not NULL and master.Provee_RS is not null

        insert into MR_ANDERSON.Direccion(calle,nro_piso,depto,localidad,username)

            select master.Provee_Dom, null,null,master.Provee_Ciudad, cast(master.Provee_CUIT as NVARCHAR)  
                from gd_esquema.Maestra master

                join MR_ANDERSON.Datos_Proveedores Proveedores
                    on   master.Provee_CUIT = Proveedores.provee_cuit
                
                group by master.Provee_Dom, master.Provee_Ciudad, master.Provee_CUIT

        insert into MR_ANDERSON.Factura(factura_nro,factura_fecha,provee_cuit,provee_rs)

            select master.Factura_Nro,master.Factura_Fecha, master.Provee_CUIT,master.Provee_RS 
                from gd_esquema.Maestra master

                group by master.Factura_Nro,master.Factura_Fecha, master.Provee_CUIT,master.Provee_RS 
                having master.Factura_Nro is not null

        

                


commit tran trn_inserts_tablas