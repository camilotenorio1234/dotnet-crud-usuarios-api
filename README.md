# dotnet-crud-usuarios-api

## Introduction

dotnet-crud-usuarios-api is a RESTful API built using **ASP.NET Core 10**, **Entity Framework Core**, and **SQL Server Express**.

The project implements a clean layered architecture using Controllers, Services, DTOs, and Entity Framework for database management.

This repository demonstrates a basic CRUD API for user management and serves as a backend practice project for technical interviews and .NET learning.

This README is available in both **English and Spanish**.

---

<details>
<summary><strong>dotnet-crud-usuarios-api | English</strong></summary>

# Description

This project is a REST API developed with ASP.NET Core and Entity Framework Core.

It follows a clean architecture structure:

- Controllers
- Services
- DTOs
- Models
- Entity Framework Core
- SQL Server Express

The API supports complete CRUD operations for users.

---

# Project Structure

```bash
CrudDemo/
├── Controllers/
├── Data/
├── Dtos/
├── Models/
├── Services/
├── Migrations/
├── appsettings.json
├── Program.cs
└── CrudDemo.csproj
```

---

# Technologies Used

- ASP.NET Core 10
- Entity Framework Core
- SQL Server Express
- C#
- REST API
- Swagger / OpenAPI
- VS Code

---

# Create Project From Scratch

## 1. Create project

```bash
dotnet new webapi -n CrudDemo
cd CrudDemo
```

## 2. Install packages

```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

## 3. Install EF CLI tool

```bash
dotnet tool install --global dotnet-ef
```

## 4. Verify .NET SDK

```bash
dotnet --version
dotnet --info
```

---

# Database Configuration

## appsettings.json

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=CrudDemoDb;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

---

# Entity Framework Migrations

## Create migration

```bash
dotnet ef migrations add InitialCreate
```

## Apply migration to database

```bash
dotnet ef database update
```

---

# Run Project

## Development mode

```bash
dotnet watch run
```

## Standard execution

```bash
dotnet run
```

---

# Build Project

```bash
dotnet build
```

---

# Clean Project

```bash
dotnet clean
```

---

# Available Endpoints

## Usuarios

- GET /api/usuarios
- GET /api/usuarios/{id}
- POST /api/usuarios
- PUT /api/usuarios/{id}
- DELETE /api/usuarios/{id}

---

# Example Request

## Create User

```json
{
  "nombre": "Juan Camilo",
  "email": "juan@email.com"
}
```

---

# Future Improvements

- JWT Authentication
- Global Exception Handling
- Pagination
- Repository Pattern
- Docker Support
- Unit Testing

</details>

---

<details>
<summary><strong>dotnet-crud-usuarios-api | Español</strong></summary>

# Descripción

Este proyecto es una API REST desarrollada con ASP.NET Core y Entity Framework Core.

Implementa una arquitectura limpia utilizando:

- Controllers
- Services
- DTOs
- Models
- Entity Framework Core
- SQL Server Express

La API permite realizar operaciones CRUD completas sobre usuarios.

---

# Estructura del Proyecto

```bash
CrudDemo/
├── Controllers/
├── Data/
├── Dtos/
├── Models/
├── Services/
├── Migrations/
├── appsettings.json
├── Program.cs
└── CrudDemo.csproj
```

---

# Tecnologías Utilizadas

- ASP.NET Core 10
- Entity Framework Core
- SQL Server Express
- C#
- REST API
- Swagger / OpenAPI
- VS Code

---

# Crear Proyecto Desde Cero

## 1. Crear proyecto

```bash
dotnet new webapi -n CrudDemo
cd CrudDemo
```

## 2. Instalar paquetes

```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

## 3. Instalar herramienta EF

```bash
dotnet tool install --global dotnet-ef
```

## 4. Verificar SDK .NET

```bash
dotnet --version
dotnet --info
```

---

# Configuración de Base de Datos

## appsettings.json

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=CrudDemoDb;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

---

# Migraciones Entity Framework

## Crear migración

```bash
dotnet ef migrations add InitialCreate
```

## Aplicar migración

```bash
dotnet ef database update
```

---

# Ejecutar Proyecto

## Modo desarrollo

```bash
dotnet watch run
```

## Ejecución normal

```bash
dotnet run
```

---

# Compilar Proyecto

```bash
dotnet build
```

---

# Limpiar Proyecto

```bash
dotnet clean
```

---

# Endpoints Disponibles

## Usuarios

- GET /api/usuarios
- GET /api/usuarios/{id}
- POST /api/usuarios
- PUT /api/usuarios/{id}
- DELETE /api/usuarios/{id}

---

# Ejemplo de Petición

## Crear Usuario

```json
{
  "nombre": "Juan Camilo",
  "email": "juan@email.com"
}
```

---

# Mejoras Futuras

- Autenticación JWT
- Manejo global de errores
- Paginación
- Patrón Repository
- Soporte Docker
- Pruebas unitarias

</details>
