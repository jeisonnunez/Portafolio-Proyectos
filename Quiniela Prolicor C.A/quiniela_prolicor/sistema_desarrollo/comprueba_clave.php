<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Documento sin título</title>

</head>

<body>

<?php

$n_usu= $_POST["n_usu"];
$c_usu=	$_POST["c_usu"];


$pass_cifrado=password_hash($p_usu, PASSWORD_DEFAULT, array("cost"=>12));

require("datos_conexion.php");

$conexion=mysqli_connect($db_host,$db_usuario,$db_contraseña);

if(mysqli_connect_errno()){
	
echo "Fallo al conectar con la base de datos";

exit();	
	
}

mysqli_select_db($conexion, $db_nombre) or die ("No se encuentra la base de datos");

mysqli_set_charset($conexion, "utf8");

$sql="insert into datos_usuarios (cedula, clave, perfil,correo) values (?,?,?,?)";

$resultado=mysqli_prepare($conexion,$sql);

$ok=mysqli_stmt_bind_param($resultado,"ssss",$n_usu,$pass_cifrado,$perfil,$c_usu);

$ok=mysqli_stmt_execute($resultado);

if($ok==false){
	
echo "<script language='javascript'> 			

				alert('Error al ejecutar la consulta. Usuario ya registrado');
				window.location.replace('Formulario_Insertar_Registros.php')	
							
			 </script>";
	
}else{
		
	
	echo "<script language='javascript'> 
			
				alert('Agregado nuevo usuario');
				window.location.replace('sistema_login/quiniela.php');
				
			 </script>";
}

mysqli_stmt_close($resultado);

mysqli_close($conexion);

?>


</body>
</html>