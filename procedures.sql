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
		select Habilitado,Funcionalidad
			from MR_ANDERSON.Roles r
			join MR_ANDERSON.Funcionalidades_Roles f on r.Rol = f.Rol
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
