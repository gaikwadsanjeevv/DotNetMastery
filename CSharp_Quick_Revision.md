
# C# Quick Revision Guide

---

## 1. Basics
- **Data Types**: `int`, `float`, `double`, `char`, `bool`, `string`, `decimal`
- **Variables**: Declared using `type name = value;`
- **Constants**: `const int speed = 100;`
- **Nullable Types**: `int? age = null;`
- **Type Conversion**: `Convert.ToInt32()`, `int.Parse()`

---

## 2. Control Statements
- **if-else**, **switch-case**
- **Loops**: `for`, `while`, `do-while`, `foreach`
- **Jump Statements**: `break`, `continue`, `return`

---

## 3. OOP Concepts
- **Class**: Blueprint for objects
- **Object**: Instance of class
- **Encapsulation**: Using access modifiers (`private`, `public`, `protected`, `internal`)
- **Inheritance**: `: baseClass`
- **Polymorphism**: `Method Overloading` and `Overriding`
- **Abstraction**: Using `abstract` classes and `interfaces`
- **Constructor**: Initializes an object
- **Destructor**: `~ClassName()` (rarely used in modern C#)

---

## 4. Properties & Indexers
- **Auto Properties**:
  ```csharp
  public string Name { get; set; }
  ```
- **Computed Properties**:
  ```csharp
  public int Age => DateTime.Now.Year - BirthYear;
  ```
- **Indexers**:
  ```csharp
  public string this[int index] { get { ... } set { ... } }
  ```

---

## 5. Exception Handling
```csharp
try {
   // code
} catch (Exception ex) {
   Console.WriteLine(ex.Message);
} finally {
   // always runs
}
```

---

## 6. Delegates, Events & Lambda
- **Delegate**: Type-safe function pointer
  ```csharp
delegate void MyDelegate(string msg);
MyDelegate d = Console.WriteLine;
d("Hello");
```
- **Event**: Publisher-subscriber model
- **Lambda Expression**: `x => x * x`

---

## 7. Collections
- **Array**: `int[] arr = new int[5];`
- **List**: `List<int> list = new List<int>();`
- **Dictionary**: `Dictionary<int, string>`
- **Queue**, **Stack**, **HashSet**

---

## 8. LINQ (Language Integrated Query)
```csharp
var result = from s in students where s.Age > 18 select s;
var result2 = students.Where(s => s.Age > 18).ToList();
```
- LINQ Methods: `Where()`, `Select()`, `OrderBy()`, `GroupBy()`, `FirstOrDefault()`

---

## 9. File Handling
```csharp
File.WriteAllText("file.txt", "Hello");
string content = File.ReadAllText("file.txt");
```
- Use `StreamReader`, `StreamWriter` for large data

---

## 10. Asynchronous Programming
```csharp
async Task<int> GetDataAsync() {
    await Task.Delay(1000);
    return 5;
}
```
- Keywords: `async`, `await`, `Task`, `ValueTask`

---

## 11. Attributes & Reflection
- **Attribute**: `[Obsolete]`, `[Serializable]`
- **Reflection**: Used to inspect metadata at runtime
  ```csharp
  typeof(MyClass).GetMethods();
  ```

---

## 12. Dependency Injection (DI)
- Built-in in ASP.NET Core
```csharp
services.AddScoped<IMyService, MyService>();
```

---

## 13. ASP.NET Core Basics
- **Middleware**: Custom pipeline via `Configure()`
- **Controllers**: Handle HTTP requests
- **Routing**: Attribute or conventional
- **Models/Views/Controllers (MVC)** architecture

---

## 14. Entity Framework Core (EF Core)
- ORM for .NET
- **DbContext**, **DbSet<T>**
- Migrations: `Add-Migration`, `Update-Database`
```csharp
public class AppDbContext : DbContext {
    public DbSet<Student> Students { get; set; }
}
```

---

## 15. Unit Testing
- Frameworks: `xUnit`, `NUnit`, `MSTest`
- Mocking: `Moq`

---

## 16. Useful Tools & Libraries
- **NuGet**, **Swagger**, **AutoMapper**, **Serilog**, **FluentValidation**, **MediatR**

---

> ✅ For deeper learning, check: [Microsoft C# Docs](https://learn.microsoft.com/en-us/dotnet/csharp/)
