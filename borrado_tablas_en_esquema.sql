/* ---------------------------------------------------------------------- */
/* Script generated with: DeZign for Databases V7.2.1                     */
/* Target DBMS:           MS SQL Server 2008                              */
/* Project file:          der_gestion.dez                                 */
/* Project name:                                                          */
/* Author:                                                                */
/* Script type:           Database drop script                            */
/* Created on:            2012-10-26 16:56                                */
/* ---------------------------------------------------------------------- */
USE [GD2C2012]
GO

/****** Object:  StoredProcedure [MR_ANDERSON].[sp_change_rol_name_a_usr]    Script Date: 12/14/2012 01:20:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_change_rol_name_a_usr]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_change_rol_name_a_usr]
GO

/****** Object:  StoredProcedure [MR_ANDERSON].[sp_new_rol_tipo]    Script Date: 12/14/2012 01:18:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_new_rol_tipo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_new_rol_tipo]
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_facturar_proveedor_nfactura]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_facturar_proveedor_nfactura]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_factura_proveedor_importe]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_factura_proveedor_importe]
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_guardar_ciudades_cupon]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_guardar_ciudades_cupon]
GO

/****** Object:  StoredProcedure [MR_ANDERSON].[sp_estadistico_usuarios]    Script Date: 12/09/2012 17:43:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_estadistico_usuarios]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_estadistico_usuarios]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_existe_cuit]    Script Date: 12/09/2012 17:43:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_existe_cuit]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_existe_cuit]
GO


/****** Object:  UserDefinedFunction [MR_ANDERSON].[fn_in_semester]    Script Date: 12/09/2012 17:24:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[fn_in_semester]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [MR_ANDERSON].[fn_in_semester]
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_estadistico_devoluciones]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_estadistico_devoluciones]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_cambiar_password]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_cambiar_password]
GO

/****** Object:  StoredProcedure [MR_ANDERSON].[sp_existe_usuario]    Script Date: 12/08/2012 15:33:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_existe_usuario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_existe_usuario]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_get_usrs_filtrados]    Script Date: 12/08/2012 14:59:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_get_usrs_filtrados]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_get_usrs_filtrados]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_get_ciudades_para_usr]    Script Date: 12/08/2012 14:58:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_get_ciudades_para_usr]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_get_ciudades_para_usr]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_usuario_habilitado]    Script Date: 12/08/2012 14:41:32 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_usuario_habilitado]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_usuario_habilitado]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_modificar_rol_usr]    Script Date: 12/08/2012 14:41:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_modificar_rol_usr]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_modificar_rol_usr]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_get_roles_para_tipo]    Script Date: 12/08/2012 14:41:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_get_roles_para_tipo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_get_roles_para_tipo]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_get_all_usrs]    Script Date: 12/08/2012 14:41:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_get_all_usrs]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_get_all_usrs]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_add_ciudad_user]    Script Date: 12/08/2012 14:40:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_add_ciudad_user]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_add_ciudad_user]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[get_nombre_rol_de_usuario]    Script Date: 12/08/2012 14:40:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[get_nombre_rol_de_usuario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[get_nombre_rol_de_usuario]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[get_datos_rol]    Script Date: 12/08/2012 14:40:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[get_datos_rol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[get_datos_rol]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[get_all_roles]    Script Date: 12/08/2012 14:39:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[get_all_roles]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[get_all_roles]
GO


/****** Object:  UserDefinedFunction [MR_ANDERSON].[fn_existe_cuit]    Script Date: 12/08/2012 13:31:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[fn_existe_cuit]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [MR_ANDERSON].[fn_existe_cuit]
GO

/****** Object:  StoredProcedure [MR_ANDERSON].[sp_buscador_clientes]    Script Date: 12/08/2012 12:25:33 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_buscador_proveedores]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_buscador_proveedores]
GO

/****** Object:  StoredProcedure [MR_ANDERSON].[sp_buscador_clientes]    Script Date: 12/08/2012 12:25:33 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_buscador_clientes]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_buscador_clientes]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_modify_proveedor]    Script Date: 12/08/2012 11:41:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_modify_proveedor]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_modify_proveedor]
GO

/****** Object:  StoredProcedure [MR_ANDERSON].[sp_get_datos_proveedor]    Script Date: 12/08/2012 11:41:20 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_get_datos_proveedor]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_get_datos_proveedor]
GO

/****** Object:  StoredProcedure [MR_ANDERSON].[sp_get_datos_cliente]    Script Date: 12/08/2012 11:40:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_get_datos_cliente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_get_datos_cliente]
GO

/****** Object:  StoredProcedure [MR_ANDERSON].[sp_facturar_proveedor]    Script Date: 12/08/2012 11:40:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_facturar_proveedor]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_facturar_proveedor]
GO

/****** Object:  StoredProcedure [MR_ANDERSON].[sp_publicar_cupon]    Script Date: 12/06/2012 19:52:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_publicar_cupon]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_publicar_cupon]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_cupones_a_publicar]    Script Date: 12/06/2012 19:28:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_cupones_a_publicar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_cupones_a_publicar]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_get_direccion]    Script Date: 12/06/2012 19:10:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_get_direccion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_get_direccion]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_change_status_user]    Script Date: 12/06/2012 19:10:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_change_status_user]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_change_status_user]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_agregar_cupon]    Script Date: 12/06/2012 19:03:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_agregar_cupon]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_agregar_cupon]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_get_ciudades]    Script Date: 12/06/2012 18:11:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_get_ciudades]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_get_ciudades]
GO

/****** Object:  StoredProcedure [MR_ANDERSON].[sp_get_datos_clientes]    Script Date: 12/06/2012 18:10:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_get_datos_clientes]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_get_datos_clientes]
GO

/****** Object:  StoredProcedure [MR_ANDERSON].[sp_delete_ciudad]    Script Date: 12/05/2012 21:13:35 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_delete_ciudad]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_delete_ciudad]
GO

/****** Object:  StoredProcedure [MR_ANDERSON].[sp_insert_ciudad]    Script Date: 12/05/2012 21:13:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_insert_ciudad]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_insert_ciudad]
GO

/****** Object:  StoredProcedure [MR_ANDERSON].[sp_ver_cupones_habilitados]    Script Date: 12/05/2012 21:04:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_ver_cupones_habilitados]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_ver_cupones_habilitados]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_registra_consumo_cupon]    Script Date: 12/05/2012 21:03:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_registra_consumo_cupon]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_registra_consumo_cupon]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_modify_direccion]    Script Date: 12/05/2012 21:03:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_modify_direccion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_modify_direccion]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_comprar_cupon]    Script Date: 12/01/2012 20:39:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_comprar_cupon]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_comprar_cupon]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_chequear_pertenencia]    Script Date: 12/01/2012 20:15:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_chequear_pertenencia]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_chequear_pertenencia]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_pedir_devolucion]    Script Date: 12/01/2012 20:15:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_pedir_devolucion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_pedir_devolucion]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[historial_compra]    Script Date: 11/29/2012 23:30:07 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[historial_compra]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[historial_compra]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_nombre_usuario_no_existente]    Script Date: 11/28/2012 20:56:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_nombre_usuario_no_existente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_nombre_usuario_no_existente]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_ajusta_saldo_compras]    Script Date: 11/28/2012 20:54:32 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_ajusta_saldo_compras]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_ajusta_saldo_compras]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_ajusta_saldo_devoluciones]    Script Date: 11/28/2012 20:54:19 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_ajusta_saldo_devoluciones]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_ajusta_saldo_devoluciones]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_login]    Script Date: 11/28/2012 20:50:30 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_login]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_login]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_eliminar_rol]    Script Date: 11/28/2012 20:50:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_eliminar_rol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_eliminar_rol]
GO

/****** Object:  StoredProcedure [MR_ANDERSON].[sp_compra_giftcard]    Script Date: 11/07/2012 16:49:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_compra_giftcard]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_compra_giftcard]
GO

/****** Object:  StoredProcedure [MR_ANDERSON].[sp_agregar_tarjeta]    Script Date: 11/07/2012 16:29:08 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_agregar_tarjeta]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_agregar_tarjeta]
GO

/****** Object:  StoredProcedure [MR_ANDERSON].[sp_cargar_credito]    Script Date: 11/07/2012 16:25:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_cargar_credito]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_cargar_credito]
GO

/****** Object:  StoredProcedure [MR_ANDERSON].[sp_agregar_ciudad]    Script Date: 11/06/2012 19:00:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_agregar_ciudad]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_agregar_ciudad]
GO

/****** Object:  UserDefinedFunction [MR_ANDERSON].[fn_total_factura]    Script Date: 11/05/2012 19:00:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[fn_total_factura]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [MR_ANDERSON].[fn_total_factura]
GO

/****** Object:  StoredProcedure [MR_ANDERSON].[sp_modify_client]    Script Date: 11/05/2012 18:50:35 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_modify_client]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_modify_client]
GO

/****** Object:  StoredProcedure [MR_ANDERSON].[sp_insert_direccion]    Script Date: 11/03/2012 17:23:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_insert_direccion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_insert_direccion]
GO

/****** Object:  StoredProcedure [MR_ANDERSON].[sp_insert_proveedor]    Script Date: 11/03/2012 16:26:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_insert_proveedor]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_insert_proveedor]
GO

/****** Object:  StoredProcedure [MR_ANDERSON].[sp_insert_cliente]    Script Date: 11/03/2012 15:54:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_insert_cliente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_insert_cliente]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_insert_login]    Script Date: 11/03/2012 15:39:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_insert_login]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_insert_login]
GO

/****** Object:  StoredProcedure [MR_ANDERSON].[sp_add_func_rol]    Script Date: 11/02/2012 17:15:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_add_func_rol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_add_func_rol]
GO

/****** Object:  StoredProcedure [MR_ANDERSON].[sp_change_status_rol]    Script Date: 11/02/2012 17:15:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_change_status_rol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_change_status_rol]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_del_func_rol]    Script Date: 11/02/2012 17:16:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_del_func_rol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_del_func_rol]
GO


/****** Object:  StoredProcedure [MR_ANDERSON].[sp_new_rol]    Script Date: 11/02/2012 17:16:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_new_rol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_new_rol]
GO

/****** Object:  StoredProcedure [MR_ANDERSON].[sp_change_rol_name]    Script Date: 11/02/2012 22:58:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[sp_change_rol_name]') AND type in (N'P', N'PC'))
DROP PROCEDURE [MR_ANDERSON].[sp_change_rol_name]
GO

/****** Object:  UserDefinedFunction [MR_ANDERSON].[func_login]    Script Date: 11/02/2012 23:02:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[func_login]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [MR_ANDERSON].[func_login]
GO



/* ---------------------------------------------------------------------- */
/* Drop foreign key constraints                                           */
/* ---------------------------------------------------------------------- */

ALTER TABLE [MR_ANDERSON].[Login] DROP CONSTRAINT [Tipo_Login]
GO

ALTER TABLE [MR_ANDERSON].[Rol_Tipo] DROP  CONSTRAINT [FK_ROL]
GO

ALTER TABLE [MR_ANDERSON].[Rol_Tipo]  DROP CONSTRAINT [FK_TIPO]
GO

ALTER TABLE [MR_ANDERSON].[Datos_Clientes] DROP CONSTRAINT [Login_Datos_Clientes]
GO


ALTER TABLE [MR_ANDERSON].[Cupones] DROP CONSTRAINT [Datos_Proveedores_Cupones]
GO


ALTER TABLE [MR_ANDERSON].[Giftcard] DROP CONSTRAINT [Cliente_Destino_Giftcard]
GO


ALTER TABLE [MR_ANDERSON].[Giftcard] DROP CONSTRAINT [Cliente_Origen_Giftcard]
GO


ALTER TABLE [MR_ANDERSON].[Cliente_Origen] DROP CONSTRAINT [Datos_Clientes_Cliente_Origen]
GO


ALTER TABLE [MR_ANDERSON].[Cliente_Destino] DROP CONSTRAINT [Datos_Clientes_Cliente_Destino]
GO


ALTER TABLE [MR_ANDERSON].[Cargas] DROP CONSTRAINT [Datos_Clientes_Cargas]
GO


ALTER TABLE [MR_ANDERSON].[Datos_Proveedores] DROP CONSTRAINT [Login_Datos_Proveedores]
GO

ALTER TABLE [MR_ANDERSON].[Factura] DROP CONSTRAINT [Datos_Proveedores_Factura]
GO


ALTER TABLE [MR_ANDERSON].[Factura_Renglon] DROP CONSTRAINT [Factura_Factura_Renglon]
GO


ALTER TABLE [MR_ANDERSON].[Factura_Renglon] DROP CONSTRAINT [Cupones_Factura_Renglon]
GO


ALTER TABLE [MR_ANDERSON].[Funcionalidades_Roles] DROP CONSTRAINT [Roles_Funcionalidades_Roles]
GO


ALTER TABLE [MR_ANDERSON].[Login] DROP CONSTRAINT [Roles_Login]
GO


ALTER TABLE [MR_ANDERSON].[Ciudades] DROP CONSTRAINT [Datos_Clientes_Ciudades]
GO


ALTER TABLE [MR_ANDERSON].[Direccion] DROP CONSTRAINT [Login_Direccion]
GO


ALTER TABLE [MR_ANDERSON].[Datos_Tarjeta] DROP CONSTRAINT [Datos_Clientes_Datos_Tarjeta]
GO


ALTER TABLE [MR_ANDERSON].[Compras] DROP CONSTRAINT [Datos_Clientes_Compras]
GO


ALTER TABLE [MR_ANDERSON].[Compras] DROP CONSTRAINT [Cupones_Compras]
GO


IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[Codigo_Ciudad]') AND parent_object_id = OBJECT_ID(N'[MR_ANDERSON].[Ciudades_Cupon]'))
ALTER TABLE [MR_ANDERSON].[Ciudades_Cupon] DROP CONSTRAINT [Codigo_Ciudad]
GO

/****** Object:  Table [MR_ANDERSON].[Ciudades_Cupon]    Script Date: 12/04/2012 16:14:19 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[MR_ANDERSON].[Ciudades_Cupon]') AND type in (N'U'))
DROP TABLE [MR_ANDERSON].[Ciudades_Cupon]
GO

/* ---------------------------------------------------------------------- */
/* Drop table "Consumos"                                                  */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

/* Drop table */

DROP TABLE [MR_ANDERSON].[Consumos]
GO

DROP TABLE [MR_ANDERSON].[Tipo_Usuario]
GO

DROP TABLE [MR_ANDERSON].[Rol_Tipo]
GO

/* ---------------------------------------------------------------------- */
/* Drop table "Devoluciones"                                              */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

/* Drop table */

DROP TABLE [MR_ANDERSON].[Devoluciones]
GO


/* ---------------------------------------------------------------------- */
/* Drop table "Compras"                                                   */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

/* Drop table */

DROP TABLE [MR_ANDERSON].[Compras]
GO


/* ---------------------------------------------------------------------- */
/* Drop table "Ciudades"                                                  */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

/* Drop table */

DROP TABLE [MR_ANDERSON].[Ciudades]
GO


/* ---------------------------------------------------------------------- */
/* Drop table "Factura_Renglon"                                           */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [MR_ANDERSON].[Factura_Renglon] DROP CONSTRAINT [PK_Factura_Renglon]
GO


/* Drop table */

DROP TABLE [MR_ANDERSON].[Factura_Renglon]
GO


/* ---------------------------------------------------------------------- */
/* Drop table "Giftcard"                                                  */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

/* Drop table */

DROP TABLE [MR_ANDERSON].[Giftcard]
GO


/* ---------------------------------------------------------------------- */
/* Drop table "Cupones"                                                   */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [MR_ANDERSON].[Cupones] DROP CONSTRAINT [codigo]
GO


/* Drop table */

DROP TABLE [MR_ANDERSON].[Cupones]
GO


/* ---------------------------------------------------------------------- */
/* Drop table "Datos_Tarjeta"                                             */
/* ---------------------------------------------------------------------- */


/* Drop table */

DROP TABLE [MR_ANDERSON].[Datos_Tarjeta]
GO


/* ---------------------------------------------------------------------- */
/* Drop table "Factura"                                                   */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [MR_ANDERSON].[Factura] DROP CONSTRAINT [PK_Factura]
GO


/* Drop table */

DROP TABLE [MR_ANDERSON].[Factura]
GO


/* ---------------------------------------------------------------------- */
/* Drop table "Datos_Proveedores"                                         */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [MR_ANDERSON].[Datos_Proveedores] DROP CONSTRAINT [PK_Datos_Proveedores]
GO


/* Drop table */

DROP TABLE [MR_ANDERSON].[Datos_Proveedores]
GO


/* ---------------------------------------------------------------------- */
/* Drop table "Cargas"                                                    */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

/* Drop table */

DROP TABLE [MR_ANDERSON].[Cargas]
GO


/* ---------------------------------------------------------------------- */
/* Drop table "Cliente_Destino"                                           */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [MR_ANDERSON].[Cliente_Destino] DROP CONSTRAINT [PK_Cliente_Destino]
GO


/* Drop table */

DROP TABLE [MR_ANDERSON].[Cliente_Destino]
GO


/* ---------------------------------------------------------------------- */
/* Drop table "Cliente_Origen"                                            */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [MR_ANDERSON].[Cliente_Origen] DROP CONSTRAINT [PK_Cliente_Origen]
GO


/* Drop table */

DROP TABLE [MR_ANDERSON].[Cliente_Origen]
GO


/* ---------------------------------------------------------------------- */
/* Drop table "Datos_Clientes"                                            */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [MR_ANDERSON].[Datos_Clientes] DROP CONSTRAINT [dni]
GO


/* Drop table */

DROP TABLE [MR_ANDERSON].[Datos_Clientes]
GO


/* ---------------------------------------------------------------------- */
/* Drop table "Direccion"                                                 */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [MR_ANDERSON].[Direccion] DROP CONSTRAINT [PK_Direccion]
GO


/* Drop table */

DROP TABLE [MR_ANDERSON].[Direccion]
GO



/* ---------------------------------------------------------------------- */
/* Drop table "Login"                                                     */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [MR_ANDERSON].[Login] DROP CONSTRAINT [PK_Login]
GO


/* Drop table */

DROP TABLE [MR_ANDERSON].[Login]
GO


/* ---------------------------------------------------------------------- */
/* Drop table "Funcionalidades_Roles"                                     */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

/* Drop table */

DROP TABLE [MR_ANDERSON].[Funcionalidades_Roles]
GO


/* ---------------------------------------------------------------------- */
/* Drop table "Roles"                                                     */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE [MR_ANDERSON].[Roles] DROP CONSTRAINT [PK_Roles]
GO


/* Drop table */

DROP TABLE [MR_ANDERSON].[Roles]
GO

USE [GD2C2012]
GO


DROP SCHEMA [MR_ANDERSON]
GO
