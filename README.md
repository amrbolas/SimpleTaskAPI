TaskApi
A simple Task Management REST API built with ASP.NET Core Web API.
Requirements

This project was built as part of my journey to learn backend development using ASP.NET Core


.NET SDK (version 9 or 10)

Getting Started
1. Clone the project
bashgit clone https://github.com/amrbolas/SimpleTaskAPI.git
cd TaskApi
2. Install Swagger package
bashdotnet add package Swashbuckle.AspNetCore --version 6.9.0
3. Run the project
bashdotnet run
4. Open your browser

API: http://localhost:5109/api/tasks
Swagger UI: http://localhost:5109/swagger

API Endpoints
MethodEndpointDescriptionGET/api/tasksGet all tasksPOST/api/tasksAdd a new taskPUT/api/tasks/{id}Update a taskDELETE/api/tasks/{id}Delete a task
Example Request (POST)
json{
  "title": "My first task",
  "completed": false
}
Stop the server
Press Ctrl + C in the terminal.