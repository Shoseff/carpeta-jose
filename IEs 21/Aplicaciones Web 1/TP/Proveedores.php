<html>
    <head>
    </head>
    <body>
        <h1>Cuentas</h1>
        <form name="datos" action="Consulta.php" method="post">
            Codigo de cuenta
            <input type="text" name="codCuenta" id="codCuenta">
            </input>
            <br>
            <br>
            Tipo de consulta
            <br>
            Total
            <input type="radio" name="radio" value="T" checked>
            <br>
            Deudoras
            <input type="radio" name="radio" value="D">
            <br>
            <br>
            <input type="submit" value="Consultar">
        </form>

<table>
<?php

    $cn=new mysqli("localhost","root","","rentasPorfin");
    $cod = $_POST['codCuenta'];
    $reg=$cn->query("select Nombre from cuentas where $cod=IdCuenta ");
    $c=$reg->num_rows;

    if (!empty ($_POST))
    {
        if($c==0){
        echo "Ingrese el codigo o codigo inexistente dentro de la tabla cuentas";
        }
        while($filas=$reg->fetch_array())
        {
        echo "<table border=1>";
         echo "<tr>
         <td>$filas[Nombre]</td>";
        }
    }

    if (isset($_POST['radio']))
    {
      $opcion = $_POST['radio'];
  	  if($opcion=="T")

   	    $reg = $cn->query("SELECT Liquidacion,Cuota,Importe,Periodo,Estado FROM liquidaciones WHERE $cod=IdCuenta" ); 

   	  else
   	   if($opcion=="D")

        $reg = $cn->query("SELECT Liquidacion,Cuota,Importe,Periodo,Estado FROM liquidaciones WHERE $cod=IdCuenta and Estado='I'" );  
     }

     while($filas=$reg->fetch_array())
        {
         echo "
         <td>$filas[Liquidacion]</td>
         <td>$filas[Cuota]</td>
         <td>$filas[Importe]</td>
         <td>$filas[Periodo]</td>
         <td>$filas[Estado]</td>
         </tr>";
         echo "</table>";
        }

    $cn->close();
?>
</table>
</html>