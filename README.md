**Task Tracker**
The Task Tracker is a project that allows users to manage their tasks using a microservice-based architecture. It utilizes ASP.NET Core Web API and ASP.NET Core Web Pages (Razor) frameworks, and is packaged and deployed using Docker containers on Microsoft Azure.

**Features**
+ Task Management: Users can create, update, and delete tasks, as well as view a list of all their tasks.
+ Task Prioritization: Tasks can be assigned different priority levels, allowing users to focus on the most important ones.
+ Task Scheduling: Users can set due dates and reminders for their tasks.
+ User Authentication: The application supports user authentication, allowing each user to manage their own tasks.
+ Microservices Architecture: The application is built using a microservices architecture, with separate services for task management, user management, and authentication.
+ Docker Containerization: The application is packaged and deployed using Docker containers, ensuring consistency and scalability.
+ Azure Deployment: The application is deployed on Microsoft Azure, leveraging the cloud platform's scalability and reliability.
**Technologies Used**
+ ASP.NET Core Web API: For building the microservices that handle task management, user management, and authentication.
+ ASP.NET Core Web Pages (Razor): For building the user interface and client-side functionality.
+ Docker: For packaging and deploying the application as containerized services.
+ Microsoft Azure: For hosting and running the containerized application.
**Getting Started**
Prerequisites
+ Docker installed on your machine
+ Azure CLI installed (optional, for Azure deployment)
# Running Locally
Clone the repository:
git clone https://github.com/your-username/task-tracker.git
# Navigate to the project directory:
cd task-tracker
# Build and run the Docker containers:
docker-compose up --build
Access the application in your web browser at http://localhost:8080.
# Deploying to Azure
1. Log in to your Azure account using the Azure CLI:
az login
2. Create an Azure Container Registry (ACR) instance:
az acr create --resource-group your-resource-group --name your-acr-name --sku Basic
3. Build and push the Docker images to the ACR:
docker build -t your-acr-name.azurecr.io/task-tracker .
docker push your-acr-name.azurecr.io/task-tracker
4. Create an Azure Container App environment:
az containerapp env create --resource-group your-resource-group --name your-env-name
5. Deploy the application to the Azure Container App environment:
az containerapp create --resource-group your-resource-group --name task-tracker --environment your-env-name --image your-acr-name.azurecr.io/task-tracker --target-port 80 --ingress 'auto'6. Access the application in your web browser using the public IP address or DNS name of the AKS cluster.
**Contributing**
Contributions to the Task Tracker project are welcome. If you would like to contribute, please follow the standard GitHub workflow:
1. Fork the repository
2. Create a new branch
3. Make your changes
4. Submit a pull request
