
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/17/2017 11:11:33
-- Generated from EDMX file: C:\Data\Source\Repos\CSharp_Training\VS2015\WebAppMVC_ModelFirst\WebAppMVC_ModelFirst\Models\Market.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [WebAppMvc_5_Market];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Suppliers'
CREATE TABLE [dbo].[Suppliers] (
    [SupplierId] uniqueidentifier  NOT NULL,
    [CompanyName] nvarchar(max)  NOT NULL,
    [City] nvarchar(max)  NOT NULL,
    [Country] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [ProductId] uniqueidentifier  NOT NULL,
    [ProductName] nvarchar(max)  NOT NULL,
    [UnitPrice] decimal(18,0)  NOT NULL,
    [SupplierId] uniqueidentifier  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [SupplierId] in table 'Suppliers'
ALTER TABLE [dbo].[Suppliers]
ADD CONSTRAINT [PK_Suppliers]
    PRIMARY KEY CLUSTERED ([SupplierId] ASC);
GO

-- Creating primary key on [ProductId] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([ProductId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SupplierId] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_SupplierProduct]
    FOREIGN KEY ([SupplierId])
    REFERENCES [dbo].[Suppliers]
        ([SupplierId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SupplierProduct'
CREATE INDEX [IX_FK_SupplierProduct]
ON [dbo].[Products]
    ([SupplierId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------