# Employee Management System - C# OOP & SOLID Principles Showcase

This project is a practical demonstration of advanced Object-Oriented Programming (OOP) concepts and SOLID principles in C#.  
It features a flexible employee hierarchy with real-world design patterns.

## Key Concepts Covered

### SOLID Principles
- **Single Responsibility Principle (SRP)**: `EmployeePrinter` handles all output, keeping employee classes focused on behavior.
- **Open-Closed Principle (OCP)**: New employee types (e.g., `Consultant`) added without modifying existing code.
- **Liskov Substitution Principle (LSP)**: Demonstrated with violation/fix example using `Intern` class.
- **Interface Segregation Principle (ISP)**: Small, focused interfaces (`IManageable`, `IDevelop`).
- **Dependency Inversion Principle (DIP)**: Program depends on `IEmployeeRepository` abstraction.

### Design Patterns
- **Factory Pattern**: Centralized employee creation with strategy injection (`EmployeeFactory`).
- **Strategy Pattern**: Flexible salary calculation via injectable strategies.
- **Decorator Pattern**: Dynamic addition of bonus and insurance without modifying core classes.
- **Repository Pattern**: Data access separated (in-memory implementation).
- **Singleton Pattern**: Thread-safe logger (`CompanyLogger`).

## Features
- Abstract base class `Employee` with polymorphic `Introduce()` and `Work()`.
- Multiple inheritance paths: Manager, Developer, Consultant, Intern.
- Interface-based operations for specific behaviors.
- In-memory repository for employee management.
- Comprehensive logging using Singleton.

## How to Run
1. Clone the repository.
2. Open `EmployeeManagementSystem.sln` in Visual Studio.
3. Set `EmployeeManagementConsole` as startup project.
4. Run (Ctrl+F5) – observe polymorphic behavior, salary calculation, decoration, and logging.

## Why This Project?
Perfect for discussing OOP, SOLID, and design patterns.

Built with .NET 10 – December 2025