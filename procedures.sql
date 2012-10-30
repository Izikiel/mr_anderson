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


