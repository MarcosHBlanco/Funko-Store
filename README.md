# Funko-Store
# 🎁 Funko Store – ASP.NET Core CRUD Application

A full-stack web application developed as part of a software development bootcamp at **INFNET (Rio de Janeiro, Brazil)** in 2023.  
The project simulates a simple store management system for collectible Funko Pop figures.

---

## 🛠️ Tech Stack

- **ASP.NET Core 7 (Razor Pages)**
- **Entity Framework Core**
- **SQLite**
- **ASP.NET Identity** (Authentication & Authorization)
- **Bootstrap**
- **C#**

---

## ✨ Features

- Full **CRUD operations** for:
  - Funkos
  - Brands (Marcas)
  - Universes (Universos)
- **Relational database modeling**
- **User authentication and authorization**
- **Role-based access control** (admin-only sections)
- Database migrations with EF Core
- Responsive UI using Bootstrap

---

## 📸 Screenshots

> _(Screenshots taken locally — project does not require deployment to demonstrate functionality)_

- Home Page  
- Login / Register  
- Funko Management (Create / Edit / Delete)  
- Brand & Universe Management  

_(Add screenshots here)_

---

## 🚀 Getting Started (Local Setup)

### Prerequisites
- .NET SDK **7.x**
- SQLite (included via file-based database)

### Steps
```bash
git clone https://github.com/MarcosHBlanco/Funko-Store.git
cd Funko-Store
dotnet restore
dotnet build
dotnet run
