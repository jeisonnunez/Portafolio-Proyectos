<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>CLASIFICACION</title>
<link rel="stylesheet" href="estilo_clasificacion.css">
<style>

#principal{
	
		
	background-image:url(imagenes/sport-2467178_1280.jpg);	
}

#menu ul li{
	
	width:25%;
	
	
	}
</style>
</head>

<body id="principal">

<?php

include("sistema_desarrollo/crud/conexion_crud.php");


	if(!isset($_SESSION)){
    session_start();
}

	$_usuario=$_SESSION["usuario"];
	
	$_perfil=$_SESSION["perfil"];
	
	if(!isset($_SESSION["usuario"])){
		
		header("location:sistema_desarrollo/sistema_login/login_encriptado.php");	
		
		
	}
	
	if($_perfil!="usuario"){
		
		header("location:sistema_desarrollo/sistema_login/cierre.php");	
		
		
	}

	
?>	
<header id="encabezado">

<div id="banner">

<img id="logo" src="imagenes/prolicor_logo1.png"><h1 id="titulo">QUINIELA PROLICOR NUBE AZUL</h1> <img id="logo1" src="imagenes/logo_nb.png">    
 </div>
 
<nav id="menu">
   		<ul>
            <li><a href="quinielas_prolicor.php">Mis Quinielas</a></li>
             <li><a href="resultados.php">Resultados</a></li>
             <li><a href="clasificacion_quinielas.php">Clasificacion</a></li>             
             
             <li><a href="sistema_desarrollo/sistema_login/cierre.php">Cerrar Sesion</a></li>
            
         </ul>
</nav>	
</header>

<p class='usuario'>Usuario: <?php echo $_SESSION["usuario"] ?> </p><br><br>

	<?php
	
	
	
	
	$tamagno_paginas=20;
	
	if(isset($_GET['pagina'])){
		
		if($_GET['pagina']==1){
			
			header("location:clasificacion_quinielas.php");	
			
		}else{
						
			$pagina=$_GET['pagina'];	
			
		}
		
	}else{
	
		$pagina=1;
	}
	
	$empezar_desde=($pagina-1)*$tamagno_paginas;
	
	$sql_total="select codigo_quiniela, cedula, puntaje, posicion from usuarios_quiniela order by puntaje desc ";	

	$resultado=$base->prepare($sql_total);
	
	$resultado->execute(array());
	
	$i=1;
					
			foreach ($resultado as $row) {
							
								
				$codigo=$row["codigo_quiniela"];
				
				$consulta="update usuarios_quiniela set posicion='$i' where codigo_quiniela='$codigo'";
								
				$actualizar=$base->prepare($consulta);
						
				$actualizar->execute();
							
				$i=$i+1;
						
			}
							
	
	$num_registros=$resultado->rowCount();
	
	$total_paginas=ceil($num_registros/$tamagno_paginas);
	
	$clasificacion_puntaje=$base->query("select posicion, codigo_quiniela, cedula, puntaje from usuarios_quiniela order by posicion limit $empezar_desde,$tamagno_paginas ")->fetchAll(PDO::FETCH_OBJ);
	
	
	
	?>			
				   


<div id="contenido">

<form action="<?php echo $_SERVER['PHP_SELF'];?>"  method="post">

  <table width="50%" border="0" align="center">
   
    <tr>
      <td class="primera_fila"><p>Posicion</p></td>
      <td class="primera_fila"><p>Codigo Quiniela</p></td>
      <td class="primera_fila"><p>Cedula</p></td>
      <td class="primera_fila"><p>Puntaje</p></td>
    
    </tr> 
    
    
    <?php
	
	
	
	foreach($clasificacion_puntaje as $datos):?>
   
   	<tr class="agrandar">
      <td id="puntaje"><p><?php echo $datos->posicion ?></p></td>
      <td class="resultado"><p><?php echo $datos->codigo_quiniela ?></p></td>
      <td class="resultado"><p><?php echo $datos->cedula ?></p></td>
      <td class="resultado"><p><?php echo $datos->puntaje ?></p></td>
      
      </tr>
      
    <?php
	
	endforeach;
	?>
    
    <tr><td class="centrado" colspan="4">
 
 		<?php	
			
			 for($i=1; $i<=$total_paginas; $i++){
		
			echo "<a href='?pagina=" . $i .  "'>" . $i . "</a>  "; 
			 }
	
			?>
			
			

	</td>
    </tr>  
      
  </table>
  </form>
  
  </div>
 
 
  </body>
</html>
  
