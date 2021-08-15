<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Documento sin título</title>
</head>

<body>

<?php

include("sistema_desarrollo/crud/conexion_crud.php");



$clasificacion_puntaje=$base->query("select * from usuarios_quiniela order by puntaje desc")->fetchAll(PDO::FETCH_OBJ);
				
				   
?>

<form action="<?php echo $_SERVER['PHP_SELF'];?>"  method="post">

  <table width="50%" border="0" align="center">
   
    <tr>
      <td class="primera_fila">Posicion</td>
      <td class="primera_fila">Codigo Quiniela</td>
      <td class="primera_fila">Cedula</td>
      <td class="primera_fila">Puntaje</td>
    
    </tr> 
    <?php
	
	$i=1;
	
	foreach($clasificacion_puntaje as $datos):?>
   
   	<tr>
      <td><?php echo $i ?></td>
      <td><?php echo $datos->codigo_quiniela ?></td>
      <td><?php echo $datos->cedula ?></td>
      <td><?php echo $datos->puntaje ?></td>
      
      </tr>
      
    <?php
	
	$i=$i+1;
	endforeach;
	?>
      
  </table>
  </form>
 
  </body>
</html>
  


<?php /*?><?php


date_default_timezone_set('America/Asuncion');

$time=time();
						
$fecha_actual=date("Y-m-d H:i:s", $time);
  
$correos = $base->prepare("select correo from datos_usuarios");
$correos->execute(array());
$enviar_correos = $correos->fetchAll();	


foreach($enviar_correos as $emails){
	
	$destinatario=$emails["correo"];
	
	$asunto="Clasificación Actual Fecha: " . $fecha_actual;
	
	$headers="MIME-Version 1.0\r\n";
	
	$headers.="Content-type: text/html; charset=iso-8859-1\r\n";
	
	$headers.="From: Jeison < jeisonnunez123@hotmail.com >\r\n";
	
	$texto_mail="<!doctype html>
				<html>
				<head>				
				<title>Documento sin título</title>
				</head>
				
				<body>';
				
				
				
				include('sistema_desarrollo/crud/conexion_crud.php');
				
				
				
				$clasificacion_puntaje=$base->query('select * from usuarios_quiniela order by puntaje desc')->fetchAll(PDO::FETCH_OBJ);
								
						
				<form action=''  method='post'>
				
				  <table width='50%' border='0' align='center'>
				   
					<tr>
					  <td class='primera_fila'>Posicion</td>
					  <td class='primera_fila'>Codigo Quiniela</td>
					  <td class='primera_fila'>Cedula</td>
					  <td class='primera_fila'>Puntaje</td>
					
					</tr> 
					<?php
					
					$i=1;
					
					foreach($clasificacion_puntaje as $datos):
				   
					<tr>
					  <td> $i </td>
					  <td> $datos->codigo_quiniela </td>
					  <td> $datos->cedula </td>
					  <td> $datos->puntaje </td>
					  
					  </tr>
					  
					
					
					$i=$i+1;
					endforeach;
					
					  
				  </table>
				  </form>
				 
				  </body>
				</html> ";
	
	
	$exito=mail($destinatario,$asunto,$texto_mail,$headers);
	
	if($exito==true){
		
	echo "Mensaje enviado con exito";	
		
	}else{
	
	echo "Ha habido un error";		
				
	}
}
?>
<?php */?>