/*

TEMAS:

- OPERADORES LOGICOS (AND, OR, NOT) ok
- OPERADOR IS NULL ok
- SUBCONSULTA ok
- COLUMNAS CALCULADAS ok
- ORDER BY ok

*/


-- SUBCONSULTA

SELECT
	marca
FROM
	marcas
WHERE
	nombre NOT LIKE '%AF%'

-- Extraer un listado de artículos de la marca AF (cualquier tipo).

SELECT
	articulo,
	nombre,
	marca
FROM
	articulos
WHERE
	marca IN (SELECT
				marca
			FROM
				marcas
			WHERE
				nombre LIKE '%AF%')


SELECT
	fecha, --1
	total  --2
FROM
	vencab
WHERE 
	YEAR(fecha) = 2007
	AND anulada = 0
ORDER BY
	total DESC

SELECT
	MAX(total) AS "Total"
FROM
	vencab
WHERE 
	YEAR(fecha) = 2007
	AND anulada = 0

SELECT
	vendedor,
	fecha,
	total,
	total * 0.05 AS "Comisión"
FROM
	vencab
WHERE 
	YEAR(fecha) = 2008
	AND anulada = 0
	AND total > (SELECT
					MAX(total) AS "Total"
				FROM
					vencab
				WHERE 
					YEAR(fecha) = 2007
					AND anulada = 0)
ORDER BY
	vendedor,
	total DESC

-- PSEUDOCOLUMNAS

SELECT YEAR(GETDATE())

SELECT 'Hola!'

SELECT (168*1236)/56

-- IS NULL

SELECT TOP 1000 * FROM vencab

SELECT * FROM vencab WHERE fechahora IS NOT NULL

SELECT * FROM vencab WHERE tipofac = ''

/* 

EJERCICIO 1: LISTAR LOS CÓDIGOS DE LAS SUCURSALES EN LAS QUE SE HICIERON VENTAS MAYORES A $1000 EN EL MES DE MAYO DE 2007.
NO TENGA EN CUENTA VENTAS ANULADAS.

*/

SELECT
	DISTINCT sucursal
FROM
	vencab
WHERE
	total > 1000
	AND anulada = 0
	AND fecha BETWEEN '2007-05-01' AND '2007-05-31'
ORDER BY
	1

/*


EJERCICIO 2: LISTE LOS ARTICULOS DE TIPO "CINTO" DADOS DE ALTA EN EL AÑO 2006, CUYO PRECIO MAYORISTA SEA MENOR A SU PRECIO 
MINORISTA. ADEMÁS TENER EN CUENTA QUE LA MARCA SEA 'A','F' o 'Q', Y QUE AMBOS PRECIOS SEAN MAYORES A CERO. PRESENTE: CÓDIGO,
NOMBRE, MARCA, PRECIO X MAYOR, PRECIO X MENOR, Y DIFERENCIA ENTRE AMBOS. ORDENE EN FORMA DECRECIENTE POR LA DIFERENCIA 
DE PRECIOS.

*/

SELECT
	articulo AS "Código",
	nombre AS "Nombre",
	marca AS "Marca",
	preciomayor AS "Precio x Mayor",
	preciomenor AS "Precio x Menor",
	(preciomenor - preciomayor) AS "Diferencia"
FROM
	articulos
WHERE
	YEAR(creado) = 2006
	AND preciomenor > 0
	AND preciomayor > 0
	AND preciomayor < preciomenor
	AND marca IN('A','F','Q')
	AND nombre LIKE 'CINTO%'
ORDER BY
	6 DESC

/*

EJERCICIO 3: PRESENTE EL CÓDIGO, EL NOMBRE Y LA SUCURSAL DE LOS VENDEDORES QUE SEAN ENCARGADOS, QUE ESTÉN ACTIVOS
Y QUE ALGUNA VEZ RECIBIERON UNIFORME (tabla uniformes). UTILICE SUBCONSULTA.

*/

SELECT 
	vendedor,
	nombre,
	sucursal
FROM
	vendedores
WHERE
	activo = 'S'
	AND encargado = 'S'
	AND vendedor IN (SELECT DISTINCT vendedor FROM uniformes)
	