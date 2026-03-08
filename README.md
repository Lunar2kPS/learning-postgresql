# Learning PostgreSQL
This repo contains some of my own personal examples of PostgreSQL for software and RPG/gaming database backends, using a Docker Compose setup to make setup and testing easy and predictable across machines.


## Development / Testing Workflow
```sh
# We use Docker a bind mount (basically an unnamed Docker volume in docker-compose.yml) to link a folder on our host machine to automatically be synced/available inside the Docker container.

# First, we enter in the Docker container with a bash terminal:
docker exec -it postgresql-database bash

# Once we're in the PostgreSQL database container, we create our first DATABASE in PostgreSQL:
psql -U root
CREATE DATABASE "Learning PostgreSQL"; # IMPORTANT: If you don't end this with a semi-colon, the psql command-line tool WILL NOT RUN your PostgreSQL query.
\q

# Then, we can run a script and tell it to operate on that DATABASE:
psql -U root -d "Learning PostgreSQL" -f /sql/example.sql
```
