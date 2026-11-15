# Employee Management System

A simple Employee Management System developed using **React** for the frontend and **ASP.NET Core Web API** for the backend.

## Project Overview

This application allows users to manage employee information, including adding, viewing, updating, and deleting employee records.

## Technologies Used

### Frontend
- React.js
- JavaScript
- HTML5
- CSS3
- Axios

### Backend
- C#
- ASP.NET Core Web API
- Entity Framework Core

### Database
- SQL Server

## Features

- View all employees
- Add a new employee
- Update employee details
- Delete employee records
- Fetch employee data through REST APIs

## Project Structure

```text
EmployeeManagement/
│
├── frontend/
│   ├── src/
│   ├── public/
│   ├── package.json
│   └── README.md
│
├── backend/
│   ├── Controllers/
│   ├── Models/
│   ├── Data/
│   ├── Program.cs
│   └── appsettings.json
│
└── README.md
```

## How to Run the Project

### 1. Clone the Repository

```bash
git clone <your-repository-url>
```

### 2. Run the Backend

Navigate to the backend folder:

```bash
cd backend
```

Run the Web API:

```bash
dotnet restore
dotnet run
```

### 3. Run the Frontend

Open another terminal:

```bash
cd frontend
```

Install dependencies:

```bash
npm install
```

Start the React application:

```bash
npm run dev
```

Open the URL displayed in the terminal, usually:

```text
http://localhost:5173
```

## API Endpoints

| HTTP Method | Endpoint | Description |
|---|---|---|
| GET | `/api/employees` | Get all employees |
| GET | `/api/employees/{id}` | Get employee by ID |
| POST | `/api/employees` | Add employee |
| PUT | `/api/employees/{id}` | Update employee |
| DELETE | `/api/employees/{id}` | Delete employee |

## Future Enhancements

- User authentication and authorization
- Employee search functionality
- Pagination
- Department management
- Employee profile management

## Author

Developed as a learning project to understand React, ASP.NET Core Web API, REST APIs, and database integration.

## License

This project is for educational purposes.
