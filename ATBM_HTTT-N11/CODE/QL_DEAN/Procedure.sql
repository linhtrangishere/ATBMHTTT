go
drop proc SP_DangKy_KH
Go
go
drop proc SP_DangKy_TX
go
drop proc SP_DangKy_DT
go

go
create proc SP_DangKy_KH @MaKhachHang varchar(10), @TenKhachHang nvarchar(50), @DienThoaiKhachHang varchar(10),
@EmailKhachHang varchar(50), @MaDiaChi varchar(10), @ThanhPho nvarchar(20), @Huyen nvarchar(20), @Xa nvarchar(20)
as
	if not exists(select * from DIACHI where MaDiaChi=@MaDiaChi and ThanhPho=@ThanhPho and Huyen=@Huyen and Xa=@Xa)
		insert into DIACHI values (@MaDiaChi, @ThanhPho, @Huyen, @Xa)

	if not exists(select * from KHACHHANG where MaKhachHang=@MaKhachHang)
	begin
		insert into KHACHHANG values (@MaKhachHang, @TenKhachHang, @DienThoaiKhachHang,
								@EmailKhachHang, @MaDiaChi)
		return 1
	end
	return 0


go
create proc SP_DangKy_TX @MaTaiXe varchar(10), @TenTaiXe nvarchar(50), @CMND varchar(12), @DienThoaiTaiXe varchar(10),
@EmailTaiXe varchar(50), @BIENSOXE varchar(20), @Diachinhataixe nvarchar(50),@STKNG varchar(20),@NganHang varchar(20),
@PhiTheChan int, @KVucHD varchar(10), @ThanhPho nvarchar(20), @Huyen nvarchar(20), @Xa nvarchar(20)
as
	if not exists(select * from DIACHI where MaDiaChi=@KVucHD and ThanhPho=@ThanhPho and Huyen=@Huyen and Xa=@Xa)
	begin
		insert into DIACHI values (@KVucHD, @ThanhPho, @Huyen, @Xa)
	end
	
	if not exists(select * from TAIXE where MaTaiXe=@MaTaiXe)
	begin
		insert into TAIXE values (@MaTaiXe, @TenTaiXe, @CMND, @DienThoaiTaiXe,
							@EmailTaiXe, @BIENSOXE, @Diachinhataixe,@STKNG,@NganHang ,
							@PhiTheChan, @KVucHD)
		return 1
	end
	return 0


go
create proc SP_DangKy_DT @MaDoiTac varchar(10), @NguoiDaiDien nvarchar(50),  @Email varchar(50),
@DienThoaiDoiTac varchar(10), @MaSoThue varchar(20), @SoLuongChiNhanh int,
@LoaiAmThuc nvarchar(20), @STKNganHang varchar(20), @NganHang varchar(20), @Diachikinhdoanh nvarchar(100), @TenDoiTac nvarchar(50)
as
	if not exists(select * from DOITAC where MaDoiTac=@MaDoiTac)
	begin
		insert into DOITAC values (@MaDoiTac, @NguoiDaiDien,  @Email,
							@DienThoaiDoiTac, @MaSoThue, @SoLuongChiNhanh,
							@LoaiAmThuc, @STKNganHang, @NganHang, @Diachikinhdoanh, @TenDoiTac)
		return 1
	end
	return 0

go
create proc SP_addOrder @MaPhieuDatHang varchar(10), @MaKhachHang varchar(10), @DiaChiGH varchar(10),
@ThanhPho nvarchar(20), @Huyen nvarchar(20), @Xa nvarchar(20), @HinhThucThanhToan nvarchar(20),
@TongHoaDon int, @PhiVanChuyen int
as
	if not exists(select * from DIACHI where MaDiaChi=@DiaChiGH and ThanhPho=@ThanhPho and Huyen=@Huyen and Xa=@Xa)
	begin
		insert into DIACHI values (@DiaChiGH, @ThanhPho, @Huyen, @Xa)
	end
	if exists (select * from PHIEUDATHANG where MaPhieuDatHang=@MaPhieuDatHang)
		return 1
	insert into PHIEUDATHANG values(@MaPhieuDatHang, @MaKhachHang, @DiaChiGH, @HinhThucThanhToan, N'Chờ xử lý', null,
									@TongHoaDon, @PhiVanChuyen, null, null, null)
return 0


--THONG KE SO LUONG DON HANG
go
drop PROCEDURE SP_orderStatistics
go

CREATE PROCEDURE SP_orderStatistics @MaDoiTac varchar(10)
AS
SELECT COUNT(PDH.MaPhieuDatHang) AS SoLuongDonHang, PDH.NgayGiaoHang
FROM PHIEUDATHANG PDH, CHINHANH CN
WHERE PDH.MaChiNhanh = CN.MaChiNhanh AND CN.MaDoiTac = @MaDoiTac
GROUP BY PDH.NgayGiaoHang
GO

EXEC SP_orderStatistics @MaDoiTac = 'DT64X02LAL'
GO

go
drop PROCEDURE SP_orderStatistics1
go

CREATE PROCEDURE SP_orderStatistics1 @MaDoiTac varchar(10)
AS
SELECT TOP 10 COUNT(PDH.MaPhieuDatHang) AS SoLuongDonHang, YEAR(PDH.NgayGiaoHang) as NgayGiaoHang
FROM PHIEUDATHANG PDH, CHINHANH CN
WHERE PDH.MaChiNhanh = CN.MaChiNhanh AND CN.MaDoiTac = @MaDoiTac
GROUP BY YEAR(PDH.NgayGiaoHang)
GO

EXEC SP_orderStatistics1 @MaDoiTac = 'DT64X02LAL'
GO

go
drop PROCEDURE SP_orderStatistics2
go

CREATE PROCEDURE SP_orderStatistics2 @MaDoiTac varchar(10)
AS
SELECT TOP 12 COUNT(PDH.MaPhieuDatHang) AS SoLuongDonHang, MONTH(PDH.NgayGiaoHang) as NgayGiaoHang
FROM PHIEUDATHANG PDH, CHINHANH CN
WHERE PDH.MaChiNhanh = CN.MaChiNhanh AND CN.MaDoiTac = @MaDoiTac
GROUP BY MONTH(PDH.NgayGiaoHang)
GO

EXEC SP_orderStatistics2 @MaDoiTac = 'DT64X02LAL'
GO

go
drop PROCEDURE SP_orderStatistics3
go

CREATE PROCEDURE SP_orderStatistics3 @MaDoiTac varchar(10)
AS
SELECT TOP 30 COUNT(PDH.MaPhieuDatHang) AS SoLuongDonHang, DAY(PDH.NgayGiaoHang) as NgayGiaoHang
FROM PHIEUDATHANG PDH, CHINHANH CN
WHERE PDH.MaChiNhanh = CN.MaChiNhanh AND CN.MaDoiTac = @MaDoiTac
GROUP BY DAY(PDH.NgayGiaoHang)
GO

EXEC SP_orderStatistics3 @MaDoiTac = 'DT64X02LAL'
GO

--THONG KE XU HUONG MON AN BAN RA
go
drop PROCEDURE SP_orderTrend_DESC
go

CREATE PROCEDURE SP_orderTrend_DESC @MaDoiTac varchar(10)
AS
SELECT SUM(CTPDH.SoLuongMonAn) AS SoLuong, MA.TenMonAn
FROM  PHIEUDATHANG PDH left join CHITIETPHIEUDATHANG CTPDH on CTPDH.MaPhieuDatHang = PDH.MaPhieuDatHang
					   right join CHINHANH CN on PDH.MaChiNhanh = CN.MaChiNhanh
					   left join MONAN MA on MA.MaMonAn=CTPDH.MaMonAn
WHERE CN.MaDoiTac = @MaDoiTac
GROUP BY CTPDH.MaMonAn, MA.TenMonAn
ORDER BY SoLuong DESC
GO
EXEC SP_orderTrend_DESC @MaDoiTac = 'DT001IYML4'
GO

go
drop PROCEDURE SP_orderTrend_ASC
go

CREATE PROCEDURE SP_orderTrend_ASC @MaDoiTac varchar(10)
AS
SELECT SUM(CTPDH.SoLuongMonAn) AS SoLuong, MA.TenMonAn
FROM  PHIEUDATHANG PDH left join CHITIETPHIEUDATHANG CTPDH on CTPDH.MaPhieuDatHang = PDH.MaPhieuDatHang
					   right join CHINHANH CN on PDH.MaChiNhanh = CN.MaChiNhanh
					   left join MONAN MA on MA.MaMonAn=CTPDH.MaMonAn
WHERE CN.MaDoiTac = @MaDoiTac
GROUP BY CTPDH.MaMonAn, MA.TenMonAn
ORDER BY SoLuong ASC
GO
EXEC SP_orderTrend_ASC @MaDoiTac = 'DT001IYML4'
GO

---------------------------------
go
drop PROCEDURE SP_Total_Revenue
go

CREATE PROCEDURE SP_Total_Revenue @MaDoiTac varchar(10)
AS
SELECT SUM(PDH.TongHoaDon) AS TongHoaDon, PDH.NgayGiaoHang
FROM  PHIEUDATHANG PDH left join CHINHANH CN on PDH.MaChiNhanh=CN.MaChiNhanh
WHERE CN.MaDoiTac = @MaDoiTac
GROUP BY PDH.NgayGiaoHang
GO
EXEC SP_Total_Revenue @MaDoiTac = 'DT001IYML4'
GO

go
drop PROCEDURE SP_Total_Revenue1
go

CREATE PROCEDURE SP_Total_Revenue1 @MaDoiTac varchar(10)
AS
SELECT Top 10 SUM(PDH.TongHoaDon) AS TongHoaDon, YEAR(PDH.NgayGiaoHang) as NgayGiaoHang
FROM  PHIEUDATHANG PDH left join CHINHANH CN on PDH.MaChiNhanh=CN.MaChiNhanh
WHERE CN.MaDoiTac = @MaDoiTac
GROUP BY YEAR(PDH.NgayGiaoHang)
GO
EXEC SP_Total_Revenue1 @MaDoiTac = 'DT001IYML4'
GO

go
drop PROCEDURE SP_Total_Revenue2
go

CREATE PROCEDURE SP_Total_Revenue2 @MaDoiTac varchar(10)
AS
SELECT top 12 SUM(PDH.TongHoaDon) AS TongHoaDon, MONTH(PDH.NgayGiaoHang) as NgayGiaoHang
FROM  PHIEUDATHANG PDH left join CHINHANH CN on PDH.MaChiNhanh=CN.MaChiNhanh
WHERE CN.MaDoiTac = @MaDoiTac
GROUP BY MONTH(PDH.NgayGiaoHang)
GO
EXEC SP_Total_Revenue2 @MaDoiTac = 'DT001IYML4'
GO

go
drop PROCEDURE SP_Total_Revenue3
go

CREATE PROCEDURE SP_Total_Revenue3 @MaDoiTac varchar(10)
AS
SELECT top 30 SUM(PDH.TongHoaDon) AS TongHoaDon, DAY(PDH.NgayGiaoHang) as NgayGiaoHang
FROM  PHIEUDATHANG PDH left join CHINHANH CN on PDH.MaChiNhanh=CN.MaChiNhanh
WHERE CN.MaDoiTac = @MaDoiTac
GROUP BY DAY(PDH.NgayGiaoHang)
GO
EXEC SP_Total_Revenue3 @MaDoiTac = 'DT001IYML4'
GO

select top 10 dt.MaDoiTac, dt.TenDoiTac, count (dh.MaKhachHang) as slkh,day(dh.NgayGiaoHang) as NgayGiaoHang
from PHIEUDATHANG dh
join CHINHANH cn on dh.MaChiNhanh=cn.MaChiNhanh
join DOITAC dt on cn.MaDoiTac=dt.MaDoiTac
group by dt.TenDoiTac, dt.MaDoiTac, day(dh.NgayGiaoHang)

-- Khach hang xem thuc don
create --alter
proc Xem_Thuc_Don @MaTD varchar(10)
as
	if not exists (select * from THUCDON where MaThucDon=@MaTD)
		begin
			print(N'Không tồn tại thực đơn')
			return 
		end
	declare @Tong int
	set @Tong = (select count(*) from MONAN where MaThucDon=@MaTD)
	select @Tong as Tong, MaMonAn, TenMonAn, Gia, TinhTrangMon from MONAN where MaThucDon=@MaTD

-- Doi tac them 1 mon an
create --alter
proc Add_mon_an @MaTD varchar(10), @MaMonAn varchar(10), @Ten nvarchar(80), @MieuTa nvarchar(100), @Gia int, @TinhTrang nvarchar(20)
as
	if not exists (select * from THUCDON where MaThucDon=@MaTD)
		begin
			print(N'Không tồn tại thực đơn')
			return 
		end
	if exists (select * from MONAN where MaMonAn=@MaMonAn)
		begin
			print(N'Đã tồn tại mã món ăn')
			return 
		end
	insert MONAN(MaMonAn, MaThucDon, TenMonAn, MieuTaMon, Gia, TinhTrangMon)
	values(@MaMonAn, @MaTD, @Ten, @MieuTa, @Gia, @TinhTrang)
GO

–Doi tac doi ten chi nhanh
CREATE  --ALTER
proc SP_UPDATE_TENCHINHANH  
@MaDoiTac varchar(10),  
@MaChiNhanh varchar(10),  
@TenChiNhanh nvarchar(20),  
@ThoiGianDoiTen date  
as  
begin  
if not exists(select * from CHINHANH where @MaDoiTac = MaDoiTac and @MaChiNhanh = MaChiNhanh)  
begin  
return 1  
end  
if datediff(day, (select ThoiGianDoiTen from CHINHANH where @MaDoiTac = MaDoiTac and @MaChiNhanh = MaChiNhanh), @ThoiGianDoiTen) < 31  
begin  
return 2  
end  
update CHINHANH  
set TenChiNhanh = @TenChiNhanh  
where @MaDoiTac = MaDoiTac and @MaChiNhanh = MaChiNhanh  
update CHINHANH  
set ThoiGianDoiTen = @ThoiGianDoiTen  
where @MaDoiTac = MaDoiTac and @MaChiNhanh = MaChiNhanh  
return 0  
end  
GO
– Doi tac cap nhat tinh trang cua hang
create --drop  
--alter  
proc SP_UPDATE_TINHTRANG  
@MaDoiTac varchar(10),  
@MaChiNhanh varchar(10),  
@TinhTrangChiNhanh nvarchar(20)  
as  
begin  
if not exists(select * from CHINHANH where @MaDoiTac = MaDoiTac and @MaChiNhanh = MaChiNhanh)  
begin  
return 1  
end  
update CHINHANH  
set TinhTrangChiNhanh = @TinhTrangChiNhanh  
where @MaDoiTac = MaDoiTac and @MaChiNhanh = MaChiNhanh  
return 0  
end  
GO
– Doi tac cap nhat thoi gian dong cua
CREATE  
proc SP_UPDATE_THOIGIANDONGCUA  
@MaDoiTac varchar(10),  
@MaChiNhanh varchar(10),  @ThoiGianDongCua varchar(50)  
as  
begin  
if not exists(select * from CHINHANH where @MaDoiTac = MaDoiTac and @MaChiNhanh = MaChiNhanh)  
begin  
return 1  
end  
DECLARE @TimeFormat AS time(7) = @ThoiGianDongCua  
update CHINHANH  
set ThoiGianDongCua = @TimeFormat  
where @MaDoiTac = MaDoiTac and @MaChiNhanh = MaChiNhanh  
return 0  
end
go
– Doi tac cap nhat thoi gian mo cua
CREATE  
proc SP_UPDATE_THOIGIANMOCUA  
@MaDoiTac varchar(10),  
@MaChiNhanh varchar(10),  
@ThoiGianMoCua varchar(50)  
as  
begin  
if not exists(select * from CHINHANH where @MaDoiTac = MaDoiTac and @MaChiNhanh = MaChiNhanh)  
begin  
return 1  
end  
DECLARE @TimeFormat AS time(7) = @ThoiGianMoCua  
update CHINHANH  
set ThoiGianMoCua = @TimeFormat  
where @MaDoiTac = MaDoiTac and @MaChiNhanh = MaChiNhanh  
return 0  
end  
GO
– Doi tac cap nhat gia mon an
CREATE 
--ALTER
PROC USP_ThayDoiGiaMonAn
	@MaMonAn VARCHAR(10),
	@GiaMonAn INT
AS
BEGIN 
	BEGIN TRY
	IF NOT EXISTS (SELECT * FROM MONAN WITH(XLOCK) WHERE MONAN.MaMonAn = @MaMonAn)
	BEGIN
	PRINT N'MÓN ĂN KHÔNG TỒN TẠI'
	RETURN 1
	END

	IF (@GiaMonAn <=0)
	BEGIN
	PRINT N'GIÁ MÓN ĂN PHẢI LỚN HƠN 0'
	RETURN 1
	END
	UPDATE MONAN
	SET Gia = @GiaMonAn 
	WHERE MaMonAn= @MaMonAn

	END TRY
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG'
		RETURN 1	
	END CATCH
RETURN 0
END
GO
– Ap dung ma khuyen mai cho mon an
CREATE 
--ALTER
PROC USP_ApDungKhuyenMai
	@MaMonAn VARCHAR(10),
	@PhanTramKhuyenMai INT
AS
BEGIN 

	BEGIN TRY
	IF NOT EXISTS (SELECT * FROM MONAN with (xlock) WHERE MONAN.MaMonAn = @MaMonAn)
		BEGIN
		PRINT N'MÓN ĂN KHÔNG TỒN TẠI'
		RETURN 1
		END
	IF (@PhanTramKhuyenMai <0 OR @PhanTramKhuyenMai > 100)
		BEGIN
		PRINT N'PHẦN TRĂM KHUYẾN MẠI KHÔNG HỢP LỆ'
		RETURN 1
		END
	DECLARE @temp int
	set @temp = (select Gia from MONAN where MaMonAn = @MaMonAn)
	UPDATE MONAN
	SET Gia = (@temp*(100-@PhanTramKhuyenMai)/100)
	WHERE MaMonAn= @MaMonAn

	END TRY
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG'
		RETURN 1	
	END CATCH
RETURN 0
END
GO
