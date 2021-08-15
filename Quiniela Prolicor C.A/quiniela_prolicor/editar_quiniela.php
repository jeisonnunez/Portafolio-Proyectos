<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>ACTUALIZAR</title>
<link rel="stylesheet" href="estilos_usuarios.css">
<style>
#principal{
	
		
	background-image:url(imagenes/stadium-2921657_1280.jpg);	
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
    
	<!--<header id="encabezado">

        <div id="banner">
        
        <img id="logo" src="imagenes/prolicor_logo1.png"><h1 id="titulo">QUINIELA PROLICOR NUBE AZUL</h1>  
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

 <p class='usuario'>Administrador: <?php /*?><?php echo $_SESSION["usuario"] ?><?php */?> </p><br><br>
-->
<?php



 $tamagno_paginas=$_POST["comienza"];

 $empezar_desde=$_POST["tamano"];
 
 

$sql_total="select codigo_quiniela from usuarios_quiniela limit $tamagno_paginas, $empezar_desde";	

	$resultado=$base->prepare($sql_total);
	
	$resultado->execute(array());
	
foreach($resultado as $datos){


$cod=$datos["codigo_quiniela"];

 if(isset($_POST["$cod"])==1) {
		
        $pagado=1;
		
    }else{
		
		$pagado=0;
		
		
		}




$sql="update usuarios_quiniela set pagado=:miPag where codigo_quiniela=:miCod";
	
$resultado=$base->prepare($sql);
	
$resultado->execute(array(":miPag"=>$pagado, ":miCod"=>$cod));

}
?>
<script>
//	
alert('Registros actualizado');
window.location.replace("quinielas_usuarios.php");
//	</script>
   

<?php /*?>/* <?php <?php ?>$cod=$_GET['cod'];
$ced=$_GET['ced'];
$pag=$_GET['pag'];

if($_GET['pag']==1){
	
	$check="checked";
	
	}else{
		
		$check="";
		
		}



	
	
	$sql="update usuarios_quiniela set cedula=:miCed, pagado=:miPag where codigo_quiniela=:miCod";
	
	$resultado=$base->prepare($sql);
	
	$resultado->execute(array(":miCed"=>$ced_e, ":miPag"=>$pag_e, ":miCod"=>$cod_e));
	
	?><?php */?>
	
    
    
	

<!--<div id="contenido">

<form name="form1" method="post" action="<?php /*?><?php echo $_SERVER['PHP_SELF'];?><?php */?>">
  <table width="25%" border="0" align="center">
    <tr>
      <td class="primera_fila">Quiniela</td>
      <td class="resultado"><label for="ced"></label>
      <input type="hidden" name="cod" id="cod" value="<?php /*?><?php echo $cod?><?php */?>"><?php /*?><?php echo $cod?><?php */?></td>
    </tr>
    <tr>
      <td class="primera_fila">Cedula</td>
      <td class="resultado"><label for="ced"></label>
      <input type="hidden" name="ced" id="ced" value="<?php /*?><?php echo $ced?><?php */?>"><?php /*?><?php echo $ced?><?php */?></td>	
     
    </tr>
    <tr>
      <td class="primera_fila">Pagado</td>
      <td class="resultado"><label for="pag"></label>
      <input type="checkbox" name="pag" class="check" value="<?php /*?><?php echo $pag?><?php */?>" <?php /*?><?php echo $check?><?php */?>></td>
    </tr>
    
    <tr>
      <td colspan="2" class="centrado"><input type="submit" name="bot_actualizar" class="button1" id="bot_actualizar" value="Actualizar"></td>
    </tr>
  </table>
</form>
</div>-->
</body>
</html>