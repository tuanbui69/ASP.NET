# Môn học: Công nghệ ASP.NET

Kho lưu trữ bài tập và thực hành môn Công nghệ ASP.NET (Năm 4).

**Sinh viên thực hiện:** Bùi Đình Tuấn

---

## Cấu trúc Repository

```text
ASP.NET/
├── .gitignore
├── README.md
└── Day2/
    ├── Day2_BuiDinhTuan.sln
    ├── Day2_BuiDinhTuan/
    │   ├── Controllers/
    │   │   ├── HelloController.cs
    │   │   ├── HomeController.cs
    │   │   └── SanPhamController.cs
    │   ├── Models/
    │   │   ├── ErrorViewModel.cs
    │   │   └── HocPhanItem.cs
    │   ├── ViewComponents/
    │   │   └── HocPhanViewComponent.cs
    │   ├── Views/
    │   │   ├── Hello/
    │   │   ├── Home/
    │   │   ├── SanPham/
    │   │   └── Shared/
    │   │       ├── _Layout.cshtml
    │   │       ├── _ThongTinSinhVien.cshtml
    │   │       └── Components/
    │   │           └── HocPhan/
    │   │               └── Default.cshtml
    │   ├── Program.cs
    │   └── Day2_BuiDinhTuan.csproj
    └── Picture/
        ├── 01_Home_Index.png
        ├── 02_Hello_Index.png
        ├── 03_Hello_Welcome.png
        ├── 04_SanPham_List.png
        ├── 05_SanPham_Details.png
        └── 06_Privacy.png
```

---

## Chi tiết nội dung Day 2

1. **Routing**:
   - **Conventional Routing:** Mặc định `{controller=Home}/{action=Index}/{id?}`.
   - **Custom Conventional Route:** `/chao-mung/{name}/{id}` trỏ đến `HelloController.Welcome`.
   - **Attribute Routing:** Cấu hình trong `SanPhamController` với `[Route("san-pham")]` và `[HttpGet("chi-tiet/{id:int}")]`.
   - **Alias Route:** `/gioi-thieu` trỏ về `HomeController.Privacy`.
2. **Partial View (`_ThongTinSinhVien.cshtml`)**:
   - Tái sử dụng khối thông tin sinh viên trên các trang: `Home`, `Hello/Index`, `Hello/Welcome`, `SanPham/Index`.
3. **ViewComponent (`HocPhanViewComponent`)**:
   - Tự quản lý và hiển thị danh sách các học phần môn học độc lập tại `Home` và `SanPham/Details`.
