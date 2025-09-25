# CaclApiAppDocker

## Installation

1. Clone the repository:
   ```
   git clone https://github.com/nezuss/CaclApiAppDocker.git
   ```
2. Make sure you have Docker installed on your machine.

## Running the Project

1. Build and run the Docker container:
   ```
   docker build -t backend .
   docker run -d -p 8181:5116 --name backendC backend
   ```
2. The API will be available at `http://localhost:8181`.

## Usage

Send requests to the API endpoint using any HTTP client (such as curl or Postman) or use Swagger.
Refer to the API documentation for available routes and parameters.
