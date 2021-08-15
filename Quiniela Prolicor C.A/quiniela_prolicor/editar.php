<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>ACTUALIZAR</title>
<link rel="stylesheet" href="estilos_usuarios.css">
<style>
#principal{
	
		
	background-image:url(imagenes/ekaterinburg-3423345_1280.jpg);	
}

.button{
  font-size: 14px;
 
  color: #000;
  padding: 6px 25px 0px 20px;
  
  cursor:pointer;
  display: inline-block;
  margin: 5px;
  text-decoration: none;
  width: 100px; 
 font-family:"Dusha V5";
  -webkit-border-radius: 5px; 
  -moz-border-radius: 5px; 
  border-radius: 5px; 
  background-color: #F0FFCE; 
  -webkit-box-shadow: 0 3px #F0FFCE; 
  -moz-box-shadow: 0 3px #F0FFCE;  
  box-shadow: 0 3px #F0FFCE; 
  transition: all 0.1s linear 0s; 
  top: 0px;
  position: relative;
}

.button:hover {
  top: 3px;
  background-color:#F0FFCE;
  -webkit-box-shadow: none; 
  -moz-box-shadow: none; 
  box-shadow: none;
  
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
        
        <img id="logo" src="imagenes/prolicor_logo1.png"><h1 id="titulo">QUINIELA PROLICOR NUBE AZUL</h1><img id="logo1" src="imagenes/logo_nb.png">     
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

if(!isset($_POST['bot_actualizar'])){

$ced=$_GET['ced'];
$per=$_GET['per'];
$ema=$_GET['cor'];



}else{
	
	
	$ced_e=$_POST['ced'];	
	$per_e=$_POST['per'];
	$ema_e=$_POST['ema'];
	
	
	$sql="update datos_usuarios set perfil=:miPer, correo=:miEma where cedula=:miCed";
	
	$resultado=$base->prepare($sql);
	
	$resultado->execute(array(":miCed"=>$ced_e, ":miPer"=>$per_e, ":miEma"=>$ema_e));
	
	?>
	<script>
	
		alert('Registro actualizado');
		window.location.replace("usuarios.php");
	</script>
    
    
	<?php
	
}
		
?>


<div id="contenido">

<form name="form1" method="post" action="<?php echo $_SERVER['PHP_SELF'];?>">
  <table width="25%" border="0" align="center">
    <tr>
      <td class="primera_fila">Cedula</td>
      <td class="resultado"><label for="ced"></label>
      <input type="hidden" name="ced" id="ced" value="<?php echo $ced?>"><?php echo $ced?></td>
    </tr>
    <tr>
      <td class="primera_fila">Perfil</td>
      <td class="resultado"><label for="per"></label>
      <select name="per">
      <option selected value='usuario'>usuario</option> 
      <option value='administrador'>administrador</option> 
       </select> </td>	
     
    </tr>
    <tr>
      <td class="primera_fila">Correo</td>
      <td class="resultado"><label for="ema"></label>
      <input type="email" name="ema" id="ema" value="<?php echo $ema?>"></td>
    </tr>
    
    <tr>
      <td colspan="2" class="centrado"><input type="submit" name="bot_actualizar" class="button" id="bot_actualizar" value="Actualizar"></td>
    </tr>
  </table>
</form>
</div>
</body>
</html>