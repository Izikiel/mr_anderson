exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Cliente',@Funcionalidad = 'Cargar Credito'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Cliente',@Funcionalidad = 'Comprar Giftcard'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Cliente',@Funcionalidad = 'Listado Estadistico'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Cliente',@Funcionalidad = 'Pedir Devolucion'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Cliente',@Funcionalidad = 'Ver Cupones'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Cliente',@Funcionalidad = 'Ver Historial'


exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Proveedor',@Funcionalidad = 'Armar Cupon'

exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Administrador',@Funcionalidad = 'ABM Rol'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Administrador',@Funcionalidad = 'ABM Usuario'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Administrador',@Funcionalidad = 'Facturar Proveedor'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Administrador',@Funcionalidad = 'Publicar Cupones'