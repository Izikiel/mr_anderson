-- Esbozo del punto 14 del TP (pagina 12)

create procedure mostrar_cupones_proveedores (@fecha_inicio DATETIME, @fecha_fin DATETIME, 
								@proveedor NVARCHAR(100))
	as
		begin
			-- select que devuelve cupones que no fueron facturados
			select * from MR_ANDERSON.Cupones
				where Cupones.codigo not in (select Factura_Renglon.codigo from MR_ANDERSON.Factura_Renglon)
				and Cupones.provee_rs = @proveedor
			-- Falta banda, ver tema de las fechas, y usar cursor para retornar el select
			
		end
GO

-- rol


create procedure MR_ANDERSON.get_datos_rol (@nombre_rol NVARCHAR(255))
	as
		begin
		select Habilitado,Funcionalidad,tipo
			from MR_ANDERSON.Roles r
			join MR_ANDERSON.Funcionalidades_Roles f on r.Rol = f.Rol
			left join MR_ANDERSON.Rol_tipo rt on rt.Rol = r.Rol
		where r.rol = @nombre_rol
			
		end
GO
--get nombre all roles

create procedure MR_ANDERSON.get_all_roles
as
begin
select rol from MR_ANDERSON.Roles
end
GO
--cargar rol con nombre de usuario

create procedure MR_ANDERSON.get_nombre_rol_de_usuario(@nombre_usuario NVARCHAR(255))
as 
begin
	select rol from MR_ANDERSON.Login l
	where l.username = @nombre_usuario

end
GO
--get ciudades

create procedure MR_ANDERSON.sp_get_ciudades
	as
		begin
		select ciudad from MR_ANDERSON.ciudades
		group by ciudad
			
		end
GO
--add ciudad preferencia para user
create procedure MR_ANDERSON.sp_add_ciudad_user (@dni numeric, @ciudad varchar(255))
	as
		begin
			insert into MR_ANDERSON.ciudades(dni,ciudad)
				values(@dni,@ciudad)
		end
GO

--get roles para tipo
create procedure MR_ANDERSON.sp_get_roles_para_tipo (@tipo varchar(100))
	as
		begin
			select rol from MR_ANDERSON.Rol_Tipo
			where tipo = @tipo
			
		end
GO

--modify rol de usuario
create procedure MR_ANDERSON.sp_modificar_rol_usr (@nombre_rol nvarchar(255),@nombre_antiguo NVARCHAR(255))
	as
		begin
			update MR_ANDERSON.Login
				set rol = @nombre_rol
				where rol = @nombre_antiguo
		end
GO

--get all usrs tipo
create procedure MR_ANDERSON.sp_get_all_usrs (@tipo NVARCHAR(100))
	as
		begin
		select username from MR_ANDERSON.Login
		where tipo = @tipo
			
		end
GO


--get ciudades para usuario
create procedure MR_ANDERSON.sp_get_ciudades_para_usr (@dni numeric)
	as
		begin
			select ciudad from MR_ANDERSON.ciudades
			where dni = @dni
		end
GO

--get datos cliente dni
create procedure MR_ANDERSON.sp_get_datos_cliente(@username varchar(100))
as
begin
		select nombre,apellido,telefono,mail,YEAR(fecha_nac)*10000+MONTH(fecha_nac)*100+DAY(fecha_nac) as fecha_nac,saldo,dni
		from MR_ANDERSON.Datos_clientes
		where username = @username
		end
GO

--usuario Habilitado
create procedure MR_ANDERSON.sp_usuario_habilitado (@nombre_usuario varchar(100))
	as
		begin
			select Habilitado from MR_ANDERSON.Login
			where username = @nombre_usuario
		end
