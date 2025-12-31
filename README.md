# 🚀 OmniChannel Dispatcher – Notification API w/ Strategy Pattern

![Status](https://img.shields.io/badge/Status-Completed-success?style=flat)
![.NET](https://img.shields.io/badge/.NET-10-512BD4?style=flat&logo=dotnet&logoColor=white)
![CSharp](https://img.shields.io/badge/C%23-239120?style=flat&logo=csharp&logoColor=white)
![Tests](https://img.shields.io/badge/Tests-xUnit%20%7C%20FluentAssertions-blue?style=flat)
![CI](https://img.shields.io/badge/CI-GitHub%20Actions-2088FF?style=flat&logo=githubactions&logoColor=white)

---

## 📖 About the Project

**OmniChannel Dispatcher** is a **boilerplate notification API** built with **.NET 10**, designed to demonstrate the practical use of a **design pattern** within the evolution of a software system.

This project has a strong **educational and architectural focus**, serving as a **hands-on case study of Clean Architecture, SOLID principles, and Design Patterns**, with special emphasis on **Dependency Inversion** and the **Strategy Pattern**.

> 🧠 “Architecture is not about frameworks, it’s about well-made decisions.”

---

## 🎯 Architectural Goal

Inspired by the guide **“From Fragility to Fluency”**, the system addresses classic architectural problems such as:

- Excessive use of `new`
- Strong coupling between layers
- Difficulty in testing
- Unsustainable code growth

The solution is built upon:

- **Inversion of Control (IoC)**
- **Dependency Injection**
- **Polymorphism instead of conditionals**

---

## 🏗️ Design Patterns & Principles Applied

### 🧩 Strategy Pattern

Enables dynamic selection of notification channels (**Email, SMS, Push**) at runtime, **without using `if` or `switch` statements**, fully respecting the:

- **OCP – Open/Closed Principle**

Each channel is implemented as an independent strategy, making the system easy to extend without modifying existing code.

---

### 🔌 Dependency Injection (DI)

Advanced usage of the **native .NET DI container** to:

- Manage object lifetimes (`Scoped`)
- Resolve multiple implementations via `IEnumerable<T>`
- Eliminate direct dependencies on concrete implementations

---

### ⚡ Fail-Fast with FluentValidation

Validations are executed **at the very beginning of the pipeline**, preventing unnecessary processing:

- Clear validation rules
- Consistent error messages
- DTOs protected from invalid states

---

### 🛑 Resilience with CancellationToken

Propagation of `CancellationToken` across all layers to enable:

- Cooperative request cancellation
- Efficient server resource usage
- Better scalability under load

---

## 🛠️ Technologies Used

### Core Stack

| Technology | Description |
|---------|------------|
| **.NET 10** | Runtime and main framework |
| **ASP.NET Core** | Web API framework |
| **C#** | Primary programming language |

### Quality & Infrastructure

| Technology | Description |
|---------|------------|
| **FluentValidation** | Fail-fast input validation |
| **xUnit** | Unit testing framework |
| **NSubstitute** | Mocking framework |
| **FluentAssertions** | Expressive assertions |
| **GitHub Actions** | Automated CI pipeline |

---

## 🧪 Testing Strategy

The project follows the **Test Pyramid**, prioritizing isolation and fast feedback.

### ✅ Implemented Tests

- **Unit Tests**
  - Validation of the `NotificationService`
  - Strategies isolated using mocks

- **Validation Tests**
  - Business rules applied to DTOs
  - Example: minimum of 3 characters

- **Middleware Tests**
  - Correct exception-to-response mapping
  - HTTP Status Codes:
    - `400 Bad Request`
    - `500 Internal Server Error`

---

## 🚀 How to Run the Project

### 📥 Clone the Repository

```bash
git clone https://github.com/SEU-USUARIO/.NET-OmniChannel-StrategyPattern.git
