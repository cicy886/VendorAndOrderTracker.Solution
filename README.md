# Vendor and Order Tracker
___________
#### By Sisi Vieira
#### A simple C# application for bakery to keep track with its vendors and orders.

## Description
* A user can track the vendors that purchase backed goods from them and the orders belonging to those vendors.
* There are two classes. The Vendor class represent the cafe and the Order class help keep track of user's expanding business relationship.
* When the user runs the application, they receive a welcome message along with the links for both *view vendors* and *add a new vendor*.
* The user can see a list of vendors by clicking the *view vendors* link.
* When the user clicks on *add a new vendor* link, receives a form to create a new vendor.
* When the user fills out the form and clicks to the *add* button, the user is routed to the vendor list page.
* When the user clicks the vendor's name, the user is routed to the order page of that vendor.
* The user can create a new order by clicking the *add a new order*.
* When the user fills out the form and clicks to the *add order* button, the user is routed to the order list page.
* From the order list page, the user can click on *Return to vendor list* or the *Return to main page* or can *add a new order*.


## Technologies Used
* C#
* .NET 5.0

## Program Setup instruction
1. $ git clone https://github.com/cicy886/VendorAndOrderTracker.Solution.git
2. Navigate to **VendorAndOrderTracker.Tests** and run the command **dotnet restore** from the terminal
3. Run **$dotnet run** in **VendorAndOrderTracker** directory to run the executable file
4. Run **$dotnet test** in **VendorAndOrderTracker.Tests** directory to test the project functionality

## Known Bugs
* Order list is not displaying correctly
* Order detail list is not desplaying correctly

## GitHub page website
[https://cicy886.github.io/VendorAndOrderTracker.Solution/](https://cicy886.github.io/VendorAndOrderTracker.Solution/)
## License
[MIT](https://opensource.org/licenses/MIT)

Copyright (c) 2021 Sisi Vieira