-- 1. Cria o banco de dados chamado SistemaIES
CREATE DATABASE SistemaIES;
GO

-- 2. Informa que vamos usar este banco que acabou de ser criado
USE SistemaIES;
GO

-- 3. Cria a tabela de Disciplinas com suas colunas
CREATE TABLE DISCIPLINAS (
    disciplinaid INT IDENTITY(1,1) PRIMARY KEY, -- IDENTITY faz o ID ser automático (1, 2, 3...)
    nome VARCHAR(100) NOT NULL,
    cargahoraria INT NOT NULL
);
GO