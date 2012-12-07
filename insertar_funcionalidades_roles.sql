exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Cliente',@Funcionalidad = 'Cargar Credito'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Cliente',@Funcionalidad = 'Comprar Giftcard'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Cliente',@Funcionalidad = 'Listado Estadistico'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Cliente',@Funcionalidad = 'Pedir Devolucion'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Cliente',@Funcionalidad = 'Ver Cupones'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Cliente',@Funcionalidad = 'Ver Historial'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Cliente',@Funcionalidad = 'Cargar Credito'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Cliente',@Funcionalidad = 'Comprar GiftCard'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Cliente',@Funcionalidad = 'Comprar Cupon'

exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Proveedor',@Funcionalidad = 'Armar Cupon'

exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Administrador',@Funcionalidad = 'ABM Rol'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Administrador',@Funcionalidad = 'ABM Usuario'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Administrador',@Funcionalidad = 'Facturar Proveedor'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Administrador',@Funcionalidad = 'Publicar Cupones'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Administrador',@Funcionalidad = 'Cargar Credito'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Administrador',@Funcionalidad = 'Comprar GiftCard'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Administrador',@Funcionalidad = 'Comprar Cupon'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Administrador',@Funcionalidad = 'Simular Usuario'


exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Administrador General',@Funcionalidad = 'Cargar Credito'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Administrador General',@Funcionalidad = 'Comprar Giftcard'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Administrador General',@Funcionalidad = 'Listado Estadistico'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Administrador General',@Funcionalidad = 'Pedir Devolucion'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Administrador General',@Funcionalidad = 'Ver Cupones'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Administrador General',@Funcionalidad = 'Ver Historial'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Administrador General',@Funcionalidad = 'Armar Cupon'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Administrador General',@Funcionalidad = 'ABM Rol'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Administrador General',@Funcionalidad = 'ABM Usuario'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Administrador General',@Funcionalidad = 'Facturar Proveedor'
exec MR_ANDERSON.sp_add_func_rol @nombre_rol = 'Administrador General',@Funcionalidad = 'Publicar Cupones'



select * from MR_ANDERSON.Login

select * from MR_ANDERSON.Datos_clientes where username = '99725860'

$19759