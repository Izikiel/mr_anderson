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


ALTER TABLE [MR_ANDERSON].[Devoluciones] DROP CONSTRAINT [Datos_Clientes_Devoluciones]
GO


ALTER TABLE [MR_ANDERSON].[Devoluciones] DROP CONSTRAINT [Cupones_Devoluciones]
GO


ALTER TABLE [MR_ANDERSON].[Consumos] DROP CONSTRAINT [Cupones_Consumos]
GO


ALTER TABLE [MR_ANDERSON].[Consumos] DROP CONSTRAINT [Datos_Clientes_Consumos]
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

/* Drop constraints */

ALTER TABLE [MR_ANDERSON].[Datos_Tarjeta] DROP CONSTRAINT 
GO


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
