# Implementación DevOps 1 - Lavandería Olivo

Este repositorio contiene la base técnica de una arquitectura de microservicios para Lavandería Olivo. La entrega demuestra control de versiones, contenerización, integración continua y preparación para servicios en la nube.

## Servicios

- `AuthService`: autenticación y control inicial de usuarios.
- `CatalogService`: catálogo de lavado, secado, planchado y membresías.
- `OrdersService`: creación y seguimiento de órdenes.
- `PaymentsService`: registro administrativo de pagos asociados a órdenes. No procesa pagos electrónicos.

## Requisitos

- Git 2.40 o superior.
- Docker Desktop con Docker Compose.
- .NET SDK 8.0 para ejecución local sin contenedores.
- Visual Studio 2022 o Visual Studio Code.

## Configuración

1. Copiar `.env.example` como `.env`.
2. Cambiar las credenciales de ejemplo antes de usar un ambiente compartido.
3. Ejecutar `docker compose up --build`.
4. Verificar los servicios:
   - Auth: `http://localhost:5001/health`
   - Catálogo: `http://localhost:5002/health`
   - Órdenes: `http://localhost:5003/health`
   - Pagos: `http://localhost:5004/health`

## Pruebas

Ejecutar `dotnet test tests/LavanderiaOlivo.Tests/LavanderiaOlivo.Tests.csproj`.

## Estructura

- `/src`: código fuente de los microservicios.
- `/docs`: arquitectura y evidencia de DevOps.
- `/docker`: Dockerfiles de cada microservicio.
- `/tests`: pruebas automatizadas básicas.
- `docker-compose.yml`: ejecución conjunta de servicios, PostgreSQL y Redis.
- `azure-pipelines.yml`: compilación y pruebas en Azure Pipelines.

## Flujo de trabajo

- `main`: versión estable.
- `develop`: integración del Sprint.
- `feature/*`: desarrollo de funcionalidades.

Los cambios se integran mediante pull requests y se relacionan con historias de usuario de Azure Boards.
