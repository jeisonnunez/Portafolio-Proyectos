<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Documento sin título</title>
</head>

<body>

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
	
	$cod=$_GET["cod"];
	
	
	$base->query("delete from usuarios_quiniela where codigo_quiniela='$cod'");
	
	$base->query("delete from quinielas where codigo_quiniela='$cod'");
	
	

header("Location:quinielas_usuarios.php");
?>
</body>
</html>