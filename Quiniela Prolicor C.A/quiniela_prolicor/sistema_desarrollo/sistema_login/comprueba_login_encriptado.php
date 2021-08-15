<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Documento sin título</title>
</head>

<body>


<?php

try{
	
	$login=htmlentities(addslashes($_POST["login"]));
	
	$password=htmlentities(addslashes($_POST["password"]));
	
	$contador=0;
	
	$base=new PDO("mysql:host=localhost; dbname=quiniela_prolicor" , "root", "");
	
	$base->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
	
	
	$sql="select * from datos_usuarios where cedula= :login";
	
	$resultado=$base->prepare($sql);	
		
	$resultado->execute(array(":login"=>$login));
	
	
		
		while($registro=$resultado->fetch(PDO::FETCH_ASSOC)){			
			
		$perfil=$registro['perfil'];
			
			if(password_verify($password, $registro['clave'])){//devuelve true si son iguales. false si no son iguales
				
				$contador++;
				
			}
					
			
		}
		
		
		
		if($contador>0){
			
		session_start();//crear una sesion para el usuario logeado
		
		$_SESSION["usuario"]=$_POST["login"];
		
		$_SESSION["perfil"]=$perfil;
		
		  if($perfil=="administrador"){
			   
				header("location:../../administrador_quiniela.php"); 
			   
			   
		   }else{
			   
			   header("location:../../quinielas_prolicor.php"); 				 
			   
		   }
            
				
		}else{
			
			echo "<script language='javascript'> 
			
				alert('Usuario o clave');
				window.location.replace('login_encriptado.php');
				
			 </script>";
			
		}
		
		
		$resultado->closeCursor();

	
	
}catch(Exception $e){
	
	die("Error: " . $e->getMessage());
	
	
	
}




?>
</body>


</html>