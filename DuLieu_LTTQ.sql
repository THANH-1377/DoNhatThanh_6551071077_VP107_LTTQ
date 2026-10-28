CREATE DATABASE DuLieu;
GO

USE DuLieu;
GO

CREATE TABLE MonHoc(
	MaMonHoc NVARCHAR(10) PRIMARY KEY,
	TenMonHoc nText NOT NULL,
	SoTinChi NVARCHAR(5) NOT NULL
);

INSERT INTO MonHoc(MaMonHoc, TenMonHoc, SoTinChi)
VALUES
(N'MH001', N'Lập trình C# cơ bản', '3'),
(N'MH002', N'Cơ sở dữ liệu', '4'),
(N'MH003', N'Phân tích thiết kế hệ thống', '3'),
(N'MH004', N'Mạng máy tính', '3'),
(N'MH005', N'Trí tuệ nhân tạo cơ bản', '3');

SELECT * FROM MonHoc;
