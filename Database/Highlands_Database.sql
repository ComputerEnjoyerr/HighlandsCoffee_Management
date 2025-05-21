CREATE DATABASE Highlands_Database
GO
USE Highlands_Database
GO
set dateformat dmy
GO

-- Tạo bảng BRANCHES (Chi nhánh)
go
create table BRANCHES(
BranchId int primary key identity (1,1), -- Mã tự động tăng 1 đơn vị từ 1
BranchName nvarchar(80) not null,
ManagerId int unique, -- Mã của nhân viên làm quản lý (EmployeeId)
Address nvarchar(200) not null,
Phone varchar(20) not null,
OpenTime time(0), -- Thời gian mở cửa
CloseTime time(0),
MonthlyRent decimal (12,2),
Status nvarchar(20) Check (Status in (N'Đang hoạt động', N'Đã đóng', N'Đóng vĩnh viễn'))
)

-- Tạo bảng TABLES (Bàn ăn)
go
create table TABLES(
TableId int primary key identity (1,1),
TableName nvarchar(10),
BranchId int foreign key (BranchId) references BRANCHES(BranchId) not null,
Capacity int default 4, -- Bàn mặc định có 4 chỗ
Status int check (Status in (0,1)) default 0 -- 0: trống, 1: đã đặt
)

-- Tạo bảng EMPLOYEE (Nhân viên)
go
create table EMPLOYEE(
EmployeeId int primary key identity (1,1),
EmployeeName nvarchar(30) not null,
BranchId int foreign key (BranchId) references BRANCHES(BranchId) not null,
Address nvarchar(200),
Phone varchar(13) not null,
HireDate date default getdate(), -- getdate(): lấy ngày hiện tại
BaseSalary decimal (8) not null, -- Max là 99,999,999
OverTimeHours int default 0,
TotalSalary decimal (8),
Role nvarchar(10) check (Role in (N'Quản lý', N'Nhân viên', N'Thời vụ')) default N'Nhân viên'
)

-- Tạo bảng ACCOUNT (Tài khoản)
go
create table ACCOUNT(
AccountId int primary key identity (1,1),
AccountName nvarchar(50) not null,
Password nvarchar(50) not null,
EmployeeId int foreign key (EmployeeId) references EMPLOYEE(EmployeeId) not null unique,
CreateDate date default getdate()
)

-- Tạo bảng SUPPLIER (Nhà cung cấp)
go
create table SUPPLIER(
SupplierId int primary key identity(1,1),
Name nvarchar(100) not null,
Phone varchar(20) not null,
Address nvarchar(200) not null,
Email varchar(50) not null
)

-- Tạo bảng INGREDIENT (Nguyên liệu)
go 
create table INGREDIENT(
IngredientId int primary key identity (1,1),
IngredientName nvarchar(30) not null,
SupplierId int foreign key (SupplierId) references SUPPLIER(SupplierId) not null,
Price decimal (10,2),
Unit nvarchar(20), -- Đơn vị tính
EXPDay int default 30 -- số ngày hết hạn
)

-- Tạo bảng PRODUCTS (Sản phẩm)
go
create table PRODUCTS(
ProductId int primary key identity(1,1),
ProductName nvarchar (50) not null,
Price decimal(10) not null,
Image varchar(100)
)

-- Tạo bảng RECIPE (Công thức)
go
create table RECIPE(
RecipeId int primary key identity(1,1),
IngredientId int foreign key (IngredientId) references INGREDIENT(IngredientId) not null,
ProductId int foreign key (ProductId) references PRODUCTS(ProductId) not null,
Quantity decimal (10,3) default 0.01,
Unit nvarchar(20) default 'kg'
)

-- Tạo bảng INVENTORY (Kho hàng)
create table INVENTORY (
InventoryId varchar(14) primary key,
BranchId int foreign key (BranchId) references BRANCHES(BranchId) not null,
IngredientId int foreign key (IngredientId) references INGREDIENT(IngredientId) not null,
RestockDate date default getdate(),
EXPDay int NOT NULL, -- Thêm để lưu EXPDay
EXPDate as (dateadd(day, EXPDay, RestockDate)), -- Cột tính toán dùng EXPDay
Quantity decimal(10,2) default 1,
Unit nvarchar(20) default 'kg',
UnitPrice decimal(10) NOT NULL,
TotalPrice as (Quantity * UnitPrice)
);

-- Tạo bảng CUSTOMER (Khách hàng)
go
create table CUSTOMER(
CustomerId int primary key identity(1,1),
CustomerName nvarchar(30) not null,
Email nvarchar(50) not null,
Phone varchar(13) not null,
Point int default 0,
Tier nvarchar(10) check (Tier in (N'Đồng',N'Bạc',N'Vàng', N'Bạch kim')) default N'Đồng'
)

-- Tạo bảng BILL (Hóa đơn)
go
create table BILL(
BillId int primary key identity(1,1),
BranchId int foreign key (BranchId) references BRANCHES(BranchId) not null,
EmployeeId int foreign key (EmployeeId) references EMPLOYEE(EmployeeId) not null,
CustomerId int foreign key (CustomerId) references CUSTOMER(CustomerId) not null,
TableId int foreign key (TableId) references TABLES(TableId) not null,
TotalPrice decimal (10,2),
CreateDate date default getdate(),
Status int  check (Status in (0, 1)) default 0 -- Chưa thanh toán
)

-- Tạo bảng BILLINFO (Chi tiết hóa đơn)
go
create table BILLINFO(
BillInfoId int primary key identity(1,1),
ProductId int foreign key (ProductId) references PRODUCTS(ProductId) not null,
BillId int foreign key (BillId) references BILL(BillId) not null,
Quantity int not null
)

-- Tạo bảng PROMOTION (Khuyến mãi)
go
create table PROMOTION(
PromotionId int primary key identity(1,1),
PromotionName nvarchar(100) not null,
Description nvarchar(100),
RequirePoint int default 100,
Discount decimal (3,2), -- vd: 0.3, 0.02 (30%, 2%)
StartDate date default getdate(),
EndDate date
)

-- Tạo bảng PROMOTION_CUSTOMER (Khuyễn mãi của khách)
go
create table PROMOTION_CUSTOMER(
CustomerId int foreign key (CustomerId) references CUSTOMER(CustomerId) not null,
PromotionId int foreign key (PromotionId) references PROMOTION(PromotionId) not null,
ApplyDate date default getdate()
primary key (CustomerId, PromotionId)
)

-- Tạo bảng FINANCIAL (Tài chính)
go
create table FINANCIAL(
FinancialId int primary key identity(1,1),
BranchId int foreign key (BranchId) references BRANCHES(BranchId),
ReportDate date default getdate(),
Revenue decimal(12) default 0,
OperationCost decimal(12) default 0,
IngredientCost decimal(12) default 0,
Profit as (Revenue - OperationCost - IngredientCost)
)

-- Truy Vấn
--select * from BRANCHES;
--select * from TABLES;
--select * from EMPLOYEE;
--select * from SUPPLIER;
--select * from INGREDIENT;
--select * from PRODUCTS;
--select * from RECIPE;
--select * from INVENTORY;
--select * from CUSTOMER;
--select * from BILL;
--select * from BILLINFO;
--select * from PROMOTION;
--select * from PROMOTION_CUSTOMER;
--select * from FINANCIAL;
--select * from ACCOUNT;
