-- En esta consulta se muestra el ultimo dia del mes de la fecha de ingreso de cada vendedor. 
-- Utilizamos esta funcion para mostrar el ultimo dia del mes de la fecha insertada como parametro.
SELECT 
	EOMONTH(ingreso) as 'Ultimo dia del mes de ingreso',
	vendedor,
	nombre
FROM
	vendedores
ORDER BY
	2

-- En esta consulta se muestran las fechas de las facturas emitidas por los vendedores, con 1 año de diferencia.
-- Utilizamos esta funcion para mostrar las fechas de las facturas sumandoles 1 año.
SELECT 
	DATEADD(year,1,fecha) as 'Fecha',
	vendedor,
	dni,
	neto,
	total
FROM
	vencab

-- En esta consulta se muestra la diferencia de años que hay entre el ingreso de un vendedor hasta el año actual.
-- Utilizamos esta funcion para mostrar la diferencia en años que hay entre el ingreso de un vendedor hasta el 2021.
SELECT
	DATEDIFF(year,ingreso,getdate()) as 'Diferencia',
	vendedor,
	nombre
FROM
	vendedores

-- En esta consulta se muestran en una columna las primeras tres letras del nombre del vendedor.
-- Utilizamos esta consulta para mostrar en una columna llamada 'Primeras tres letras' las primeras tres letras de la tabla nombre.
SELECT 
	vendedor,
	nombre,
	LEFT(nombre, 3) as 'Primeras tres letras'
FROM
	vendedores
ORDER BY
	nombre

-- En esta consulta se muestran las fechas y horarios en el que se emitieron las facturas.
-- Utilizamos esta consulta para mostrar el horario exacto en el que se emite una factura.
SELECT
	DATETIMEFROMPARTS(YEAR(fechahora), MONTH(fechahora), DAY(fechahora), DATEPART(hh, fechahora),
	DATEPART(mi, fechahora),DATEPART(ss, fechahora),DATEPART(ms, fechahora)) as 'Fecha y hora',
	vendedor,
	letra,
	factura
FROM
	vencab
ORDER BY
	2

