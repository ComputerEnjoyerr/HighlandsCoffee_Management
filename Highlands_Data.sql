-- UPDATE DATA
USE Highlands_Database
-- Bảng BRANCHES (Chi nhánh)
go
insert into BRANCHES (BranchName, ManagerId, Address, Phone, OpenTime, Closetime, MonthlyRent, Status) values
(N'Highlands Coffee 85 No.3 Binh Tan', 101, N'85 Đường Số 3, Phường Bình Hưng Hòa B, Quận Bình Tân, Tp. Hồ Chí Minh', '028 7109 5140', '07:00', '23:00', 15000000, N'Đang hoạt động'),

(N'Highlands Coffee 925 Tan Ky Tan Quy', 102, N'925 Tân Kỳ Tân Quý, Bình Hưng Hoà A, Bình Tân, Tp. HCM', '028 7109 4925', '07:00', '23:00', 12000000, N'Đang hoạt động'),

(N'Highlands Coffee 366 Le Van Quoi HCM', 103, N'366 Lê Văn Quới, Bình Hưng Hòa A, Quận Bình Tân, Thành phố Hồ Chí Minh', '(028) 7100 0366', '07:00', '23:00', 13000000, N'Đang hoạt động'),

(N'Highlands Coffee 565 Tinh Lo 10', 104, N'565 Tỉnh Lộ 10, P.Bình Trị Đông B, Q.Bình Tân, TP.HCM', '(028) 7100 0565', '07:00', '23:00', 18000000, N'Đang hoạt động'),

(N'Highlands Coffee Số 7 Bình Tân', 105, N'142-144, Số 7, Phường Bình Trị Đông, Quận Bình Tân, Tp. Hồ Chí Minh', '(028) 7109 9628', '07:30', '23:00', 11500000, N'Đang hoạt động'),

(N'Highlands Coffee Aeon Tân Phú', 106, N'Lô G15 Tầng trệt, Trung tâm thương mại Aeon Tân Phú, 30 Bờ Bao Tân Thắng, Phường Sơn Kỳ, Quận Tân Phú, TP. Hồ Chí Minh', '(028) 7101 6768', '08:00', '22:00', 12500000, N'Đang hoạt động'),

(N'Highlands Coffee 377 Tân Kỳ Tân Quý', 107, N'377 Tân Kỳ Tân Quý, Phường Tân Quý, Quận Tân Phú, Tp. Hồ Chí Minh', '(028) 7108 8377', '07:00', '23:00', 10000000, N'Đang hoạt động'),

(N'Highlands Coffee 180 Thạch Lam', 108, N'180 Thạch Lam, Phường Phú Thạnh, Quận Tân Phú, Tp. Hồ Chí Minh', '(028) 7100 6465', '07:00', '23:00', 9500000, N'Đang hoạt động'),

(N'Highlands Coffee 284 Hoa Binh Tan Phu', 109, N'284 Hòa Bình, P. Hiệp Tân, Q. Tân Phú, TP.HCM', '028 7100 0284', '07:00', '23:00', 10500000, N'Đang hoạt động'),

(N'Highlands Coffee 287 Âu Cơ', 110, N'287 Âu Cơ, Phường Phú Trung, Quận Tân Phú, TP.HCM', '028.71002324', '07:00', '23:00', 9800000, N'Đang hoạt động'),

(N'Highlands Coffee Lạc Long Quân - Quận 11', 111, N'343E-343F Lạc Long Quân, Phường 5, Quận 11, Tp. Hồ Chí Minh', '028 7106 6343', '07:00', '23:00', 9200000, N'Đang hoạt động'),

(N'Highlands Coffee 55 Vườn Lài', 112, N'55 Vườn Lài, Phường Phú Thọ Hòa, Quận Tân Phú, Tp. Hồ Chí Minh', '(028) 7109 7755', '07:00', '23:00', 8800000, N'Đang hoạt động'),

(N'Highlands Coffee Hồng Lạc', 113, N'291 Hồng Lạc, Phường 10, Quận Tân Bình, Tp. HCM', '028 7109 7690', '07:00', '23:00', 10200000, N'Đang hoạt động'),

(N'Highlands Coffee 105 Doc Lap Tan Phu', 114, N'105 Độc Lập, P.Tân Thành, Q.Tân Phú, TP.HCM', '(028) 7100 0105', '07:00', '23:00', 9600000, N'Đang hoạt động'),

(N'Highlands Coffee D9 Tân Phú', 115, N'71 Đường D9, Phường Tây Thạnh, Quận Tân Phú, TP.HCM', '028 710 20071', '07:00', '22:00', 8900000, N'Đang hoạt động'),

(N'Highlands Coffee Lê Trọng Tấn', 116, N'49-57 Lê Trọng Tấn, phường Sơn Kỳ, quận Tân Phú, Tp.HCM, Việt Nam', '(028) 7105 4949', '07:00', '22:00', 8400000, N'Đang hoạt động'),

(N'Highlands Coffee 43 Truong Chinh D12', 117, N'41 - 43 Trường Chinh, Phường Tân Thới Nhất, Quận 12, Tp. Hồ Chí Minh', '028 7106 4143', '07:00', '23:00', 8500000, N'Đang hoạt động'),

(N'Highlands Coffee117 Nguyễn Văn Quá', 118, N'117 Nguyễn Văn Quá, Phường Tân Hưng Thuận, Quận 12, TP.HCM (bên phải SatraFoods Nguyễn Văn Quá)', '(028) 7102 3324', '07:00', '23:00', 8200000, N'Đang hoạt động'),

(N'Highlands Coffee Phan Huy Ích 2 - Tân Bình', 119, N'53 Phan Huy Ích, Phường 15, Quận Tân Bình, TP. Hồ Chí Minh', '028 7100 0053', '07:00', '23:00', 8300000, N'Đang hoạt động'),

(N'Highlands Coffee To Ky 2 D12', 120, N'B55 Tô Ký, Đông Hưng Thuận, Quận 12, Tp. Hồ Chí Minh', '028 7108 0055', '07:00', '23:00', 8500000, N'Đang hoạt động');

-- Bảng TABLES (Bàn ăn)
go
declare @BranchId int, @SoLuongTable int, @i int 
set @BranchId = 1
while @BranchId <= 20
begin 
-- Tạo số lượng bàn ngẫu nhiên cho BranchId hiện tại (từ 4 đến 10)
set @SoLuongTable = floor(rand()*(10-4+1)+4)
set @i = 1
while @i <= @SoLuongTable
begin
-- Chèn dữ liệu vào bảng TABLES
insert into TABLES (TableName, BranchId) values (N'Bàn ' + cast(@BranchId as nvarchar(2)) + '-' + cast(@i as nvarchar(2)), @BranchId)
set @i = @i + 1
end
-- Tăng BranchId để chuyển sang chi nhánh tiếp theo 
set @BranchId = @BranchId + 1
end

-- Bảng EMPLOYEE (Nhân viên)

-- Trường TotalSalary
go
create trigger trg_UpdateTotalSalary
on EMPLOYEE
after insert, update
as
begin
    update EMPLOYEE 
    set TotalSalary = BaseSalary * OverTimeHours 
    where EmployeeId in (select EmployeeId from inserted);
end;

go
insert into EMPLOYEE (EmployeeName, BranchId, Address, Phone, HireDate, BaseSalary, OverTimeHours, Role) values

(N'Trần Phạm Thanh Phú', 1, N'12 Đường Số 3, Phường Bình Hưng Hòa B, Quận Bình Tân, Tp. Hồ Chí Minh', '09854245214', getdate(), 200000, 2, N'Quản lý'),
(N'Thiên Văn', 1, N'24 Đường Số 3, Phường Bình Hưng Hòa B, Quận Bình Tân, Tp. Hồ Chí Minh', '05145271648', getdate(), 300000, 8, N'Nhân viên'),
(N'Bảo Ngọc', 1, N'54 Đường Số 3, Phường Bình Hưng Hòa B, Quận Bình Tân, Tp. Hồ Chí Minh', '03246571864', getdate(), 300000, 10, N'Nhân viên'),
(N'Trần Thiên Đô', 1, N'18 Đường Số 4, Phường Bình Hưng Hòa B, Quận Bình Tân, Tp. Hồ Chí Minh', '03124876243', getdate(), 500000, 12, N'Quản lý'),

(N'Nguyễn Quang Mạnh', 2, N'900 Tân Kỳ Tân Quý, Bình Hưng Hoà A, Bình Tân, Tp. HCM', '0973379501', getdate(), 300000, 5, N'Nhân viên'),
(N'Nguyễn Anh Minh', 2, N'30 Tân Kỳ Tân Quý, Bình Hưng Hoà A, Bình Tân, Tp. HCM', '0974326016', getdate(), 300000, 6, N'Nhân viên'),
(N'Nguyễn Đức Phúc', 2, N'52 Tân Kỳ Tân Quý, Bình Hưng Hoà A, Bình Tân, Tp. HCM', '0982715706', getdate(), 300000, 9, N'Nhân viên'),
(N'Lê Bá Hoàng', 2, N'45 Tân Kỳ Tân Quý, Bình Hưng Hoà A, Bình Tân, Tp. HCM', '0982932473', getdate(), 500000, 10, N'Quản lý'),

(N'Nguyễn Gia Huy', 3, N'14 Lê Văn Quới, Bình Hưng Hòa A, Quận Bình Tân, Thành phố Hồ Chí Minh', '0973379501', getdate(), 200000, 4, N'Thời vụ'),
(N'Bùi Quốc Anh', 3, N'32 Lê Văn Quới, Bình Hưng Hòa A, Quận Bình Tân, Thành phố Hồ Chí Minh', '0983612035', getdate(), 200000, 4, N'Thời vụ'),
(N'Tuyết Ngân', 3, N'47 Lê Văn Quới, Bình Hưng Hòa A, Quận Bình Tân, Thành phố Hồ Chí Minh', '0983733714', getdate(), 300000, 8, N'Nhân viên'),
(N'Thiên Phong', 3, N'145 Lê Văn Quới, Bình Hưng Hòa A, Quận Bình Tân, Thành phố Hồ Chí Minh', '0986071924', getdate(), 500000, 15, N'Quản lý'),

(N'Nguyễn Cẩm Vân', 4, N'500 Tỉnh Lộ 10, P.Bình Trị Đông B, Q.Bình Tân, TP.HCM', '0971234141', getdate(), 300000, 8, N'Nhân viên'),
(N'Nguyễn Thiên Kim', 4, N'465 Tỉnh Lộ 10, P.Bình Trị Đông B, Q.Bình Tân, TP.HCM', '0981234040', getdate(), 300000, 9, N'Nhân viên'),
(N'Nguyễn Minh Châu', 4, N'525 Tỉnh Lộ 10, P.Bình Trị Đông B, Q.Bình Tân, TP.HCM', '0975322222', getdate(), 300000, 12, N'Nhân viên'),
(N'Nguyễn Bảo Ngọc', 4, N'285 Tỉnh Lộ 10, P.Bình Trị Đông B, Q.Bình Tân, TP.HCM', '0963888881', getdate(), 500000, 15, N'Quản lý'),

(N'Vũ Tuấn Kiệt', 5, N'Số 5, Phường Bình Trị Đông, Quận Bình Tân, Tp. Hồ Chí Minh', '0989117799', getdate(), 300000, 7, N'Nhân viên'),
(N'Trần Diệp Thảo Nguyên', 5, N'Số 7, Phường Bình Trị Đông, Quận Bình Tân, Tp. Hồ Chí Minh', '0784333993', getdate(), 200000, 5, N'Thời vụ'),
(N'Huỳnh Ngọc Anh', 5, N'Số 3, Phường Bình Trị Đông, Quận Bình Tân, Tp. Hồ Chí Minh', '0768686875', getdate(), 300000, 10, N'Nhân viên'),
(N'Lê Đặng Ðăng Khoa', 5, N'Số 8, Phường Bình Trị Đông, Quận Bình Tân, Tp. Hồ Chí Minh', '0708647997', getdate(), 500000, 12, N'Quản lý'),

(N'Nguyễn Gia Linh', 6, N'20 Bờ Bao Tân Thắng, Phường Sơn Kỳ, Quận Tân Phú, TP. Hồ Chí Minh', '0798993355', getdate(), 300000, 8, N'Nhân viên'),
(N'Phạm Đình Chí Kiên', 6, N'15 Bờ Bao Tân Thắng, Phường Sơn Kỳ, Quận Tân Phú, TP. Hồ Chí Minh', '0981234040', getdate(), 300000, 10, N'Nhân viên'),
(N'Trần Thị Ngọc Trúc', 6, N'23 Bờ Bao Tân Thắng, Phường Sơn Kỳ, Quận Tân Phú, TP. Hồ Chí Minh', '0764226996', getdate(), 300000, 9, N'Nhân viên'),
(N'Huỳnh Tố Như Bích', 6, N'42 Bờ Bao Tân Thắng, Phường Sơn Kỳ, Quận Tân Phú, TP. Hồ Chí Minh', '0767676784', getdate(), 500000, 12, N'Quản lý'),

(N'Đinh Quý Vương', 7, N'300 Tân Kỳ Tân Quý, Phường Tân Quý, Quận Tân Phú, Tp. Hồ Chí Minh', '0789860055', getdate(), 300000, 6, N'Nhân viên'),
(N'Phan Diễm Lan Chi', 7, N'205 Tân Kỳ Tân Quý, Phường Tân Quý, Quận Tân Phú, Tp. Hồ Chí Minh', '0703221515', getdate(), 300000, 8, N'Nhân viên'),
(N'Lê Gia Huy', 7, N'301 Tân Kỳ Tân Quý, Phường Tân Quý, Quận Tân Phú, Tp. Hồ Chí Minh', '0792332277', getdate(), 300000, 9, N'Nhân viên'),
(N'Vũ Hùng Cường', 7, N'327 Tân Kỳ Tân Quý, Phường Tân Quý, Quận Tân Phú, Tp. Hồ Chí Minh', '0707746699', getdate(), 500000, 15, N'Quản lý'),

(N'Lê Đức Dương', 8, N'150 Thạch Lam, Phường Phú Thạnh, Quận Tân Phú, Tp. Hồ Chí Minh', '0123456789', getdate(), 300000, 10, N'Nhân viên'),
(N'Lê Trần Hiếu Duy', 8, N'103 Thạch Lam, Phường Phú Thạnh, Quận Tân Phú, Tp. Hồ Chí Minh', '0123456789', getdate(), 300000, 9, N'Nhân viên'),
(N'Lê Phúc Hưng', 8, N'192 Thạch Lam, Phường Phú Thạnh, Quận Tân Phú, Tp. Hồ Chí Minh', '0123456789', getdate(), 300000, 8, N'Nhân viên'),
(N'Lê Tuấn Hưng', 8, N'158 Thạch Lam, Phường Phú Thạnh, Quận Tân Phú, Tp. Hồ Chí Minh', '0123456789', getdate(), 500000, 13, N'Quản lý'),

(N'Phan Kim Thiên Ý', 9, N'204 Hòa Bình, P. Hiệp Tân, Q. Tân Phú, TP.HCM', '0797770088', getdate(), 300000, 8, N'Nhân viên'),
(N'Huỳnh Tâm Như', 9, N'132 Hòa Bình, P. Hiệp Tân, Q. Tân Phú, TP.HCM', '0708927676', getdate(), 200000, 5, N'Thời vụ'),
(N'Trần Thị Lan Hương', 9, N'102 Hòa Bình, P. Hiệp Tân, Q. Tân Phú, TP.HCM', '0789990006', getdate(), 300000, 7, N'Nhân viên'),
(N'Vũ Thái Khang', 9, N'246 Hòa Bình, P. Hiệp Tân, Q. Tân Phú, TP.HCM', '0703177997', getdate(), 500000, 14, N'Quản lý'),

(N'Trần Ngọc Bích', 10, N'280 Âu Cơ, Phường Phú Trung, Quận Tân Phú, TP.HCM', '0786662112', getdate(), 300000, 7, N'Nhân viên'),
(N'Huỳnh Ngọc Hạ Vy', 10, N'122 Âu Cơ, Phường Phú Trung, Quận Tân Phú, TP.HCM', '0767676746', getdate(), 300000, 8, N'Nhân viên'),
(N'Lê Thị Bạch Vân', 10, N'150 Âu Cơ, Phường Phú Trung, Quận Tân Phú, TP.HCM', '0798182233', getdate(), 300000, 10, N'Nhân viên'),
(N'Lê Đức Chính', 10, N'152 Âu Cơ, Phường Phú Trung, Quận Tân Phú, TP.HCM', '0708645757', getdate(), 500000, 15, N'Quản lý'),

(N'Trần Khả Ái', 11, N'30 Lạc Long Quân, Phường 5, Quận 11, Tp. Hồ Chí Minh', '0123456789', getdate(), 300000, 5, N'Nhân viên'),
(N'Trần Kim Loan', 11, N'24 Lạc Long Quân, Phường 5, Quận 11, Tp. Hồ Chí Minh', '0123456789', getdate(), 300000, 8, N'Nhân viên'),
(N'Vũ Tuấn Kiệt', 11, N'43 Lạc Long Quân, Phường 5, Quận 11, Tp. Hồ Chí Minh', '0123456789', getdate(), 300000, 7, N'Nhân viên'),
(N'Phạm Bảo Long', 11, N'50 Lạc Long Quân, Phường 5, Quận 11, Tp. Hồ Chí Minh', '0123456789', getdate(), 500000, 9, N'Quản lý'),

(N'Phạm Ðức Tài', 12, N'50 Vườn Lài, Phường Phú Thọ Hòa, Quận Tân Phú, Tp. Hồ Chí Minh', '0799979292', getdate(), 300000, 8, N'Nhân viên'),
(N'Vũ Uy Vũ', 12, N'43 Vườn Lài, Phường Phú Thọ Hòa, Quận Tân Phú, Tp. Hồ Chí Minh', '0708325599', getdate(), 300000, 6, N'Nhân viên'),
(N'Nguyễn Như Ý', 12, N'21 Vườn Lài, Phường Phú Thọ Hòa, Quận Tân Phú, Tp. Hồ Chí Minh', '0794449966', getdate(), 200000, 4, N'Thời vụ'),
(N'Phạm Quang Anh', 12, N'35 Vườn Lài, Phường Phú Thọ Hòa, Quận Tân Phú, Tp. Hồ Chí Minh', '0793451155', getdate(), 500000, 13, N'Quản lý'),

(N'Lê Mẫn Tiên', 13, N'221 Hồng Lạc, Phường 10, Quận Tân Bình, Tp. HCM', '0783336446', getdate(), 200000, 6, N'Thời vụ'),
(N'Lê Thảo Hiền', 13, N'211 Hồng Lạc, Phường 10, Quận Tân Bình, Tp. HCM', '0797794477', getdate(), 200000, 6, N'Thời vụ'),
(N'Đinh Quý Hiển', 13, N'201 Hồng Lạc, Phường 10, Quận Tân Bình, Tp. HCM', '0792220088', getdate(), 300000, 6, N'Nhân viên'),
(N'Phạm Thiên Ân', 13, N'230 Hồng Lạc, Phường 10, Quận Tân Bình, Tp. HCM', '0789912020', getdate(), 500000, 14, N'Quản lý'),

(N'Lê Thục Khánh An', 14, N'100 Độc Lập, P.Tân Thành, Q.Tân Phú, TP.HCM', '0783336655', getdate(), 300000, 9, N'Nhân viên'),
(N'Lê Thùy Thư Ánh', 14, N'112 Độc Lập, P.Tân Thành, Q.Tân Phú, TP.HCM', '0703022662', getdate(), 300000, 9, N'Nhân viên'),
(N'Lê Phương Như Cát', 14, N'123 Độc Lập, P.Tân Thành, Q.Tân Phú, TP.HCM', '0798838282', getdate(), 300000, 9, N'Nhân viên'),
(N'Đinh Hoàng Giang', 14, N'145 Độc Lập, P.Tân Thành, Q.Tân Phú, TP.HCM', '0784115757', getdate(), 500000, 17, N'Quản lý'),

(N'Đinh Trường Minh', 15, N'70 Đường D9, Phường Tây Thạnh, Quận Tân Phú, TP.HCM', '0786665454', getdate(), 300000, 5, N'Nhân viên'),
(N'Đinh Minh Cảnh', 15, N'75 Đường D9, Phường Tây Thạnh, Quận Tân Phú, TP.HCM', '0703330202', getdate(), 200000, 3, N'Thời vụ'),
(N'Lê Tuấn Anh', 15, N'61 Đường D9, Phường Tây Thạnh, Quận Tân Phú, TP.HCM', '0792666144', getdate(), 300000, 9, N'Nhân viên'),
(N'Lê Bảo Bình', 15, N'32 Đường D9, Phường Tây Thạnh, Quận Tân Phú, TP.HCM', '0783331166', getdate(), 500000, 12, N'Quản lý'),

(N'Lê Ngọc Doanh', 16, N'50 Lê Trọng Tấn, phường Sơn Kỳ, quận Tân Phú, Tp.HCM, Việt Nam', '0784333773', getdate(), 300000, 6, N'Nhân viên'),
(N'Lê Xuân Duy', 16, N'42 Lê Trọng Tấn, phường Sơn Kỳ, quận Tân Phú, Tp.HCM, Việt Nam', '0783228811', getdate(), 200000, 4, N'Thời vụ'),
(N'Trần Ánh Hồng', 16, N'33 Lê Trọng Tấn, phường Sơn Kỳ, quận Tân Phú, Tp.HCM, Việt Nam', '0783332772', getdate(), 300000, 5, N'Nhân viên'),
(N'Vũ Quốc Trung', 16, N'55 Lê Trọng Tấn, phường Sơn Kỳ, quận Tân Phú, Tp.HCM, Việt Nam', '0703113300', getdate(), 500000, 11, N'Quản lý'),

(N'Vũ Thiện Nhân', 17, N'40 Trường Chinh, Phường Tân Thới Nhất, Quận 12, Tp. Hồ Chí Minh', '0767676753', getdate(), 300000, 7, N'Nhân viên'),
(N'Vũ Hữu Thiện', 17, N'33 Trường Chinh, Phường Tân Thới Nhất, Quận 12, Tp. Hồ Chí Minh', '0783330004', getdate(), 300000, 8, N'Nhân viên'),
(N'Vũ Đức Minh', 17, N'21 Trường Chinh, Phường Tân Thới Nhất, Quận 12, Tp. Hồ Chí Minh', '0794446664', getdate(), 300000, 5, N'Nhân viên'),
(N'Vũ Phúc Điền', 17, N'52 Trường Chinh, Phường Tân Thới Nhất, Quận 12, Tp. Hồ Chí Minh', '0786669911', getdate(), 500000, 10, N'Quản lý'),

(N'Phạm Thiên Bảo', 18, N'101 Nguyễn Văn Quá, Phường Tân Hưng Thuận, Quận 12, TP.HCM', '0798584949', getdate(), 300000, 5, N'Nhân viên'),
(N'Phạm Dũng Cường', 18, N'115 Nguyễn Văn Quá, Phường Tân Hưng Thuận, Quận 12, TP.HCM', '0708923377', getdate(), 200000, 8, N'Thời vụ'),
(N'Nguyễn Vĩ Hạ', 18, N'123 Nguyễn Văn Quá, Phường Tân Hưng Thuận, Quận 12, TP.HCM', '0937259556', getdate(), 300000, 6, N'Nhân viên'),
(N'Trần Quang Huy', 18, N'141 Nguyễn Văn Quá, Phường Tân Hưng Thuận, Quận 12, TP.HCM', '0703334400', getdate(), 500000, 13, N'Quản lý'),

(N'Trần Lê Anh Trí', 19, N'50 Phan Huy Ích, Phường 15, Quận Tân Bình, TP. Hồ Chí Minh', '0794445858', getdate(), 300000, 6, N'Nhân viên'),
(N'Phan Kim Ánh Dương', 19, N'43 Phan Huy Ích, Phường 15, Quận Tân Bình, TP. Hồ Chí Minh', '0708338811', getdate(), 300000, 7, N'Nhân viên'),
(N'Huỳnh Khởi My', 19, N'21 Phan Huy Ích, Phường 15, Quận Tân Bình, TP. Hồ Chí Minh', '0703334242', getdate(), 300000, 9, N'Nhân viên'),
(N'Trần Xuân Trường', 19, N'33 Phan Huy Ích, Phường 15, Quận Tân Bình, TP. Hồ Chí Minh', '0789912277', getdate(), 500000, 16, N'Quản lý'),

(N'Phan Hạ Thùy An', 20, N'50 Tô Ký, Đông Hưng Thuận, Quận 12, Tp. Hồ Chí Minh', '0703337117', getdate(), 300000, 7, N'Nhân viên'),
(N'Huỳnh Ngọc Linh Đan', 20, N'32 Tô Ký, Đông Hưng Thuận, Quận 12, Tp. Hồ Chí Minh', '0798184499', getdate(), 300000, 5, N'Nhân viên'),
(N'Phan Kiều Hải Ngân', 20, N'40 Tô Ký, Đông Hưng Thuận, Quận 12, Tp. Hồ Chí Minh', '0797771122', getdate(), 300000, 9, N'Nhân viên'),
(N'Lê Ngọc Minh', 20, N'18 Tô Ký, Đông Hưng Thuận, Quận 12, Tp. Hồ Chí Minh', '0794447700', getdate(), 500000, 15, N'Quản lý');

-- Bảng ACCOUNT
go
insert into ACCOUNT (AccountName, Password, EmployeeId) values
('sysadmin','sys3041975', 1),
('thvan','tv123', 2),
('ttDo','tdo123', 4),
('lbhoang','bh123', 8)

-- Bảng SUPPLIER (Nhà cung cấp)
go
insert into SUPPLIER (Name, Phone, Address, Email) values
(N'Công ty TNHH MTV Thái Kiên', '0917561212', N'127 Nguyễn Cơ Thạch, An Lợi Đông, Q.2, Tp. Hồ Chí Minh', 'cpg.customerservice@vtijs.com'),
(N'Công Ty TNHH Sản Xuất – Thương Mại Hồng Phúc', '1900555525', N'390 – 396 Tô Ngọc Vân, Phường Thạnh Xuân, Quận 12, TP. Hồ Chí Minh', 'hp@nuocdahongphuc.com'),
(N'Công ty TNHH Ba Huân', '18006002', N'Tòa nhà Cantavil Premier, Song Hành, Phường An Phú, Tp. Thủ Đức, Tp. Hồ Chí Minh', 'info@bahuan.vn'),
(N'Công Ty TNHH Thương Mại Chế Biến Thực Phẩm Hòa Phát', '0903974225 ', N'39/4F Ấp Nam Lân, Bà Điểm, Hóc Môn, TP. Hồ Chí Minh', 'hoaphattapioca@gmail.com'),
(N'Công ty Cổ Phần Sữa Việt Nam (Vinamilk)', '(028)54155555', N'10, Đường Tân Trào, phường Tân Phú, quận 7, Tp. HCM', 'vinamilk@vinamilk.com.vn'),
(N'Công Ty TNHH Thương Mại Dịch Vụ Và Sản Xuất Trí Việt Phát', '0987799239', N'81 Tân Hòa 2, KP. 6, P. Hiệp Phú, TP. Thủ Đức, TP. Hồ Chí Minh', 'www.trivietphat.net'),
(N'Công Ty TNHH Thương Mại Xuất Nhập Khẩu Sao Khuê', '0906339598', N'180/15 Đường Nguyễn Hữu Cảnh, P. 22, Q. Bình Thạnh, TP. Hồ Chí Minh', 'khuestarco@made-in-vietnam.com.vn');

-- Bảng INGREDIENT (Nguyên liệu)
go
insert into INGREDIENT (IngredientName, SupplierId, Unit, EXPDay, Price) values 
(N'Cafe Phin', 1, 'kg', 60, 125000),
(N'Cafe Hạt', 1, 'kg', 60, 110000),
(N'Nước', 2, 'lít', 1800, 25000),
(N'Sữa Đặc', 5, 'lít', 60, 61452),
(N'Sữa Tươi', 5, 'lít', 60, 47100),
(N'Trà', 6, 'gói', 120, 890),
(N'Chuối', 7, 'kg', 60, 10000),
(N'Chanh Dây', 7, 'kg', 90, 25000),
(N'Đào', 7, 'kg', 90, 20000),
(N'Vải', 7, 'kg', 90, 80000),
(N'Sô-Cô-La', 4, 'kg', 60, 300000),
(N'Cacao', 4, 'kg', 60, 300000),
(N'Hạnh Nhân', 7, 'kg', 90, 150000),
(N'Whipping cream', 4, 'kg', 90, 120000),
(N'Đậu Đỏ', 7, 'kg', 90, 45000),
(N'Đá Viên', 2, 'kg', 1, 5000),
(N'Đường', 4, 'kg', 120, 20000),
(N'Muối', 4, 'kg', 120, 15000),
(N'Bột mì', 4, 'kg', 90, 30000),
(N'Trứng gà', 3, N'quả', 30, 5000),
(N'Patê', 3, 'kg', 30, 80000),
(N'Thịt Bò', 3, 'kg', 25, 250000),
(N'Rich Lùn (kem béo thực vật)', 4, 'lít', 30, 75000);

-- Bảng PRODUCTS (Sản phẩm)
go
insert into PRODUCTS (ProductName, Price) values
(N'Phin Sữa Đá', 39000),
(N'Phin Đen Đá', 35000),
(N'Bạc Xỉu', 39000),
(N'Phindi Hạnh Nhân', 55000),
(N'Phindi Kem Sữa', 55000),
(N'Phindi Choco', 55000),
(N'Bánh Chuối', 29000),
(N'Bánh Phô Mai Chanh Dây', 29000),
(N'Bánh Su Kem', 29000),
(N'Bánh Tritramisu', 35000),
(N'Bánh Mousse Đào', 35000),
(N'Bánh Mousse Cacao', 35000),
(N'Bánh Phô Mai Trà Xanh', 35000),
(N'Bánh Phô Mai Caramel', 35000),
(N'Bánh Sô-Cô-La Highlands', 35000),
(N'Bánh Sữa Chua Phô Mai', 39000),
(N'Bánh Mì Que (Patê)', 19000),
(N'Bánh Mì Que (Gà Phô Mai)', 19000),
(N'Bánh Mì Que (Bò Xốt Phô Mai)', 25000),
(N'Trà Sen Vàng', 65000),
(N'Trà Thạch Đào', 55000),
(N'Trà Thanh Đào', 65000),
(N'Trà Thạch Vải', 55000),
(N'Trà Xanh Đậu Đỏ', 65000),
(N'Freeze Trà Xanh', 69000),
(N'Caramel Phin Freeze', 65000),
(N'Cookies & Cream', 69000),
(N'Freeze Sô-Cô-La', 69000),
(N'Classic Phin Freeze', 65000),
(N'COMBO Hứng Khởi (Phin Sữa Đá & Bánh Mì Que)', 49000),
(N'COMBO Chuyện Trò (Trà & Bánh Ngọt)', 75000),
(N'MOKA 200GR', 120000),
(N'CULI 200GR', 110000),
(N'CÀ PHÊ ĐEN LON 185ML/LON', 66000);

-- Bảng RECIPE (Công thức)
go
insert into RECIPE (IngredientId, ProductId, Quantity, Unit) values
-- Phin Sữa Đá
(1, 1, 0.02, 'kg'),  -- Cafe Phin
(4, 1, 0.03, 'lít'), -- Sữa Đặc
(16, 1, 0.2, 'kg'),  -- Đá Viên
(17, 1, 0.01, 'kg'), -- Đường

-- Phin Đen Đá
(1, 2, 0.02, 'kg'),  -- Cafe Phin
(16, 2, 0.2, 'kg'),  -- Đá Viên

-- Bạc Xỉu
(1, 3, 0.015, 'kg'), -- Cafe Phin
(5, 3, 0.05, 'lít'), -- Sữa Tươi
(16, 3, 0.15, 'kg'), -- Đá Viên
(17, 3, 0.015, 'kg'),-- Đường

-- Phindi Hạnh Nhân
(1, 4, 0.025, 'kg'), -- Cafe Phin
(13, 4, 0.03, 'kg'), -- Hạnh Nhân
(14, 4, 0.02, 'kg'), -- Whipping cream
(16, 4, 0.15, 'kg'), -- Đá Viên

-- Bánh Chuối
(7, 7, 0.1, 'kg'),   -- Chuối
(19, 7, 0.15, 'kg'), -- Bột mì
(20, 7, 2, 'quả'),   -- Trứng gà
(17, 7, 0.05, 'kg'); -- Đường

---- Bảng INVENTORY (Kho hàng)
--go
--DECLARE @BranchId INT = 1;
--WHILE @BranchId <= 20
--BEGIN
--    INSERT INTO INVENTORY (BranchId, IngredientId, RestockDate, EXPDay, Quantity, Unit, UnitPrice) 
--    VALUES
--    (@BranchId, 1, GETDATE(), (SELECT EXPDay FROM INGREDIENT WHERE IngredientId = 1), 100, 'kg', 125000),  -- Cafe Phin
--    (@BranchId, 2, GETDATE(), (SELECT EXPDay FROM INGREDIENT WHERE IngredientId = 2), 100, 'kg', 110000),  -- Cafe Hạt
--    (@BranchId, 3, GETDATE(), (SELECT EXPDay FROM INGREDIENT WHERE IngredientId = 3), 200, 'lít', 25000),  -- Nước
--    (@BranchId, 4, GETDATE(), (SELECT EXPDay FROM INGREDIENT WHERE IngredientId = 4), 50, 'lít', 61452),   -- Sữa Đặc
--    (@BranchId, 5, GETDATE(), (SELECT EXPDay FROM INGREDIENT WHERE IngredientId = 5), 50, 'lít', 47100),   -- Sữa Tươi
--    (@BranchId, 6, GETDATE(), (SELECT EXPDay FROM INGREDIENT WHERE IngredientId = 6), 500, 'gói', 890),    -- Trà
--    (@BranchId, 16, GETDATE(), (SELECT EXPDay FROM INGREDIENT WHERE IngredientId = 16), 100, 'kg', 5000),  -- Đá Viên
--    (@BranchId, 17, GETDATE(), (SELECT EXPDay FROM INGREDIENT WHERE IngredientId = 17), 50, 'kg', 20000);  -- Đường
    
--    SET @BranchId = @BranchId + 1;
--END;

---- Trigger cho INVENTORY
--go
--CREATE TRIGGER trg_SetEXPDay
--ON INVENTORY
--INSTEAD OF INSERT
--AS
--BEGIN
--    INSERT INTO INVENTORY (BranchId, IngredientId, RestockDate, EXPDay, Quantity, Unit, UnitPrice)
--    SELECT i.BranchId, i.IngredientId, i.RestockDate, ing.EXPDay, i.Quantity, i.Unit, i.UnitPrice
--    FROM inserted i
--    JOIN INGREDIENT ing ON i.IngredientId = ing.IngredientId;
--END;

-- Bảng CUSTOMER (Khách hàng)
go
-- Tạo bảng tạm cho tên và họ
create table #FirstNames (FirstName nvarchar(30));
create table #LastNames (LastName nvarchar(30));

-- Chèn dữ liệu vào bảng tên
insert into #FirstNames (FirstName) values
(N'An'), (N'Ánh'), (N'Ân'), (N'Âu'), (N'Ấu'),
(N'Bá'), (N'Bạc'), (N'Bạch'), (N'Bàn'), (N'Bàng'),
(N'Bế'), (N'Bì'), (N'Biện'), (N'Bình'), (N'Bồ'),
(N'Ca'), (N'Cái'), (N'Cam'), (N'Cao'), (N'Cát'),
(N'Cảnh'), (N'Chế'), (N'Chiêm'), (N'Chu'), (N'Châu'),
(N'Chung'), (N'Trung'), (N'Chúng'), (N'Chương'),
(N'Chử'), (N'Cổ'), (N'Cù'), (N'Dã'), (N'Danh'),
(N'Diêm'), (N'Diệp'), (N'Doãn'), (N'Du'), (N'Đàm'),
(N'Đan'), (N'Đào'), (N'Đậu'), (N'Hà'), (N'Hạ'),
(N'Hàn'), (N'Hán'), (N'Hề'), (N'Hè'), (N'Hi'),
(N'Hình'), (N'Hoa'), (N'Hồng'), (N'Hùng'), (N'Kha'),
(N'Khương'), (N'Khâu'), (N'Khưu'), (N'Khiếu'),
(N'Khoa'), (N'Khổng'), (N'Khu'), (N'Khuất'),
(N'Khúc'), (N'Kiều'), (N'Lương'), (N'Lưu'),
(N'Lỳ'), (N'Lý'), (N'Ma'), (N'Mã'), (N'Mạc'),
(N'Mạch'), (N'Mai'), (N'Mang'), (N'Mâu'),
(N'Lạc'), (N'Lại'), (N'Lâm'), (N'Lều'), (N'Lãnh'),
(N'Lãng'), (N'Liễu'), (N'Lò'), (N'Lô'), (N'Lỗ'),
(N'Luyện'), (N'Lục'), (N'Ninh'), (N'Nhâm'),
(N'Ngân'), (N'Nghiêm'), (N'Nghị'), (N'Ngọ'),
(N'Ngụy'), (N'Nhữ'), (N'Nông'), (N'Ong'),
(N'Phí'), (N'Phó'), (N'Phú'), (N'Phùng'),
(N'Phương'), (N'Phường'), (N'Quản'), (N'Quàng'),
(N'Quách'), (N'Sầm'), (N'Sơn'), (N'Thôi'),
(N'Tiêu'), (N'Tiếp'), (N'Tòng'), (N'Tô'), (N'Tôn'),
(N'Tông'), (N'Tống'), (N'Trang'), (N'Tra'),
(N'Triệu'), (N'Trịnh'), (N'Trình'), (N'Trưng'),
(N'Trừng'), (N'Trương'), (N'Từ'), (N'Ti'),
(N'Uông'), (N'Ung'), (N'Ưng'), (N'Tào'),
(N'Tán'), (N'Tăng'), (N'Thạch'), (N'Thái'),
(N'Thành'), (N'Thào'), (N'Thẩm'), (N'Thân'),
(N'Thập'), (N'Vi'), (N'Viên'), (N'Vương'),
(N'Vừ'), (N'Xa'), (N'Yên');

-- Chèn dữ liệu vào bảng họ
insert into #LastNames (LastName) values
(N'Nguyễn'), (N'Trần'), (N'Lê'), (N'Phạm'),
(N'Hoàng'), (N'Vũ'), (N'Đặng'), (N'Toàn'),
(N'Tuấn'), (N'Hải'), (N'Khoa'), (N'Huỳnh'),
(N'Bùi'), (N'Nguyệt'), (N'Ngô'), (N'Tần'),
(N'Đinh'), (N'Quang'), (N'Tư'), (N'Tiêu');

-- Khai báo biến để theo dõi số lượng khách hàng đã tạo
declare @Counter int = 1;

-- Bắt đầu vòng lặp để tạo 500 khách hàng
while @Counter <= 500
begin
    -- Tạo tên khách hàng ngẫu nhiên từ họ và tên
    declare @FirstName nvarchar(30);
    declare @LastName nvarchar(30);
    declare @MiddleName1 nvarchar(30);
    declare @MiddleName2 nvarchar(30);
    declare @MiddleName3 nvarchar(30);

    select top 1 @LastName = LastName from #LastNames order by newid();
    select top 1 @FirstName = FirstName from #FirstNames order by newid();

    -- Chọn ngẫu nhiên độ dài tên
    declare @NameLength int = rand() * 3 + 2; -- Số ngẫu nhiên từ 2 đến 4

    -- Tạo tên theo độ dài
    declare @CustomerName nvarchar(100);
    set @CustomerName = @LastName + N' ';

    if @NameLength >= 3
    begin
        select top 1 @MiddleName1 = FirstName from #FirstNames order by newid();
        set @CustomerName = @CustomerName + @MiddleName1 + N' ';
    end
    if @NameLength >= 4
    begin
         select top 1 @MiddleName2 = FirstName from #FirstNames order by newid();
         set @CustomerName = @CustomerName + @MiddleName2 + N' ';
    end
    if @NameLength >= 5
    begin
         select top 1 @MiddleName3 = FirstName from #FirstNames order by newid();
         set @CustomerName = @CustomerName + @MiddleName3 + N' ';
    end
    set @CustomerName = @CustomerName + @FirstName;

	if object_id('dbo.RemoveDiacritics') is null
    exec('create function dbo.RemoveDiacritics (@str nvarchar(max))
          returns nvarchar(max)
          as
          begin
              declare @ret nvarchar(max) = @str;
              set @ret = replace(@ret, N''à'', ''a'');
              set @ret = replace(@ret, N''á'', ''a'');
              set @ret = replace(@ret, N''ả'', ''a'');
              set @ret = replace(@ret, N''ã'', ''a'');
              set @ret = replace(@ret, N''ạ'', ''a'');
              set @ret = replace(@ret, N''ă'', ''a'');
              set @ret = replace(@ret, N''ằ'', ''a'');
              set @ret = replace(@ret, N''ắ'', ''a'');
              set @ret = replace(@ret, N''ẳ'', ''a'');
              set @ret = replace(@ret, N''ẵ'', ''a'');
              set @ret = replace(@ret, N''ặ'', ''a'');
              set @ret = replace(@ret, N''â'', ''a'');
              set @ret = replace(@ret, N''ầ'', ''a'');
              set @ret = replace(@ret, N''ấ'', ''a'');
              set @ret = replace(@ret, N''ẩ'', ''a'');
              set @ret = replace(@ret, N''ẫ'', ''a'');
              set @ret = replace(@ret, N''ậ'', ''a'');
              set @ret = replace(@ret, N''è'', ''e'');
              set @ret = replace(@ret, N''é'', ''e'');
              set @ret = replace(@ret, N''ẻ'', ''e'');
              set @ret = replace(@ret, N''ẽ'', ''e'');
              set @ret = replace(@ret, N''ẹ'', ''e'');
              set @ret = replace(@ret, N''ê'', ''e'');
              set @ret = replace(@ret, N''ề'', ''e'');
              set @ret = replace(@ret, N''ế'', ''e'');
              set @ret = replace(@ret, N''ể'', ''e'');
              set @ret = replace(@ret, N''ễ'', ''e'');
              set @ret = replace(@ret, N''ệ'', ''e'');
              set @ret = replace(@ret, N''ì'', ''i'');
              set @ret = replace(@ret, N''í'', ''i'');
              set @ret = replace(@ret, N''ỉ'', ''i'');
              set @ret = replace(@ret, N''ĩ'', ''i'');
              set @ret = replace(@ret, N''ị'', ''i'');
              set @ret = replace(@ret, N''ò'', ''o'');
              set @ret = replace(@ret, N''ó'', ''o'');
              set @ret = replace(@ret, N''ỏ'', ''o'');
              set @ret = replace(@ret, N''õ'', ''o'');
              set @ret = replace(@ret, N''ọ'', ''o'');
              set @ret = replace(@ret, N''ô'', ''o'');
              set @ret = replace(@ret, N''ồ'', ''o'');
              set @ret = replace(@ret, N''ố'', ''o'');
              set @ret = replace(@ret, N''ổ'', ''o'');
              set @ret = replace(@ret, N''ỗ'', ''o'');
              set @ret = replace(@ret, N''ộ'', ''o'');
              set @ret = replace(@ret, N''ơ'', ''o'');
              set @ret = replace(@ret, N''ờ'', ''o'');
              set @ret = replace(@ret, N''ớ'', ''o'');
              set @ret = replace(@ret, N''ở'', ''o'');
              set @ret = replace(@ret, N''ỡ'', ''o'');
              set @ret = replace(@ret, N''ợ'', ''o'');
              set @ret = replace(@ret, N''ù'', ''u'');
              set @ret = replace(@ret, N''ú'', ''u'');
              set @ret = replace(@ret, N''ủ'', ''u'');
              set @ret = replace(@ret, N''ũ'', ''u'');
              set @ret = replace(@ret, N''ụ'', ''u'');
              set @ret = replace(@ret, N''ư'', ''u'');
              set @ret = replace(@ret, N''ừ'', ''u'');
              set @ret = replace(@ret, N''ứ'', ''u'');
              set @ret = replace(@ret, N''ử'', ''u'');
              set @ret = replace(@ret, N''ữ'', ''u'');
              set @ret = replace(@ret, N''ự'', ''u'');
              set @ret = replace(@ret, N''ỳ'', ''y'');
              set @ret = replace(@ret, N''ý'', ''y'');
              set @ret = replace(@ret, N''ỷ'', ''y'');
              set @ret = replace(@ret, N''ỹ'', ''y'');
              set @ret = replace(@ret, N''ỵ'', ''y'');
              set @ret = replace(@ret, N''đ'', ''d'');
			  set @ret = replace(@ret, N'' '', ''''); -- Loại bỏ khoảng trắng luôn
              return @ret;
          end;');

    -- Tạo email ngẫu nhiên theo tên (không dấu)
    declare @Email nvarchar(50) = lower(dbo.RemoveDiacritics(@CustomerName)) + '@gmail.com';

    -- Tạo số điện thoại Viettel hợp lệ
    declare @Phone varchar(13);
    declare @Prefix varchar(3);
    declare @randomNumber varchar(7);

    declare @randomPrefixIndex int = abs(checksum(newid())) % 9; -- 9 là số lượng tiền tố
    set @Prefix =
        case @randomPrefixIndex
            when 0 then '032'
            when 1 then '033'
            when 2 then '034'
            when 3 then '035'
            when 4 then '036'
            when 5 then '037'
            when 6 then '038'
            when 7 then '039'
            else '086'
        end;

    set @randomNumber = RIGHT('0000000' + cast(abs(checksum(newid())) % 10000000 as varchar(7)), 7);
    set @Phone = @Prefix + @randomNumber;

    -- Tạo điểm tích lũy ngẫu nhiên
    declare @Point int = abs(checksum(newid())) % 5001;

    -- Tạo hạng thành viên ngẫu nhiên
    declare @Tier nvarchar(10);

    set @Tier =
		case when @Point >= 10 AND @Point < 100 then N'Đồng' 
		when @Point >= 100 AND @Point < 1000 then N'Bạc' 
		when @Point >= 1000 AND @Point < 2500 then N'Vàng' 
		when @Point >= 2500 AND @Point <= 5000 then N'Bạch kim' else N'Đồng' -- Giá trị mặc định nếu Point không nằm trong khoảng nào 
        end;

    -- Chèn dữ liệu vào bảng CUSTOMER
    insert into CUSTOMER (CustomerName, Email, Phone, Point, Tier)
    values (@CustomerName, @Email, @Phone, @Point, @Tier);

    -- Tăng biến đếm
    set @Counter = @Counter + 1;
end;

-- Nhận thông báo hoàn thành
print N'Đã thêm 500 khách hàng vào bảng CUSTOMER';
go
-- Xóa các bảng tạm thời
drop table #FirstNames;
drop table #LastNames;

-- Bảng BILL (Hóa đơn)
go
declare @BillId int 
declare @BranchId int
declare @EmployeeId int
declare @CustomerId int 
declare @TableId int
declare @TotalPrice decimal(10, 2)
declare @i int = 1 

while @i <= 200
begin
    -- Chọn ngẫu nhiên BranchId từ bảng BRANCHES 
    set @BranchId = (select top 1 BranchId from BRANCHES order by newid())
    
    -- Chọn ngẫu nhiên EmployeeId từ bảng EMPLOYEE 
    set @EmployeeId = (select top 1 EmployeeId from EMPLOYEE order by newid())
    
    -- Chọn ngẫu nhiên CustomerId từ bảng CUSTOMER 
    set @CustomerId = (select top 1 CustomerId from CUSTOMER order by newid())
    
    -- Chọn ngẫu nhiên TableId từ bảng TABLE 
    set @TableId = (select top 1 TableId from [TABLES] order by newid())
    
    -- Tạo giá trị tổng tiền ngẫu nhiên
    set @TotalPrice = round((rand() * (1000000 - 50000) + 50000), 2)
    
    -- Chèn dữ liệu vào bảng BILL 
    insert into BILL(BranchId, EmployeeId, CustomerId, TableId, TotalPrice, Status) 
    values (@BranchId, @EmployeeId, @CustomerId, @TableId, @TotalPrice, 1)
    
    set @i = @i + 1
end

-- Thêm dữ liệu ngẫu nhiên vào bảng BILLINFO (không có ràng buộc UNIQUE)
go
-- Khai báo biến
declare @TargetRecords int = 200 -- Số lượng bản ghi muốn thêm
declare @Counter int = 1
declare @ProductId int
declare @BillId int
declare @Quantity int

-- Vòng lặp để thêm dữ liệu
while @Counter <= @TargetRecords
begin
    -- Lấy ProductId ngAŨ nhiên
    set @ProductId = (
        select top 1 ProductId 
        from PRODUCTS 
        order by newid()
    )

    -- Lấy BillId ngẫu nhiên
    set @BillId = (
        select top 1 BillId 
        from BILL 
        order by newid()
    )

    -- Tạo Quantity ngẫu nhiên từ 1 đến 10
    set @Quantity = round(rand() * 9 + 1, 0)

    -- Chèn dữ liệu vào bảng BILLINFO
    begin try
        insert into BILLINFO (ProductId, BillId, Quantity)
        values (@ProductId, @BillId, @Quantity)
    end try
    begin catch
        print N'Lỗi khi chèn bản ghi ' + cast(@Counter as nvarchar(10)) + ': ' + error_message()
        break
    end catch

    -- Tăng biến đếm
    set @Counter = @Counter + 1
end

-- Thông báo hoàn thành
print N'Đã thêm ' + cast(@Counter - 1 as nvarchar(10)) + N' bản ghi vào bảng BILLINFO'
go

---- Trigger cho BILLINFO
--CREATE TRIGGER trg_UpdateBillInfoQuantity
--ON BILLINFO
--INSTEAD OF INSERT
--AS
--BEGIN
--    MERGE INTO BILLINFO AS target
--    USING inserted AS source
--    ON target.BillId = source.BillId AND target.ProductId = source.ProductId
--    WHEN MATCHED THEN
--        UPDATE SET Quantity = target.Quantity + source.Quantity
--    WHEN NOT MATCHED THEN
--        INSERT (ProductId, BillId, Quantity)
--        VALUES (source.ProductId, source.BillId, source.Quantity);
--END;
--GO

-- Bảng PROMOTION (Khuyến mãi)
go
insert into PROMOTION (PromotionName, Description, RequirePoint, Discount, StartDate, EndDate) values
(N'Khuyến mãi khách hàng thân thiết (Loại 1)', N'Giảm giá 80% cho tất cả sản phẩm', 5000, 0.80, getdate(), DATEADD(DAY, 10, getdate())),
(N'Khuyến mãi khách hàng thân thiết (Loại 2)', N'Giảm giá 50% cho tất cả sản phẩm', 3000, 0.50, getdate(), DATEADD(DAY, 10, getdate())),
(N'Khuyến mãi khách hàng thân thiết (Loại 3)', N'Giảm giá 30% cho tất cả sản phẩm', 2500, 0.30, getdate(), DATEADD(DAY, 10, getdate())),
(N'Khuyến mãi khách hàng thân thiết (Loại 4)', N'Giảm giá 20% cho tất cả sản phẩm', 2000, 0.20, getdate(), DATEADD(DAY, 10, getdate())),
(N'Khuyến mãi ngày lễ', N'Mua 1 sản phẩm được tặng 1', 5000, 0.00, getdate(), DATEADD(DAY, 5, getdate())),
(N'Khuyến mãi đặc biệt', N'Khách hàng sẽ nhận được 1 lượt bốc thăm trúng quà', 1000, 0.00, getdate(), DATEADD(DAY, 10, getdate()));

-- Bảng PROMOTION_CUSTOMER (Khuyễn mãi của khách)
go
insert into PROMOTION_CUSTOMER (CustomerId, PromotionId)
select C.CustomerId, P.PromotionId
from CUSTOMER C inner join PROMOTION P
on C.Point >= P.RequirePoint;

-- Bảng FINANCIAL (Tài chính)
go
insert into FINANCIAL (BranchId, ReportDate, Revenue, OperationCost, IngredientCost) values
(1, getdate(), 1000000, 500000, 100000),
(2, getdate(), 1500000, 400000, 100000),
(3, getdate(), 2000000, 430000, 150000),
(4, getdate(), 3000000, 600000, 200000),
(5, getdate(), 1000000, 383000, 50000),
(6, getdate(), 5000000, 417000, 200000),
(7, getdate(), 1300000, 300000, 100000),
(8, getdate(), 1700000, 316000, 85000),
(9, getdate(), 3000000, 350000, 100000),
(10, getdate(), 1900000, 327000, 120000),
(11, getdate(), 1300000, 307000, 150000),
(12, getdate(), 4000000, 294000, 300000),
(13, getdate(), 1800000, 340000, 100000),
(14, getdate(), 2400000, 320000, 180000),
(15, getdate(), 1100000, 297000, 90000),
(16, getdate(), 3000000, 280000, 300000),
(17, getdate(), 8000000, 284000, 500000),
(18, getdate(), 2800000, 274000, 170000),
(19, getdate(), 2100000, 277000, 230000),
(20, getdate(), 3600000, 284000, 320000);

