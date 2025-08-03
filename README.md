## .NET Aspire Course
This repository contains the code examples and exercises for the .NET Aspire course. The course is designed to help developers learn and master .NET technologies.
## Course Structure
The course is divided into several modules, each focusing on different aspects of .NET development. Each module contains code examples, exercises, and resources to help you understand the concepts.
## Getting Started
To get started with the course, follow these steps:
1. Clone the repository to your local machine:
   ```bash
   git clone
   ```
2. Navigate to the course directory:
   ```bash
   cd Podcasts-Aspire
   ```
3. Open the solution file in Visual Studio or your preferred IDE.
4. Follow the instructions in each module to complete the exercises and examples.


## Dotnet Migrations:
To create migrations to the database, you can use the following command:
```bash
dotnet ef migrations add --project Entities/Entities.csproj --startup-project Api/Api.csproj --context Entities.PodcastDbContext --configuration Debug InitialCreate --output-dir Migrations
```

## Docker Container
To run the course examples in a Docker container, you can use the provided Dockerfile. Follow these steps:
```bash
docker compose -f docker-compose.yaml -p podcasts-aspire up -d --build  
```
This command will build the Docker image and automatically seed the database with sample data. 

Start the application (AppHost project) and access it via the following URLs:
- Aspire dashboard: `https://localhost:15011` or `http://localhost:15299`
- Podcasts API: `https://localhost:7092` or `http://localhost:5142`
- Podcasts UI: `https://localhost:7032` or `http://localhost:5115`

## Other Integrations (just for reference)
- RabbitMQ: The course includes RabbitMQ integration for message queuing.
- Redis: Redis is used for caching and session management.
- MongoDB: MongoDB is used for NoSQL data storage.
