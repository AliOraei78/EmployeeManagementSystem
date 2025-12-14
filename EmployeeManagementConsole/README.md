### Liskov Substitution Principle (LSP)

#### Violation Example
The `Intern` class inherits from `Employee` but throws an exception in the `Work()` method.

This violates LSP because:
- Subclasses should be substitutable for their base class.
- When we use `Intern` in a list of `Employee` and call `Work()`, the program crashes unexpectedly.

#### Fix
To comply with LSP:
- Implemented `Work()` without exception.
- Now any `Employee` subclass can safely replace `Employee` without breaking behavior.

LSP ensures code remains predictable and maintainable when using polymorphism.

## Single Responsibility Principle (SRP)

### Violation
Employee subclasses (Manager, Developer) were responsible for both business logic and printing/output.

### Fix
- Created a dedicated `EmployeePrinter` class responsible **only** for displaying information.
- Employee classes now focus solely on behavior and data.

Each class has only one reason to change → SRP achieved.

## Open-Closed Principle (OCP)

### Violation
Adding a new employee type would require modifying printing logic in multiple places.

### Fix
- Added a new `Consultant` class with its own behavior.
- No changes needed in `EmployeePrinter` or main program logic (only an optional type check for special methods).
- The system is **open for extension** (new employee types) but **closed for modification** (existing code untouched).

OCP is satisfied through polymorphism and proper abstraction.

## Interface Segregation Principle (ISP)

Interfaces are small and focused:
- `IManageable` for management actions
- `IDevelop` for development actions

No class is forced to implement unnecessary methods.

## Dependency Inversion Principle (DIP)

High-level module (Program) depends on abstraction (`IEmployeeRepository`).
Low-level implementation (`InMemoryEmployeeRepository`) can be swapped easily.

### Repository Pattern
- Data access separated from business logic.
- Current implementation: in-memory list.
- Methods: `GetAll()`, `Add()`, `GetById()`.