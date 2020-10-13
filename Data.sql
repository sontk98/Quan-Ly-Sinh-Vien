use master
go

create database QuanLyHoSoSinhVien
go

use QuanLyHoSoSinhVien
go

create table Khoa
(
	MaKhoa char(10) primary key,
	TenKhoa nvarchar(100) not null,
)
go

create table Nganh
(
	MaNganh char(10) primary key,
	TenNganh nvarchar(100) not null,
	MaKhoa char(10) not null,
	FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
)
go

create table Lop
(
	MaLop char(10) primary key,
	TenLop nvarchar(100) not null,
	MaNganh char(10) not null,
	HeDaoTao nvarchar(25) not null,
	SiSo int not null default 0,
	FOREIGN KEY (MaNganh) REFERENCES Nganh(MaNganh)
)
go

create table DoiTuong
(
	MaDT char(10) primary key,
	TenDT nvarchar(100) not null,
)
go

create table SinhVien
(
	MaSV char(10) primary key,
	Ho nvarchar(100) not null,
	Ten nvarchar(50) not null,
	NgaySinh date not null,
	NoiSinh nvarchar(50) not null,
	GioiTinh nvarchar(10) not null,
	DanToc nvarchar(10) not null,
	MaLop char(10) not null,
	MaDT char(10) not null,
	NgayVaoTruong date not null,
	TrangThai nvarchar(50) not null,
	CMND int,
	SDT int,
	Email nvarchar(50),
	DiaChi nvarchar(100),
	TenBo nvarchar(150),
	NgheBo nvarchar(50),
	SDTBo int,
	TenMe nvarchar(150),
	NgheMe nvarchar(50),
	SDTMe int,
	FOREIGN KEY (MaLop) REFERENCES Lop(MaLop),
	FOREIGN KEY (MaDT) REFERENCES DoiTuong(MaDT)
)
go

create table Account
(
	Username char(50) primary key,
	PassWord char(50),
	TenNguoiDung nvarchar(100),
	Type int default 0
)
go


--Thêm Khoa
insert into Khoa(MaKhoa,TenKhoa)
values ('CN',N'Công Nghệ Thông Tin');
insert into Khoa(MaKhoa,TenKhoa)
values ('KT',N'Kinh Tế');

--Thêm Ngành
insert into Nganh(MaNganh,TenNganh,MaKhoa)
values('1101',N'Công Nghệ Thông Tin','CN');
insert into Nganh(MaNganh,TenNganh,MaKhoa)
values('1102',N'Truyền Thông Và Mạng Máy Tính','CN');
insert into Nganh(MaNganh,TenNganh,MaKhoa)
values('1103',N'Quản Lý Chất Lượng','KT');

--Thêm Lớp
insert into Lop(MaLop,TenLop,MaNganh,HeDaoTao)
values('CN16B',N'Công Nghệ Thông Tin','1101',N'Đại Học Chính Quy');
insert into Lop(MaLop,TenLop,MaNganh,HeDaoTao)
values('CN16A',N'Công Nghệ Thông Tin','1101',N'Đại Học Chính Quy');
insert into Lop(MaLop,TenLop,MaNganh,HeDaoTao)
values('KM16',N'Truyền Thông Và Mạng Máy Tính','1102',N'Đại Học Chính Quy');
insert into Lop(MaLop,TenLop,MaNganh,HeDaoTao)
values('CN16CD',N'Công Nghệ Thông Tin','1101',N'Cao Đẳng Chính Quy');

--Thêm Đối Tượng
insert into DoiTuong(MaDT,TenDT)
values('KV01',N'Khu Vực 1');
insert into DoiTuong(MaDT,TenDT)
values('KV02',N'Khu Vực 2');
insert into DoiTuong(MaDT,TenDT)
values('KV03',N'Khu Vực 3');
insert into DoiTuong(MaDT,TenDT)
values('TB01',N'Người thân phục vụ trong QĐND,CAND');

--Thêm Sinh Viên
insert into SinhVien(MaSV,Ho,Ten,NgaySinh,NoiSinh,GioiTinh,DanToc,MaLop,MaDT,NgayVaoTruong,TrangThai)
values('1000001',N'Ngô Quốc',N'Bình','1998-01-01','Phú Yên',N'Nam',N'Kinh','CN16B','KV02','2016-08-29',N'Đang học');
insert into SinhVien(MaSV,Ho,Ten,NgaySinh,NoiSinh,GioiTinh,DanToc,MaLop,MaDT,NgayVaoTruong,TrangThai)
values('1000002',N'Nguyễn Văn',N'Bình','1998-09-01','Khánh Hòa',N'Nam',N'Kinh','CN16A','KV03','2016-08-30',N'Đang học');
insert into SinhVien(MaSV,Ho,Ten,NgaySinh,NoiSinh,GioiTinh,DanToc,MaLop,MaDT,NgayVaoTruong,TrangThai)
values('1000003',N'Lê',N'Bình','1997-11-01','Hưng Yên',N'Nam',N'Kinh','KM16','KV01','2016-08-29',N'Đang học');
insert into SinhVien(MaSV,Ho,Ten,NgaySinh,NoiSinh,GioiTinh,DanToc,MaLop,MaDT,NgayVaoTruong,TrangThai)
values('1000004',N'Ung Văn',N'Dĩ','1998-02-03','Phú Yên',N'Nam',N'Kinh','CN16B','KV02','2016-08-29',N'Đang học');
insert into SinhVien(MaSV,Ho,Ten,NgaySinh,NoiSinh,GioiTinh,DanToc,MaLop,MaDT,NgayVaoTruong,TrangThai)
values('1000005',N'Nguyễn Thành',N'Tâm','1998-10-09','Phú Yên',N'Nam',N'Kinh','CN16CD','KV02','2016-08-29',N'Đang học');

