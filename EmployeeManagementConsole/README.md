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