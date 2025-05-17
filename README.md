# Saucedemo UI Automation Tests

This is a UI automation project for [SauceDemo.com](https://www.saucedemo.com/), built using -C#-, -Selenium WebDriver-, and -NUnit-, following the -Page Object Model (POM)-.

The goal of this project is to demonstrate practical automation testing skills.

---

## ✅ Features

- Automated login tests (valid and invalid scenarios)
- Add to cart functionality test
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

## 🗂 Project Structure

saucedemo-ui-tests/
│
├── Drivers/ → WebDriver config
├── Pages/ → Page Object Model classes
├── Tests/ → NUnit test classes
├── Utilities/ → Reusable helpers (wait)
├── saucedemo-ui-tests.csproj

---

##📌 Notes
The site under test is a demo app provided by Sauce Labs.

Credentials used in tests:

Username: standard_user

Password: secret_sauce

Tests are intentionally beginner-friendly for learning and portfolio purposes.

---

##👨‍🎓 Author
Georgi Dimitrov
Junior QA Engineer
Graduate of SoftUni
