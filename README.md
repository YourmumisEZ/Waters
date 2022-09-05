# Bank gateway for booking transactions in a Central Accounting System

## Introduction
The Bank has its own Central Accounting System, in which all transactions processed by the Bank have to be booked. 
The Bank has also a system that processes large transaction volumes, so for performance reasons, they are processed by many threads simultaneously.
At the moment, the Central Accounting System has its limitation. It can only "book transactions" from one thread at the same time.

The "**transaction booking**" process has the following stages:
1. Start of booking – during which the thread has to call the `StartBooking` method. 
2. Transaction booking – during which the thread has to call the `Booking` method for each transaction. The method has to save the data in a DB using `SaveBooking` from `IDBRepository`. 
3. Next transaction booking...
4. Next transaction booking...
5. Next transaction booking...
6. End of booking – during which the thread has to call the `EndBooking` method.
7. Get information about the booking status – during which the thread has to call the `GetBookingStatus` method).
To complete the booking process, all threads have to use `IBookingGateway` that has the required methods.  

## Remember / Assumptions
`IBookingGateway` should protect the access to common resources. There will be many instances of `IBookingGateway`. 
Each thread will call `BookingGatewayFactory.CreateGateway` only once (so you can assume that one thread will operate on one instance of `IBookingGateway`).

Each `IBookingGateway` can have its own instance of `IDBRepository` or share it with other instances of `IBookingGateway`.

## Problem Statement
To complete this task, you need to implement the `IBookingGateway` interface (**create own class** in a **separate file** in the**BookingGatewayService project** and **implement it**) and
finish implementation of the `BookingGatewayFactory` class, which should create objects of `IBookingGateway`.
For each of the threads that process transactions, the system **creates a new instance** of `IBookingGateway` using the `BookingGatewayFactory` factory.

You must meet the following requirements for the following actions:
- `IBookingGateway.StartBooking`: 
  - if the method is called by another thread at the same time (or the same thread calls it again before `EndBooking`) a `BookingInProgressException` should be thrown.
  - if the method is called and a `IBookingGateway.GetBookingStatuses` is in progress a `ReadOperationInProgressException` should be thrown.
  
- Calling `IBookingGateway.Booking` without calling `StartBooking` earlier, should throw a `NoStartBookingException`.
- `IBookingGateway.Booking` should save the transaction data to a local repository using the `IDBRepository.SaveBooking` method.

- Calling `IBookingGateway.EndBooking` without calling `StartBooking` earlier, should throw a `NoStartBookingException`.

- Calling `IBookingGateway.GetBookingStatuses` by other thread, when the booking is in progress (`IBookingGateway.StartBooking` was called but `IBookingGateway.EndBooking` not yet) 
  should throw a `BookingInProgressException`, **except for** a situation, when the booking is executed by the same thread.
- `IBookingGateway.GetBookingStatuses` can be called by many threads at the same time. 
- `IBookingGateway.GetBookingStatuses` should return information on transaction statuses. You have to use `IDBRepository.GetStatuses` to get the required data from the repository. 
- `IBookingGateway.GetBookingStatuses` should return an empty list if the passed parameter is null or empty or if there are no results from the DB (from `IDBRepository.GetStatuses`).

- `BookingGatewayFactory` should be *protected* from **inheritance**.
- The class that implements `IBookingGateway` should be **protected** from **inheritance**.
- `BookingInProgressException`, `NoStartBookingException` and `ReadOperationInProgressException` should be **protected** from **inheritance**. 
- `BookingGatewayFactory.CreateObject` and `BookingGatewayFactory.NewObject` should be **marked as deprecated**, but the developer can use `CreateObject`. If the developer tries to use `NewObject`, a compilation error should occur.

## Hints
1. Your solution should pass all tests.
2. Call `IDBRepository.SaveBooking` from `IBookingGateway.Booking` to save transactions to the DB.
3. Call `IDBRepository.GetStatuses` to get transaction statuses (for `IBookingGateway.GetBookingStatuses`).
4. `IDBRepository.GetStatuses` can return a null or an empty list, if there are no results in the database. You should only call the function if the user has passed a list of references with at least one element.
5. Check the `TODO` comments.
