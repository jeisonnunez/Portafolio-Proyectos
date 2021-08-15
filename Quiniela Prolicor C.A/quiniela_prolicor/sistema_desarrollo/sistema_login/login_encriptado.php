<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Documento sin título</title>
<link rel="stylesheet" href="../../estilo_login.css">

<style>

	

#principal{
	
		
	background-image:url(../../imagenes/russia-1199330_1280.jpg);	
}

</style>





</head>

<body id="principal">

<header id="encabezado">

<div id="banner">

<img id="logo" src="../../imagenes/prolicor_logo1.png"><h1 id="titulo">QUINIELA PROLICOR NUBE AZUL</h1> <img id="logo1" src="../../imagenes/logo_nb.png">       
 </div>
 
 <nav id="menu">
   		<ul><li>&nbsp;</li></ul>
</nav>	
</header>


<div id="contenido">



<form class="login" action="comprueba_login_encriptado.php" method="post" id="id_formulario" name="formulario">
    <h1 class="login-title">FORMULARIO LOGIN</h1>
    <input type="text" name="login" class="login-input" placeholder="Cedula" required>
    <input type="password" name="password" class="login-input" placeholder="Clave" required>
    <a class="olvido" href="../Recuperar_clave.php"><p class="olvido">Olvido su clave?</p></a>
    <input type="submit" value="LOGIN" class="login-button">
    
  
  </form>
</div>





</body>
</html>