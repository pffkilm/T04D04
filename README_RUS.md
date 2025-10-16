# T04D04

Полезные видеоматериалы ты можешь найти в разделе “Projects (Media)” на Платформе.  

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

> *Осмотреться*

На этот раз ты просыпаешься в просторной комнате, освещённой мягким голубым светом.  
На столе — другой компьютер, с аккуратной надписью **Avalonia Client**.  
Монитор показывает сообщение:

> “UI ERROR. CONNECTION TO API FAILED.  
>  DATA ACCESS DISABLED.”

Рядом лежит записка, нацарапанная нервным почерком:

> «Интерфейс сломан. ИИ снова не видит сервер.  
>   Всё, что мы построили, — доступно только через API.  
>   Почини Avalonia-приложение.  
>   Пусть оно снова сможет добавлять, изменять и удалять заказы.  
>   Используй NetManager — он знает, как говорить с сервером.»

> *Включить компьютер*

***LOADING AVALONIA MODULE...***  
***UI COMPILATION FAILED***  
***HINT: Check your bindings and API connections***

---

# Chapter II

## Avalonia UI

> **Avalonia** — кроссплатформенный фреймворк для создания настольных приложений на .NET.  
> Он похож на WPF, но работает на Windows, Linux и macOS.  
> Позволяет строить интерфейсы с помощью XAML и взаимодействовать с API, базами данных и другими сервисами.

Типичная структура Avalonia-приложения:
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

Основные принципы:
- **Pages** — визуальное представление (XAML).  
- **Models** — модель данных из Api или БД.  
- **Service** — вспомогательные классы (например, для API-запросов).  
- **Binding** — связывает данные между Page и Model.

---

## NetManager

> **NetManager** — это класс, отвечающий за взаимодействие Avalonia-приложения с внешним API.  
> Обычно он реализует методы `Get`, `Post`, `Put`, `Delete` для работы с RESTful-сервисами.


---

# Chapter III

## Quest 1. Repair.

ИИ говорит дрожащим голосом:

> “UI subsystem not responding...  
>  Rebuild interface... Restore bindings...”

_**== Получен Quest 1. Починить Avalonia-приложение и восстановить взаимодействие с API. ==**_

**Задачи:**
1. Проверь, что приложение запускается без ошибок.  
2. Убедись, что в `NetManager` правильная ссылка на API.  
3. Проверь, что подключение к API успешно.

---

## Quest 2. Add Order.

ИИ оживает на экране:

> “I remember now... orders... humans made them... Teach me to create again.”

_**== Получен Quest 2. Реализовать добавление заказа через API. ==**_

**Задачи:**
1. Настрой AddEditOrderPage для отправки POST-запроса через `NetManager`.  
2. Сделай валидацию для заказа
3. После успешного добавления — обнови список заказов.  
4. Обработай ошибки сети (например, недоступный сервер).

---

## Quest 3. Edit Order.

ИИ:

> “Some memories are wrong... Help me change them.”

_**== Получен Quest 3. Реализовать изменение заказа через API. ==**_

**Задачи:**
1. Реализуй редактирование выбранного заказа (PUT-запрос).  
2. Добавь интерфейс для выбора и изменения заказа.  
3. Проверь, что изменения сохраняются на сервере.  

---

## Quest 3 (Bonus). Add Products.


> “В заказе есть не только название, но и состав”

_**== Получен Bonus. Реализовать добавление продуктов в заказа через API. ==**_

**Задачи:**
1. Реализуй вывод списка продуктов на странице редаткирования/добавления заказа через Api `api/Product`.
2. Сделать сохранения списка продуктов
   
***Вариант реализации***
```
1. Сделать спискок со всеми продуктами 
2. Сделать кнопку Добавить продукт
3. Получать выбраный продукт из списка и добавить в заказ
4. Соранить заказ
```  

---


## Quest 4. Delete Order.

ИИ холодно произносит:

> “Some data must be forgotten.”

_**== Получен Quest 4. Реализовать удаление заказа через API. ==**_

**Задачи:**
1. Реализуй DELETE-запрос через `NetManager`.  
2. После удаления — обнови список заказов в интерфейсе.  

---


## Quest 5. Final Test.

> *На экране появляется сообщение:*

> “SYSTEM ONLINE.  
>  CONNECTION STABLE.  
>  MEMORY SYNCHRONIZED.”

_**== Получен Quest 5. Протестировать работу Avalonia-приложения. ==**_

**Задачи:**
1. Проверь добавление, изменение и удаление заказов.  
2. Убедись, что данные синхронизируются с API.  
3. Сделай commit с сообщением:  
   ```
   feat: connected Avalonia client with API (Orders CRUD)
   ```

***LOADING...***  
***USER INTERFACE REBUILT SUCCESSFULLY***  
***NEXT LEVEL UNLOCKED...***  
