
---

# BankApp - Basic Bank Account Simulation

This project is a simple simulation of a bank account in C#. It allows users to deposit and withdraw money from their account while maintaining the account balance securely using encapsulation.

## Description

The project demonstrates how to simulate basic banking operations such as **depositing** and **withdrawing** money from an account. The `BankAccount` class manages the account balance, ensuring that operations on the balance are encapsulated and handled through specific methods.

### Class: `BankAccount`

#### Properties:
- **accountBlance** (private): Represents the current balance of the bank account. It is hidden from direct access to ensure encapsulation.

#### Methods:
1. **withDraw(int amount)**: This method simulates a withdrawal operation by **increasing** the account balance by the given amount. (Note: The name suggests withdrawal but currently behaves like a deposit.)
   
2. **deposit(int amount)**: This method simulates a deposit operation by **decreasing** the account balance by the given amount. (Note: The current logic in this method should be revisited as it behaves opposite to the intended deposit functionality.)

3. **accountBlanceCheck()**: This method returns the current balance of the account. It acts as a getter for the private `accountBlance` field.

## Main Method:
In the `Main` method, an instance of the `BankAccount` class is created, and several operations are performed on it:

1. Checking the initial account balance.
2. Withdrawing an amount from the account (simulated by increasing the balance).
3. Depositing an amount into the account (simulated by decreasing the balance).

### Code Example:

```csharp
BankAccount b1 = new BankAccount();
Console.WriteLine(b1.accountBlanceCheck());

b1.withDraw(1500);
Console.WriteLine("Amount in your bank account:" + b1.accountBlanceCheck());

b1.deposit(100);
Console.WriteLine("Amount in your bank account:" + b1.accountBlanceCheck());
```

### Output Example:

```
0
Amount in your bank account:1500
Amount in your bank account:1400
```

## Key Concepts:

- **Encapsulation**: The bank account balance is a private field, ensuring it is only modified through controlled methods. This helps maintain the integrity of the account data.
  
- **Bank Operations**: The project introduces basic banking operations such as depositing and withdrawing money, though the logic should be adjusted as follows:
  - **withdraw** should decrease the balance.
  - **deposit** should increase the balance.

## Suggested Fixes:
- To align with typical banking logic, the following changes are suggested:
  - In the `withDraw()` method, change `accountBlance += amount;` to `accountBlance -= amount;` to properly simulate money withdrawal.
  - In the `deposit()` method, change `accountBlance -= amount;` to `accountBlance += amount;` to correctly add money to the balance.

## How to Run:
1. Clone or download the project to your local machine.
2. Open the project in a C# IDE (like Visual Studio).
3. Run the program by pressing `F5` or clicking "Start" in your IDE.

## Purpose:
This project serves as a basic demonstration of:
- Encapsulation in object-oriented programming.
- Basic banking operations using C# classes and methods.
- The importance of controlled access to class fields using getter and setter methods.

---

