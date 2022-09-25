# Online Banking System with ASP.NET Core 3.1 

**This is the largest project I have ever got from my freelacing clients, I leart a lot like how does the fin-tech world works**

**Online Banking System** is a web app where users can create bank accounts, transfer money, create payment cards, pay with them or directly through their account, etc.
It supports connecting multiple banks together through the _CentralApi_. This allows money to be securely transferred between **separate instances of Online Banking System** running on different machines.

## Documentation


Online Banking System consists of two base components - the bank web application and the _CentralApi_, which securely connects banks running on separate machines together to process transfers between different banks, card payments and direct payments.

Additionally, all bank accounts created have an initial balance of €500 for demonstration purposes.



### [Bank accounts]
Bank accounts hold information about their owner, balance, transactions, date of creation, etc.

### [Money transfers]
Online Banking System supports two types of money transfers - internal and global / worldwide.

### [Cards]
Cards are used for making purchases on other websites using the _CentralApi_.

### [Direct payments]
Direct payments are a way to securely pay on websites directly through a bank account without the need to provide card details.


**Used technologies:**
* C#
* ASP.NET Core 3.1
* ASP.NET Core MVC
* ASP.NET Core Web API
* Entity Framework Core
* Asymmetric & hybrid encryption
* jQuery
* AJAX
* HTML
* CSS
* Bootstrap

***

