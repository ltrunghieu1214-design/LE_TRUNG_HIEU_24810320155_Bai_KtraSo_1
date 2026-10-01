# LE_TRUNG_HIEU_24810320155_Bai_KtraSo_1
# PHẦN I: LÝ THUYẾT & CÂU HỎI NGẮN (C#)

---

### Câu 1: Trình bày sự khác nhau giữa Value Types và Reference Types trong C# (Stack vs Heap)

| Tiêu chí | Value Types (Kiểu giá trị) | Reference Types (Kiểu tham chiếu) |
| :--- | :--- | :--- |
| **Kiểu dữ liệu** | `int`, `float`, `bool`, `char`, `struct`, `enum`, `Tuple` | `class`, `interface`, `delegate`, `object`, `string`, `record` |
| **Cơ chế lưu trữ** | Giá trị thực sự được lưu trực tiếp trên **Stack** (hoặc nằm trên Heap nếu thuộc thuộc tính của một `class`). | Dữ liệu/Đối tượng thực sự lưu trên **Heap**. Biến nằm trên **Stack** chỉ lưu **địa chỉ tham chiếu** trỏ đến Heap. |
| **Gán dữ liệu (`=`)** | Sao chép **toàn bộ giá trị**. Việc sửa đổi biến này không làm ảnh hưởng đến biến kia. | Sao chép **địa chỉ tham chiếu**. Cả hai biến cùng trỏ đến chung một đối tượng trên Heap. |
| **Quản lý bộ nhớ** | Tự động giải phóng khi vượt ra khỏi phạm vi hoạt động (Scope). | Do bộ thu gom rác **Garbage Collector (GC)** tự động quản lý và giải phóng. |

---

### Câu 2: Tính năng Init-only Properties (`init`) trong C# 9/10 khác gì so với `set` thông thường? Nêu trường hợp sử dụng thực tế.

* **Sự khác biệt:**
  * **`set` (thông thường):** Cho phép gán hoặc thay đổi giá trị của thuộc tính **bất kỳ lúc nào** trong suốt vòng đời của đối tượng.
  * **`init` (Init-only setter):** Chỉ cho phép gán giá trị **một lần duy nhất** tại thời điểm khởi tạo đối tượng (qua Constructor hoặc Object Initializer). Sau khi khởi tạo xong, thuộc tính trở thành Read-Only (chỉ đọc) và không thể sửa đổi từ bên ngoài.

* **Trường hợp sử dụng thực tế:**
  * Dùng khi thiết kế các đối tượng **Bất biến (Immutable Objects)** hoặc các lớp **Data Transfer Objects (DTOs)**, giúp bảo đảm dữ liệu không bị thay đổi trái phép sau khi được tạo ra nhưng vẫn giữ được cú pháp khởi tạo linh hoạt dạng Object Initializer.

```csharp
public class Person
{
    public string Id { get; init; } // Chỉ được gán khi khởi tạo
    public string Name { get; set; } // Có thể thay đổi bất kỳ lúc nào
}

// Khởi tạo đối tượng:
var p = new Person { Id = "123", Name = "Nguyen Van A" };

// p.Id = "456"; // LỖI BIÊN DỊCH: Cannot assign to property 'Id' except in an object initializer
p.Name = "Nguyen Van B"; // Hợp lệ
