<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Documento sin título</title>
</head>

<body>


<?php

try{
	
	$login=$_POST["n_usu"];
	
	$correo=$_POST["c_usu"];
	
	$contador=0;
	
	$base=new PDO("mysql:host=localhost; dbname=quiniela_prolicor" , "root", "");
	
	$base->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);	
	
	$sql="select * from datos_usuarios where cedula= :login and correo= :correo";
	
	$resultado=$base->prepare($sql);	
		
	$resultado->execute(array(":login"=>$login, ":correo"=>$correo));
	
	
		
		while($registro=$resultado->fetch(PDO::FETCH_ASSOC)){			
			
			
			if(($registro['cedula']==$login) && ($registro['correo']==$correo)){
				
				$contador++;
				
				
				
				
			}
					
			
		}
		
		if($contador>0){
			
			session_start();
			
				$_SESSION["login"]=$login;
				$_SESSION["correo"]=$correo;
			
			echo "	<script language='javascript'> 
			
				alert('Busqueda Exitosa. Por favor introduzca su nueva clave');
				window.location.replace('../cambiar_clave.php');
				
			 </script>";
				
				
				
		}else{
			
			echo "<script language='javascript'> 
			
				alert('Usuario y correo no coinciden');
				window.location.replace('../Recuperar_clave.php');
				
			 </script>";
			
		}
		
		
		$resultado->closeCursor();

	
	
}catch(Exception $e){
	
	die("Error: " . $e->getMessage());
	
	
	
}




?>
</body>


</html>