/* ---------------------------------------------------------------------- */
/* Script generated with: DeZign for Databases V7.2.1                     */
/* Target DBMS:           MS SQL Server 2008                              */
/* Project file:          der_gestion.dez                                 */
/* Project name:                                                          */
/* Author:                                                                */
/* Script type:           Database drop script                            */
/* Created on:            2012-10-26 16:56                                */
/* ---------------------------------------------------------------------- */




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


/* ---------------------------------------------------------------------- */
/* Drop foreign key constraints                                           */
/* ---------------------------------------------------------------------- */

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


ALTER TABLE [MR_ANDERSON].[Ciudades] DROP CONSTRAINT [Cupones_Ciudades]
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


/* ---------------------------------------------------------------------- */
/* Drop table "Consumos"                                                  */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

/* Drop table */

DROP TABLE [MR_ANDERSON].[Consumos]
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

DROP SCHEMA [MR_ANDERSON]
GO
