# Learning PostgreSQL
This repo contains some of my own personal examples of PostgreSQL for software and RPG/gaming database backends, using a Docker Compose setup to make setup and testing easy and predictable across machines.

```sh
# TODO: Use an improved workflow with Docker Volumes for more instantaneous file editing updates:
docker cp ./example.sql postgresql_database:/root/example.sql

docker exec -it postgresql_database bash

# NOTE: This uses the psql command line tool, operates with the root user and "Learning PostgreSQL" DATABASE, and runs the given file inside the running Docker container.
psql -U root -d "Learning PostgreSQL" -f /root/example.sql
```
