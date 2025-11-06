# Bookify

# Launch DB in Docker

Run the DB container in the docker network:
```bash
docker run --name bookify.db \
  -e POSTGRES_USER=postgres \
  -e POSTGRES_PASSWORD=postgres \
  -e POSTGRES_DB=bookify \
  -p 5432:5432 \
  -v ./.containers/database:/var/lib/postgresql/data \
  -d postgres
```
