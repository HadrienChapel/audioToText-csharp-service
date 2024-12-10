# To-Do API in C#

## Overview
This is a simple RESTful API built with C# and .NET Core to manage a to-do list. It allows users to create, read, update, and delete tasks.

## Features
- CRUD operations for tasks.
- Lightweight and easy to set up.
- Uses in-memory storage for simplicity.

## Prerequisites
- .NET 6 SDK

## Setup and Run
1. Clone the repository:
   ```bash
   git clone <repository_url>
   cd todo-api
   ```

2. Build and run the application:
   ```bash
   dotnet run
   ```

3. The API will be available at `https://localhost:5001/api/tasks`.

## API Endpoints
### `GET /api/tasks`
Retrieve all tasks.

### `POST /api/tasks`
Create a new task. Example body:
```json
{
  "title": "New Task",
  "completed": false
}
```

### `PUT /api/tasks/{id}`
Update a task by ID. Example body:
```json
{
  "title": "Updated Task",
  "completed": true
}
```

### `DELETE /api/tasks/{id}`
Delete a task by ID.

## Notes
This project uses in-memory storage; changes will not persist after restarting the application.
