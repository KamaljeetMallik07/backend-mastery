# backend-mastery

A structured, self-paced practice repo for becoming a stronger .NET backend developer — built while working full-time.

Covers OOP fundamentals, design patterns, and system design — each problem paired with a real-world use case.

---

## Why this repo exists

This repo is my deliberate practice — building things from scratch, understanding the *why* behind patterns, and being able to talk about design decisions in interviews.

---

## Structure

```
backend-mastery/
├── oop-problems/
│   ├── Level1-BankAccount/
│   ├── Level1-ShapeCalculator/
│   ├── Level1-MultiTargetLogger/
│   ├── Level1-AnimalSoundSystem/
│   ├── Level2-PaymentProcessor/
│   ├── Level2-EmployeePermissions/
│   ├── Level2-ReportGenerator/
│   ├── Level2-TaxCalculator/
│   ├── Level3-VehicleRental/
│   └── Level3-GodClassRefactor/
├── design-patterns/
│   ├── Creational/
│   │   ├── Singleton-ConfigManager/
│   │   ├── Factory-NotificationFactory/
│   │   ├── Builder-SearchQueryBuilder/
│   │   └── Prototype-DocumentTemplate/
│   ├── Structural/
│   │   ├── Repository-UserRepository/
│   │   ├── Decorator-ApiClientChain/
│   │   ├── Adapter-PaymentGateway/
│   │   └── Facade-OrderFacade/
│   └── Behavioral/
│       ├── CQRS-SearchService/
│       ├── Strategy-SortingService/
│       ├── Observer-OrderEvents/
│       └── ChainOfResponsibility-Pipeline/
└── system-design/
    ├── url-shortener/
    ├── rate-limiter/
    ├── notification-service/
    └── leaderboard/
```

---

## Progress

### OOP Problems

| Problem | Concept | Status |
|---|---|---|
| Level1-BankAccount | Encapsulation, Validation | ✅ Done |
| Level1-ShapeCalculator | Inheritance, Method Overriding | 🔲 Pending |
| Level1-MultiTargetLogger | Abstraction, Interface | 🔲 Pending |
| Level1-AnimalSoundSystem | Polymorphism | 🔲 Pending |
| Level2-PaymentProcessor | Open/Closed Principle | 🔲 Pending |
| Level2-EmployeePermissions | RBAC via OOP | 🔲 Pending |
| Level2-ReportGenerator | Dependency Inversion | 🔲 Pending |
| Level2-TaxCalculator | Interface Segregation | 🔲 Pending |
| Level3-VehicleRental | All 4 OOP Pillars | 🔲 Pending |
| Level3-GodClassRefactor | Refactoring, SRP | 🔲 Pending |

### Design Patterns

| Pattern | Category | Status |
|---|---|---|
| Singleton-ConfigManager | Creational | 🔲 Pending |
| Factory-NotificationFactory | Creational | 🔲 Pending |
| Builder-SearchQueryBuilder | Creational | 🔲 Pending |
| Prototype-DocumentTemplate | Creational | 🔲 Pending |
| Repository-UserRepository | Structural | 🔲 Pending |
| Decorator-ApiClientChain | Structural | 🔲 Pending |
| Adapter-PaymentGateway | Structural | 🔲 Pending |
| Facade-OrderFacade | Structural | 🔲 Pending |
| CQRS-SearchService | Behavioral | 🔲 Pending |
| Strategy-SortingService | Behavioral | 🔲 Pending |
| Observer-OrderEvents | Behavioral | 🔲 Pending |
| ChainOfResponsibility-Pipeline | Behavioral | 🔲 Pending |

### System Design

| System | Core Concept | Status |
|---|---|---|
| URL Shortener | Hashing, Redis caching | 🔲 Pending |
| Rate Limiter | Token bucket, Redis | 🔲 Pending |
| Notification Service | Async fan-out, MediatR | 🔲 Pending |
| Leaderboard | Redis Sorted Sets | 🔲 Pending |

---

## Stack

![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=csharp&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-512BD4?style=flat&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=flat&logo=microsoftsqlserver&logoColor=white)
![Redis](https://img.shields.io/badge/Redis-FF4438?style=flat&logo=redis&logoColor=white)
![Azure](https://img.shields.io/badge/Azure-0078D4?style=flat&logo=microsoftazure&logoColor=white)
![Docker](https://img.shields.io/badge/Docker-2496ED?style=flat&logo=docker&logoColor=white)

---

## How I approach each problem

1. Read the problem statement fully
2. Design on paper — classes, interfaces, relationships
3. Code in C# with clean folder structure
4. Ask: *"What breaks at 1 million users?"*
5. Commit with a meaningful message

---

*Built by [Kamaljeet Mallik](https://in.linkedin.com/in/kamaljeet-mallik) — .NET Backend Developer*