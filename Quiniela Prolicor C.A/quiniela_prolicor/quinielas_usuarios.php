<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>QUINIELAS USUARIOS</title>
<link rel="stylesheet" href="estilos_usuarios.css">
</head>


<script>

function preguntar(){
	
    if (confirm('¿Está seguro que desea eliminar esta quiniela?')){
         
		 document.eliminar.submit();
         alert('Quiniela Eliminada');
		 return true;
		  
		
    }else{
		
		alert('Cancelo eliminación');
		 return false;
		
		}
}



</script>

<style>

#principal{
	
		
	background-image:url(imagenes/football-stadium-227561_1920.jpg);	
}

@media (max-width:1250px) {
		
	#principal:before{
	
			content:"";
			width:100%;
			height:1550px;			
			position:absolute;
			background-color:#4169E1;
			opacity:0.5;
			
	}	
	
	
	
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
	
	if($_perfil!="administrador"){
		
		header("location:sistema_desarrollo/sistema_login/cierre.php");	
		
		
	}

?>

<header id="encabezado">

<div id="banner">

<img id="logo" src="imagenes/prolicor_logo1.png"><h1 id="titulo">QUINIELA PROLICOR NUBE AZUL</h1>  <img id="logo1" src="imagenes/logo_nb.png">   
 </div>
 
 <nav id="menu">
   		<ul>
             <li><a href="administrador_quiniela.php">Quiniela Ganadora</a></li>
             <li><a href="quinielas_usuarios.php">Quinielas</a></li>
             <li><a href="usuarios.php">Usuarios</a></li>
             <li><a href="clasificacion.php">Clasificacion</a></li>
             <li><a href="sistema_desarrollo/sistema_login/cierre.php">Cerrar Sesion</a></li>
            
         </ul>
</nav>	
</header>

 <p class='usuario'>Administrador: <?php echo $_SESSION["usuario"] ?> </p><br><br>

<?php

	//------------------------------------------------------Paginacion---------------------------------------------------------------
	
	$tamagno_paginas=10;
	
	if(isset($_GET['pagina'])){
		
		if($_GET['pagina']==1){
			
			header("location:quinielas_usuarios.php");	
			
		}else{
						
			$pagina=$_GET['pagina'];	
			
		}
		
	}else{
	
		$pagina=1;
	}
	
	$empezar_desde=($pagina-1)*$tamagno_paginas;
	
	$sql_total="select codigo_quiniela, cedula, pagado from usuarios_quiniela";	

	$resultado=$base->prepare($sql_total);
	
	$resultado->execute(array());
	
	$num_registros=$resultado->rowCount();
	
	$total_paginas=ceil($num_registros/$tamagno_paginas);
	
	//---------------------------------------------------------------------------------------------------------------------------------------//	
	
	$registros=$base->query("select codigo_quiniela, cedula, pagado from usuarios_quiniela limit $empezar_desde,$tamagno_paginas")->fetchAll(PDO::FETCH_OBJ);
	
	
//------------------------------------------------------------------------------------//
?>





<div id="contenido">
 

<form action="<?php /*?><?php echo $_SERVER['PHP_SELF'];?><?php */?>"  method="post">

  <table width="50%" border="0" align="center">
   
    <tr>
      
      <td class="primera_fila"><p>Codigo Quiniela</p></td>
      <td class="primera_fila"><p>Usuario</p></td>
      <td class="primera_fila"><p>Pagado</p></td>
    </tr> 
   
	
    <?php
	
	
	foreach($registros as $datos):
	
	if($datos->pagado==1){
	
	$check="checked";
	
	}else{
		
		$check="";
		
		}

	
	?>
   
   
   
   	<tr>
      <td class="resultado"><p><?php echo $datos->codigo_quiniela ?></p></td>
     <td class="resultado"><p><?php echo $datos->cedula ?></p></td>
     <td class="resultado"><p><input type="checkbox" name='<?php echo $datos->codigo_quiniela ?>'  value='<?php echo $datos->pagado?>'  <?php echo $check ?> form="editar"></p></td>
     
     
<form action="eliminar_quiniela.php" name="eliminar" method="get">

	 
      <td class="bot"><a onclick='return preguntar()' href="eliminar_quiniela.php?cod=<?php  echo $datos->codigo_quiniela?>"><input type='button' name='del' id='del' value='Eliminar' class="button1"></a></td>
      
 </form>
 
 
 
      
 <form action="ver_quinielas.php" name="ver" method="post">

   <td class='bot'><input type="hidden" name="codigo" value="<?php echo $datos->codigo_quiniela?>">
   <input type='submit' name='up' id='up' value='Ver' class="button2"></td>
      
    </tr>   
</form>

    
    <?php
		endforeach;
	?>
    
 <form action="editar_quiniela.php" name="editar" method="post" id="editar"> 
   <input type="hidden" name="tamano" value="<?php echo $tamagno_paginas ?>">
   <input type="hidden" name="comienza" value="<?php echo $empezar_desde ?>">
   
  <tr> 
  <td ></td>  
  <td></td>  
  <td ></td>  
  <td ></td>  
   <td class='bot'><input type="submit" value='Actualizar' class="button"></td>
      
  </tr> 
   
  </form>
  
     <tr><td class="centrado" colspan="2">
 
 			<?php 
			
			for($i=1; $i<=$total_paginas; $i++){
			?>	
				
		
        
        <?php 
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