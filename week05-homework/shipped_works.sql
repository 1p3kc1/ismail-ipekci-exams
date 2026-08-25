--1
SELECT 
	*
FROM Customer;

--2
SELECT 
	c.CompanyName AS FirmaAdı,
	c.City AS Sehir,
	c.ContractType AS SozlesmeTipi
FROM Customer c;

--3 
SELECT
	v.Plate AS Plaka,
	v.VehicleType AS AracTipi,
	v.CapacityTon AS TonaJKapasitesi
FROM Vehicle v;

--4
SELECT 
	d.FirstName || '' ||  Lastname AS AdSoyad,
	d.LicenseClass AS EhliyetSinifi
FROM Driver d;

--5
SELECT 
	COUNT(*) AS SevkiyatSayisi
FROM Shipment s;

--6
SELECT DISTINCT
    s.DestCity AS VarisSehri
FROM Shipment s
ORDER BY DestCity ASC;

--7
SELECT DISTINCT
v.VehicleType AS AracTipi
FROM vehicle v;

--8
SELECT
c.CompanyName AS FirmaAdi,
c.City AS Sehir,
c.ContractType AS SozlesmeTipi
FROM Customer c
WHERE IsActive= 1 ;

--9
SELECT
c.CompanyName AS FirmaAdi,
c.City AS Sehir
FROM Customer c
WHERE IsActive=0;

--10
SELECT 
s.ShipmentId AS SevkiyatId,
s.OriginCity AS CikisSehri,
s.DestCity AS VarisSehri,
s.Freight AS Navlun
FROM Shipment s 
WHERE Freight> 20000
ORDER BY Freight DESC;

--11
SELECT
    ShipmentId AS SevkiyatId,
    OriginCity AS CikisSehri,
    DestCity AS VarisSehri,
    Freight AS Navlun
FROM Shipment
WHERE Freight >= 21000
ORDER BY Freight DESC;

--12
SELECT
s.OriginCity AS CikisSehri,
s.DestCity AS VarisSehri,
s.DistanceKm AS Mesafe,
s.Freight AS Navlun
FROM Shipment s
WHERE DistanceKm <200;

--13
SELECT
s.OriginCity AS CikisSehri,
s.DestCity AS VarisSehri,
s.DistanceKm AS Mesafe,
s.Freight AS Navlun 
FROM Shipment s
WHERE DistanceKm <=155;

--14
SELECT 
s.ShipmentId AS SevkiyatId,
s.OriginCity AS CikisSehri,
s.DestCity AS VarisSehri,
s.Freight AS Navlun
FROM Shipment s
WHERE Freight BETWEEN 10000 AND 20000
ORDER BY Freight ;

--15
SELECT 
s.ShipmentId AS SevkiyatId,
s.OriginCity AS CikisSehri,
s.DestCity AS VarisSehri,
s.ShipDate AS SevkTarihi,
s.Freight AS Navlun 
FROM Shipment s
WHERE Status = 'Yolda';

--16
SELECT 
s.ShipmentId AS SevkiyatId,
s.OriginCity AS CikisSehri,
s.DestCity AS VarisSehri,
s.Status AS Durum
FROM Shipment s 
WHERE Status = 'Teslim'
ORDER BY Shipdate DESC;

--17
SELECT
c.CompanyName AS FirmaAdi,
c.Email AS Eposta 
FROM Customer c 
WHERE ContractType='Spot';

--18
SELECT 
v.Plate AS Plaka,
v.CapacityTon AS Kapasite
FROM Vehicle v 
WHERE VehicleType='Tir';

--19
SELECT
d.FirstName AS Ad,
d.LastName AS Soyad, 
d.HireDate AS IseGirisTarihi,
d.Phone AS Telefon
FROM Driver d 
WHERE LicenseClass='CE';

--20
SELECT 
c.CompanyName AS FirmaAdi,
c.City AS Sehir,
c.ContractType AS SozlesmeTipi
FROM Customer c
WHERE CompanyName LIKE '%Gida%';

--21
SELECT 
v.Plate AS Plaka,
v.VehicleType AS AracTipi
FROM Vehicle v
WHERE Plate LIKE '34%';

--22
SELECT 
s.OriginCity AS CikisSehri,
s.DestCity AS VarisSehri,
s.Status AS Durum
FROM Shipment s
WHERE DestCity LIKE '%an%';

--23 
SELECT 
d.FirstName AS Ad,
d.Lastname AS Soyad,
d.Phone AS Telefon
FROM Driver d
WHERE LastName LIKE '%Demir%';

--24
SELECT
s.ShipmentId,
s.OriginCity,
s.Destcity,
s.Shipdate,
s.Status
FROM Shipment s 
WHERE Status IN ('Yolda','Planlandi');

--25 
SELECT 
s.ShipmentId,
s.OriginCity,
s.DestCity,
s.Freight,
s.Status
FROM Shipment s
WHERE OriginCity IN ('Izmir','Istanbul')
ORDER BY Freight DESC

--26 
SELECT 
s.ShipmentId,
s.OriginCity,
s.DestCity,
s.Status,
s.Freight,
s.ShipDate
FROM Shipment s
WHERE Status NOT IN ('Iptal')
ORDER BY ShipDate;

--27
SELECT
v.Plate,
v.VehicleType,
v.CapacityTon
FROM Vehicle v
WHERE VehicleType <>('Tir');

--28
SELECT 
c.CompanyName,
c.City
FROM Customer c
WHERE Email IS NULL;

--29
SELECT 
d.FirstName ,
d.LastName ,
d.LicenseClass
FROM Driver d
WHERE Phone IS NULL;

--30
SELECT 
s.ShipmentId,
s.OriginCity,
s.DestCity,
S.Shipdate,
s.Status
FROM Shipment s 
WHERE DeliverDate IS NULL;

--31
SELECT
    s.ShipmentId AS SevkiyatId,
    s.OriginCity AS CikisSehri,
    s.DestCity AS VarisSehri,
    s.ShipDate AS SevkTarihi,
    s.DeliverDate AS TeslimTarihi,
    s.Status AS Durum
FROM Shipment s
WHERE DeliverDate IS NOT NULL
ORDER BY DeliverDate DESC;

--32
SELECT
    s.ShipmentId AS SevkiyatId,
    s.ShipDate AS SevkTarihi,
    s.OriginCity AS CikisSehri,
    s.DestCity AS VarisSehri,
    s.Status AS Durum
FROM Shipment s
WHERE strftime('%Y', ShipDate) = '2026'
ORDER BY ShipDate ASC;

--33 
SELECT
    s.ShipmentId AS SevkiyatId,
    s.ShipDate AS SevkTarihi,
    s.OriginCity AS CikisSehri,
    s.DestCity AS VarisSehri,
    s.Status AS Durum
FROM Shipment s
WHERE strftime('%m', ShipDate) = '08'
ORDER BY ShipDate ASC;

--34
SELECT
    s.ShipmentId AS SevkiyatId,
    s.ShipDate AS SevkTarihi,
    s.OriginCity AS CikisSehri,
    s.DestCity AS VarisSehri,
    s.Status AS Durum
FROM Shipment s
WHERE ShipDate BETWEEN '2025-01-01' AND '2025-06-30'
ORDER BY ShipDate ASC;

--35
SELECT
    s.ShipmentId AS SevkiyatId,
    s.OriginCity AS CikisSehri,
    s.DestCity AS VarisSehri,
    s.Freight AS Navlun,
    s.Status AS Durum
FROM Shipment s
ORDER BY Freight DESC;

--36
SELECT
    d.FirstName AS Ad,
    d.LastName AS Soyad,
    d.LicenseClass AS EhliyetSinifi,
    d.Phone AS Telefon
FROM Driver d
ORDER BY LastName ASC, FirstName ASC;

--37
SELECT 
c.CompanyName,
COUNT(s.ShipmentId) AS SevkiyatSayisi
FROM Customer c
		JOIN Shipment s ON c.CustomerId=s.CustomerId
GROUP BY c.CustomerId,c.CompanyName
ORDER BY SevkiyatSayisi DESC;

--38 
SELECT
Status AS Durum,
COUNT(*) AS Adet
FROM Shipment s
GROUP BY Status
ORDER BY Adet DESC;

--39
SELECT
    v.VehicleType AS AracTipi,
    COUNT(*) AS AracSayisi
FROM Vehicle v
GROUP BY VehicleType 
ORDER BY AracSayisi DESC;

--40
SELECT
    c.CompanyName AS FirmaAdi,
    COUNT(s.ShipmentId) AS SevkiyatSayisi,
    AVG(s.Freight) AS OrtalamaNavlun
FROM Customer c
JOIN Shipment s
    ON c.CustomerId = s.CustomerId
GROUP BY c.CustomerId, c.CompanyName
HAVING AVG(s.Freight) > 15000
ORDER BY OrtalamaNavlun DESC;

--41
SELECT
    d.FirstName || ' ' || d.LastName AS AdSoyad,
    COUNT(s.ShipmentId) AS SevkiyatSayisi
FROM Driver d
JOIN Shipment s
    ON d.DriverId = s.DriverId
GROUP BY d.DriverId, d.FirstName, d.LastName
HAVING COUNT(s.ShipmentId) >= 4
ORDER BY SevkiyatSayisi DESC;

--42
SELECT
    s.ShipmentId AS SevkiyatId,
    c.CompanyName AS FirmaAdi,
    s.OriginCity AS CikisSehri,
    s.DestCity AS VarisSehri,
    s.Freight AS Navlun,
    s.Status AS Durum
FROM Shipment s
INNER JOIN Customer c
    ON s.CustomerId = c.CustomerId
ORDER BY s.ShipDate ASC;

--43
SELECT
    s.ShipmentId AS SevkiyatId,
    d.FirstName || ' ' || d.LastName AS AdSoyad,
    v.Plate AS Plaka,
    v.VehicleType AS AracTipi,
    s.OriginCity AS CikisSehri,
    s.DestCity AS VarisSehri,
    s.Status AS Durum
FROM Shipment s
INNER JOIN Driver d
    ON s.DriverId = d.DriverId
INNER JOIN Vehicle v
    ON s.VehicleId = v.VehicleId;
--44
SELECT
    s.ShipDate AS SevkTarihi,
    c.CompanyName AS FirmaAdi,
    d.FirstName || ' ' || d.LastName AS AdSoyad,
    v.Plate AS Plaka,
    s.OriginCity AS CikisSehri,
    s.DestCity AS VarisSehri,
    s.Freight AS Navlun,
    s.Status AS Durum
FROM Shipment s
INNER JOIN Customer c
    ON s.CustomerId = c.CustomerId
INNER JOIN Driver d
    ON s.DriverId = d.DriverId
INNER JOIN Vehicle v
    ON s.VehicleId = v.VehicleId
ORDER BY s.ShipDate DESC;
--45
SELECT
    c.CompanyName AS FirmaAdi,
    v.Plate AS Plaka,
    s.OriginCity AS CikisSehri,
    s.DestCity AS VarisSehri,
    s.Freight AS Navlun
FROM Shipment s
INNER JOIN Customer c
    ON s.CustomerId = c.CustomerId
INNER JOIN Vehicle v
    ON s.VehicleId = v.VehicleId
WHERE v.VehicleType = 'Tir'
  AND s.Status = 'Teslim'
ORDER BY s.Freight DESC;

--46
SELECT
    c.CompanyName AS FirmaAdi,
    c.City AS Sehir
FROM Customer c
LEFT JOIN Shipment s
    ON c.CustomerId = s.CustomerId
    AND s.Status = 'Yolda'
WHERE s.ShipmentId IS NULL;
  
--47
SELECT
    ShipmentId AS SevkiyatId,
    OriginCity AS CikisSehri,
    DestCity AS VarisSehri,
    Freight AS Navlun,
    CASE
        WHEN Freight < 10000 THEN 'Dusuk'
        WHEN Freight <= 20000 THEN 'Orta'
        WHEN Freight > 20000 THEN 'Yuksek'
    END AS NavlunDilimi
FROM Shipment
ORDER BY Freight ASC;

--48
SELECT
    ShipmentId AS SevkiyatId,
    OriginCity AS CikisSehri,
    DestCity AS VarisSehri,
    Freight AS Navlun,
    CASE
        WHEN Freight < 10000 THEN 'Dusuk'
        WHEN Freight <= 20000 THEN 'Orta'
        WHEN Freight > 20000 THEN 'Yuksek'
    END AS NavlunDilimi
FROM Shipment
ORDER BY Freight ASC;

--49
SELECT
    s.ShipDate AS SevkTarihi,
    c.CompanyName AS FirmaAdi,
    s.OriginCity AS CikisSehri,
    s.DestCity AS VarisSehri,
    s.Freight AS Navlun,
    s.Status AS Durum,
    CASE
        WHEN s.Status = 'Planlandi' THEN 'Bekliyor'
        WHEN s.Status = 'Yolda' THEN 'Sahada'
        WHEN s.Status = 'Teslim' THEN 'Kapandi'
        ELSE 'Iptal/Diger'
    END AS Kuyruk
FROM Shipment s
INNER JOIN Customer c
    ON s.CustomerId = c.CustomerId
WHERE s.OriginCity IN ('Izmir', 'Istanbul', 'Bursa')
ORDER BY Kuyruk ASC, s.ShipDate ASC;

--50
SELECT
    d.FirstName || ' ' || d.LastName AS AdSoyad,
    'Aktif Sofer' AS Tip
FROM Driver d
WHERE d.IsActive = 1

UNION

SELECT
    d.FirstName || ' ' || d.LastName AS AdSoyad,
    'Yoldaki Sefer' AS Tip
FROM Driver d
INNER JOIN Shipment s
    ON d.DriverId = s.DriverId
WHERE s.Status = 'Yolda'

ORDER BY Tip ASC, AdSoyad ASC;






