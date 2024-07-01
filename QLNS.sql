Create database QuanLyNhaSach

create table Khachhang
(
	KH_ID char(7) primary key not null,
	KH_Name nvarchar(30) not null,
	Ngaysinh date not null,
	Gioitinh nvarchar(3) not null,
	KH_Email nvarchar(30) not null,
	KH_phone nvarchar(10) not null
)
create table Nhanvien
(
	NV_ID char(7) primary key not null,
	NV_Name nvarchar(30) not null,
	Pass_Word nvarchar(100),
	Ngaysinh date not null,
	Gioitinh nvarchar(3) not null,
	Nhiemvu nvarchar(10) not null
)
create table Kho
(
	Sach_ID char(7) primary key not null,
	Soluong int not null
)

create table Theloai
(
	TL_Name nvarchar(30) primary key not null
)

create table NhaXB
(
	NXB_Name nvarchar(200) primary key not null
)

create table Sach
(
	Sach_ID char(7) primary key not null,
	Sach_Name nvarchar(100) not null,
	TG_ID char(7) not null,
	TL_Name nvarchar(30) not null,
	NXB_Name nvarchar(200),
	NamXB date,
	gia float,
	GiaNhap float
)

create table Tacgia
(
    TG_ID char(7) primary key not null,
	TG_Name nvarchar(40),
	Namsinh date,
	Quequan nvarchar(20)
)


create table CTHD
(
	HD_ID char(7) not null,
	Sach_ID char(7) not null,
	Soluong int not null,
	Thanhtien float not null
)
ALTER TABLE CTHD
ADD Thanhtien float;
create table Hoadon
(
	HD_ID char(7) primary key not null,
	KH_ID char(7) not null,
	NV_ID char(7) not null,
	Ngaylap date not null,
	Tongtien float not null 
)


create table CTPN
(
	PN_ID char(7) not null,
	Sach_ID char(7) not null,
	Soluong int not null,
	Giamua float not null,
	Thanhtien float not null
)
ALTER TABLE CTPN
DROP COLUMN Giamua;

create table Phieunhap
(
	PN_ID char(7) primary key not null,
	NV_ID char(7) not null,
	Ngaylap datetime not null,
	Tongtien float not null 
)


Select SUM(Tongtien) AS [Doanh Thu] From Hoadon
Select A.Sach_ID, B.Sach_Name, SUM(A.Soluong) AS [Số lượng bán ra], B.gia, C.Giamua From CTHD A
join Sach B on A.Sach_ID = B.Sach_ID
join CTPN C on A.Sach_ID = C.Sach_ID
Group By A.Sach_ID, B.Sach_Name, B.gia, C.Giamua


CREATE PROC USP_Login
@username char(7), @password nvarchar(100)
AS
BEGIN
	SELECT * FROM Nhanvien WHERE NV_ID = @username AND Pass_Word = @password
END
EXEC USP_Login @username = 'adm', @password = 'ad'


--quản lý sách
CREATE PROC pro_them_sach
@masach char(7), @tensach nvarchar(100), @matg char (7), @theloai nvarchar(30), @nhaxb nvarchar(200), @gia float, @gianhap float, @namxb date
AS
BEGIN 
	INSERT INTO Sach(Sach_ID,Sach_Name,TG_ID,TL_Name,NXB_Name,gia,GiaNhap,NamXB) VALUES (@masach, @tensach, @matg, @theloai, @nhaxb, @gia,@gianhap,@namxb)
END

EXEC pro_them_sach 
    @masach = 'STTG008', 
    @tensach = 'Mắt Biếc', 
    @matg = 'TG001', 
    @theloai = 'Tiểu thuyết',
    @nhaxb = 'NXB Trẻ', 
    @gia = 135000, 
    @gianhap = 55000, 
    @namxb = '2000-12-12';

DROP PROCEDURE pro_capnhap_sach

CREATE PROC pro_capnhap_sach
@masach char(7), @tensach nvarchar(100), @matg char (7), @theloai nvarchar(30), @nhaxb nvarchar(200), @gia float, @gianhap float, @namxb date
AS
BEGIN 
	UPDATE Sach
	SET Sach_Name = @tensach, TG_ID = @matg, TL_Name = @theloai, NXB_Name = @nhaxb, gia = @gia, GiaNhap = @gianhap, NamXB = @namxb
	WHERE Sach_ID = @masach
END
SELECT Sach_ID FROM Sach WHERE Sach_ID = 'SAVH005'

--Quản lý tác giả
CREATE PROC pro_them_tacgia
@matg char(7), @tentg nvarchar(40), @ngaysinh date, @quequan nvarchar(20)
AS
BEGIN 
	INSERT INTO Tacgia(TG_ID,TG_Name, Namsinh, Quequan) VALUES (@matg, @tentg, @ngaysinh, @quequan)
END

CREATE PROC pro_capnhap_tacgia
@matg char(7), @tentg nvarchar(40), @ngaysinh date, @quequan nvarchar(20)
AS
BEGIN 
	UPDATE Tacgia
	SET TG_Name = @tentg, Namsinh = @ngaysinh, Quequan = @quequan
	WHERE TG_ID = @matg
END


--Quản lý thể loại
CREATE PROC pro_them_theloai
@tentl nvarchar(30)
AS
BEGIN 
	INSERT INTO Theloai(TL_Name) VALUES (@tentl)
END


--Quản lý nhà xuất bản
CREATE PROC pro_them_nhaxb
@tennxb nvarchar(200)
AS
BEGIN 
	INSERT INTO NhaXB(NXB_Name) VALUES (@tennxb)
END


--Quản lý nhân viên
CREATE PROC pro_them_nhanvien
@manv char(7), @tennv nvarchar(30), @pass nvarchar(100), @ns date, @gt nvarchar(3), @nv nvarchar(10)
AS
BEGIN 
	INSERT INTO Nhanvien(NV_ID, NV_Name, Pass_Word, Ngaysinh, Gioitinh, Nhiemvu) VALUES (@manv, @tennv, @pass, @ns, @gt, @nv)
END


CREATE PROC pro_capnhap_nhanvien
@manv char(7), @tennv nvarchar(30), @pass nvarchar(100), @ns date, @gt nvarchar(3), @nv nvarchar(10)
AS
BEGIN 
	UPDATE Nhanvien
	SET NV_Name = @tennv, Pass_Word = @pass, Ngaysinh = @ns, Gioitinh = @gt, Nhiemvu = @nv
	WHERE NV_ID = @manv
END



--Quản lý khách hàng

CREATE PROC pro_them_khachhang
@makh char(7), @tenkh nvarchar(30), @ngaysinh date, @gioitinh nvarchar(3), @email nvarchar(30), @sdt nvarchar(10)
AS
BEGIN 
	INSERT INTO Khachhang(KH_ID, KH_Name, Ngaysinh, Gioitinh, KH_Email, KH_phone) VALUES (@makh, @tenkh, @ngaysinh, @gioitinh, @email, @sdt)
END


CREATE PROC pro_capnhap_khachhang
@makh char(7), @tenkh nvarchar(30), @ngaysinh date, @gioitinh nvarchar(3), @email nvarchar(30), @sdt nvarchar(10)
AS
BEGIN 
	UPDATE Khachhang
	SET KH_Name = @tenkh, Ngaysinh = @ngaysinh, Gioitinh = @gioitinh, KH_Email = @email, KH_phone = @sdt
	WHERE KH_ID = @makh
END

--Quản lý hóa đơn
CREATE PROC pro_capnhap_hoadon
@mahd char(7), @makh char(7), @manv char(7), @ngaylap date, @tongtien float
AS
BEGIN 
	UPDATE Hoadon
	SET KH_ID = @makh, NV_ID = @manv, Ngaylap = @ngaylap, Tongtien = @tongtien
	WHERE HD_ID = @mahd
END


CREATE PROC pro_them_hoadon
@mahd char(7), @makh char(7), @manv char(7), @ngaylap date, @tongtien float
AS
BEGIN 
	INSERT INTO Hoadon(HD_ID, KH_ID, NV_ID, Ngaylap, Tongtien) VALUES (@mahd, @makh, @manv, @ngaylap, @tongtien)
END


--Xem chi tiết hóa đơn
Select HD_ID as [Mã HD], A.Sach_ID as [Mã sách], Sach_Name as [Tên sách], Soluong as [Số lượng], 
Soluong*gia as [Tổng tiền] from CTHD A join Sach B on A.Sach_ID = B.Sach_ID 
where HD_ID = 'HD0121';


--Quản lý CTHD
CREATE PROC pro_them_cthd
@mahd char(7), @masach char(7), @soluong int, @thanhtien float
AS
BEGIN 
	INSERT INTO CTHD(HD_ID, Sach_ID, Soluong, Thanhtien) VALUES (@mahd, @masach, @soluong, @thanhtien)
END



CREATE PROC pro_capnhap_cthd
 @mahd char(7), @masach char(7), @soluong int
AS
BEGIN 
    UPDATE CTHD
    SET Soluong = @soluong,
        Thanhtien = @soluong * (SELECT gia FROM Sach WHERE Sach_ID = @masach)
    WHERE HD_ID = @mahd AND Sach_ID = @masach;
END


EXEC pro_capnhap_cthd @mahd = 'HD0121', @masach = 'SATH002', @soluong = '3'

--Quản lý phiêu nhập
CREATE PROC pro_them_phieunhap
@mapn char(7), @manv char(7), @ngaylap date, @tongtien float
AS
BEGIN 
	INSERT INTO Phieunhap(PN_ID, NV_ID, Ngaylap, Tongtien) VALUES (@mapn, @manv, @ngaylap, @tongtien)
END


CREATE PROC pro_capnhap_phieunhap
@mapn char(7), @manv char(7), @ngaylap date, @tongtien float
AS
BEGIN 
	UPDATE Phieunhap
	SET NV_ID = @manv, Ngaylap = @ngaylap, Tongtien = @tongtien
	WHERE PN_ID = @mapn
END


--Chi tiết phiêu nhập
CREATE PROC pro_them_ctpn
@mapn char(7), @masach char(7), @soluong int, @thanhtien float
AS
BEGIN 
	INSERT INTO CTPN(PN_ID, Sach_ID, Soluong, Thanhtien) VALUES (@mapn, @masach, @soluong, @thanhtien)
END


CREATE PROC pro_capnhap_ctpn
 @mapn char(7), @masach char(7), @soluong int
AS
BEGIN 
    UPDATE CTPN
    SET Soluong = @soluong,
        Thanhtien = @soluong * (SELECT gia FROM Sach WHERE Sach_ID = @masach)
    WHERE PN_ID = @mapn AND Sach_ID = @masach;
END
EXEC pro_them_ctpn @mapn = 'PN003', @masach = 'SAVH003', @soluong = '150',@thanhtien = '6450000'



--Cập nhập kho
CREATE PROC pro_capnhap_kho
@masach char(7), @soluong int
AS
BEGIN 
    UPDATE Kho
    SET Soluong = @soluong
    WHERE Sach_ID = @masach;
END










Select HD_ID as [Mã HD], A.Sach_ID as [Mã sách], Sach_Name as [Tên sách], Soluong as [Số lượng], Soluong*gia as [Tổng tiền] from CTHD A join Sach B on A.Sach_ID = B.Sach_ID ;
select Sach_ID as [Mã sách], Sach_Name as [Tên sách], gia as [Giá bán] from Sach
Select HD_ID as [Mã HD], KH_ID as [Mã KH], NV_ID as [Mã NV], Ngaylap as [Ngày lập], Tongtien as [Tổng tiền] from Hoadon ;

Select C.KH_Name  from CTHD A join Hoadon B on B.HD_ID = A.HD_ID join Khachhang C on C.KH_ID = B.KH_ID where B.HD_ID = ''

Select HD_ID as [Mã HD], A.Sach_ID as [Mã sách], Sach_Name as [Tên sách], Soluong as [Số lượng], Thanhtien as [Tổng tiền] from CTHD A join Sach B on A.Sach_ID = B.Sach_ID
where HD_ID = 'HD0121' and Thanhtien = Soluong*B.gia

Select A.Sach_ID as [Mã sách], B.Sach_Name as [Tên sách], A.Soluong as [Số lượng tồn] from Kho A join Sach B on A.Sach_ID = B.Sach_ID

SELECT Ngaylap FROM Phieunhap where PN_ID = 'PN001'

SELECT * FROM Hoadon where HD_ID = 'HD007'
EXEC pro_capnhap_hoadon @mahd = 'HD007', @makh = 'KH001', @manv = 'NVBH002', @ngaylap = '2024-05-14', @tongtien = '381000'

Select A.Sach_ID as [Mã sách], Sach_Name as [Tên sách], Soluong as [Số lượng], Soluong * B.gia as [Tổng tiền] from CTHD A join Sach B on A.Sach_ID = B.Sach_ID where HD_ID =  'HD007'

SELECT KH_ID FROM Hoadon where HD_ID = 'HD007'
--Thêm khóa ngoại
alter table CTHD add constraint FK_CTHD_Hoadon foreign key(HD_ID) references HOADON(HD_ID)
alter table CTHD add constraint FK_CTHD_Sach foreign key(Sach_ID) references Sach(Sach_ID)
alter table CTPN add constraint FK_CTPN_Phieunhap foreign key(PN_ID) references Phieunhap(PN_ID)
alter table CTPN add constraint FK_CTPN_Sach foreign key(Sach_ID) references Sach(Sach_ID)
alter table Phieunhap add constraint FK_Phieunhap_Nhanvien foreign key(NV_ID) references Nhanvien(NV_ID)
alter table Hoadon add constraint FK_Hoadon_Khachhang foreign key(KH_ID) references Khachhang(KH_ID)
alter table Hoadon add constraint FK_Hoadon_Nhanvien foreign key(NV_ID) references Nhanvien(NV_ID)
alter table Kho add constraint FK_Kho_Sach foreign key(Sach_ID) references Sach(Sach_ID)
alter table Sach add constraint FK_Sach_Theloai foreign key(TL_Name) references Theloai(TL_Name)
alter table Sach add constraint FK_Sach_Tacgia foreign key(TG_ID) references Tacgia(TG_ID)
ALTER TABLE Sach ADD CONSTRAINT FK_Sach_NhaXuatBan FOREIGN KEY(NXB_Name) REFERENCES NhaXB(NXB_Name);


select * from Phieunhap where PN_ID = ''


SELECT s.Sach_ID as [Mã sách], s.Sach_Name as [Tên sách], SUM(cthd.Soluong) AS [Số lượng], SUM(cthd.Soluong * s.gia) AS [Tổng tiền]
            FROM Hoadon hd
            JOIN CTHD cthd ON hd.HD_ID = cthd.HD_ID
            JOIN Sach s ON cthd.Sach_ID = s.Sach_ID
            WHERE hd.NgayLap BETWEEN '5/1/2024' AND '5/5/2024'
            GROUP BY s.Sach_ID, s.Sach_Name


--In báo cáo
Create proc pro_In_BaoCao
@start date, @end date
as
	begin
		Select Sach.Sach_ID, Sach.Sach_Name, SUM(CTHD.Soluong) as [Soluong], SUM(CTHD.Soluong * Sach.gia) AS [Tongtien]
		from Hoadon, CTHD, Sach
		where Hoadon.Ngaylap BETWEEN @start And @end and CTHD.Sach_ID = Sach.Sach_ID and Hoadon.HD_ID = CTHD.HD_ID 
		group by Sach.Sach_ID, Sach.Sach_Name
	end

--CREATE PROC pro_In_baocao
--    @start DATE, 
--    @end DATE
--AS
--BEGIN
   
--    SELECT 
--        Sach.Sach_ID, 
--        Sach.Sach_Name, 
--        SUM(CTHD.Soluong) AS [Soluong], 
--        SUM(CTHD.Soluong * Sach.gia) AS [Tongtien],
--        @start AS [StartDate],
--        @end AS [EndDate]
--    INTO #TempResult
--    FROM 
--        Hoadon
--        JOIN CTHD ON Hoadon.HD_ID = CTHD.HD_ID
--        JOIN Sach ON CTHD.Sach_ID = Sach.Sach_ID
--    WHERE 
--        Hoadon.Ngaylap BETWEEN @start AND @end
--    GROUP BY 
--        Sach.Sach_ID, 
--        Sach.Sach_Name;
    
--    SELECT 
--        SUM(Soluong) AS [TotalSoluong], 
--        SUM(Tongtien) AS [TotalTongtien]
--    FROM 
--        #TempResult;

--    SELECT * FROM #TempResult;

--    DROP TABLE #TempResult;
--END

EXEC pro_In_baocao @start = '5/13/2024', @end = '5/15/2024'
Drop procedure pro_InBaoCao


--In hóa đơn
Create proc pro_In_cthd
@mahd char(7)
as
	begin
		declare @tong float;
		set @tong = 0;

		Select @tong = Sum(CTHD.Soluong * Sach.gia)
		from CTHD, Sach
		where HD_ID = @mahd and Sach.Sach_ID = CTHD.Sach_ID

		Select @mahd as HD_ID, CTHD.Sach_ID, Sach.Sach_Name, 
		CTHD.Soluong, Sach.gia, CTHD.Thanhtien, Hoadon.Ngaylap, Khachhang.KH_Name, Nhanvien.NV_Name, Hoadon.Tongtien

		from CTHD, Sach, Hoadon, Khachhang, Nhanvien
		where CTHD.Sach_ID = Sach.Sach_ID and CTHD.HD_ID = @mahd and Hoadon.HD_ID = CTHD.HD_ID and Hoadon.KH_ID = Khachhang.KH_ID and Hoadon.NV_ID = Nhanvien.NV_ID
	end

drop procedure pro_In_cthd
exec pro_In_cthd @mahd = 'HD001'








