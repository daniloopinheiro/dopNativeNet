# dopNativeNet

[![dopNN Net - CI](https://github.com/daniloopinheiro/dopNativeNet/actions/workflows/dotnet.yml/badge.svg?branch=develop)](https://github.com/daniloopinheiro/dopNativeNet/actions/workflows/dotnet.yml)

**Arquitetura distribuída moderna com .NET**, projetada para ambientes empresariais que demandam **alta escalabilidade**, **resiliência**, **observabilidade** e **automatização total**.

O `dopNativeNet` é um projeto de referência que integra **microserviços desacoplados** com tecnologias de ponta como **containers**, **orquestradores**, **CI/CD**, **GitOps**, **monitoramento** e **comunicação assíncrona**.

---

## 📃 Índice

1. [Visão Geral](#visão-geral)
2. [Técnicas Aplicadas](#técnicas-aplicadas)
3. [Instalação](#instalação)
4. [Como Usar](#como-usar)
5. [Arquitetura de Referência](#arquitetura-de-referência)
6. [Contribuições](#contribuições)
7. [Licença](#licença)
8. [Contato](#contato)

---

## 🔍 Visão Geral

Este projeto demonstra uma implementação robusta de sistemas distribuídos com .NET 7+, aplicando:

* Separacão de responsabilidades via **microserviços**
* Execução via **containers Docker**
* Orquestração com **Kubernetes / Azure Container Apps**
* Integração com **mensageria** (Kafka, RabbitMQ)
* Automatização com **GitHub Actions / GitOps**
* Observabilidade com **OpenTelemetry**, **Prometheus**, **Grafana**, **Datadog**, **Elastic Stack**
* Escalabilidade horizontal e resiliente

---

## 🌐 Técnicas Aplicadas

| Categoria              | Tecnologias Utilizadas                                           |
| ---------------------- | ---------------------------------------------------------------- |
| Linguagem              | .NET 7+, C#                                                      |
| Microsserviços         | REST, gRPC, Event-Driven, Domain-Oriented Services               |
| Containers             | Docker, Docker Compose                                           |
| Orquestração           | Kubernetes, Kustomize, Helm                                      |
| Comunicação Assíncrona | Apache Kafka, RabbitMQ, Azure Service Bus                        |
| Backing Services       | PostgreSQL, Redis, MongoDB, ElasticSearch, Azure Blob Storage    |
| CI/CD                  | GitHub Actions, GitLab CI, ArgoCD (GitOps)                       |
| DevOps                 | Docker Registry, Kubernetes, Observability Stack                 |
| Observabilidade        | OpenTelemetry, Grafana, Prometheus, Jaeger, Datadog, Elastic APM |
| Monitoramento          | Health Checks, Dashboards, Alerts, Traces, Logs estruturados     |

---

## ⚙️ Instalação

### Requisitos

* [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download)
* [Docker](https://www.docker.com/)
* [Kubernetes](https://kubernetes.io/) (ou minikube/k3d)
* [Helm](https://helm.sh/)
* [Git](https://git-scm.com/)

### Clonar o repositório

```bash
git clone https://github.com/daniloopinheiro/dopNativeNet.git
cd dopNativeNet
```

### Subir os containers

```bash
docker-compose up -d
```

### Aplicar manifestos no Kubernetes (exemplo com Kustomize)

```bash
kubectl apply -k k8s/overlays/dev
```

---

## 🚀 Como Usar

### Iniciar aplicações

```bash
cd src/Services/OrderService
dotnet run
```

### Executar testes automatizados

```bash
dotnet test
```

### Acessar Swagger / Endpoints

```
https://localhost:5001/swagger
```

---

## 🛀 Arquitetura de Referência

```bash
dopNativeNet/
│
├── src/
│   ├── Services/                # Microserviços independentes
│   │   ├── OrderService/       
│   │   ├── CatalogService/     
│   │   └── PaymentService/     
│   
│   ├── BuildingBlocks/         # Reutilizáveis (EventBus, Middlewares, Logging)
│   ├── Observability/          # Instrumentação com OpenTelemetry
│   ├── Infrastructure/         # Repositórios, Mensageria, Caches
│   └── Gateway/                # API Gateway (YARP, Ocelot, BFF)
│
├── tests/                      # Testes unitários e de integração
├── k8s/                        # Manifests do Kubernetes (base/overlays)
├── docker-compose.yml          # Subida local de serviços e dependências
├── .github/workflows/          # CI/CD (GitHub Actions)
└── README.md
```

---

## 📄 Contribuições

Contribuições são bem-vindas! Para colaborar:

1. Fork este repositório
2. Crie uma branch: `git checkout -b feature/nova-feature`
3. Commit: `git commit -m 'feat: nova funcionalidade'`
4. Push: `git push origin feature/nova-feature`
5. Abra um **Pull Request**

---

## 📅 Licença

Este projeto está sob a [Licença MIT](LICENSE).

---

## 👋 Contato

* **Email Pessoal**: [daniloopro@gmail.com](mailto:daniloopro@gmail.com)
* **Email Empresarial**: [devsfree@devsfree.com.br](mailto:devsfree@devsfree.com.br)
* **Consultoria**: [contato@dopme.io](mailto:contato@dopme.io)
* **LinkedIn**: [Danilo O. Pinheiro](https://www.linkedin.com/in/daniloopinheiro)

---

<p align="center">Feito com ❤️ por <strong>Danilo O. Pinheiro</strong><br/> <a href="https://devsfree.com.br" target="_blank">DevsFree</a> • <a href="https://dopme.io" target="_blank">dopme.io</a></p>
