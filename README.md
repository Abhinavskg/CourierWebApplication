# About Us

The **French Courier Management System** is a web-based application built using **ASP.NET MVC 8.0** and **Entity Framework Core**. It provides robust features for managing deliveries, customers, items, and units with seamless **CRUD operations**. The system integrates **ASP.NET Core Identity Framework** for secure authentication and role-based access control. Additionally, it utilizes **Azure** and **MSSQL** for cloud hosting and database management.

## Key Technical Features

1. **Built with ASP.NET MVC 8.0**  
   The latest version of **ASP.NET MVC** ensures a scalable, high-performance framework for handling dynamic web applications.

2. **Entity Framework Core Integration**  
   This ensures smooth database interactions, supporting relational data storage and management.

3. **Identity Framework for Authentication**  
   Secure, role-based access management using ASP.NET Core Identity for user authentication and authorization.

4. **Azure Hosting**  
   The project is deployed on **Microsoft Azure**, offering cloud scalability and resilience.

5. **MSSQL Database**  
   The system uses **Microsoft SQL Server** for handling data storage and complex queries.

6. **Real-Time Search and Reporting**  
   Efficient data retrieval through search functionality and analytics to monitor key business metrics.

---

## Setting Up the Project from GitHub

Here are the detailed steps to **clone, set up, and run** the project from GitHub:

### 1. Clone the Project

First, clone the project repository from GitHub:

```bash
git clone https://github.com/your-username/FrenchCourierManagementSystem.git
```

### 2. Install Prerequisites

Make sure you have the following software installed:

- **Visual Studio 2022**
- **.NET Core SDK 8.0+**
- **SQL Server** (Local or Azure-based)

### 3. Database Configuration

- Open the project in **Visual Studio**.
- Navigate to `appsettings.json` and update the **connection string** to point to your local **SQL Server** or **Azure SQL Database**.
  
Example:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=CourierDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

### 4. Apply Migrations

Run the following commands in the **Package Manager Console** to create and seed the database:

```bash
Update-Database
```

This will apply migrations and set up the database schema.

### 5. Run the Project

Now, run the project locally by pressing **F5** in Visual Studio or by using:

```bash
dotnet run
```

### 6. Publish to Azure (Optional)

You can publish the application to **Azure** by following these steps:

- Right-click on the project in **Solution Explorer**.
- Select **Publish**.
- Choose **Azure App Service** as the target, and follow the prompts to deploy the application.

### 7. Testing the Application

Once the project is running, use the demo credentials to log in and test the system:

- **URL**: `https://CourierWebApp.azurewebsites.net/`
- **Username**: `Admin@gmail.com`
- **Password**: `Admin123#`
