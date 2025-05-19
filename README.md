# Saucedemo UI Automation Tests

This is a UI automation project for [SauceDemo.com](https://www.saucedemo.com/), built using -C#-, -Selenium WebDriver-, and -NUnit-, following the -Page Object Model (POM)-.

The goal of this project is to demonstrate practical automation testing skills.

---

## ✅ Features

- UI automation using C#, Selenium, and NUnit
- Automated login tests (valid and invalid scenarios)
- Chrome popup suppression for stable test execution
- Organized test classes by feature (Login, Cart, Checkout)
- Use of POM for clean test structure
- Wait helper for stable UI interactions
- Cross-browser-ready architecture (currently Chrome only)

---

## 🔧 Tech Stack

| Tool        | Purpose                      |
|-------------|------------------------------|
| C#          | Programming language         |
| Selenium    | UI automation framework      |
| NUnit       | Test framework               |
| ChromeDriver| Browser driver               |
| .NET 8.0    | Runtime                      |

---

## 🧪 Test Coverage

### 🔐 Login
- [x] Valid login
- [x] Invalid login
- [x] Empty credentials

### 🛒 Cart
- [x] Add item to cart
- [x] Remove item from cart
- [x] Verify cart badge

### 📦 Inventory
- [x] Sort products by price (low to high)
- [x] Verify product name and price consistency between inventory and cart

### 💳 Checkout
- [x] Proceed with valid data
- [x] Error on missing required fields (postal code)
- [x] Complete checkout and verify success message

---

##📌 Notes
The site under test is a demo app provided by Sauce Labs.

Credentials used in tests:

Username: standard_user

Password: secret_sauce

Tests are intentionally beginner-friendly for learning and portfolio purposes.

---

##👨‍🎓 Author
**Georgi Dimitrov**
Junior QA Engineer
Graduate of SoftUni
