### **1. Which of the following is the correct syntax to define a class in C#?**

 Ans -  a) `class MyClass { }`
 








### **2. What is the default access modifier for members of a class in C#?**

Ans -  b) `private`








### **3. Which of the following is true about constructors in C#?**

Ans -  b) A constructor can have the same name as the class.




### **4. What is the result of the following code?**

```csharp
class MyClass {
    public int x = 5;
}

class Program {
    static void Main() {
        MyClass obj = new MyClass();
        Console.WriteLine(obj.x);
    }
}

```

Ans - c)` 5`




### **5. What is the purpose of the `this` keyword in C#?**

Ans -  b) It is used to access the instance members of the current object.




### **6. Which of the following is an example of a property in a C# class?**

Ans -  b) `public int x { get; set; }`




### **7. What will happen if you try to access a private member of a class from outside that class in C#?**

Ans -  a)` Compilation error`




### **8. Which of the following statements is correct about the C#.NET code snippet given below?**

```csharp
int i;
int j = new int();
i = j = ;
String str;
str = i.ToString();
str = j.ToString();

```


Ans - 2) Since `int` is a primitive, we cannot use `new` with it.




### **9. Which of the following statements are correct about the `this` reference?**

Ans -  2. Static functions of a class never receive the `this` reference.
       3. Instance member functions of a class always receive a `this` reference.
       5. While calling an instance member function we are not required to pass the `this` reference explicitly.



### **10. Which of the following is the correct way to create an object of the `class Sample`?**

Ans -  1. `Sample s = new Sample();`
       3. `Sample s; s = new Sample();`
