Topic:
1. Array   &nbsp 2. List   3. Dictionary<TKey, TValue>   4. Stack   5. Queue   6. HashSet


## Array
- Array — Fixed Size Collection
- Namespace: System (built-in)
- Structure: Contiguous memory block
- Access: Random access via index
- Size: Fixed (declare করা হলে পরে enlarge করা যায় না, List<T> dynamic)
- Time Complexity:
  - Access → O(1)
  - Insert/Delete → O(n) (because shifting needed)

```c#
// Declare
int[] numbers = new int[5]; // fixed size array
numbers[0] = 10;
numbers[1] = 20;

// Initialize with values
int[] nums = {1, 2, 3, 4, 5};

// Access
Console.WriteLine(nums[2]); // 3

// Loop
for(int i=0; i<nums.Length; i++)
    Console.WriteLine(nums[i]);
```

Multidimention array:
```c#
int[,] matrix = new int[2,3]; // 2 rows, 3 cols
matrix[0,0] = 1;
matrix[1,2] = 6;
```

## List:
- List<T> — Dynamic Array
- Namespace: System.Collections.Generic
- Structure: Dynamic array, size automatically grows
- Access: Random access via index
- Time Complexity:
      - Add → O(1) amortized
      - Remove → O(n)
      - Access → O(1)
  
```C#
List<int> a = new List<int> {1, 2, 3};
a.Add(4);              // add element
a.Insert(1, 10);       // insert at index 1
a.Remove(2);           // remove element by value
a.RemoveAt(0);         // remove element by index

Console.WriteLine(numbers[1]);      // Access the index
Console.WriteLine(numbers.Count);  // count number of list
foreach(int n in a)
    Console.WriteLine(n);
```


## Dictonary:
- Dictionary<TKey, TValue> — Key-Value Pair
- Structure: Hash Table
- Access: Fast access via key
- Time Complexity:
    - Add → O(1)
    - Lookup → O(1)
    - Remove → O(1)

```c#
Dictionary<string, int> studentMarks = new Dictionary<string, int>();
studentMarks.Add("Alice", 90);
studentMarks["Bob"] = 85;   // alternative way
Console.WriteLine(studentMarks["Alice"]); // 90

if(studentMarks.ContainsKey("Charlie"))
    Console.WriteLine(studentMarks["Charlie"]);
```


## Stack:
- Stack<T> — LIFO (Last In First Out)
- Structure: Linked list internally or array-backed
- Operations: Push, Pop, Peek
- Time Complexity: O(1) for Push/Pop

```c#
Stack<string> stack = new Stack<string>();
stack.Push("A");
stack.Push("B");
Console.WriteLine(stack.Pop()); // B
Console.WriteLine(stack.Peek()); // A
```


## Queue:
- Queue<T> — FIFO (First In First Out)
- Structure: Circular buffer or linked list internally
- Operations: Enqueue, Dequeue, Peek
- Time Complexity: O(1)

```c#
Queue<int> queue = new Queue<int>();
queue.Enqueue(10);
queue.Enqueue(20);
Console.WriteLine(queue.Dequeue()); // 10
Console.WriteLine(queue.Peek());    // 20
```


## HashSet:
- HashSet<T> — Unique Collection
- Namespace: System.Collections.Generic
- Structure: Hash table storing only unique values
- Operations: Add, Remove, Contains
- Time Complexity: O(1) average

```c#
HashSet<int> set = new HashSet<int>();
set.Add(1);
set.Add(2);
set.Add(2); // duplicate ignored
Console.WriteLine(set.Contains(1)); // true

foreach(int n in set)
    Console.WriteLine(n);
```
























