<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>RESULTADOS</title>
<link rel="stylesheet" href="estilo_quiniela2.css">

<style>

#menu ul li{
	
	width:25%;
	
	
	}
	
	#principal{
	
		
	background-image:url(imagenes/football-world-cup-2018-3420784_1280.jpg);	
}

#principal:before{
	
	height:2305px;
	
	}
	
	#principal:before{
	
	content:"";
	width:100%;
	height:2420px;
	position:absolute;
	background-color:#4169E1;
	opacity:0.5;
	
	}
	
	@media (max-width:715px) {
		
	#principal:before{
	
			content:"";
			width:100%;
			height:3930px;			
			position:absolute;
			background-color:#4169E1;
			opacity:0.5;
			
	}	
	
	
	
	}
	@media (max-width:400px) {
		
	#principal:before{
	
			content:"";
			width:100%;
			height:3580px;			
			position:absolute;
			background-color:#4169E1;
			opacity:0.5;
			
	}


</style>

<script>

function isNumberKey(evt)
        {
         var charCode = (evt.which) ? evt.which : event.keyCode
         if (charCode > 31 && (charCode < 48 || charCode > 57))
            return false;
 
         return true;
        }

</script>
</head>

<body>

<?php

	if(!isset($_SESSION)){
    session_start();
}

	$_usuario=$_SESSION["usuario"];
	
	$_perfil=$_SESSION["perfil"];
	
	if(!isset($_SESSION["usuario"])){
		
		header("location:sistema_desarrollo/sistema_login/login_encriptado.php");	
		
		
	}
	
	if($_perfil!="usuario"){
		
		header("location:sistema_desarrollo/sistema_login/cierre.php");	
		
		
	}
	

?>

<header id="encabezado">

<div id="banner">

<img id="logo" src="imagenes/prolicor_logo1.png"><h1 id="titulo">QUINIELA PROLICOR NUBE AZUL</h1> <img id="logo1" src="imagenes/logo_nb.png">    
 </div>
 
 <nav id="menu">
   		<ul>
             <li><a href="quinielas_prolicor.php">Mis Quinielas</a></li>
             <li><a href="resultados.php">Resultados</a></li>
             <li><a href="clasificacion_quinielas.php">Clasificacion</a></li>             
          
             <li><a href="sistema_desarrollo/sistema_login/cierre.php">Cerrar Sesion</a></li>
            
         </ul>
</nav>	
</header>

<p class='usuario'>Usuario: <?php echo $_SESSION["usuario"] ?> </p><br><br>


<?php

include("sistema_desarrollo/crud/conexion_crud.php");

?>	
		
     
<?php					
					
//----------------------------------------------------------Carga la quiniela ganadora-------------------------------------------					
		
						$i=1;	
						$j=2;
						
						for($con=1;$con<=64;$con++){
							
						$valores=$base->prepare("select valor_1, valor_2 from quiniela_ganadora where posicion='$con'");
						$valores->execute(array());
						
						$record = $valores->fetchAll();
					
							foreach ($record as $row) {
								
							${"indice".$i."s"}=$row["valor_1"];
									
							${"indice".$j."s"}=$row["valor_2"];
							}
							
						
						
						$i=$i+2;
						$j=$j+2;	
						}
					
//------------------------------------------------------octavos de final s---------------------------------------------------

							$i=0;
							$j=1;	
					       
						
							for($con=49;$con<=56;$con++){
														
							$paises=$base->prepare("select equipo_1, equipo_2 from quiniela_ganadora where posicion='$con'");
							$paises->execute(array());
													
							$record_paises = $paises->fetchAll();
												
								foreach ($record_paises as $row) {
															
								    $paises_octavos[$i]=$row["equipo_1"];
									$paises_octavos[$j]=$row["equipo_2"];							
									
								}
														
							$logo_1=$base->prepare("select bandera from equipos_participantes where pais='$paises_octavos[$i]'");
							$logo_1->execute(array());
													
							$logo_paises = $logo_1->fetchAll();
												
								foreach ($logo_paises as $row) {
															
								    $logo[$i]=$row["bandera"];
																
									
								}	
										
							$logo_2=$base->prepare("select bandera from equipos_participantes where pais='$paises_octavos[$j]'");
							$logo_2->execute(array());
													
							$logo_paises_2 = $logo_2->fetchAll();
												
								foreach ($logo_paises_2 as $row) {
															
								    $logo[$j]=$row["bandera"];
																
									
								}			
												
							$i=$i+2;
							$j=$j+2;	
							}
							
							
							$i=0;
							$j=1;	
					       
	//---------------------------------------------------cuartos------------------------------------------------------------------					
						for($con=57;$con<=60;$con++){
														
							$paises_cuartos_1=$base->prepare("select equipo_1, equipo_2 from quiniela_ganadora where posicion='$con'");
							$paises_cuartos_1->execute(array());
													
							$record_paises_cuartos = $paises_cuartos_1->fetchAll();
												
								foreach ($record_paises_cuartos as $row) {
															
								    $paises_cuartos[$i]=$row["equipo_1"];
									$paises_cuartos[$j]=$row["equipo_2"];							
									
								}
														
							$logo_1_cuartos=$base->prepare("select bandera from equipos_participantes where pais='$paises_cuartos[$i]'");
							$logo_1_cuartos->execute(array());
													
							$logo_paises_cuartos = $logo_1_cuartos->fetchAll();
												
								foreach ($logo_paises_cuartos as $row) {
															
								    $logo_cuartos[$i]=$row["bandera"];
																
									
								}	
										
							$logo_2_cuartos=$base->prepare("select bandera from equipos_participantes where pais='$paises_cuartos[$j]'");
							$logo_2_cuartos->execute(array());
													
							$logo_paises_cuartos = $logo_2_cuartos->fetchAll();
												
								foreach ($logo_paises_cuartos as $row) {
															
								    $logo_cuartos[$j]=$row["bandera"];
																
									
								}			
												
							$i=$i+2;
							$j=$j+2;	
						}
						
		//------------------------------------------------semi---------------------------------------------------------------------	
							$i=0;
							$j=1;	
							
							
					for($con=61;$con<=62;$con++){
														
							$paises_semi_1=$base->prepare("select equipo_1, equipo_2 from quiniela_ganadora where posicion='$con'");
							$paises_semi_1->execute(array());
													
							$record_paises_semi_1 = $paises_semi_1->fetchAll();
												
								foreach ($record_paises_semi_1 as $row) {
															
								    $paises_semi[$i]=$row["equipo_1"];
									$paises_semi[$j]=$row["equipo_2"];							
									
								}
														
							$logo_1_semi=$base->prepare("select bandera from equipos_participantes where pais='$paises_semi[$i]'");
							$logo_1_semi->execute(array());
													
							$logo_paises_semi_1 = $logo_1_semi->fetchAll();
												
								foreach ($logo_paises_semi_1 as $row) {
															
								    $logo_semi[$i]=$row["bandera"];
																
									
								}	
										
							$logo_2_semi=$base->prepare("select bandera from equipos_participantes where pais='$paises_semi[$j]'");
							$logo_2_semi->execute(array());
													
							$logo_paises_semi_2 = $logo_2_semi->fetchAll();
												
								foreach ($logo_paises_semi_2 as $row) {
															
								    $logo_semi[$j]=$row["bandera"];
																
									
								}			
												
							$i=$i+2;
							$j=$j+2;	
						}			
						
//-----------------------------------------------------------------final-------------------------------------------------------
							$i=0;
							$j=1;
								
				for($con=63;$con<=64;$con++){
														
							$paises_final_1=$base->prepare("select equipo_1, equipo_2 from quiniela_ganadora where posicion='$con'");
							$paises_final_1->execute(array());
													
							$record_paises_final_1 = $paises_final_1->fetchAll();
												
								foreach ($record_paises_final_1 as $row) {
															
								    $paises_final[$i]=$row["equipo_1"];
									$paises_final[$j]=$row["equipo_2"];							
									
								}
														
							$logo_1_final=$base->prepare("select bandera from equipos_participantes where pais='$paises_final[$i]'");
							$logo_1_final->execute(array());
													
							$logo_paises_1 = $logo_1_final->fetchAll();
												
								foreach ($logo_paises_1 as $row) {
															
								    $logo_final[$i]=$row["bandera"];
																
									
								}	
										
							$logo_2_final=$base->prepare("select bandera from equipos_participantes where pais='$paises_final[$j]'");
							$logo_2_final->execute(array());
													
							$logo_paises_2 = $logo_2_final->fetchAll();
												
								foreach ($logo_paises_2 as $row) {
															
								    $logo_final[$j]=$row["bandera"];
																
									
								}			
												
							$i=$i+2;
							$j=$j+2;	
						}			
						
//--------------------------------------------------------campeon-------------------------------------------------------

							if($indice127s>$indice128s){
								
								$campeon=$paises_final[2];
								$logo_campeon=$logo_final[2];
									
							}
							
							else if($indice127s<$indice128s){
								
								$campeon=$paises_final[3];
								$logo_campeon=$logo_final[3];
									
							}else{
								
								$empate_goles=$base->prepare("select pais, bandera from equipos_participantes where codigo_equipo=33");
																	
								$empate_goles->execute(array());
																	
								$empate_goles_array = $empate_goles->fetchAll();
																	
									foreach ($empate_goles_array as $datos_paises) {
													
									$campeon=$datos_paises["pais"];
																			  
									$logo_campeon=$datos_paises["bandera"];
																			  
									}
									
							}				
									
												


//----------------------------------------------------------------------------------------------------------------------------------------
	

?>
	
<section id="principal">




<div id="col1">

    <div id="grupo_a">
    
    <form name="formulario_fase_grupo" method="post" action="" id="formulario_fase_grupo">
        
     <table id="equipos_grupo_a">
         
       <th id="titulo_grupo_a" colspan="6">         
             <p>Grupo A</p>           
        </th>
        
        <tr id="a_partido_1">
        
            <td><p class="informacion"><strong>RUSSIA</strong></p></td>
            <td><img src="equipos mundial/png/012-russia.png" class="imagen"></td>
            <td><input type="text" name="1" id="a_local_1" class="cuadro" value="<?php echo $indice1s ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="2" id="a_visitante_1" class="cuadro" value="<?php echo $indice2s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/013-saudi-arabia.png" class="imagen"></td>
            <td><p class="informacion"><strong>ARABIA <br> SAUDITA</strong></p></td>
         
         </tr>
         
         <tr id="a_partido_2">
        
            <td><p class="informacion"><strong>EGIPTO</strong></p></td>
            <td><img src="equipos mundial/png/005-egypt.png" class="imagen"></td>
            <td><input type="text" name="3" id="a_local_2" class="cuadro" value="<?php echo $indice3s ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="4" id="a_visitante_2" class="cuadro" value="<?php echo $indice4s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/023-uruguay.png" class="imagen"></td>
            <td><p class="informacion"><strong>URUGUAY</strong></p></td>
         
         </tr>
         
         <tr id="a_partido_3">
        
            <td><p class="informacion"><strong>RUSSIA</strong></p></td>
            <td><img src="equipos mundial/png/012-russia.png" class="imagen"></td>
            <td><input type="text" name="5" id="a_local_3" class="cuadro" value="<?php echo $indice5s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="6" id="a_visitante_3" class="cuadro" value="<?php echo $indice6s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/005-egypt.png" class="imagen"></td>
            <td><p class="informacion"><strong>EGIPTO</strong></p></td>
         
         </tr>
         
         <tr id="a_partido_4">
        
            <td><p class="informacion"><strong>URUGUAY</p></td>
            <td><img src="equipos mundial/png/023-uruguay.png" class="imagen"></td>
            <td><input type="text" name="7" id="a_local_4" class="cuadro" value="<?php echo $indice7s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="8" id="a_visitante_4" class="cuadro" value="<?php echo $indice8s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/013-saudi-arabia.png" class="imagen"></td>
            <td><p class="informacion"><strong>ARABIA <br> SAUDITA</strong></p></td>
         
         </tr>
         
         <tr id="a_partido_5">
        
            <td><p class="informacion"><strong>ARABIA <br> SAUDITA</strong></p></td>
            <td><img src="equipos mundial/png/013-saudi-arabia.png" class="imagen"></td>
            <td><input type="text" name="9" id="a_local_5" class="cuadro" value="<?php echo $indice9s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="10" id="a_visitante_5" class="cuadro" value="<?php echo $indice10s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/005-egypt.png" class="imagen"></td>
            <td><p class="informacion"><strong>EGIPTO</strong></p></td>
         
         </tr>
         
         <tr id="a_partido_6">
        
            <td><p class="informacion"><strong>URUGUAY</strong></p></td>
            <td><img src="equipos mundial/png/023-uruguay.png" class="imagen"></td>
            <td><input type="text" name="11" id="a_local_6" class="cuadro" value="<?php echo $indice11s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="12" id="a_visitante_6" class="cuadro" value="<?php echo $indice12s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/012-russia.png" class="imagen"></td>
            <td><p class="informacion"><strong>RUSIA</strong></p></td>
         
         </tr>
        
        </table>      
        
         
    </div>
  
  <div id="grupo_b">
    
   
        
     <table id="equipos_grupo_b">
         
       <th id="titulo_grupo_b" colspan="6">         
             <p>Grupo B</p>           
        </th>
        
        <tr id="b_partido_1">
        
            <td><p class="informacion"><strong>MARRUECOS</strong></p></td>
            <td><img src="equipos mundial/png/019-morocco.png" class="imagen"></td>
            <td><input type="text" name="13" id="b_local_1" class="cuadro" value="<?php echo $indice13s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="14" id="b_visitante_1" class="cuadro" value="<?php echo $indice14s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/028-iran.png" class="imagen"></td>
            <td><p class="informacion"><strong>IRÁN</strong></p></td>
         
         </tr>
         
         <tr id="b_partido_2">
        
            <td><p class="informacion"><strong>PORTUGAL</strong></p></td>
            <td><img src="equipos mundial/png/011-portugal.png" class="imagen"></td>
            <td><input type="text" name="15" id="b_local_2" class="cuadro" value="<?php echo $indice15s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="16" id="b_visitante_2" class="cuadro" value="<?php echo $indice16s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/015-spain.png" class="imagen"></td>
            <td><p class="informacion"><strong>ESPAÑA</strong></p></td>
         
         </tr>
         
         <tr id="b_partido_3">
        
            <td><p class="informacion"><strong>PORTUGAL</strong></p></td>
            <td><img src="equipos mundial/png/011-portugal.png" class="imagen"></td>
            <td><input type="text" name="17" id="b_local_3" class="cuadro" value="<?php echo $indice17s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="18" id="b_visitante_3" class="cuadro" value="<?php echo $indice18s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/019-morocco.png" class="imagen"></td>
            <td><p class="informacion"><strong>MARRUECOS</strong></p></td>
         
         </tr>
         
         <tr id="b_partido_4">
        
            <td><p class="informacion"><strong>IRÁN</p></td>
            <td><img src="equipos mundial/png/028-iran.png" class="imagen"></td>
            <td><input type="text" name="19" id="b_local_4" class="cuadro" value="<?php echo $indice19s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="20" id="b_visitante_4" class="cuadro" value="<?php echo $indice20s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/015-spain.png" class="imagen"></td>
            <td><p class="informacion"><strong>ESPAÑA</strong></p></td>
         
         </tr>
         
         <tr id="b_partido_5">
        
            <td><p class="informacion"><strong>ESPAÑA</strong></p></td>
            <td><img src="equipos mundial/png/015-spain.png" class="imagen"></td>
            <td><input type="text" name="21" id="b_local_5" class="cuadro" value="<?php echo $indice21s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="22" id="b_visitante_5" class="cuadro" value="<?php echo $indice22s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/019-morocco.png" class="imagen"></td>
            <td><p class="informacion"><strong>MARRUECOS</strong></p></td>
         
         </tr>
         
         <tr id="b_partido_6">
        
            <td><p class="informacion"><strong>IRÁN</strong></p></td>
            <td><img src="equipos mundial/png/028-iran.png" class="imagen"></td>
            <td><input type="text" name="23" id="b_local_6" class="cuadro" value="<?php echo $indice23s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="24" id="b_visitante_6" class="cuadro" value="<?php echo $indice24s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/011-portugal.png" class="imagen"></td>
            <td><p class="informacion"><strong>PORTUGAL</strong></p></td>
         
         </tr>
        
        </table>   
        
    </div>
  
  <div id="grupo_c">
    
     <table id="equipos_grupo_c">
         
       <th id="titulo_grupo_c" colspan="6">         
             <p>Grupo C</p>           
        </th>
        
        <tr id="c_partido_1">
        
            <td><p class="informacion"><strong>FRANCIA</strong></p></td>
            <td><img src="equipos mundial/png/007-france.png" class="imagen"></td>
            <td><input type="text" name="25" id="c_local_1" class="cuadro" value="<?php echo $indice25s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="26" id="c_visitante_1" class="cuadro" value="<?php echo $indice26s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/024-australia.png" class="imagen"></td>
            <td><p class="informacion"><strong>AUSTRALIA</strong></p></td>
         
         </tr>
         
         <tr id="c_partido_2">
        
            <td><p class="informacion"><strong>PERU</strong></p></td>
            <td><img src="equipos mundial/png/032-peru.png" class="imagen"></td>
            <td><input type="text" name="27" id="c_local_2" class="cuadro" value="<?php echo $indice27s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="28" id="c_visitante_2" class="cuadro" value="<?php echo $indice28s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/004-denmark.png" class="imagen"></td>
            <td><p class="informacion"><strong>DINAMARCA</strong></p></td>
         
         </tr>
         
         <tr id="c_partido_3">
        
            <td><p class="informacion"><strong>FRANCIA</strong></p></td>
            <td><img src="equipos mundial/png/007-france.png" class="imagen"></td>
            <td><input type="text" name="29" id="c_local_3" class="cuadro" value="<?php echo $indice29s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="30" id="c_visitante_3" class="cuadro" value="<?php echo $indice30s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/032-peru.png" class="imagen"></td>
            <td><p class="informacion"><strong>PERU</strong></p></td>
         
         </tr>
         
         <tr id="c_partido_4">
        
            <td><p class="informacion"><strong>DINAMARCA</p></td>
            <td><img src="equipos mundial/png/004-denmark.png" class="imagen"></td>
            <td><input type="text" name="31" id="c_local_4" class="cuadro" value="<?php echo $indice31s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="32" id="c_visitante_4" class="cuadro" value="<?php echo $indice32s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/024-australia.png" class="imagen"></td>
            <td><p class="informacion"><strong>AUSTRALIA</strong></p></td>
         
         </tr>
         
         <tr id="c_partido_5">
        
            <td><p class="informacion"><strong>AUSTRALIA</strong></p></td>
            <td><img src="equipos mundial/png/024-australia.png"  class="imagen"></td>
            <td><input type="text" name="33" id="c_local_5" class="cuadro" value="<?php echo $indice33s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="34" id="c_visitante_5" class="cuadro" value="<?php echo $indice34s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/032-peru.png" class="imagen"></td>
            <td><p class="informacion"><strong>PERU</strong></p></td>
         
         </tr>
         
         <tr id="c_partido_6">
        
            <td><p class="informacion"><strong>DINAMARCA</strong></p></td>
            <td><img src="equipos mundial/png/004-denmark.png" class="imagen"></td>
            <td><input type="text" name="35" id="c_local_6" class="cuadro" value="<?php echo $indice35s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="36" id="c_visitante_6" class="cuadro" value="<?php echo $indice36s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/007-france.png" class="imagen"></td>
            <td><p class="informacion"><strong>FRANCIA</strong></p></td>
         
         </tr>
        
        </table>   
        
    </div>
    
    <div id="grupo_d">
    
     <table id="equipos_grupo_d">
         
       <th id="titulo_grupo_d" colspan="6">         
             <p>Grupo D</p>           
        </th>
        
        <tr id="d_partido_1">
        
            <td><p class="informacion"><strong>ARGENTINA</strong></p></td>
            <td><img src="equipos mundial/png/001-argentina.png" class="imagen"></td>
            <td><input type="text" name="37" id="d_local_1" class="cuadro" value="<?php echo $indice37s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="38" id="d_visitante_1" class="cuadro" value="<?php echo $indice38s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/027-iceland.png" class="imagen"></td>
            <td><p class="informacion"><strong>ISLANDIA</strong></p></td>
         
         </tr>
         
         <tr id="d_partido_2">
        
            <td><p class="informacion"><strong>CROACIA</strong></p></td>
            <td><img src="equipos mundial/png/003-croatia.png" class="imagen"></td>
            <td><input type="text" name="39" id="d_local_2" class="cuadro" value="<?php echo $indice39s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="40" id="d_visitante_2" class="cuadro" value="<?php echo $indice40s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/029-nigeria.png" class="imagen"></td>
            <td><p class="informacion"><strong>NIGERIA</strong></p></td>
         
         </tr>
         
         <tr id="d_partido_3">
        
            <td><p class="informacion"><strong>ARGENTINA</strong></p></td>
            <td><img src="equipos mundial/png/001-argentina.png" class="imagen"></td>
            <td><input type="text" name="41" id="d_local_3" class="cuadro" value="<?php echo $indice41s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="42" id="d_visitante_3" class="cuadro" value="<?php echo $indice42s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/003-croatia.png" class="imagen"></td>
            <td><p class="informacion"><strong>CROACIA</strong></p></td>
         
         </tr>
         
         <tr id="d_partido_4">
        
            <td><p class="informacion"><strong>NIGERIA</p></td>
            <td><img src="equipos mundial/png/029-nigeria.png" class="imagen"></td>
            <td><input type="text" name="43" id="d_local_4" class="cuadro" value="<?php echo $indice43s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="44" id="d_visitante_4" class="cuadro" value="<?php echo $indice44s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/027-iceland.png" class="imagen"></td>
            <td><p class="informacion"><strong>ISLANDIA</strong></p></td>
         
         </tr>
         
         <tr id="d_partido_5">
        
            <td><p class="informacion"><strong>ISLANDIA</strong></p></td>
            <td><img src="equipos mundial/png/027-iceland.png" class="imagen"></td>
            <td><input type="text" name="45" id="d_local_5" class="cuadro" value="<?php echo $indice45s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="46" id="d_visitante_5" class="cuadro" value="<?php echo $indice46s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/003-croatia.png" class="imagen"></td>
            <td><p class="informacion"><strong>CROACIA</strong></p></td>
         
         </tr>
         
         <tr id="d_partido_6">
        
            <td><p class="informacion"><strong>NIGERIA</strong></p></td>
            <td><img src="equipos mundial/png/029-nigeria.png" class="imagen"></td>
            <td><input type="text" name="47" id="d_local_6" class="cuadro" value="<?php echo $indice47s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="48" id="d_visitante_6" class="cuadro" value="<?php echo $indice48s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/001-argentina.png" class="imagen"></td>
            <td><p class="informacion"><strong>ARGENTINA</strong></p></td>
         
         </tr>
        
        </table>           
  
  		</div>
   
    </div>
 
 <div id="col2">
  <div id="grupo_e">
    
    
     <table id="equipos_grupo_e">
         
       <th id="titulo_grupo_e" colspan="6">         
             <p>Grupo E</p>           
        </th>
        
        <tr id="e_partido_1">
        
            <td><p class="informacion"><strong>COSTA <br> RICA</strong></p></td>
            <td><img src="equipos mundial/png/026-costa-rica.png" class="imagen"></td>
            <td><input type="text" name="49" id="e_local_1" class="cuadro" value="<?php echo $indice49s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="50" id="e_visitante_1" class="cuadro" value="<?php echo $indice50s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/021-serbia.png" class="imagen"></td>
            <td><p class="informacion"><strong>SERBIA</strong></p></td>
         
         </tr>
         
         <tr id="e_partido_2">
        
            <td><p class="informacion"><strong>BRASIL</strong></p></td>
            <td><img src="equipos mundial/png/017-brazil.png" class="imagen"></td>
            <td><input type="text" name="51" id="e_local_2" class="cuadro" value="<?php echo $indice51s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="52" id="e_visitante_2" class="cuadro" value="<?php echo $indice52s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/031-switzerland.png" class="imagen"></td>
            <td><p class="informacion"><strong>SUIZA</strong></p></td>
         
         </tr>
         
         <tr id="e_partido_3">
        
            <td><p class="informacion"><strong>BRASIL</strong></p></td>
            <td><img src="equipos mundial/png/017-brazil.png" class="imagen"></td>
            <td><input type="text" name="53" id="e_local_3" class="cuadro" value="<?php echo $indice53s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="54" id="e_visitante_3" class="cuadro" value="<?php echo $indice54s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/026-costa-rica.png" class="imagen"></td>
            <td><p class="informacion"><strong>COSTA <br> RICA</strong></p></td>
         
         </tr>
         
         <tr id="e_partido_4">
        
            <td><p class="informacion"><strong>SERBIA</p></td>
            <td><img src="equipos mundial/png/021-serbia.png"  class="imagen"></td>
            <td><input type="text" name="55" id="e_local_4" class="cuadro" value="<?php echo $indice55s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="56" id="e_visitante_4" class="cuadro" value="<?php echo $indice56s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/031-switzerland.png" class="imagen"></td>
            <td><p class="informacion"><strong>SUIZA</strong></p></td>
         
         </tr>
         
         <tr id="e_partido_5">
        
            <td><p class="informacion"><strong>SUIZA</strong></p></td>
            <td><img src="equipos mundial/png/031-switzerland.png" class="imagen"></td>
            <td><input type="text" name="57" id="e_local_5" class="cuadro" value="<?php echo $indice57s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="58" id="e_visitante_5" class="cuadro" value="<?php echo $indice58s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/026-costa-rica.png" class="imagen"></td>
            <td><p class="informacion"><strong>COSTA <br> RICA</strong></p></td>
         
         </tr>
         
         <tr id="e_partido_6">
        
            <td><p class="informacion"><strong>SERBIA</strong></p></td>
            <td><img src="equipos mundial/png/021-serbia.png" class="imagen"></td>
            <td><input type="text" name="59" id="e_local_6" class="cuadro" value="<?php echo $indice59s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="60" id="e_visitante_6" class="cuadro" value="<?php echo $indice60s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/017-brazil.png"  class="imagen"></td>
            <td><p class="informacion"><strong>BRASIL</strong></p></td>
         
         </tr>
        
        </table>   
        
    </div>
    
    <div id="grupo_f">
    
    
     <table id="equipos_grupo_f">
         
       <th id="titulo_grupo_f" colspan="6">         
             <p>Grupo F</p>           
        </th>
        
        <tr id="f_partido_1">
        
            <td><p class="informacion"><strong>ALEMANIA</strong></p></td>
            <td><img src="equipos mundial/png/008-germany.png" class="imagen"></td>
            <td><input type="text" name="61" id="f_local_1" class="cuadro" value="<?php echo $indice61s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="62" id="f_visitante_1" class="cuadro" value="<?php echo $indice62s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/018-mexico.png" class="imagen"></td>
            <td><p class="informacion"><strong>MEXICO</strong></p></td>
         
         </tr>
         
         <tr id="f_partido_2">
        
            <td><p class="informacion"><strong>SUECIA</strong></p></td>
            <td><img src="equipos mundial/png/016-sweden.png" class="imagen"></td>
            <td><input type="text" name="63" id="f_local_2" class="cuadro" value="<?php echo $indice63s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="64" id="f_visitante_2" class="cuadro" value="<?php echo $indice64s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/030-south-korea.png" class="imagen"></td>
            <td><p class="informacion"><strong>COREA DEL <br> SUR</strong></p></td>
         
         </tr>
         
         <tr id="f_partido_3">
        
            <td><p class="informacion"><strong>ALEMANIA</strong></p></td>
            <td><img src="equipos mundial/png/008-germany.png" class="imagen"></td>
            <td><input type="text" name="65" id="f_local_3" class="cuadro" value="<?php echo $indice65s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="66" id="f_visitante_3" class="cuadro" value="<?php echo $indice66s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/016-sweden.png" class="imagen"></td>
            <td><p class="informacion"><strong>SUECIA</strong></p></td>
         
         </tr>
         
         <tr id="f_partido_4">
        
            <td><p class="informacion"><strong>COREA DEL <br> SUR</p></td>
            <td><img src="equipos mundial/png/030-south-korea.png" class="imagen"></td>
            <td><input type="text" name="67" id="f_local_4" class="cuadro" value="<?php echo $indice67s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="68" id="f_visitante_4" class="cuadro" value="<?php echo $indice68s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/018-mexico.png" class="imagen"></td>
            <td><p class="informacion"><strong>MEXICO</strong></p></td>
         
         </tr>
         
         <tr id="f_partido_5">
        
            <td><p class="informacion"><strong>MEXICO</strong></p></td>
            <td><img src="equipos mundial/png/018-mexico.png" class="imagen"></td>
            <td><input type="text" name="69" id="f_local_5" class="cuadro" value="<?php echo $indice69s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="70" id="f_visitante_5" class="cuadro" value="<?php echo $indice70s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/016-sweden.png" class="imagen"></td>
            <td><p class="informacion"><strong>SUECIA</strong></p></td>
         
         </tr>
         
         <tr id="f_partido_6">
        
            <td><p class="informacion"><strong>COREA DEL <br> SUR</strong></p></td>
            <td><img src="equipos mundial/png/030-south-korea.png" class="imagen"></td>
            <td><input type="text" name="71" id="f_local_6" class="cuadro" value="<?php echo $indice71s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="72" id="f_visitante_6" class="cuadro" value="<?php echo $indice72s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/008-germany.png" class="imagen"></td>
            <td><p class="informacion"><strong>ALEMANIA</strong></p></td>
         
         </tr>
        
        </table>   
        
    </div>
    
    <div id="grupo_g">
    
    
     <table id="equipos_grupo_g">
         
       <th id="titulo_grupo_g" colspan="6">         
             <p>Grupo G</p>           
        </th>
        
        <tr id="g_partido_1">
        
            <td><p class="informacion"><strong>BÉLGICA</strong></p></td>
            <td><img src="equipos mundial/png/002-belgium.png" class="imagen"></td>
            <td><input type="text" name="73" id="g_local_1" class="cuadro" value="<?php echo $indice73s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="74" id="g_visitante_1" class="cuadro" value="<?php echo $indice74s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/020-panama.png" class="imagen"></td>
            <td><p class="informacion"><strong>PÁNAMA</strong></p></td>
         
         </tr>
         
         <tr id="g_partido_2">
        
            <td><p class="informacion"><strong>TÚNEZ</strong></p></td>
            <td><img src="equipos mundial/png/022-turkey.png" class="imagen"></td>
            <td><input type="text" name="75" id="g_local_2" class="cuadro" value="<?php echo $indice75s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="76" id="g_visitante_2" class="cuadro" value="<?php echo $indice76s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/006-england.png" class="imagen"></td>
            <td><p class="informacion"><strong>INGLATERRA</strong></p></td>
         
         </tr>
         
         <tr id="g_partido_3">
        
            <td><p class="informacion"><strong>BÉLGICA</strong></p></td>
            <td><img src="equipos mundial/png/002-belgium.png" class="imagen"></td>
            <td><input type="text" name="77" id="g_local_3" class="cuadro" value="<?php echo $indice77s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="78" id="g_visitante_3" class="cuadro" value="<?php echo $indice78s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/022-turkey.png" class="imagen"></td>
            <td><p class="informacion"><strong>TÚNEZ</strong></p></td>
         
         </tr>
         
         <tr id="g_partido_4">
        
            <td><p class="informacion"><strong>INGLATERRA</p></td>
            <td><img src="equipos mundial/png/006-england.png" class="imagen"></td>
            <td><input type="text" name="79" id="g_local_4" class="cuadro" value="<?php echo $indice79s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="80" id="g_visitante_4" class="cuadro" value="<?php echo $indice80s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/020-panama.png" class="imagen"></td>
            <td><p class="informacion"><strong>PÁNAMA</strong></p></td>
         
         </tr>
         
         <tr id="g_partido_5">
        
            <td><p class="informacion"><strong>PÁNAMA</strong></p></td>
            <td><img src="equipos mundial/png/020-panama.png" class="imagen"></td>
            <td><input type="text" name="81" id="g_local_5" class="cuadro" value="<?php echo $indice81s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="82" id="g_visitante_5" class="cuadro" value="<?php echo $indice82s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/022-turkey.png" class="imagen"></td>
            <td><p class="informacion"><strong>TÚNEZ</strong></p></td>
         
         </tr>
         
         <tr id="g_partido_6">
        
            <td><p class="informacion"><strong>INGLATERRA</strong></p></td>
            <td><img src="equipos mundial/png/006-england.png" class="imagen"></td>
            <td><input type="text" name="83" id="g_local_6" class="cuadro" value="<?php echo $indice83s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="84" id="g_visitante_6" class="cuadro" value="<?php echo $indice84s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/002-belgium.png" class="imagen"></td>
            <td><p class="informacion"><strong>BÉLGICA</strong></p></td>
         
         </tr>
        
        </table>   
        
    </div>
    
    <div id="grupo_h">
    
    
     <table id="equipos_grupo_h">
         
       <th id="titulo_grupo_h" colspan="6">         
             <p>Grupo H</p>           
        </th>
        
        <tr id="h_partido_1">
        
            <td><p class="informacion"><strong>POLONIA</strong></p></td>
            <td><img src="equipos mundial/png/010-poland.png" class="imagen"></td>
            <td><input type="text" name="85" id="h_local_1" class="cuadro" value="<?php echo $indice85s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="86" id="h_visitante_1" class="cuadro" value="<?php echo $indice86s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/014-senegal.png" class="imagen"></td>
            <td><p class="informacion"><strong>SENEGAL</strong></p></td>

         
         </tr>
         
         <tr id="h_partido_2">
        
            <td><p class="informacion"><strong>COLOMBIA</strong></p></td>
            <td><img src="equipos mundial/png/025-colombia.png" class="imagen"></td>
            <td><input type="text" name="87" id="h_local_2" class="cuadro" value="<?php echo $indice87s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="88" id="h_visitante_2" class="cuadro" value="<?php echo $indice88s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/009-japan.png" class="imagen"></td>
            <td><p class="informacion"><strong>JAPÓN</strong></p></td>
         
         </tr>
         
         <tr id="h_partido_3">
        
            <td><p class="informacion"><strong>JAPÓN</strong></p></td>
            <td><img src="equipos mundial/png/009-japan.png" class="imagen"></td>
            <td><input type="text" name="89" id="h_local_3" class="cuadro" value="<?php echo $indice89s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="90" id="h_visitante_3" class="cuadro" value="<?php echo $indice90s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/014-senegal.png" class="imagen"></td>
            <td><p class="informacion"><strong>SENEGAL</strong></p></td>
         
         </tr>
         
         <tr id="h_partido_4">
        
            <td><p class="informacion"><strong>POLONIA</p></td>
            <td><img src="equipos mundial/png/010-poland.png" class="imagen"></td>
            <td><input type="text" name="91" id="h_local_4" class="cuadro" value="<?php echo $indice91s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="92" id="h_visitante_4" class="cuadro" value="<?php echo $indice92s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/025-colombia.png" class="imagen"></td>
            <td><p class="informacion"><strong>COLOMBIA</strong></p></td>
         
         </tr>
         
         <tr id="h_partido_5">
        
            <td><p class="informacion"><strong>SENEGAL</strong></p></td>
            <td><img src="equipos mundial/png/014-senegal.png" class="imagen"></td>
            <td><input type="text" name="93" id="h_local_5" class="cuadro" value="<?php echo $indice93s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="94" id="h_visitante_5" class="cuadro" value="<?php echo $indice94s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/025-colombia.png" class="imagen"></td>
            <td><p class="informacion"><strong>COLOMBIA</strong></p></td>
         
         </tr>
         
         <tr id="h_partido_6">
        
            <td><p class="informacion"><strong>JAPÓN</strong></p></td>
            <td><img src="equipos mundial/png/009-japan.png" class="imagen"></td>
            <td><input type="text" name="95" id="h_local_6" class="cuadro" value="<?php echo $indice95s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><input type="text" name="96" id="h_visitante_6" class="cuadro" value="<?php echo $indice96s  ?>" onkeypress="return isNumberKey(this);" disabled></td>
            <td><img src="equipos mundial/png/010-poland.png" class="imagen"></td>
            <td><p class="informacion"><strong>POLONIA</strong></p></td>
         
         </tr>
        
        </table>   
       
    
    </div>
    
 <!-- ---------------------------------------------cuadro de octavos de final ----------------------------------------------------- -->
   
   </div> 
   
  <div id="cuadro_eliminatoria">
  
   <table id="eliminatoria">
    
    <th class="titulo" colspan="24"><p class="parrafo">ELIMINATORIAS MUNDIAL RUSSIA 2018</p></th>
    <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
      <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    </tr>

    <tr>
    
   <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[0] ?></strong></p></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[0];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="97"  class="cuadro" value="<?php echo $indice97s  ?>" disabled onkeypress="return isNumberKey(this);"></td> 
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
      <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td class="colum2"><input type="text" name="105"  class="cuadro" value="<?php echo $indice105s  ?>" disabled onkeypress="return isNumberKey(this);"></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[8];?>" class="imagen"></td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[8] ?></strong></p></td> 
      
  
    </tr>
    
     <tr>
    <td>&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td>&nbsp;</td>
   <td class="colum1"><p class="informacion1"><strong><?php echo $paises_cuartos[0] ?></strong></p></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_cuartos[0];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="113"  class="cuadro" value="<?php echo $indice113s  ?>" disabled onkeypress="return isNumberKey(this);"></td>  
    
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    
    <td class="colum2"><input type="text" name="117"  class="cuadro" value="<?php echo $indice117s  ?>" disabled onkeypress="return isNumberKey(this);"></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_cuartos[4];?>" class="imagen"></td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_cuartos[4] ?></strong></p></td>
  <td>&nbsp;</td>
     <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    </tr> 
    
    
    
    <tr>
    
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[1] ?></strong></p></td>    
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[1];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="98"  class="cuadro" value="<?php echo $indice98s  ?>" disabled onkeypress="return isNumberKey(this);"></td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
   <td class="colum2"><input type="text" name="106"  class="cuadro" value="<?php echo $indice106s  ?>" disabled onkeypress="return isNumberKey(this);"></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[9];?>" class="imagen"></td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[9] ?></strong></p></td> 
    
    </tr>
    
    <tr>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>       
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_semi[0] ?></strong></p></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_semi[0];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="121"  class="cuadro" value="<?php echo $indice121s  ?>" disabled onkeypress="return isNumberKey(this);"></td> 
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td colspan="2" rowspan="4"><img id="copa" src="imagenes/copa_del_mundo.png" class="copa"></td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td class="colum2"><input type="text" name="123"  class="cuadro" value="<?php echo $indice123s  ?>" disabled onkeypress="return isNumberKey(this);"></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_semi[2];?>" class="imagen"></td>  
    <td  class="colum1"><p class="informacion1"><strong><?php echo $paises_semi[2] ?></strong></p></td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    </tr> 
    
    <tr>
    
   <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[2] ?></strong></p></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[2];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="99"  class="cuadro" value="<?php echo $indice99s  ?>" disabled onkeypress="return isNumberKey(this);"></td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td class="colum2"><input type="text" name="107"  class="cuadro" value="<?php echo $indice107s  ?>" disabled onkeypress="return isNumberKey(this);"></td>    
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[10];?>" class="imagen"></td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[10] ?></strong></p></td>
    
    </tr>
    
     <tr>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td>&nbsp;</td>
     <td class="colum1"><p class="informacion1"><strong><?php echo $paises_cuartos[1] ?></strong></p></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_cuartos[1];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="114"  class="cuadro" value="<?php echo $indice114s  ?>" disabled onkeypress="return isNumberKey(this);"></td> 
    
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    
    <td class="colum2"><input type="text" name="118"  class="cuadro" value="<?php echo $indice118s  ?>" disabled onkeypress="return isNumberKey(this);"></td>  
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_cuartos[5];?>" class="imagen"></td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_cuartos[5] ?></strong></p></td> 
    <td>&nbsp;</td>  
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td>&nbsp;</td>
    </tr> 
    
    <tr>
    
   <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[3] ?></strong></p></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[3];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="100"  class="cuadro" value="<?php echo $indice100s  ?>" disabled onkeypress="return isNumberKey(this);"></td> 
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td class="colum2"><input type="text" name="108"  class="cuadro" value="<?php echo $indice108s  ?>" disabled onkeypress="return isNumberKey(this);"></td>    
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[11];?>" class="imagen"></td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[11] ?></strong></p></td>
    
   
    </tr>
    
     <tr>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     
     
     <td colspan="2"><p class="final"><strong>Gran Final</strong></p></td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>   
   
    <td>&nbsp;</td>
     <td>&nbsp;</td>          
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td >&nbsp;</td>
    
    </tr> 
    
    
     
    <tr>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td class="colum1"><p class="informacion1"><strong><?php echo $paises_final[2] ?></strong></p></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_final[2];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="127"  class="cuadro" value="<?php echo $indice127s  ?>" disabled onkeypress="return isNumberKey(this);"></td> 
    <td>&nbsp;</td>
    <td>&nbsp;</td>
   
     <td class="colum2"><input type="text" name="128"  class="cuadro" value="<?php echo $indice128s  ?>" disabled onkeypress="return isNumberKey(this);"></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_final[3];?>" class="imagen"></td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_final[3] ?></strong></p></td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td >&nbsp;</td>
     <td >&nbsp;</td>
     <td >&nbsp;</td>
    
    </tr>   
    
    
     <tr>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
       <td>&nbsp;</td>
        <td>&nbsp;</td>     
     <td colspan="2"><p class="final"><strong>Campeon</strong><br><img id="campeon" src="/intranet/uploads/<?php echo $logo_campeon;?>" class="imagen_campeon"></p></td>
     
    <td>&nbsp;</td>
     <td>&nbsp;</td>          
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td >&nbsp;</td>
     <td >&nbsp;</td>
     <td >&nbsp;</td>
    
    </tr> 
    
    
    
    <tr>
   <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[4] ?></strong></p></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[4];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="101"  class="cuadro" value="<?php echo $indice101s  ?>" disabled onkeypress="return isNumberKey(this);"></td>
   	<td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
   <td class="colum2"><input type="text" name="109"  class="cuadro" value="<?php echo $indice109s  ?>" disabled onkeypress="return isNumberKey(this);"></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[12];?>" class="imagen"></td>
     <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[12] ?></strong></p></td>
    </tr>
    
     <tr>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td>&nbsp;</td>
        <td>&nbsp;</td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_cuartos[2] ?></strong></p></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_cuartos[2];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="115"  class="cuadro" value="<?php echo $indice115s  ?>" disabled onkeypress="return isNumberKey(this);"></td> 
 
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    
     <td class="colum2"><input type="text" name="119"  class="cuadro" value="<?php echo $indice119s  ?>" disabled onkeypress="return isNumberKey(this);"></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_cuartos[6];?>" class="imagen"></td>  
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_cuartos[6] ?></strong></p></td>
   <td>&nbsp;</td>
     <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    </tr> 
    
    <tr>
    
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[5] ?></strong></p></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[5];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="102"  class="cuadro" value="<?php echo $indice102s  ?>" disabled onkeypress="return isNumberKey(this);"></td>
   <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td class="colum2"><input type="text" name="110"  class="cuadro" value="<?php echo $indice110s  ?>" disabled onkeypress="return isNumberKey(this);"></td> 
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[13];?>" class="imagen"></td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[13] ?></strong></p></td>
    
    </tr>
    
     
    <tr>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_semi[1] ?></strong></p></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_semi[1];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="122"  class="cuadro" value="<?php echo $indice122s  ?>" disabled onkeypress="return isNumberKey(this);"></td>   
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
	 <td class="colum2"><input type="text" name="124"  class="cuadro" value="<?php echo $indice124s  ?>" disabled onkeypress="return isNumberKey(this);"></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_semi[3];?>" class="imagen"></td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_semi[3] ?></strong></p></td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>    
     <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
     
    </tr> 
    
    <tr>
    
     <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[6] ?></strong></p></td>    
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[6];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="103"  class="cuadro" value="<?php echo $indice103s  ?>" disabled onkeypress="return isNumberKey(this);"></td>  
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td class="colum2"><input type="text" name="111"  class="cuadro" value="<?php echo $indice111s  ?>" disabled onkeypress="return isNumberKey(this);"></td>   
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[14];?>" class="imagen"></td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[14] ?></strong></p></td> 
       
    </tr>
    
     <tr>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
     <td>&nbsp;</td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_cuartos[3] ?></strong></p></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_cuartos[3];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="116"  class="cuadro" value="<?php echo $indice116s  ?>" disabled onkeypress="return isNumberKey(this);"></td>   
   
    <td>&nbsp;</td>
     <td>&nbsp;</td>
      <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
   
    <td class="colum2"><input type="text" name="120"  class="cuadro" value="<?php echo $indice120s  ?>" disabled onkeypress="return isNumberKey(this);"></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_cuartos[7];?>" class="imagen"></td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_cuartos[7] ?></strong></p></td>
     <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    </tr> 
    
    <tr>
    
   <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[7] ?></strong></p></td>    
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[7];?>" class="imagen"></td>
    <td class="colum2"><input type="text" name="104"  class="cuadro" value="<?php echo $indice104s  ?>" disabled onkeypress="return isNumberKey(this);"></td> 
   <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td class="colum2"><input type="text" name="112"  class="cuadro" value="<?php echo $indice112s  ?>" disabled onkeypress="return isNumberKey(this);"></td>       
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo[15];?>" class="imagen"></td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_octavos[15] ?></strong></p></td> 
   
    </tr>
    
    <tr>
    <td >&nbsp;</td>
    <td>&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
     <td>&nbsp;</td>
      <td>&nbsp;</td>
     <td colspan="2"><p class="final"><strong>3er Lugar</strong></p></td>
    
   
    <td>&nbsp;</td>
     <td>&nbsp;</td>          
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td >&nbsp;</td>
     <td >&nbsp;</td>
     <td >&nbsp;</td>
    
    </tr> 
    
    <tr>
    
   <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>    
   <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_final[0] ?></strong></p></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_final[0];?>" class="imagen"></td> 
    <td class="colum2"><input type="text" name="125"  class="cuadro" value="<?php echo $indice125s  ?>" disabled onkeypress="return isNumberKey(this);"></td>  
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td class="colum2"><input type="text" name="126"  class="cuadro" value="<?php echo $indice126s  ?>" disabled onkeypress="return isNumberKey(this);"></td>
    <td class="colum1"><img src="/intranet/uploads/<?php echo $logo_final[1] ;?>" class="imagen"></td>
    <td class="colum1"><p class="informacion1"><strong><?php echo $paises_final[1] ?></strong></p></td>
    
    <td>&nbsp;</td>
    <td>&nbsp;</td>
     <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
   
    </tr>
</table>
  




   </form>
   
</div>



</section>
</body>
</html>
