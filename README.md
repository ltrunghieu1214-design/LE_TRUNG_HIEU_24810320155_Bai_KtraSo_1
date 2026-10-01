# LE_TRUNG_HIEU_24810320155_Bai_KtraSo_1
# I. PHẦN LÝ THUYẾT & CÂU HỎI NGẮN

## Câu 1: Trình bày sự khác nhau giữa Value Types và Reference Types trong C# về cơ chế lưu trữ vùng nhớ (Stack vs Heap).

**Value Types (kiểu giá trị)** là kiểu dữ liệu mà biến lưu trực tiếp giá trị của dữ liệu. Khi gán một biến Value Type cho biến khác thì giá trị được sao chép sang biến mới, hai biến độc lập với nhau. Các kiểu thường gặp là `int`, `float`, `double`, `bool`, `struct`.

Đối với biến cục bộ, Value Type thường được lưu trên **Stack**.

**Reference Types (kiểu tham chiếu)** là kiểu dữ liệu mà biến lưu một tham chiếu đến đối tượng. Đối tượng thường được lưu trên **Heap**. Khi gán một biến Reference Type cho biến khác thì tham chiếu được sao chép, vì vậy hai biến có thể cùng tham chiếu đến một đối tượng.

Các Reference Type thường gặp là `class`, `object`, `array`, `string`.

**Ví dụ:**

```csharp
int a = 10;
int b = a;
b = 20;
```

Kết quả:

```text
a = 10
b = 20
```

Vì `a` và `b` là hai Value Type độc lập.

**Kết luận:**

* Value Type: biến chứa trực tiếp **giá trị**.
* Reference Type: biến chứa **tham chiếu đến đối tượng**.
* Value Type thường gắn với Stack đối với biến cục bộ, còn đối tượng của Reference Type thường nằm trên Heap.

## Câu 2: Tính năng Init-only Properties (`init`) trong C# 9/10 khác gì so với thuộc tính có `set` thông thường? Nêu trường hợp sử dụng thực tế.

`set` thông thường cho phép gán và thay đổi giá trị của thuộc tính bất cứ lúc nào sau khi đối tượng được tạo.

**Ví dụ:**

```csharp
class Student
{
    public string Name { get; set; }
}
```

Có thể thay đổi:

```csharp
Student sv = new Student();
sv.Name = "Hieu";
sv.Name = "Nam";
```

Trong khi đó, `init` chỉ cho phép gán giá trị trong quá trình khởi tạo đối tượng. Sau khi đối tượng được khởi tạo thì không thể thay đổi giá trị của thuộc tính đó.

**Ví dụ:**

```csharp
class Student
{
    public string Name { get; init; }
}
```

Khởi tạo:

```csharp
Student sv = new Student
{
    Name = "Hieu"
};
```

Sau đó:

```csharp
sv.Name = "Nam";   // Lỗi
```

**Trường hợp sử dụng thực tế:**

`init` phù hợp với những thông tin cần được xác định khi tạo đối tượng và không muốn thay đổi về sau, ví dụ:

* Mã sinh viên.
* Mã đơn hàng.
* Ngày tạo hồ sơ.
* Thông tin cấu hình ban đầu.

**Kết luận:**

* `set`: có thể thay đổi thuộc tính sau khi tạo đối tượng.
* `init`: chỉ được gán khi khởi tạo đối tượng.

## Câu 3: Phân biệt sự khác nhau giữa phương thức `virtual` ở lớp cha và phương thức `override` ở lớp con khi triển khai tính Đa hình (Polymorphism).

`virtual` là từ khóa được sử dụng ở **lớp cha** để khai báo một phương thức có thể được lớp con ghi đè.

**Ví dụ:**

```csharp
class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Tieng keu dong vat");
    }
}
```

`override` là từ khóa được sử dụng ở **lớp con** để ghi đè và thay đổi cách thực hiện của phương thức `virtual` trong lớp cha.

**Ví dụ:**

```csharp
class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Gau gau");
    }
}
```

Khi sử dụng:

```csharp
Animal a = new Dog();
a.Sound();
```

Kết quả:

```text
Gau gau
```

Mặc dù biến `a` có kiểu `Animal`, nhưng đối tượng thực tế là `Dog`, nên C# gọi phương thức `Sound()` của lớp `Dog`.

Đây chính là **tính đa hình (Polymorphism)**.

**Kết luận:**

* `virtual` → khai báo ở **lớp cha**, cho phép lớp con ghi đè.
* `override` → khai báo ở **lớp con**, dùng để ghi đè phương thức của lớp cha.

## Câu 4: Tại sao một thành phần được khai báo là `static` trong Lớp (Class) lại không thể truy xuất thông qua một thể hiện (Object Instance) được tạo bằng toán tử `new`?

Thành phần `static` thuộc về **Class**, không thuộc về từng Object Instance.

Khi tạo đối tượng bằng toán tử `new`, mỗi đối tượng có các thành phần riêng của nó. Trong khi đó, thành phần `static` chỉ có một bản dùng chung cho toàn bộ Class.

**Ví dụ:**

```csharp
class Student
{
    public static int Count = 0;
}
```

Cách truy cập đúng:

```csharp
Student.Count++;
```

Không truy cập `static` thông qua Object:

```csharp
Student sv = new Student();
sv.Count++;   // Không hợp lệ
```

Lý do là `Count` thuộc về lớp `Student`, không thuộc riêng đối tượng `sv`.

**Kết luận:**

* Thành phần `static` → thuộc về **Class**.
* Thành phần không có `static` → thuộc về **Object Instance**.
* `static` được truy cập bằng **tên Class**.

Ví dụ:

```csharp
Student.Count;
```

Còn thuộc tính thông thường được truy cập bằng Object:

```csharp
sv.Name;
```
