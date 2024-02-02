Web uygulamasının düzgün bir veritabanı bağlantısı yapabilmesi için Startup.cs dosyasında 30. satırı kendi veritabanınıza uygun olacak şekilde düzenlemelisiniz. 30. satırda size uygun olan bağlantı cümlelerinin internet adresi verilmiştir. 




SQL Serverda veritabanı için yazılacak kodlar şu şekilde:





CREATE DATABASE SaglikProjesi;
GO

USE SaglikProjesi;
GO

CREATE TABLE Belirtis (
    BelirtiId INT PRIMARY KEY,
    Belirtiler NVARCHAR(MAX)
);

INSERT INTO Belirtis (BelirtiId, Belirtiler) VALUES
(1, 'Ateş'),
(2, 'Bacak Ağrısı'),
(3, 'Baş Ağrısı'),
(4, 'Baş Dönmesi'),
(5, 'Bilinç Kaybı'),
(6, 'Boğaz Ağrısı'),
(7, 'Boğaz Kaşıntısı'),
(8, 'Boğaz Şişliği'),
(9, 'Bulanık Görme'),
(10, 'Burun Akıntısı'),
(11, 'Burun Kanaması'),
(12, 'Burun Tıkanıklığı'),
(13, 'Deride Döküntü'),
(14, 'Deride Kanama'),
(15, 'Deride Kızarıklık'),
(16, 'Deride Şişme'),
(17, 'Diş Eti Kanaması'),
(18, 'Dışkıda Kan'),
(19, 'Dudakta Kaşıntı'),
(20, 'Düşük Tansiyon'),
(21, 'Düzensiz Kalp Atımı'),
(22, 'Göğüs Ağrısı'),
(23, 'Gözde Kaşıntı'),
(24, 'Gözde Kızarıklık'),
(25, 'Gözde Kuruma'),
(26, 'Gözde Sulanma'),
(27, 'His Kaybı'),
(28, 'Hızlı Kalp Atımı'),
(29, 'İdrarda Kan'),
(30, 'İdrarda Kötü Koku'),
(31, 'İshal'),
(32, 'Isı Artışı'),
(33, 'Işığa Hassasiyet'),
(34, 'İştahsızlık'),
(35, 'Kabızlık'),
(36, 'Kalp Çarpıntısı'),
(37, 'Karın Ağrısı'),
(38, 'Kas Ağrısı'),
(39, 'Kaşıntı'),
(40, 'Kilo Kaybı'),
(41, 'Kusma'),
(42, 'Makatta Tahriş ve Kan'),
(43, 'Mide Bulantısı'),
(44, 'Nefes Darlığı'),
(45, 'Öksürük'),
(46, 'Öksürük (Kanlı)'),
(47, 'Parmakta Şişlik veya Ağrı'),
(48, 'Sağırlık'),
(49, 'Ses Kısıklığı'),
(50, 'Sindirim Güçlüğü'),
(51, 'Sudan Korkma'),
(52, 'Terleme'),
(53, 'Titreme'),
(54, 'Üşüme'),
(55, 'Vajinal Kanama'),
(56, 'Yavaş Kalp Atımı'),
(57, 'Yorgunluk'),
(58, 'Yüksek Tansiyon');




