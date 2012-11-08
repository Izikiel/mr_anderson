
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
        [Habilitado] BIT NOT NULL,
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
        [codigo_postal] NUMERIC(5),
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
        [saldo] NUMERIC(10,2) NOT NULL,
        CONSTRAINT [dni] PRIMARY KEY ([dni]),
        UNIQUE ([telefono])
    )
    


    /* ---------------------------------------------------------------------- */
    /* Add table "Cliente_Origen"                                             */
    /* ---------------------------------------------------------------------- */

    CREATE TABLE [Cliente_Origen] (
        [dni] NUMERIC(18) NOT NULL,
        [id_origen] NUMERIC IDENTITY(0,1) NOT NULL,
        CONSTRAINT [PK_Cliente_Origen] PRIMARY KEY ([id_origen])
    )
    


    /* ---------------------------------------------------------------------- */
    /* Add table "Cliente_Destino"                                            */
    /* ---------------------------------------------------------------------- */

    CREATE TABLE [Cliente_Destino] (
        [dni] NUMERIC(18) NOT NULL,
        [id_destino] NUMERIC IDENTITY(0,1) NOT NULL,
        CONSTRAINT [PK_Cliente_Destino] PRIMARY KEY ([id_destino])
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
        CONSTRAINT [PK_Datos_Proveedores] PRIMARY KEY ([provee_cuit])
    )
    


    /* ---------------------------------------------------------------------- */
    /* Add table "Factura"                                                    */
    /* ---------------------------------------------------------------------- */

    CREATE TABLE [Factura] (
        [factura_nro] NUMERIC(18) NOT NULL,
        [factura_fecha] DATETIME NOT NULL,
        [provee_cuit] NVARCHAR(20),
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
        [stock_disponible] NUMERIC(10) NOT NULL,
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
        [id_origen] NUMERIC NOT NULL,
        [id_destino] NUMERIC NOT NULL
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
        [dni] NUMERIC(18) ,
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
        [motivo] NVARCHAR(255),
        [cantidad] NUMERIC(10) NOT NULL
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
    GO


    ALTER TABLE [MR_ANDERSON].[Cupones] ADD CONSTRAINT [Datos_Proveedores_Cupones] 
        FOREIGN KEY ([provee_cuit]) REFERENCES [MR_ANDERSON].[Datos_Proveedores] ([provee_cuit]) on update cascade;
    GO


    ALTER TABLE [MR_ANDERSON].[Cliente_Origen] ADD CONSTRAINT [Datos_Clientes_Cliente_Origen] 
        FOREIGN KEY ([dni]) REFERENCES [MR_ANDERSON].[Datos_Clientes] ([dni]) on update cascade;
    GO

    ALTER TABLE [MR_ANDERSON].[Cliente_Destino] ADD CONSTRAINT [Datos_Clientes_Cliente_Destino] 
        FOREIGN KEY ([dni]) REFERENCES [MR_ANDERSON].[Datos_Clientes] ([dni]) on update cascade; 
    GO

    ALTER TABLE [MR_ANDERSON].[Giftcard] ADD CONSTRAINT [Cliente_Destino_Giftcard] 
        FOREIGN KEY ([id_destino]) REFERENCES [MR_ANDERSON].[Cliente_Destino] ([id_destino])
    GO

    ALTER TABLE [MR_ANDERSON].[Giftcard] ADD CONSTRAINT [Cliente_Origen_Giftcard] 
        FOREIGN KEY ([id_origen]) REFERENCES  [MR_ANDERSON].[Cliente_Origen] ([id_origen])
    GO

    ALTER TABLE [MR_ANDERSON].[Cargas] ADD CONSTRAINT [Datos_Clientes_Cargas] 
        FOREIGN KEY ([dni]) REFERENCES [MR_ANDERSON].[Datos_Clientes] ([dni]) on update cascade;
    GO


    ALTER TABLE [MR_ANDERSON].[Datos_Proveedores] ADD CONSTRAINT [Login_Datos_Proveedores] 
        FOREIGN KEY ([username]) REFERENCES [MR_ANDERSON].[Login] ([username])
    GO


    ALTER TABLE [MR_ANDERSON].[Factura] ADD CONSTRAINT [Datos_Proveedores_Factura] 
        FOREIGN KEY ([provee_cuit]) REFERENCES [MR_ANDERSON].[Datos_Proveedores] ([provee_cuit]) on update cascade;
    GO


    ALTER TABLE [MR_ANDERSON].[Factura_Renglon] ADD CONSTRAINT [Factura_Factura_Renglon] 
        FOREIGN KEY ([factura_nro]) REFERENCES [MR_ANDERSON].[Factura] ([factura_nro])
    GO


    ALTER TABLE [MR_ANDERSON].[Factura_Renglon] ADD CONSTRAINT [Cupones_Factura_Renglon] 
        FOREIGN KEY ([codigo]) REFERENCES [MR_ANDERSON].[Cupones] ([codigo])
    GO


    ALTER TABLE [MR_ANDERSON].[Funcionalidades_Roles] ADD CONSTRAINT [Roles_Funcionalidades_Roles] 
        FOREIGN KEY ([Rol]) REFERENCES [MR_ANDERSON].[Roles] ([Rol])
    GO


    ALTER TABLE [MR_ANDERSON].[Login] ADD CONSTRAINT [Roles_Login] 
        FOREIGN KEY ([Rol]) REFERENCES [MR_ANDERSON].[Roles] ([Rol])
    GO


    ALTER TABLE [MR_ANDERSON].[Ciudades] ADD CONSTRAINT [Datos_Clientes_Ciudades] 
        FOREIGN KEY ([dni]) REFERENCES [MR_ANDERSON].[Datos_Clientes] ([dni]) on update cascade;
    GO


    ALTER TABLE [MR_ANDERSON].[Ciudades] ADD CONSTRAINT [Cupones_Ciudades] 
        FOREIGN KEY ([codigo]) REFERENCES [MR_ANDERSON].[Cupones] ([codigo])
    GO


    ALTER TABLE [MR_ANDERSON].[Direccion] ADD CONSTRAINT [Login_Direccion] 
        FOREIGN KEY ([username]) REFERENCES [MR_ANDERSON].[Login] ([username])
    GO


    ALTER TABLE [MR_ANDERSON].[Datos_Tarjeta] ADD CONSTRAINT [Datos_Clientes_Datos_Tarjeta] 
        FOREIGN KEY ([dni]) REFERENCES [MR_ANDERSON].[Datos_Clientes] ([dni]) on update cascade;
    GO


    ALTER TABLE [MR_ANDERSON].[Compras] ADD CONSTRAINT [Datos_Clientes_Compras] 
        FOREIGN KEY ([dni]) REFERENCES [MR_ANDERSON].[Datos_Clientes] ([dni]) on update cascade;
    GO


    ALTER TABLE [MR_ANDERSON].[Compras] ADD CONSTRAINT [Cupones_Compras] 
        FOREIGN KEY ([codigo]) REFERENCES [MR_ANDERSON].[Cupones] ([codigo])
    GO


    ALTER TABLE [MR_ANDERSON].[Devoluciones] ADD CONSTRAINT [Datos_Clientes_Devoluciones] 
        FOREIGN KEY ([dni]) REFERENCES [MR_ANDERSON].[Datos_Clientes] ([dni]) on update cascade;
    GO


    ALTER TABLE [MR_ANDERSON].[Devoluciones] ADD CONSTRAINT [Cupones_Devoluciones] 
        FOREIGN KEY ([codigo]) REFERENCES [MR_ANDERSON].[Cupones] ([codigo])
    GO


    ALTER TABLE [MR_ANDERSON].[Consumos] ADD CONSTRAINT [Cupones_Consumos] 
        FOREIGN KEY ([codigo]) REFERENCES [MR_ANDERSON].[Cupones] ([codigo])
    GO


    ALTER TABLE [MR_ANDERSON].[Consumos] ADD CONSTRAINT [Datos_Clientes_Consumos] 
        FOREIGN KEY ([dni]) REFERENCES [MR_ANDERSON].[Datos_Clientes] ([dni]) on update cascade;
    GO
GO

--Migracion de Datos 

begin tran trn_inserts_tablas
        
        insert into MR_ANDERSON.Roles(Rol,Habilitado)
            values('Administrador',1)

        insert into MR_ANDERSON.Roles(Rol,Habilitado)
            values('Cliente',1)

        insert into MR_ANDERSON.Roles(Rol,Habilitado)
            values('Proveedor',1)
			
		-- Insertamos el administrador a la tabla de Login (pass: gdadmin2012)	
		insert into MR_ANDERSON.Login(username,user_password,last_login,intentos_fallidos,Habilitado,Rol) 
			VALUES('administrador','914B8A5A8AD525437A7723C688AED4E72E7F7893184BF087C6E91C93E102891B',NULL,0,1,'Administrador')
		
		-- Insertamos los datos de los clientes al Login
        insert into MR_ANDERSON.Login(username,user_password,last_login,intentos_fallidos,Habilitado,Rol)

            select distinct master.Cli_Dni, NULL,NULL,0,1,'Cliente' 
                from gd_esquema.Maestra master

		-- Insertamos los datos de los proveedores al Login
        insert into MR_ANDERSON.Login(username,user_password,last_login,intentos_fallidos,Habilitado,Rol)

            select distinct master.Provee_CUIT,NULL,NULL,0,1,'Proveedor' 
                from gd_esquema.Maestra master 
                where master.Provee_CUIT is not NULL

        --Insertamos los datos viejos de los clientes al modelo nuevo
        insert into MR_ANDERSON.Datos_Clientes (dni, nombre, apellido,  telefono, mail, fecha_nac, username, saldo )
        
            select distinct master.Cli_Dni, master.Cli_Nombre, master.Cli_Apellido,
                            master.Cli_Telefono, master.Cli_Mail, master.Cli_Fecha_Nac,cast(master.Cli_Dni as NVARCHAR), 0
                from gd_esquema.Maestra master 

        --Insertamos las direcciones de los clientes al modelo nuevo
        insert into MR_ANDERSON.Direccion(calle,nro_piso,depto,localidad,username)

            select master.Cli_Direccion,NULL,NULL,master.Cli_Ciudad, cast(Clientes.dni as NVARCHAR)
                from gd_esquema.Maestra master
                join MR_ANDERSON.Datos_Clientes Clientes
                    on   master.Cli_Dni = Clientes.dni
                
                group by master.Cli_Direccion,master.Cli_Ciudad, Clientes.dni

        --Insertamos los clientes que compraron alguna giftcard
        insert into MR_ANDERSON.Cliente_Origen(dni)

            select distinct master.Cli_Dni 
                from gd_esquema.Maestra master
                where master.Cli_Dni is not NULL

        --Insertamos los clientes que recibieron alguna giftcard
        insert into MR_ANDERSON.Cliente_Destino(dni)

            select distinct master.Cli_Dest_Dni 
                from gd_esquema.Maestra master
                where master.Cli_Dest_Dni is not NULL

        --Insertamos los datos de las giftcards
        insert into MR_ANDERSON.Giftcard(fecha,monto,id_origen,id_destino)

            select master.Giftcard_Fecha, master.Giftcard_Monto, origen.id_origen, destino.id_destino 
                from gd_esquema.Maestra master

                join MR_ANDERSON.Cliente_Origen origen
                    on   master.Cli_Dni = origen.dni
                
                join MR_ANDERSON.Cliente_Destino destino
                    on   master.Cli_Dest_Dni = destino.dni

        --Insertamos los datos de las cargas de los clientes
        insert into MR_ANDERSON.Cargas(monto,fecha,dni,tipo_pago)

            select master.Carga_Credito, master.Carga_Fecha,master.Cli_Dni, master.Tipo_Pago_Desc 
                from gd_esquema.Maestra master

                join MR_ANDERSON.Datos_Clientes Clientes
                    on   master.Cli_Dni = Clientes.dni
                
                where master.Carga_Credito is not NULL and master.Carga_Fecha is not NULL 
                    and master.Tipo_Pago_Desc is not NULL

        --Insertamos los datos de los proveedores
        insert into MR_ANDERSON.Datos_Proveedores(provee_cuit,provee_rs,provee_telefono,provee_rubro,username,nombre_contacto,provee_email)

            select master.Provee_CUIT,master.Provee_RS,master.Provee_Telefono,master.Provee_Rubro,
                cast(master.Provee_CUIT as NVARCHAR), NULL,NULL
                from gd_esquema.Maestra master

                group by master.Provee_CUIT,master.Provee_RS,master.Provee_Telefono,master.Provee_Rubro

                having master.Provee_CUIT is not NULL and master.Provee_RS is not null

        --Insertamos las direcciones de los proveedores
        insert into MR_ANDERSON.Direccion(calle,nro_piso,depto,localidad,username)

            select master.Provee_Dom, null,null,master.Provee_Ciudad, cast(master.Provee_CUIT as NVARCHAR)  
                from gd_esquema.Maestra master

                join MR_ANDERSON.Datos_Proveedores Proveedores
                    on   master.Provee_CUIT = Proveedores.provee_cuit
                
                group by master.Provee_Dom, master.Provee_Ciudad, master.Provee_CUIT


        insert into MR_ANDERSON.Cupones(codigo,precio,precio_fict,cantidad_x_usuario,descripcion,
                                        stock_disponible,provee_cuit,provee_rs,vencimiento_oferta,
                                        vencimiento_canje,fecha_publicacion)

            select master.Groupon_Codigo, master.Groupon_Precio, master.Groupon_Precio_Ficticio,
                    1, master.Groupon_Descripcion, master.Groupon_Cantidad,
                    master.Provee_CUIT, master.Provee_RS, master.Groupon_Fecha_Venc, NULL, master.Groupon_Fecha
                from gd_esquema.Maestra master

                join MR_ANDERSON.Datos_Proveedores Proveedores
                    on   master.Provee_CUIT = Proveedores.provee_cuit
                
                group by master.Groupon_Codigo, master.Groupon_Precio, master.Groupon_Precio_Ficticio,
                    master.Groupon_Cantidad, master.Groupon_Descripcion, master.Provee_CUIT, master.Provee_RS, 
                    master.Groupon_Fecha_Venc, master.Groupon_Fecha

                having master.Groupon_Fecha is not null

        insert into MR_ANDERSON.Devoluciones(fecha_devolucion,dni,codigo,motivo, cantidad)

            select master.Groupon_Devolucion_Fecha, master.Cli_Dni, master.Groupon_Codigo, NULL, 1 
                from gd_esquema.Maestra master

            join MR_ANDERSON.Datos_Clientes Clientes
                on   master.Cli_Dni = Clientes.dni
            
            join MR_ANDERSON.Cupones Cupones
                on   master.Groupon_Codigo = Cupones.codigo
            
            where master.Groupon_Devolucion_Fecha is not null

        insert into MR_ANDERSON.Compras(dni,cantidad,fecha,codigo)

            select  master.Cli_Dni, 1, master.Groupon_Fecha_Compra, master.Groupon_Codigo
                from gd_esquema.Maestra master
                
                join MR_ANDERSON.Datos_Clientes Clientes
                    on   master.Cli_Dni = Clientes.dni
                
                join MR_ANDERSON.Cupones Cupones
                    on   master.Groupon_Codigo = Cupones.codigo
                
                where master.Groupon_Fecha_Compra is not null

                group by master.Cli_Dni, master.Groupon_Fecha_Compra,
                    master.Groupon_Codigo

        GO

        Merge into MR_ANDERSON.Cupones
            using(
                    select Cupones.Codigo as codigo, sum(Devoluciones.cantidad) as stock    
                from MR_ANDERSON.Devoluciones

                 join MR_ANDERSON.Cupones Cupones
                    on   Devoluciones.codigo = Cupones.codigo
                    
                 group by Cupones.codigo
                 ) as source
                on MR_ANDERSON.Cupones.codigo = source.codigo
           when matched then
                update 
                    set MR_ANDERSON.Cupones.stock_disponible = MR_ANDERSON.Cupones.stock_disponible + source.stock;

        GO


        Merge into MR_ANDERSON.Cupones
            using(
                    select Cupones.Codigo as codigo, sum(Compras.cantidad) as out    
                from MR_ANDERSON.Compras

                 join MR_ANDERSON.Cupones Cupones
                    on   Compras.codigo = Cupones.codigo
                    
                 group by Cupones.codigo
                 ) as source
                on MR_ANDERSON.Cupones.codigo = source.codigo
           when matched then
                update 
                    set MR_ANDERSON.Cupones.stock_disponible = MR_ANDERSON.Cupones.stock_disponible - source.out;

        GO
            
        insert into MR_ANDERSON.Consumos(fecha_consumo, codigo, dni)

            select master.Groupon_Entregado_Fecha, master.Groupon_Codigo, master.Cli_Dni 
                from gd_esquema.Maestra master

                join MR_ANDERSON.Cupones Cupones
                    on   master.Groupon_Codigo = Cupones.codigo
                
                join MR_ANDERSON.Datos_Clientes Cliente
                    on   master.Cli_Dni = Cliente.dni
                
                where master.Groupon_Entregado_Fecha is not null

        insert into MR_ANDERSON.Factura(factura_nro,factura_fecha,provee_cuit)

            select master.Factura_Nro,master.Factura_Fecha, master.Provee_CUIT
                from gd_esquema.Maestra master

                group by master.Factura_Nro,master.Factura_Fecha, master.Provee_CUIT
                having master.Factura_Nro is not null

        insert into MR_ANDERSON.Factura_Renglon(cantidad,factura_nro,codigo)

            select sum(Compras.cantidad), master.Factura_Nro, master.Groupon_Codigo 
                from gd_esquema.Maestra master

                join MR_ANDERSON.Factura Factura
                    on   master.Factura_Nro = Factura.factura_nro
                
                join MR_ANDERSON.Cupones Cupones
                    on   master.Groupon_Codigo = Cupones.codigo 

                join MR_ANDERSON.Compras Compras
                    on   master.Groupon_Codigo = Compras.codigo

                group by master.Factura_Nro, master.Groupon_Codigo 
            
commit tran trn_inserts_tablas

GO

--ABM ROL !
/*
create trigger  actualizar_habilitaciones on MR_ANDERSON.Roles
    after
        update
    as
        begin
            if update(Habilitado)
                begin

                    declare @rol NVARCHAR(255)
                    declare @habilitado BIT
                    declare @my_fetch_status int
                    
                    declare roles_a_chequear cursor  
                    
                    for select Rol, Habilitado 
                        from inserted
                    
                    open roles_a_chequear
                    
                    fetch roles_a_chequear into @rol, @habilitado

                    set @my_fetch_status = @@FETCH_STATUS

                    while (@my_fetch_status = 0)
                    begin
                        
                        update MR_ANDERSON.Roles set Habilitado = @habilitado 
                            where Rol = @rol

                        update MR_ANDERSON.Login set Habilitado = @habilitado
                            where Rol = @rol and Habilitado = 1

                        fetch next from roles_a_chequear into @rol, @habilitado
                        set @my_fetch_status = @@FETCH_STATUS    
                    end
                    
                    close roles_a_chequear
                    deallocate roles_a_chequear

                                                             
                end
        end
GO
*/
create procedure MR_ANDERSON.sp_new_rol (@nombre_rol NVARCHAR(255) , @Funcionalidad VARCHAR(40))
    as
        begin
            if @nombre_rol not in (select Roles.Rol 
                from MR_ANDERSON.Roles Roles)
                begin
                    insert into MR_ANDERSON.Roles(Rol,Habilitado)
                        VALUES(@nombre_rol, 1)

                    insert into MR_ANDERSON.Funcionalidades_Roles(Rol,Funcionalidad)
                        VALUES(@nombre_rol, @Funcionalidad)
                end
            else 
                begin
                    raiserror('Este Rol ya existe!',1,1)
                end

        end
GO

create procedure MR_ANDERSON.sp_del_func_rol (@nombre_rol NVARCHAR(255), @Funcionalidad VARCHAR(40))        
    as
        begin
            delete from MR_ANDERSON.Funcionalidades_Roles 
                where Rol = @nombre_rol and Funcionalidad = @Funcionalidad
        end
GO

create procedure MR_ANDERSON.sp_add_func_rol (@nombre_rol NVARCHAR(255), @Funcionalidad VARCHAR(40))    
    as
        begin
            if not exists(select Rol,Funcionalidad 
                from MR_ANDERSON.Funcionalidades_Roles 
                where Rol = @nombre_rol and Funcionalidad = @Funcionalidad)
                
                begin
                    insert into MR_ANDERSON.Funcionalidades_Roles(Rol, Funcionalidad)
                        VALUES(@nombre_rol, @Funcionalidad)
                end

        end
GO

create procedure MR_ANDERSON.sp_change_status_rol (@nombre_rol NVARCHAR(255), @status BIT) --Usar para borrar/inhabilitar, habilitar
    as
        begin
            update MR_ANDERSON.Roles
                set Habilitado = @status
                where Rol = @nombre_rol

            update MR_ANDERSON.Login set Habilitado = @status
                where Rol = @nombre_rol and Habilitado = 1
        end
GO

create procedure MR_ANDERSON.sp_change_rol_name (@nombre_rol NVARCHAR(255), @nuevo_nombre_rol NVARCHAR(255))
    as
        begin
            update MR_ANDERSON.Roles
                set Rol = @nuevo_nombre_rol
                where Rol = @nombre_rol

            update MR_ANDERSON.Login 
                set Rol = @nuevo_nombre_rol
                where Rol = @nombre_rol
        end
GO


--Fin ABM ROL!

-- Login !

create procedure MR_ANDERSON.sp_login (@username_sended NVARCHAR(100) , @user_password_sended NVARCHAR(255), @result NVARCHAR(20) output)

    as
        begin

            if @username_sended is null
                begin
                    set @result = 'LOGIN_ERROR'
                    return 1
                end

            declare @check_password nvarchar(255)
            declare @check_habilitado bit
            declare @check_fallidos numeric(10)

            if (exists(select user_password from MR_ANDERSON.Login where username = @username_sended))

                begin
                    -- Seleccionamos el hash 'posta'
                    set @check_password = (select user_password from MR_ANDERSON.Login where username = @username_sended)

                    -- Nos fijamos si es el primer login
                    if (@check_password is null)

                        begin
                            set @result = 'LOGIN_FIRST'
                            return 0
                        end

                    -- Seleccionamos la cantidad de intentos fallidos que tiene
                    set @check_habilitado = (select Habilitado from MR_ANDERSON.Login where username = @username_sended)
                    if (@check_habilitado = 0)

                        begin
                            set @result = 'LOGIN_OFF'
                            return 1
                        end

                    -- Usuario correcto pero contraseña incorrecta
                    if (@check_password <> @user_password_sended)
                        
                        begin
                                update MR_ANDERSON.Login
                                    set intentos_fallidos = intentos_fallidos + 1
                                    where username = @username_sended

                                set @result = 'LOGIN_PASS_ERR'
                                return 1
                        end

                    -- Si intentos_fallidos = 3, deshabilitar usuario
                    set @check_fallidos = (select intentos_fallidos from MR_ANDERSON.Login where username = @username_sended)
                    if (@check_fallidos = 3)
                        begin
                                update MR_ANDERSON.Login
                                    set Habilitado = 0
                                    where username = @username_sended

                                set @result = 'LOGIN_TOO_MANY_TIMES'
                                return 1
                        end                  

                    -- Login Correcto deberia entrar aca
                    if (@check_habilitado = 1 and @check_password = @user_password_sended)
                        begin
                            update MR_ANDERSON.Login
                                set intentos_fallidos = 0
                                where username = @username_sended

                            set @result = 'LOGIN_OK'
                            return 0
                        end
                end
                
            -- Si no se cumple ninguna de las condiciones anteriores, (usuario inexistente, otro error, etc) retornar error
            set @result = 'LOGIN_ERROR'
            return 1
            
        end

GO

-- Listo Login !

-- Insert nuevo login

create procedure MR_ANDERSON.sp_insert_login (@username_sended NVARCHAR(100), @user_password_sended NVARCHAR(255), @rol_sended NVARCHAR(255), 
                                                @result NVARCHAR(14) output)
    as
        begin
            if @username_sended is null or @rol_sended is null
                    begin
                        set @result = 'LOGIN_ERROR'
                        return 2
                    end    

            if exists(select username from MR_ANDERSON.Login where username = @username_sended)
                begin
                    set @result = 'LOGIN_EXISTS'
                    return 1
                end

            insert into MR_ANDERSON.Login(username, user_password, last_login, intentos_fallidos, Habilitado, Rol) 
                VALUES(@username_sended, @user_password_sended, NULL, 0, 1, @rol_sended)
            
            set @result = 'LOGIN_REG_OK'
            return 0
        end

GO

-- Listo insert nuevo login


-- Insert nuevo cliente

create procedure MR_ANDERSON.sp_insert_cliente (@nombre_sended NVARCHAR(255), @dni_sended NUMERIC(18), @apellido_sended NVARCHAR(255),
                    @telefono_sended NUMERIC(18) , @mail_sended NVARCHAR(255), @fecha_nac_sended DATETIME,
                    @username_sended NVARCHAR(100), @result NVARCHAR(19) output)
    as
        begin

            if @nombre_sended is null 
                or @dni_sended is null 
                or @apellido_sended is null 
                or @telefono_sended is null 
                or @mail_sended is null 
                or @fecha_nac_sended is null
                or @username_sended is null
                begin
                    set @result = 'SENT_VALUE_NULL'
                    return 2
                end

            if exists(select dni from MR_ANDERSON.Datos_Clientes where dni = @dni_sended)
                or exists(select username from MR_ANDERSON.Datos_Clientes where username = @username_sended)

                begin
                    set @result = 'CLIENT_EXISTENT'
                    return 1 
                end
            if exists(select telefono from MR_ANDERSON.Datos_Clientes where telefono = @telefono_sended)
                begin 
                    set @result = 'CLIENT_TEL_EXISTENT'
                    return 1
                end

            insert into MR_ANDERSON.Datos_Clientes (dni, nombre, apellido, telefono, mail, fecha_nac, username, saldo) 
                VALUES(@dni_sended, @nombre_sended, @apellido_sended, @telefono_sended, @mail_sended, @fecha_nac_sended, @username_sended, 10)
      
            set @result = 'CLIENT_REG_OK'
            return 0 
        
        end
GO

-- Listo insert nuevo cliente


-- Insert nuevo proveedor

create procedure MR_ANDERSON.sp_insert_proveedor (@provee_cuit_sended NVARCHAR(20), @provee_rs_sended NVARCHAR(100), @provee_telefono_sended NUMERIC(18),
                            @provee_rubro_sended NVARCHAR(100), @username_sended NVARCHAR(100), @nombre_contacto_sended VARCHAR(40), 
                            @provee_email_sended NVARCHAR(255), @result NVARCHAR(20) output)
    as
        begin

            if @provee_cuit_sended is null
                or @provee_rs_sended is null
                or @provee_telefono_sended is null
                or @provee_rubro_sended is null 
                or @username_sended is null
                or @nombre_contacto_sended is null
                or @provee_email_sended is null
                begin
                    set @result = 'SENT_VALUE_NULL'
                    return 1
                end

            if exists(select provee_cuit from MR_ANDERSON.Datos_Proveedores where provee_cuit = @provee_cuit_sended)
                or exists(select username from MR_ANDERSON.Datos_Proveedores where username = @username_sended)

                begin
                    set @result = 'PROV_EXISTENT'
                    return 1
                end
            
            insert into MR_ANDERSON.Datos_Proveedores (provee_cuit, provee_rs, provee_telefono, provee_rubro, username, nombre_contacto, provee_email) 
                VALUES(@provee_cuit_sended, @provee_rs_sended, @provee_telefono_sended, @provee_rubro_sended, @username_sended, @nombre_contacto_sended, @provee_email_sended)
            return 'PROV_REG_OK'
                
        end

GO

-- Listo insert nuevo proveedor

--Insert Direccion
create procedure MR_ANDERSON.sp_insert_direccion (@calle NVARCHAR(100), @localidad NVARCHAR(100), 
                                @username NVARCHAR(100), @nro_piso NUMERIC(3), @depto NVARCHAR(40),
                                @codigo_postal NUMERIC(5), @result NVARCHAR(30) output)
    as
        begin
            if @calle is null or @localidad is null or @username is null
                begin
                    set @result = 'SENT_VALUE_NULL'
                    return 1
                end

            if not exists(select username 
                from MR_ANDERSON.Login where username = @username)
                begin
                    set @result = 'INEXISTENT_USER'
                    return 1
                end
            if @username in (select username from MR_ANDERSON.Direccion where username = @username)
                begin
                    set @result = 'EXISTENT_USER'
                    return 1
                end

            insert into MR_ANDERSON.Direccion(calle, localidad, username, nro_piso, depto, codigo_postal)
                VALUES(@calle,@localidad,@username,@nro_piso,@depto, @codigo_postal)

            set @result = 'OK'
            return 0
        end
GO
--Listo insert direccion


--Modificar cliente

create procedure MR_ANDERSON.sp_modify_client (@nombre_sended NVARCHAR(255), @dni_sended NUMERIC(18), @apellido_sended NVARCHAR(255),
                    @telefono_sended NUMERIC(18) , @mail_sended NVARCHAR(255), @fecha_nac_sended DATETIME,
                    @username_sended NVARCHAR(100), @result NVARCHAR(19) output)
    as
        begin
            if @nombre_sended is null 
                or @dni_sended is null 
                or @apellido_sended is null 
                or @telefono_sended is null 
                or @mail_sended is null 
                or @fecha_nac_sended is null
                or @username_sended is null
                begin
                    set @result = 'SENT_VALUE_NULL'
                    return 2
                end

            if @telefono_sended in (select telefono from MR_ANDERSON.Datos_Clientes where username != @username_sended)
                begin 
                    set @result = 'CLIENT_TEL_EXISTENT'
                    return 1
                end


            update MR_ANDERSON.Datos_Clientes
                set nombre = @nombre_sended
                ,dni = @dni_sended
                ,apellido = @apellido_sended
                ,telefono = @telefono_sended
                ,mail = @mail_sended
                ,fecha_nac = @fecha_nac_sended

                where username = @username_sended

        end
GO
--Listo Modificar cliente

--Calcular total factura

create function MR_ANDERSON.fn_total_factura (@factura_nro NUMERIC(18))

    returns NUMERIC(18,2)

    as
        begin
            return (select sum(FR.cantidad * Cupones.precio)
                from MR_ANDERSON.Factura_Renglon FR

            join MR_ANDERSON.Factura Factura
                on   FR.factura_nro = Factura.factura_nro and Factura.factura_nro = @factura_nro

            join MR_ANDERSON.Cupones Cupones
                on   FR.codigo = Cupones.codigo)
            
            
        end
GO


-- Update saldos (cargas +)

update MR_ANDERSON.Datos_Clientes 
    set saldo = saldo + C.monto
    from MR_ANDERSON.Datos_Clientes DC
    join MR_ANDERSON.Cargas C
        on   DC.dni = C.dni

-- Update saldos (- giftcard credito en los de origen)

update MR_ANDERSON.Datos_Clientes 
    set saldo = saldo - G.monto
    from MR_ANDERSON.Datos_Clientes DC
    join MR_ANDERSON.Cliente_Origen CO
        on   DC.dni = CO.dni
    join MR_ANDERSON.Giftcard G
        on   CO.id_origen = G.id_origen

-- Update saldos (+ giftcard credito en los de destino)

update MR_ANDERSON.Datos_Clientes 
    set saldo = saldo + G.monto
    from MR_ANDERSON.Datos_Clientes DC
    join MR_ANDERSON.Cliente_Destino CD
        on   DC.dni = CD.dni
    join MR_ANDERSON.Giftcard G
        on   CD.id_destino = G.id_destino