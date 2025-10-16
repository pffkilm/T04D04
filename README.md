# T04D04

You can find useful video materials in the “Projects (Media)” section on the Platform.  

---

## Contents

1. [Chapter I](#chapter-i)  
    1.1. [Level 3. Room 1.](#level-3-room-1)
2. [Chapter II](#chapter-ii)  
    2.1. [Avalonia UI.](#avalonia-ui)  
    2.2. [NetManager.](#netmanager)
3. [Chapter III](#chapter-iii)  
    3.1. [Quest 1. Repair.](#quest-1-repair)  
    3.2. [Quest 2. Add Order.](#quest-2-add-order)  
    3.3. [Quest 3. Edit Order.](#quest-3-edit-order)  
    3.4. [Quest 4. Delete Order.](#quest-4-delete-order)  
    3.5. [Quest 5. Final Test.](#quest-5-final-test)

---

# Chapter I

## Level 3. Room 1.

***LOADING LEVEL 3...***

***SYSTEM CHECK... OK***  
***UI SUBSYSTEM INITIALIZATION FAILED***

> *Look around*

This time, you wake up in a spacious room illuminated by a soft blue light.  
On the table stands another computer labeled **Avalonia Client**.  
The monitor displays the message:

> “UI ERROR. CONNECTION TO API FAILED.  
>  DATA ACCESS DISABLED.”

Next to it lies a note written in a nervous hand:

> “The interface is broken. The AI can’t see the server again.  
>   Everything we built is only available through the API.  
>   Fix the Avalonia app.  
>   Let it add, edit, and delete orders again.  
>   Use the NetManager — it knows how to talk to the server.”

> *Turn on the computer*

***LOADING AVALONIA MODULE...***  
***UI COMPILATION FAILED***  
***HINT: Check your bindings and API connections***

---

# Chapter II

## Avalonia UI

> **Avalonia** is a cross-platform framework for creating desktop applications in .NET.  
> It’s similar to WPF but works on Windows, Linux, and macOS.  
> It allows building interfaces using XAML and connecting to APIs, databases, and other services.

Typical Avalonia project structure:
```
/Models
    Order.cs
    Product.cs
/Pages
    OrdersPage.axaml
    AddEditOrderPage.axaml
/Services
    NetManager.cs
MainWindow.axaml
```

Main concepts:
- **Pages** — visual representation (XAML).  
- **Models** — data models from API or DB.  
- **Service** — helper classes (e.g., for API requests).  
- **Binding** — connects data between Page and Model.

---

## NetManager

> **NetManager** is a class responsible for the communication between the Avalonia application and the external API.  
> It usually implements `Get`, `Post`, `Put`, and `Delete` methods to work with RESTful services.

---

# Chapter III

## Quest 1. Repair.

The AI speaks in a trembling voice:

> “UI subsystem not responding...  
>  Rebuild interface... Restore bindings...”

_**== Quest 1 received. Fix the Avalonia application and restore communication with the API. ==**_

**Tasks:**
1. Make sure the application builds and runs without errors.  
2. Verify that `NetManager` has the correct API endpoint.  
3. Check that the connection to the API works properly.

---

## Quest 2. Add Order.

The AI comes alive on the screen:

> “I remember now... orders... humans made them... Teach me to create again.”

_**== Quest 2 received. Implement order creation through the API. ==**_

**Tasks:**
1. Configure `AddEditOrderPage` to send a POST request using `NetManager`.  
2. Add validation for the order.  
3. After successful creation, refresh the order list.  
4. Handle network errors (e.g., server unavailable).

---

## Quest 3. Edit Order.

The AI says:

> “Some memories are wrong... Help me change them.”

_**== Quest 3 received. Implement order editing through the API. ==**_

**Tasks:**
1. Implement editing of a selected order (PUT request).  
2. Add an interface for selecting and editing an order.  
3. Verify that changes are saved on the server.  

---

## Quest 3 (Bonus). Add Products.

> “An order contains not only a name, but also its composition.”

_**== Bonus Received. Implement adding products to an order via the API. ==**_

**Tasks:**

1. Implement displaying the list of products on the order creation/editing page using the api/Product endpoint.

2. Implement saving the list of selected products.

***Example implementation:***

1. Display a list of all available products.
2. Add a "Add Product" button.
3. Get the selected product from the list and add it to the order.
4. Save the order.

---

## Quest 4. Delete Order.

The AI speaks coldly:

> “Some data must be forgotten.”

_**== Quest 4 received. Implement order deletion through the API. ==**_

**Tasks:**
1. Implement a DELETE request using `NetManager`.  
2. After deletion, refresh the order list in the UI.  

---

## Quest 5. Final Test.

> *The screen flickers with a new message:*

> “SYSTEM ONLINE.  
>  CONNECTION STABLE.  
>  MEMORY SYNCHRONIZED.”

_**== Quest 5 received. Test the Avalonia application. ==**_

**Tasks:**
1. Test adding, editing, and deleting orders.  
2. Ensure data is synchronized with the API.  
3. Commit your work with the message:  
   ```
   feat: connected Avalonia client with API (Orders CRUD)
   ```

***LOADING...***  
***USER INTERFACE REBUILT SUCCESSFULLY***  
***NEXT LEVEL UNLOCKED...***  
