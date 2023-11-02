# Custom Linked List Data Structure in C#

This is a custom implementation of a singly linked list data structure in C#. A linked list is a fundamental data structure that consists of a sequence of nodes, where each node holds data and a reference to the next node in the sequence. This implementation is designed for educational purposes and serves as a simple example of how a linked list can be created in C#.

## Table of Contents

- [Features](#features)
- [Usage](#usage)
- [Methods](#methods)
- [Example](#example)
- [License](#license)

## Features

- Singly linked list
- Add elements to the end of the list
- Remove elements from the list
- Search for elements in the list
- Check if the list is empty
- Get the number of elements in the list
- Enumerate the elements in the list

## Usage

1. Clone or download this repository to your local machine.
2. Open the solution in Visual Studio or your preferred C# development environment.
3. Build the solution.
4. Use the `MyLinkedList<T>` class in your C# code as needed.

## Methods

### `MyLinkedList<T>` Class

#### `MyLinkedList()`

- Constructor: Initializes an empty linked list.

#### `AddToEnd(T value)`

- Adds an element with the specified value to the end of the linked list.

#### `Remove(T value)`

- Removes the first occurrence of the specified value from the linked list, if it exists.

#### `Contains(T value)`

- Checks whether the linked list contains the specified value.

#### `IsEmpty()`

- Checks if the linked list is empty.

#### `Count`

- Gets the number of elements in the linked list.

#### `GetEnumerator()`

- Returns an enumerator that iterates through the linked list.

## Example

```csharp
using System;

class Program
{
    static void Main()
    {
        IMyLinkedList<int> myList = new MyLinkedList<int>();

        myList.AddToEnd(1);
        myList.AddToEnd(2);
        myList.AddToEnd(3);

        Console.WriteLine($"Count: {myList.Count}");
        Console.WriteLine($"Contains 2: {myList.Contains(2)}");

        myList.Remove(2);

        Console.WriteLine($"Count after removal: {myList.Count}");
        Console.WriteLine($"Contains 2 after removal: {myList.Contains(2)}");
    }
}
```

## License

This project is licensed under the MIT License. Feel free to use, modify, and distribute this code as needed. See the [LICENSE](LICENSE) file for details.
