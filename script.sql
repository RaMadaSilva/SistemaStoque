IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Categoria] (
    [Id] int NOT NULL IDENTITY,
    [Nome] NVARCHAR(80) NOT NULL,
    [Descricao] NVARCHAR(500) NOT NULL,
    CONSTRAINT [PK_Categoria] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Fornecedor] (
    [Id] int NOT NULL IDENTITY,
    [Nome] NVARCHAR(80) NOT NULL,
    [Pais] NVARCHAR(120) NOT NULL DEFAULT N'ANGOLA',
    CONSTRAINT [PK_Fornecedor] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Utilizador] (
    [Id] int NOT NULL IDENTITY,
    [Nome] NVARCHAR(80) NOT NULL,
    [Funcao] NVARCHAR(60) NOT NULL,
    CONSTRAINT [PK_Utilizador] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Produto] (
    [Id] int NOT NULL IDENTITY,
    [Nome] NVARCHAR(80) NOT NULL,
    [Quantidade] INT NOT NULL,
    [PrecoUnitario] FLOAT NOT NULL,
    [DataFabrico] DATETIME NOT NULL,
    [DataExpiracao] DATETIME NOT NULL,
    [PrecoTotal] FLOAT NOT NULL,
    [CategoriaId] int NOT NULL,
    CONSTRAINT [PK_Produto] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_CategoriaId] FOREIGN KEY ([CategoriaId]) REFERENCES [Categoria] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [ProductoFornecedor] (
    [FornecedorId] int NOT NULL,
    [ProdutoId] int NOT NULL,
    CONSTRAINT [PK_ProductoFornecedor] PRIMARY KEY ([FornecedorId], [ProdutoId]),
    CONSTRAINT [FK_ProdutoForneccedor_ProdutoId] FOREIGN KEY ([ProdutoId]) REFERENCES [Fornecedor] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_ProdutoFornecedor_FornecedorId] FOREIGN KEY ([FornecedorId]) REFERENCES [Produto] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [ProdutoUtilizadores] (
    [ProdutoId] int NOT NULL,
    [UtilizadorId] int NOT NULL,
    CONSTRAINT [PK_ProdutoUtilizadores] PRIMARY KEY ([ProdutoId], [UtilizadorId]),
    CONSTRAINT [FK_ProdutoUtilizador_ProdutoId] FOREIGN KEY ([ProdutoId]) REFERENCES [Produto] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_ProdutoUtilizadores_UtilizadorId] FOREIGN KEY ([UtilizadorId]) REFERENCES [Utilizador] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_ProductoFornecedor_ProdutoId] ON [ProductoFornecedor] ([ProdutoId]);
GO

CREATE INDEX [IX_Produto_CategoriaId] ON [Produto] ([CategoriaId]);
GO

CREATE INDEX [IX_ProdutoUtilizadores_UtilizadorId] ON [ProdutoUtilizadores] ([UtilizadorId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221115150448_MinhaPrimeiraMigracaoEF', N'6.0.6');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Utilizador] ADD [Removido] BIT NOT NULL DEFAULT CAST(0 AS BIT);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221116205256_ActualizacaoUtilizador', N'6.0.6');
GO

COMMIT;
GO

