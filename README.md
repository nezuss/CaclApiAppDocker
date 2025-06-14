# Installing

Clone the repository using `https://github.com/nezuss/CaclApiAppDocker.git` from with-volume branch.
Then  into the cloned directory `cd backend`.

# Build the Docker image

First, build the Docker image using the following command: `docker build -t backend .`
Second, run the Docker container using the following command: `docker run -d -p 8181:5116 --name backendC -v backenddata:/app/data backend`
Then you can access the API at `http://localhost:8181/swagger/index.html`
