<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Documento sin título</title>
</head>

<body>


<?php

if(!isset($_SESSION)){
    session_start();
}

	$_usuario=$_SESSION["login"];
	
	$_correo=$_SESSION["correo"];
	
	if(!isset($_SESSION["login"])){
		
		header("location:login_encriptado.php");	
		
		
	}

try{
	

	
	$clave=htmlentities(addslashes($_POST["p_usu"]));
	
	$pass_cifrado=password_hash($clave, PASSWORD_DEFAULT, array("cost"=>12));	
	
	$base=new PDO("mysql:host=localhost; dbname=quiniela_prolicor" , "root", "");
	
	$base->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);	
	
	$sql="update datos_usuarios set clave=:clave where cedula=:login and correo=:correo";
	
	$resultado=$base->prepare($sql);	
		
	$resultado->execute(array(":login"=>$_usuario, ":correo"=>$_correo, ":clave"=>$pass_cifrado));
	
		

	
	session_destroy();
	
	
		$resultado->closeCursor();

		echo "<script language='javascript'> 
			
				alert('Cambio de clave exitoso');
				window.location.replace('quiniela.php');
				
			 </script>";
	
}catch(Exception $e){
	
	die("Error: " . $e->getMessage());
	
	
	
}




?>
</body>


</html>