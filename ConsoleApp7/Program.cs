// IComparable
// IEnumerable
// IEnumerator
// IEquatable   => Beraber olub olmadiqini yoxlayam method verir. (object classindan gelen formasida var lakin buda)
// ICloneable   => reference typelar bir birine beraber etdikde address beraberleshir istesek bunun clone methodu ile ozumuz yaza bilerikki yenisi copy edilsin





//using System;
//using System.Collections;
//using System.Reflection.Metadata.Ecma335;

//class MyEnumerator : IEnumerator
//{
//    int count = -1;
//    List<int> list = new List<int>();
//    public object Current => list[count];
//    public MyEnumerator(List<int> list)
//    {
//        this.list = list;
//    }
//    public bool MoveNext()
//    {
//        return ++count!= list.Count;
//    }

//    public void Reset()
//    {
//        throw new NotImplementedException();
//    }
//}
//class Student : IComparable, IEquatable<Student>, ICloneable, IEnumerable
//{
//    public string Name { get; set; }
//    public string Surname { get; set; }
//    public int Age { get; set; }
//    List<int> AgeList { get; set; } = new List<int>() { 1, 2, 3, 4, 5 };
//    public Student(string name, string surname, int age)
//    {
//        Name = name;
//        Surname = surname;
//        Age = age;
//    }


//    public int CompareTo(object? obj)
//    {
//        return this.Age > ((Student)obj).Age ? 1 : 0;
//    }

//    public bool Equals(Student? other)
//    {
//        return this.Name == other.Name;
//    }

//    public object Clone()
//    {
//        return ((object)new Student(this.Name, this.Surname, this.Age));
//    }
//    public override string ToString() =>
//        $@"Name:{Name}
//Surname:{Surname}
//Age:{Age}";

//    public IEnumerator GetEnumerator()
//    {
//        return new MyEnumerator(AgeList);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Student s1 = new Student("Nazim", "Nazimli", 17);
//        Student s2 = new Student("Fariz", "Farizli", 19);
//        Student s3 = new Student("Habil", "Habilli", 21);
//Student s2 = new Student("Nazim", "Fariz", 16);
//Console.WriteLine(s1.CompareTo(s2));
//Console.WriteLine(s1.Equals(s2));
//Student newStudent = (Student)s1.Clone();
//Console.WriteLine(newStudent);
//foreach (Student a in s1) { Console.WriteLine(a); }

//        foreach (int element in s1)
//        {
//            Console.WriteLine(element);
//        }

//    }
//}



//delegate void MyDel(string? text);

//class Program
//{

//    static void Hello(string? str) => Console.WriteLine($"Hello, {str}");
//    static void GoodBye(string? str) => Console.WriteLine($"GoodBye, {str}");
//    static void DelegateLikeParam(MyDel del) => del.Invoke("C++");





//    static void Main(string[] args)
//    {
//        MyDel del;
//        del = Hello;
//        del += GoodBye;
//        //del("Nazim");
//        del += delegate (string? str) { Console.WriteLine($"Anonymous, {str}"); };
//        del += str => Console.WriteLine($"Lambda, {str}");
//        DelegateLikeParam(del);

//    }

//}




//Action  - void tipli funksiyalarla isleyir
//Predicate - bool tipi 1 parametr qebul edir
//Func - 1-16 ya qeder parametr qebul edir ve void olmur


//Action<string> greet = (name) => Console.WriteLine("Merhaba, " + name + "!");


// Action delegate'i çağırma
//greet("Ahmet");
//greet("Ayşe");
//greet("Mehmet");


//List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//// Predicate delegate'i tanımı
//Predicate<int> isEven = (num) =>  num % 2 == 0;

//// List<T>.FindAll metodu ile Predicate'i kullanma
//List<int> evenNumbers = numbers.FindAll(isEven);
//Console.WriteLine("Çift sayılar:");
//foreach (var number in evenNumbers)
//{
//    Console.WriteLine(number);
//}



//Func<int, string> convertToString = (number) =>
//{
//    return number.ToString();
//};

//// Func delegate'ini çağırma
//string result = convertToString(42);

//Console.WriteLine("Sonuç: " + result);
