use Highlands_Database

go
create proc sp_ChiTietDoanhThu
	@Status int,
	@BranchId int
as
	select 
		p.ProductId,
		p.ProductName,
		p.Price,
		sum(bi.Quantity) as Quantity,
		sum(bi.Quantity) * p.Price as TotalPrice
	from BILL b, BILLINFO bi, PRODUCTS p
	where b.BillId = bi.BillId and bi.ProductId = p.ProductId and b.BranchId = @BranchId
	group by p.ProductId, p.ProductName, p.Price
	order by p.ProductId
--drop proc sp_ChiTietDoanhThu
--exec sp_ChiTietDoanhThu 1, 1

go
create proc sp_ChiTietKhoHang
	@BranchId int
as
	select
		i.InventoryId,
		ig.IngredientName,
		s.Name,
		i.RestockDate,
		i.EXPDate,
		i.Quantity,
		i.Unit,
		i.UnitPrice,
		i.TotalPrice
	from INVENTORY i, INGREDIENT ig, SUPPLIER s
	where i.BranchId = @BranchId and i.IngredientId = ig.IngredientId and s.SupplierId = ig.SupplierId

--drop proc sp_ChiTietKhoHang
--exec sp_ChiTietKhoHang 1

--Store lợi nhuận từng chi nhánh theo tháng
go
create procedure sp_LoiNhuan_TatCaChiNhanhTheoThang
    @Month int,
    @Year int
as
begin
    select 
        b.BranchId,
        b.BranchName,
        sum(f.Revenue) as Revenue,
        sum(f.OperationCost) as OperationCost,
        sum(f.IngredientCost) as IngredientCost,
        sum(f.Revenue - f.OperationCost - f.IngredientCost) as Profit
    from FINANCIAL f
    inner join BRANCHES b on f.BranchId = b.BranchId
    where month(f.ReportDate) = @Month
      and year(f.ReportDate) = @Year
    group by b.BranchId, b.BranchName
end
--drop proc sp_LoiNhuan_TatCaChiNhanhTheoThang
--exec sp_LoiNhuan_TatCaChiNhanhTheoThang '05','2025'

--Store hàng tồn kho
go
create procedure sp_HangTonKho_TheoChiNhanh
    @BranchId int
as
begin
	select 
		b.BranchId,
		b.BranchName,
		i.IngredientName,
		inv.Quantity,
		inv.Unit,
		inv.RestockDate,
		inv.EXPDate
	from INVENTORY inv
	join INGREDIENT i on inv.IngredientId = i.IngredientId
	join BRANCHES b on inv.BranchId = b.BranchId
	where inv.Quantity > 0
	and inv.BranchId = @BranchId
end
--drop proc sp_HangTonKho_TheoChiNhanh
--exec sp_HangTonKho_TheoChiNhanh '1'

--Store In Hóa Đơn theo BillID
GO
CREATE PROCEDURE sp_InHoaDon_MaHoaDon
    @BillId INT
AS
BEGIN
    SELECT 
        B.BillId,
        C.CustomerName,
        T.TableName,
        B.CreateDate AS PrintDate,
        P.ProductName,
        BI.Quantity,
        P.Price,
        (BI.Quantity * P.Price) AS TotalItemPrice,
        B.TotalPrice,
        ISNULL(PR.Discount, 0) AS Discount,
        (B.TotalPrice * (1 - ISNULL(PR.Discount, 0))) AS FinalAmount
    FROM BILL B
    JOIN CUSTOMER C ON B.CustomerId = C.CustomerId
    JOIN TABLES T ON B.TableId = T.TableId
    JOIN BILLINFO BI ON B.BillId = BI.BillId
    JOIN PRODUCTS P ON BI.ProductId = P.ProductId
    LEFT JOIN PROMOTION_CUSTOMER PC ON PC.CustomerId = C.CustomerId
    LEFT JOIN PROMOTION PR ON PR.PromotionId = PC.PromotionId
    WHERE B.BillId = @BillId;
END;

--exec sp_InHoaDon_MaHoaDon 206

--Store thống kê số lượng khuyến mãi đang được sử dụng
go
CREATE proc sp_GetPromotionSummary
AS
BEGIN
    SELECT 
        p.PromotionName,
        p.Discount,
        p.StartDate,
        p.EndDate,
        COUNT(pc.CustomerId) AS SLKH
    FROM PROMOTION p
    JOIN PROMOTION_CUSTOMER pc ON p.PromotionId = pc.PromotionId
    GROUP BY 
        p.PromotionName, p.Discount, p.StartDate, p.EndDate
END

--exec sp_GetPromotionSummary

--Tạo proc xem nhân viên khi chọn chi nhánh
GO
CREATE PROCEDURE sp_NhanVienTheoChiNhanh
    @BranchId INT
AS
BEGIN
    SELECT 
        B.BranchName,
        E.EmployeeName,
        E.Role,
        E.TotalSalary
    FROM 
        BRANCHES B
    INNER JOIN 
        EMPLOYEE E ON B.BranchId = E.BranchId
    WHERE 
        B.BranchId = @BranchId
    ORDER BY 
        E.EmployeeName
END

--EXEC sp_NhanVienTheoChiNhanh @BranchId = 2; 
go
CREATE PROCEDURE sp_InHoaDon
    @BillId INT
AS
BEGIN
   SELECT 
    B.BillId,
    BR.BranchName AS TenChiNhanh,
    T.TableName AS TenBan,
    E.EmployeeName AS TenNhanVien,
    C.CustomerName AS TenKhach,
    B.CreateDate AS NgayIn,

    SUM(pr.Price * bi.Quantity) AS ThanhTien,
    B.TotalPrice AS TongTien,
    SUM(pr.Price * bi.Quantity) - B.TotalPrice AS TienKhuyenMai --lấy thành tiền trừ tổng tiền

	FROM BILL B
	INNER JOIN BRANCHES BR ON B.BranchId = BR.BranchId
	INNER JOIN TABLES T ON B.TableId = T.TableId
	INNER JOIN EMPLOYEE E ON B.EmployeeId = E.EmployeeId
	INNER JOIN CUSTOMER C ON B.CustomerId = C.CustomerId
	INNER JOIN BILLINFO bi ON bi.BillId = B.BillId
	INNER JOIN PRODUCTS pr ON pr.ProductId = bi.ProductId

	WHERE B.BillId = @BillId

	GROUP BY 
    B.BillId, BR.BranchName, T.TableName, E.EmployeeName, C.CustomerName,
    B.CreateDate, B.TotalPrice;
END

go
create proc sp_InChiTietHoaDon
	@BillId int
as
    select 
		b.BillId,
        P.ProductName,
        P.Price,
        BI.Quantity,
        P.Price * BI.Quantity as ThanhTienTungMon
    from BILLINFO BI
    inner join PRODUCTS P on BI.ProductId = P.ProductId
	inner join BILL b on b.BillId = bi.BillId
    where BI.BillId = @BillId;

--drop proc sp_InHoaDon
--exec sp_InHoaDon 219
--exec sp_InChiTietHoaDon 219

