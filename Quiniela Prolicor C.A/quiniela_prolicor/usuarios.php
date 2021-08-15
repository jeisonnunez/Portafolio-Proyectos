<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>USUARIOS</title>

<link rel="stylesheet" href="estilos_usuarios.css">

<script>

function preguntar(){
	
    if (confirm('¿Está seguro que desea eliminar?')){
         
		 document.eliminar.submit();
         alert('Registro Eliminado');
		 return true;
		  
		
    }else{
		
		alert('Cancelo eliminación');
		 return false;
		
		}
}



</script>
<style>

@media (max-width:1330px) {
		
	#principal:before{
	
			content:"";
			width:100%;
			height:1600px;			
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
			
			header("location:usuarios.php");	
			
		}else{
						
			$pagina=$_GET['pagina'];	
			
		}
		
	}else{
	
		$pagina=1;
	}
	
	$empezar_desde=($pagina-1)*$tamagno_paginas;
	
	$sql_total="select cedula, perfil, correo from datos_usuarios";	

	$resultado=$base->prepare($sql_total);
	
	$resultado->execute(array());
	
	$num_registros=$resultado->rowCount();
	
	$total_paginas=ceil($num_registros/$tamagno_paginas);
	
	//---------------------------------------------------------------------------------------------------------------------------------------//	
	
	$registros=$base->query("select cedula, perfil, correo from datos_usuarios limit $empezar_desde,$tamagno_paginas")->fetchAll(PDO::FETCH_OBJ);
	
	
//------------------------------------------------------------------------------------//
?>





<div id="contenido">


<form action="<?php echo $_SERVER['PHP_SELF'];?>"  method="post">

  <table width="50%" border="0" align="center">
   
    <tr>
      
      <td class="primera_fila"><p>Cedula</p></td>
      <td class="primera_fila"><p>Perfil</p></td>
       <td class="primera_fila"><p>Correo</p></td>
   
      
      
    
      
    </tr> 
   
	
    <?php
	
	
	foreach($registros as $datos):?>
   
   
   	<tr>
     <td class="resultado"><p><?php echo $datos->cedula ?></p></td>
      <td class="resultado"><p><?php echo $datos->perfil ?></p></td>
      <td class="resultado"><p><?php echo $datos->correo?></p></td>
      
      
      
      
     
<form action="eliminar_prueba.php" name="eliminar" method="get">

	 
      <td class="bot"><a  onclick='return preguntar()' href="eliminar_prueba.php?ced=<?php  echo $datos->cedula?> "><input type='button' name='del' id='del' value='Eliminar' class="button1"></a></td>
      
 </form>
 
 <form action="editar.php" name="editar" method="get">

    
   <td class='bot'><a  href="editar.php?ced=<?php echo $datos->cedula?> & per=<?php echo $datos->perfil?> & cor=<?php echo $datos->correo?>"><input type='button' name='up' id='up' value='Actualizar' class="button" ></a></td>
      
    </tr>   
</form>

    
    <?php
		endforeach;
	?>
    
   
     <tr><td class="centrado" colspan="3">
 
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