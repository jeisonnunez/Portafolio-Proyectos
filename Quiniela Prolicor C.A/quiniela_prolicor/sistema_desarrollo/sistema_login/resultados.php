<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Documento sin título</title>
<link rel="stylesheet" href="estilo_quiniela2.css">
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

	session_start();
	
	$_usuario=$_SESSION["usuario"];
	
	$_perfil=$_SESSION["perfil"];
	
	if(!isset($_SESSION["usuario"])){
		
		header("location:sistema_desarrollo/sistema_login/login_encriptado.php");			
		
	}
	
	if($_perfil!="usuario"){
		
		header("location:cierre.php");	
		
		
	}
	

?>

<header id="encabezado">

<div id="banner">

<img id="logo" src="imagenes/prolicor_logo1.png"><h1 id="titulo">QUINIELA PROLICOR NUBE AZUL</h1>  
 </div>
 
 <nav id="menu">
   		<ul>
             <li><a href="../../prueba_quiniela2.php">Mis Quinielas</a></li>
             <li><a href="resultados.php">Resultados</a></li>
             <li><a href="../../clasificacion_quinielas.php">Clasificacion</a></li>             
             <li><a href="">Pronosticador</a></li>
             <li><a href="cierre.php">Cerrar Sesion</a></li>
            
         </ul>
</nav>	
</header>

<p class='usuario'>Usuario: <?php echo $_SESSION["usuario"] ?> </p><br><br>


<?php

include("sistema_desarrollo/crud/conexion_crud.php");

?>	
		
     
<?php					
					
//----------------------------------------------------------Carga la quiniela ganadora-------------------------------------------					
		
						$suma_goles=0;		
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
							
						if($con<=48){
							
						$suma_goles=$suma_goles+${"indice".$i."s"}+${"indice".$j."s"};
						}
						
						$i=$i+2;
						$j=$j+2;	
						}
					
//--------------------------------------------------------actualiza valores en la base de datos-------------------------------------
						
	
//-------------------------------------------------------identifica los paises de cada grupo-----------------------------

if($suma_goles!=0){
			
	$grupo="A";
	
	for($w=1;$w<=8;$w++){
	
					$sql_equipos = $base->prepare("select distinct equipo_1 from quiniela_ganadora where grupo='$grupo'");						
					$sql_equipos->execute(array());
					$equipos_grupos = $sql_equipos->fetchAll();
					
					$i=1;
				
					foreach ($equipos_grupos as $paises) {
						
						${"pais".$i."s"}=$paises["equipo_1"];
						
						$i=$i+1;
						
						
					}
					
//------------------------------------------------------------------------recorre los partidos---------------------------------------
							
					
					$p1=0;
					$p2=0;
					$p3=0;
					$p4=0;
					$e=1;
					$g=3;
					$goles_anotados1=0;
					$goles_anotados2=0;
					$goles_anotados3=0;
					$goles_anotados4=0;					
					$goles_recibidos1=0;
					$goles_recibidos2=0;
					$goles_recibidos3=0;
					$goles_recibidos4=0;
					$diferencia_goles1;
					$diferencia_goles2;
					$diferencia_goles3;
					$diferencia_goles4;					
					
					$sql_partidos = $base->prepare("select equipo_1, valor_1, valor_2 from quiniela_ganadora where grupo='$grupo'");
						
					$sql_partidos->execute(array());
					$partidos = $sql_partidos->fetchAll();
					
				foreach ($partidos as $row) {
						
						$pais=$row["equipo_1"];
						$valor_1=$row["valor_1"];
						$valor_2=$row["valor_2"];
					
					for($j=1; $j<=4; $j++){
						
						if($pais==${"pais".$j."s"}){
							
							${"goles_anotados".$j}=${"goles_anotados".$j}+$valor_1;
							
							${"goles_recibidos".$j}=${"goles_recibidos".$j}+$valor_2;
							
							if($valor_1>$valor_2){
								
								${"p".$j}=${"p".$j}+$g;
								}
								
							if($valor_1==$valor_2){
								
								${"p".$j}=${"p".$j}+$e;
								}//fin if
							
						}//fin if						
					}//fin for
				}//fin foreach
//-------------------------------------------------------------segundo contador------------------------------------------------------	
			
				$sql_partidos1 = $base->prepare("select equipo_2, valor_1, valor_2 from quiniela_ganadora where grupo='$grupo'");
						
					$sql_partidos1->execute(array());
					$partidos1 = $sql_partidos1->fetchAll();
					
				foreach ($partidos1 as $row2) {
						
						$pais=$row2["equipo_2"];
						$valor_1=$row2["valor_1"];
						$valor_2=$row2["valor_2"];
					
					for($j=1; $j<=4; $j++){
						
						if($pais==${"pais".$j."s"}){
							
							${"goles_anotados".$j}=${"goles_anotados".$j}+$valor_2;
							
							${"goles_recibidos".$j}=${"goles_recibidos".$j}+$valor_1;
							
							if($valor_2>$valor_1){
								
								${"p".$j}=${"p".$j}+$g;
								}
								
							if($valor_2==$valor_1){
								
								${"p".$j}=${"p".$j}+$e;
								}//fin if
							
						}//fin if						
					}//fin for
				}//fin foreach*/
				
				$j=0;	
				
				for ($i=1;$i<=4;$i++){
				
				 ${"pais".$i."s"};				
				${"p".$i};
				 ${"goles_anotados".$i};
				 ${"goles_recibidos".$i};				
				${"diferencia_goles".$i}=${"goles_anotados".$i}-${"goles_recibidos".$i} ;
				
				}
				
				
 //---------------------------------------------------------------vector diferencia de goles-----------------------------------------
				
				 $diferencia_goles_array[0]=$diferencia_goles1.$pais1s;
				$diferencia_goles_array[1]=$diferencia_goles2.$pais2s;
				$diferencia_goles_array[2]=$diferencia_goles3.$pais3s;
				$diferencia_goles_array[3]=$diferencia_goles4.$pais4s;
				 
 
	//---------------------------------------------------------------vector goles marcados de goles----------------------------------
				
				 $goles_marcados_array[0]=$goles_anotados1.$pais1s;
				 $goles_marcados_array[1]=$goles_anotados2.$pais2s;
				 $goles_marcados_array[2]=$goles_anotados3.$pais3s;
				 $goles_marcados_array[3]=$goles_anotados4.$pais4s;
				 
 
//--------------------------------------------------------------------ordena por puntos--------------------------------------------------
				
				$clasificacion_puntos = array($pais1s=>$p1, $pais2s=>$p2, $pais3s=>$p3, $pais4s=>$p4);
				arsort($clasificacion_puntos,SORT_NUMERIC);					
				
				$i=0;
				
					foreach ($clasificacion_puntos as $pais=>$puntaje) {
												
						 $clasificacion_paises[$i]=$puntaje . $pais;							
						
						$i=$i+1;	
					}
					
				
//-------------------------------------------------------verifica si hay puntajes repetidos----------------------------------------------
					
				$arreglo=(array_count_values($clasificacion_puntos));
				
				$sw=0;

				foreach ($arreglo as $key => $val) {
				
					
					 if($val>1){
		
						 $sw=1; //variable usada para saber si hay puntajes repetidos
		
					 }
				}					
				
//----------------------------------------------------------------funcion repeticion-----------------------------------------------------	
	
	if($sw==1){				
				$k=1;
				$j=0;
				$d=0;
				
//------------------------------------------------------------------inicializar el vector------------------------------------------------

for($i=0;$i<=3;$i++){
	
	$primer[$i]="x";
	
	}				
				$segundo=array();
				
				for($i=0;$i<=3; $i++){
					
					if($i==0){
						
						$primer[$j]=$clasificacion_paises[$i];							
						
						}//end if
						else
						{
							
							if(intval($clasificacion_paises[$i])==intval($primer[$j])){
							
							$primer[$k]=$clasificacion_paises[$i];	
							$k=$k+1;
							
							}//end if
							else
							{								
									if($k==1){
										
										if($d==0){
										
										$segundo[$d]=$clasificacion_paises[$i];										
										$d=$d+1;
										
										}//end if
											else
												{
												
													if(intval($segundo[$j])==intval($clasificacion_paises[$i])){
														
														$segundo[$d]=$clasificacion_paises[$i];														
														$d=$d+1;
														
													}//end if												
												}//end else										
									}//end if									
							}//end else						
						}//end else											
					}//end for			
							
//------------------------------------------------------------desempates-------------------------------------------------------------				
			
			
			$clasificacion_final=array();		
						
			if ($primer[1]!="x"){//reviso si hay mas de un primer lugar

					$i=0;
					$k=0;
					$vector_desempate=array();				
				
					foreach ($primer as $puntos) {		
							
							for($j=0; $j<=3; $j++){
									
							$mystring=$primer[$i];
							$desempate=$diferencia_goles_array[$j];
							$findme=substr($desempate,strlen(intval($desempate)),(strlen($desempate)-strlen(intval($desempate))));
							$pos = strpos($mystring, $findme);								
	
								if ($pos==true) {
										
									$vector_desempate[$k]=$diferencia_goles_array[$j];									
									$k=$k+1;	   
								}																
							}
					$i=$i+1;					
					}
						
//-------------------------------------------------------------------desempate por diferencia goles----------------------------------	
						arsort($vector_desempate,SORT_NUMERIC);					
									
						$i=0;
								
							foreach ($vector_desempate as $puntaje) {
																
								$vector_desempate[$i]=$puntaje;		
								
								$clasificacion_final[$i]=$vector_desempate[$i];	
								
								$i=$i+1;	
							}
						
						$primer_lugar=substr($clasificacion_final[0],strlen(intval($clasificacion_final[0])),(strlen($clasificacion_final[0])-strlen(intval($clasificacion_final[0]))));
						$segundo_lugar=substr($clasificacion_final[1],strlen(intval($clasificacion_final[1])),(strlen($clasificacion_final[1])-strlen(intval($clasificacion_final[1]))));
						
						
						
				}else{//desempate segundo lugar
					
					$i=0;
					$k=0;
					$vector_desempate_2=array();				
				
					foreach ($segundo as $puntos) {		
							
							for($j=0; $j<=3; $j++){
									
							$mystring_2=$segundo[$i];
							$desempate_2=$diferencia_goles_array[$j];
							$findme_2=substr($desempate_2,strlen(intval($desempate_2)),(strlen($desempate_2)-strlen(intval($desempate_2))));
	
							$pos_2 = strpos($mystring_2, $findme_2);								
	
								if ($pos_2==true) {
										
									$vector_desempate_2[$k]=$diferencia_goles_array[$j];
									
									$k=$k+1;	   
								}																
							}
					$i=$i+1;					
					}
						
//-----------------------------------------------------------------desempate por diferencia goles-----------------------------------------	
							arsort($vector_desempate_2,SORT_NUMERIC);					
							$f=0;			
							$i=0;		
									
							
							foreach ($vector_desempate_2 as $puntaje) {
																
								$vector_desempate_2[$i]=$puntaje;		
								$clasificacion_final[$i]=$vector_desempate_2[$i];								
									
								
								$i=$i+1;	
							}
					
										
//------------------------------------------------------------------clasificados------------------------------------------------------
						
						
							
						$primer_lugar=substr($primer[0],strlen(intval($primer[0])),(strlen($primer[0])-strlen(intval($primer[0]))));
						
						$segundo_lugar=substr($clasificacion_final[0],strlen(intval($clasificacion_final[0])),(strlen($clasificacion_final                        [0])-strlen(intval($clasificacion_final[0]))));
						
				}
				
		}else{
		
		
		$primer_lugar=substr($clasificacion_paises[0],strlen(intval($clasificacion_paises[0])),(strlen($clasificacion_paises[0])-strlen(intval($clasificacion_paises[0]))));
		$segundo_lugar=substr($clasificacion_paises[1],strlen(intval($clasificacion_paises[1])),(strlen($clasificacion_paises[1])-strlen(intval($clasificacion_paises[1]))));
		
		
		}
	
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
if($grupo=="A"){	
	
	$clasificado1a=$primer_lugar;
	$clasificado2a=$segundo_lugar;	
	
}

if($grupo=="B"){
	
	 $clasificado1b=$primer_lugar;
	 $clasificado2b=$segundo_lugar;	
	
}

if($grupo=="C"){
	
	$clasificado1c=$primer_lugar;
	$clasificado2c=$segundo_lugar;
	
}

if($grupo=="D"){
	
	$clasificado1d=$primer_lugar;
	$clasificado2d=$segundo_lugar;
	
	
}

if($grupo=="E"){
	
	$clasificado1e=$primer_lugar;
	$clasificado2e=$segundo_lugar;
	
	
}

if($grupo=="F"){
	
	$clasificado1f=$primer_lugar;
	$clasificado2f=$segundo_lugar;
	
	
}

if($grupo=="G"){
	
	$clasificado1g=$primer_lugar;
	$clasificado2g=$segundo_lugar;
	
	
}

if($grupo=="H"){
	
	$clasificado1h=$primer_lugar;
	$clasificado2h=$segundo_lugar;
	
}

	if($w==1){
		
		$grupo="B";		
	}
	
	if($w==2){
		
		$grupo="C";		
	}
	
	if($w==3){
		
		$grupo="D";		
	}
	
	if($w==4){
		
		$grupo="E";		
	}
	
	if($w==5){
		
		$grupo="F";		
	}
	
	if($w==6){
		
		$grupo="G";		
	}
	
	if($w==7){
		
		$grupo="H";		
	}
	
}//end for
	
//------------------------------------------------------Inserta clasificados en la quiniela del usuario-------------------------------

							for($con=49;$con<=56;$con++){
								
								if($con==49){
									
									$equipo_1=$clasificado1a;
									$equipo_2=$clasificado2b;
									
									}
									
								if($con==50){
									
									$equipo_1=$clasificado1c;
									$equipo_2=$clasificado2d;
									
									
									}
								
								if($con==51){
									
									$equipo_1=$clasificado1e;
									$equipo_2=$clasificado2f;
									
									
									}
									
								if($con==52){
									
									$equipo_1=$clasificado1g;
									$equipo_2=$clasificado2h;
									
									
									}
									
								if($con==53){
									
									$equipo_1=$clasificado1b;
									$equipo_2=$clasificado2a;
									
									}
									
								if($con==54){
									
									$equipo_1=$clasificado1d;
									$equipo_2=$clasificado2c;
									
									
									}
									
								if($con==55){
									
									$equipo_1=$clasificado1f;
									$equipo_2=$clasificado2e;
									
									}
									
								if($con==56){
									
									$equipo_1=$clasificado1h;
									$equipo_2=$clasificado2g;
									
								}
								
								$octavos_actualizar="update quiniela_ganadora set equipo_1='$equipo_1', equipo_2='$equipo_2' where posicion='$con'";
								
								$resultado_actualizar=$base->prepare($octavos_actualizar);
						
								$resultado_actualizar->execute();
								
								
						
							}
		
							
//--------------------------------------------------comparo clasificados con los equipos de la  base de datos ---------------------

		
							$h=1;
							$k=2;
							$g=0;
							
							for($con=49;$con<=56;$con++){
								
								$equipos_clasificados= $base->prepare("select equipo_1 from quiniela_ganadora where posicion='$con'");
						
								$equipos_clasificados->execute(array());
								
								$equipos_clasificados_array = $equipos_clasificados->fetchAll();
								
									foreach ($equipos_clasificados_array as $row) {
							
													$comparador1=$row["equipo_1"];
													
													}
								
								for($j=1;$j<=32;$j++){
									
									$paises_participantes=$base->prepare("select pais from equipos_participantes where codigo_equipo='$j'");
									$paises_participantes->execute(array());
									
									$paises_participantes_array = $paises_participantes->fetchAll();
								
									foreach ($paises_participantes_array as $row) {
							
													 $comparador2=$row["pais"];
													
													}
													
									
										if($comparador1==$comparador2){		
																
											$pais_identificado=$base->prepare("select pais, bandera from equipos_participantes where codigo_equipo='$j'");
											$pais_identificado->execute(array());
											
											$arreglo_paises = $pais_identificado->fetchAll();
											
												foreach ($arreglo_paises as $datos_paises) {
							
													   
													 $paises_octavos[$g]=$datos_paises["pais"];	
													 $logo[$g]=$datos_paises["bandera"];
													  
													}
											
											$g=$g+1;
											$j=33;
										}//end if
								}//end for
								
								
									
								$equipos_clasificados_1= $base->prepare("select equipo_2 from quiniela_ganadora where posicion='$con'");
						
								$equipos_clasificados_1->execute(array());
								
								$equipos_clasificados_array = $equipos_clasificados_1->fetchAll();
								
									foreach ($equipos_clasificados_array as $row) {
							
													 $comparador1=$row["equipo_2"];
													
													}
								
								for($j=1;$j<=32;$j++){
									
									$paises_participantes=$base->prepare("select pais from equipos_participantes where codigo_equipo='$j'");
									$paises_participantes->execute(array());
									
										$paises_participantes_array = $paises_participantes->fetchAll();
									
										foreach ($paises_participantes_array as $row) {
								
													 $comparador2=$row["pais"];
														
														}
									
										if($comparador1==$comparador2){	
										
											$pais_identificado=$base->prepare("select pais, bandera from equipos_participantes where  codigo_equipo='$j'");
											
											$pais_identificado->execute(array());
											
											$arreglo_paises = $pais_identificado->fetchAll();
											
												foreach ($arreglo_paises as $datos_paises) {
							
													 $paises_octavos[$g]=$datos_paises["pais"];
													  
													$logo[$g]=$datos_paises["bandera"];
													  
													}
											
											$g=$g+1;
											$j=33;
										}//end if	
								}//end for	
									
}//end for

}//end suma goles

else{
//---------------------------------------------------introducir pais indefinido en octavos----------------------------------------------

		$indefinido=$base->prepare("select pais from equipos_participantes where codigo_equipo=33");
											
		$indefinido->execute(array());
											
	    $indefinido_array = $indefinido->fetchAll();
											
		    foreach ($indefinido_array as $datos_paises) {
							
			$pais_indefinido=$datos_paises["pais"];
													  
			}
			
		for($con=49;$con<=56;$con++){
			
		$octavos_actualizar="update quiniela_ganadora set equipo_1='$pais_indefinido', equipo_2='$pais_indefinido' where posicion='$con'";
								
		$resultado_actualizar=$base->prepare($octavos_actualizar);
						
	    $resultado_actualizar->execute();
		
		}
//-------------------------------------------------tomo de equipos participantes la bandera y pais indefinido-------------------------
for($i=0;$i<16;$i++){
	
$datos_indefinido=$base->prepare("select pais, bandera from equipos_participantes where codigo_equipo=33");
											
$datos_indefinido->execute(array());
											
$arreglo_paises_indefinido = $datos_indefinido->fetchAll();
											
	foreach ($arreglo_paises_indefinido as $datos_paises) {
							
		$paises_octavos[$i]=$datos_paises["pais"];
													  
		$logo[$i]=$datos_paises["bandera"];
													  
	}
}
}//end else
						
//-----------------------------------------------------compara resultados de octavos------------------------------------------------------
	$empate=0;
	$p=0;
	$q=1;
	$c=0;
	$k=97;
	$h=98;
		
for($i=0;$i<8;$i++){
	
	if(${"indice".$k."s"}>${"indice".$h."s"}){
		
		$paises_cuartos[$c]=$paises_octavos[$p];
		$logo_cuartos[$c]=$logo[$p];
		
			
	}
	
	else if(${"indice".$k."s"}<${"indice".$h."s"}){
		
		$paises_cuartos[$c]=$paises_octavos[$q];
		$logo_cuartos[$c]=$logo[$q];
		
			
	}else{
		
		$empate=1;
		
		$empate_goles=$base->prepare("select pais, bandera from equipos_participantes where codigo_equipo=33");
											
		$empate_goles->execute(array());
											
	    $empate_goles_array = $empate_goles->fetchAll();
											
		    foreach ($empate_goles_array as $datos_paises) {
							
			$paises_cuartos[$c]=$datos_paises["pais"];
													  
			$logo_cuartos[$c]=$datos_paises["bandera"];
													  
			}
	}
	
	$k=$k+2;
	$h=$h+2;
	$p=$p+2;
	$q=$q+2;
	$c=$c+1;

	}
		
//-------------------------------------------------------------Inserta equipos a cuartos de final-----------------------------------

	$i=0;
	$j=1;
	
	for($con=57;$con<=60;$con++){
		
		$cuartos_actualizar="update quiniela_ganadora set equipo_1='$paises_cuartos[$i]', equipo_2='$paises_cuartos[$j]' where posicion='$con'";
								
		$resultado_actualizar_cuartos=$base->prepare($cuartos_actualizar);
						
		$resultado_actualizar_cuartos->execute();
		
		$i=$i+2;
		$j=$j+2;
		
		}
	
	
//-------------------------------------------------------------compara resultados de semi----------------------------------------------
	$p=0;
	$q=1;
	$c=0;
	$k=113;
	$h=114;
		
for($i=0;$i<4;$i++){
	
	if(${"indice".$k."s"}>${"indice".$h."s"}){
		
		$paises_semi[$c]=$paises_cuartos[$p];
		$logo_semi[$c]=$logo_cuartos[$p];
		
			
	}
	
	else if(${"indice".$k."s"}<${"indice".$h."s"}){
		
		$paises_semi[$c]=$paises_cuartos[$q];
		$logo_semi[$c]=$logo_cuartos[$q];
		
			
	}else{
		
		$empate=1;
		
		$empate_goles=$base->prepare("select pais, bandera from equipos_participantes where codigo_equipo=33");
											
		$empate_goles->execute(array());
											
	    $empate_goles_array = $empate_goles->fetchAll();
											
		    foreach ($empate_goles_array as $datos_paises) {
							
			$paises_semi[$c]=$datos_paises["pais"];
													  
			$logo_semi[$c]=$datos_paises["bandera"];
													  
			}
		
	}
	
	$k=$k+2;
	$h=$h+2;
	$p=$p+2;
	$q=$q+2;
	$c=$c+1;

}
	
//-------------------------------------------------------------Inserta equipos a semifinales-----------------------------------	
	$i=0;
	$j=1;
	
	for($con=61;$con<=62;$con++){
		
		$semi_actualizar="update quiniela_ganadora set equipo_1='$paises_semi[$i]', equipo_2='$paises_semi[$j]' where posicion='$con'";
								
		$resultado_actualizar_semi=$base->prepare($semi_actualizar);
						
		$resultado_actualizar_semi->execute();
		
		$i=$i+2;
		$j=$j+2;
		
		}

//------------------------------------------------compara resultados de final y 3 lugar----------------------------------------------
	$p=0;
	$q=1;
	$c=0;
	$k=121;
	$h=122;
		
for($i=0;$i<2;$i++){
	
	if(${"indice".$k."s"}>${"indice".$h."s"}){
		
		$paises_final[$c]=$paises_semi[$q];
		$logo_final[$c]=$logo_semi[$q];
		
		$paises_final[$c+2]=$paises_semi[$p];
		$logo_final[$c+2]=$logo_semi[$p];
			
	}
	
	else if(${"indice".$k."s"}<${"indice".$h."s"}){
		
		$paises_final[$c]=$paises_semi[$p];
		$logo_final[$c]=$logo_semi[$p];
		
		$paises_final[$c+2]=$paises_semi[$q];
		$logo_final[$c+2]=$logo_semi[$q];
			
	}else{
		
		$empate=1;
		
		$empate_goles=$base->prepare("select pais, bandera from equipos_participantes where codigo_equipo=33");
											
		$empate_goles->execute(array());
											
	    $empate_goles_array = $empate_goles->fetchAll();
											
		    foreach ($empate_goles_array as $datos_paises) {
							
			$paises_final[$c]=$datos_paises["pais"];
													  
			$logo_final[$c]=$datos_paises["bandera"];
													  
			}
			
		$empate_goles=$base->prepare("select pais, bandera from equipos_participantes where codigo_equipo=33");
											
		$empate_goles->execute(array());
											
	    $empate_goles_array = $empate_goles->fetchAll();
											
		    foreach ($empate_goles_array as $datos_paises) {
							
			$paises_final[$c+2]=$datos_paises["pais"];
													  
			$logo_final[$c+2]=$datos_paises["bandera"];
													  
			}
		
	}
	
	$k=$k+2;
	$h=$h+2;
	$p=$p+2;
	$q=$q+2;
	$c=$c+1;

}


//-------------------------------------------------------------Inserta equipos a 3 lugar-----------------------------------	
	$i=0;
	$j=1;
	
	for($con=63;$con<=64;$con++){
		
		$final_actualizar="update quiniela_ganadora set equipo_1='$paises_final[$i]', equipo_2='$paises_final[$j]' where posicion='$con'";
								
		$resultado_actualizar_final=$base->prepare($final_actualizar);
						
		$resultado_actualizar_final->execute();
		
		$i=$i+2;
		$j=$j+2;
		
		}
		
//-----------------------------------------------------------Campeon----------------------------------------------------------------

if($indice127s>$indice128s){
		
		$campeon=$paises_final[2];
		$logo_campeon=$logo_final[2];
			
	}
	
	else if($indice127s<$indice128s){
		
		$campeon=$paises_final[3];
		$logo_campeon=$logo_final[3];
			
	}else{
		
		$empate=1;
		
		$empate_goles=$base->prepare("select pais, bandera from equipos_participantes where codigo_equipo=33");
											
		$empate_goles->execute(array());
											
	    $empate_goles_array = $empate_goles->fetchAll();
											
		    foreach ($empate_goles_array as $datos_paises) {
							
			$campeon=$datos_paises["pais"];
													  
			$logo_campeon=$datos_paises["bandera"];
													  
			}
			
	}

//------------------------------------------------------------------------------------------------------------------------------
if($empate==1 && isset($_POST["actualizar"])){
	
	?>
                            
    <script language='javascript'>
	alert('Hay un empate en uno de las llaves. Desempate para continuar');
	</script>
    
    <?php
	
	
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
            <td><input type="text" name="7" id="a_local_4" class="cuadro" value="<?php echo $indice7s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="8" id="a_visitante_4" class="cuadro" value="<?php echo $indice8s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/013-saudi-arabia.png" class="imagen"></td>
            <td><p class="informacion"><strong>ARABIA <br> SAUDITA</strong></p></td>
         
         </tr>
         
         <tr id="a_partido_5">
        
            <td><p class="informacion"><strong>ARABIA <br> SAUDITA</strong></p></td>
            <td><img src="equipos mundial/png/013-saudi-arabia.png" class="imagen"></td>
            <td><input type="text" name="9" id="a_local_5" class="cuadro" value="<?php echo $indice9s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="10" id="a_visitante_5" class="cuadro" value="<?php echo $indice10s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/005-egypt.png" class="imagen"></td>
            <td><p class="informacion"><strong>EGIPTO</strong></p></td>
         
         </tr>
         
         <tr id="a_partido_6">
        
            <td><p class="informacion"><strong>URUGUAY</strong></p></td>
            <td><img src="equipos mundial/png/023-uruguay.png" class="imagen"></td>
            <td><input type="text" name="11" id="a_local_6" class="cuadro" value="<?php echo $indice11s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="12" id="a_visitante_6" class="cuadro" value="<?php echo $indice12s  ?>" onkeypress="return isNumberKey(this);"></td>
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
            <td><input type="text" name="13" id="b_local_1" class="cuadro" value="<?php echo $indice13s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="14" id="b_visitante_1" class="cuadro" value="<?php echo $indice14s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/028-iran.png" class="imagen"></td>
            <td><p class="informacion"><strong>IRÁN</strong></p></td>
         
         </tr>
         
         <tr id="b_partido_2">
        
            <td><p class="informacion"><strong>PORTUGAL</strong></p></td>
            <td><img src="equipos mundial/png/011-portugal.png" class="imagen"></td>
            <td><input type="text" name="15" id="b_local_2" class="cuadro" value="<?php echo $indice15s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="16" id="b_visitante_2" class="cuadro" value="<?php echo $indice16s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/015-spain.png" class="imagen"></td>
            <td><p class="informacion"><strong>ESPAÑA</strong></p></td>
         
         </tr>
         
         <tr id="b_partido_3">
        
            <td><p class="informacion"><strong>PORTUGAL</strong></p></td>
            <td><img src="equipos mundial/png/011-portugal.png" class="imagen"></td>
            <td><input type="text" name="17" id="b_local_3" class="cuadro" value="<?php echo $indice17s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="18" id="b_visitante_3" class="cuadro" value="<?php echo $indice18s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/019-morocco.png" class="imagen"></td>
            <td><p class="informacion"><strong>MARRUECOS</strong></p></td>
         
         </tr>
         
         <tr id="b_partido_4">
        
            <td><p class="informacion"><strong>IRÁN</p></td>
            <td><img src="equipos mundial/png/028-iran.png" class="imagen"></td>
            <td><input type="text" name="19" id="b_local_4" class="cuadro" value="<?php echo $indice19s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="20" id="b_visitante_4" class="cuadro" value="<?php echo $indice20s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/015-spain.png" class="imagen"></td>
            <td><p class="informacion"><strong>ESPAÑA</strong></p></td>
         
         </tr>
         
         <tr id="b_partido_5">
        
            <td><p class="informacion"><strong>ESPAÑA</strong></p></td>
            <td><img src="equipos mundial/png/015-spain.png" class="imagen"></td>
            <td><input type="text" name="21" id="b_local_5" class="cuadro" value="<?php echo $indice21s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="22" id="b_visitante_5" class="cuadro" value="<?php echo $indice22s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/019-morocco.png" class="imagen"></td>
            <td><p class="informacion"><strong>MARRUECOS</strong></p></td>
         
         </tr>
         
         <tr id="b_partido_6">
        
            <td><p class="informacion"><strong>IRÁN</strong></p></td>
            <td><img src="equipos mundial/png/028-iran.png" class="imagen"></td>
            <td><input type="text" name="23" id="b_local_6" class="cuadro" value="<?php echo $indice23s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="24" id="b_visitante_6" class="cuadro" value="<?php echo $indice24s  ?>" onkeypress="return isNumberKey(this);"></td>
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
            <td><input type="text" name="25" id="c_local_1" class="cuadro" value="<?php echo $indice25s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="26" id="c_visitante_1" class="cuadro" value="<?php echo $indice26s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/024-australia.png" class="imagen"></td>
            <td><p class="informacion"><strong>AUSTRALIA</strong></p></td>
         
         </tr>
         
         <tr id="c_partido_2">
        
            <td><p class="informacion"><strong>PERU</strong></p></td>
            <td><img src="equipos mundial/png/032-peru.png" class="imagen"></td>
            <td><input type="text" name="27" id="c_local_2" class="cuadro" value="<?php echo $indice27s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="28" id="c_visitante_2" class="cuadro" value="<?php echo $indice28s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/004-denmark.png" class="imagen"></td>
            <td><p class="informacion"><strong>DINAMARCA</strong></p></td>
         
         </tr>
         
         <tr id="c_partido_3">
        
            <td><p class="informacion"><strong>FRANCIA</strong></p></td>
            <td><img src="equipos mundial/png/007-france.png" class="imagen"></td>
            <td><input type="text" name="29" id="c_local_3" class="cuadro" value="<?php echo $indice29s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="30" id="c_visitante_3" class="cuadro" value="<?php echo $indice30s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/032-peru.png" class="imagen"></td>
            <td><p class="informacion"><strong>PERU</strong></p></td>
         
         </tr>
         
         <tr id="c_partido_4">
        
            <td><p class="informacion"><strong>DINAMARCA</p></td>
            <td><img src="equipos mundial/png/004-denmark.png" class="imagen"></td>
            <td><input type="text" name="31" id="c_local_4" class="cuadro" value="<?php echo $indice31s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="32" id="c_visitante_4" class="cuadro" value="<?php echo $indice32s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/024-australia.png" class="imagen"></td>
            <td><p class="informacion"><strong>AUSTRALIA</strong></p></td>
         
         </tr>
         
         <tr id="c_partido_5">
        
            <td><p class="informacion"><strong>AUSTRALIA</strong></p></td>
            <td><img src="equipos mundial/png/024-australia.png"  class="imagen"></td>
            <td><input type="text" name="33" id="c_local_5" class="cuadro" value="<?php echo $indice33s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="34" id="c_visitante_5" class="cuadro" value="<?php echo $indice34s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/032-peru.png" class="imagen"></td>
            <td><p class="informacion"><strong>PERU</strong></p></td>
         
         </tr>
         
         <tr id="c_partido_6">
        
            <td><p class="informacion"><strong>DINAMARCA</strong></p></td>
            <td><img src="equipos mundial/png/004-denmark.png" class="imagen"></td>
            <td><input type="text" name="35" id="c_local_6" class="cuadro" value="<?php echo $indice35s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="36" id="c_visitante_6" class="cuadro" value="<?php echo $indice36s  ?>" onkeypress="return isNumberKey(this);"></td>
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
            <td><input type="text" name="37" id="d_local_1" class="cuadro" value="<?php echo $indice37s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="38" id="d_visitante_1" class="cuadro" value="<?php echo $indice38s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/027-iceland.png" class="imagen"></td>
            <td><p class="informacion"><strong>ISLANDIA</strong></p></td>
         
         </tr>
         
         <tr id="d_partido_2">
        
            <td><p class="informacion"><strong>CROACIA</strong></p></td>
            <td><img src="equipos mundial/png/003-croatia.png" class="imagen"></td>
            <td><input type="text" name="39" id="d_local_2" class="cuadro" value="<?php echo $indice39s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="40" id="d_visitante_2" class="cuadro" value="<?php echo $indice40s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/029-nigeria.png" class="imagen"></td>
            <td><p class="informacion"><strong>NIGERIA</strong></p></td>
         
         </tr>
         
         <tr id="d_partido_3">
        
            <td><p class="informacion"><strong>ARGENTINA</strong></p></td>
            <td><img src="equipos mundial/png/001-argentina.png" class="imagen"></td>
            <td><input type="text" name="41" id="d_local_3" class="cuadro" value="<?php echo $indice41s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="42" id="d_visitante_3" class="cuadro" value="<?php echo $indice42s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/003-croatia.png" class="imagen"></td>
            <td><p class="informacion"><strong>CROACIA</strong></p></td>
         
         </tr>
         
         <tr id="d_partido_4">
        
            <td><p class="informacion"><strong>NIGERIA</p></td>
            <td><img src="equipos mundial/png/029-nigeria.png" class="imagen"></td>
            <td><input type="text" name="43" id="d_local_4" class="cuadro" value="<?php echo $indice43s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="44" id="d_visitante_4" class="cuadro" value="<?php echo $indice44s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/027-iceland.png" class="imagen"></td>
            <td><p class="informacion"><strong>ISLANDIA</strong></p></td>
         
         </tr>
         
         <tr id="d_partido_5">
        
            <td><p class="informacion"><strong>ISLANDIA</strong></p></td>
            <td><img src="equipos mundial/png/027-iceland.png" class="imagen"></td>
            <td><input type="text" name="45" id="d_local_5" class="cuadro" value="<?php echo $indice45s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="46" id="d_visitante_5" class="cuadro" value="<?php echo $indice46s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/003-croatia.png" class="imagen"></td>
            <td><p class="informacion"><strong>CROACIA</strong></p></td>
         
         </tr>
         
         <tr id="d_partido_6">
        
            <td><p class="informacion"><strong>NIGERIA</strong></p></td>
            <td><img src="equipos mundial/png/029-nigeria.png" class="imagen"></td>
            <td><input type="text" name="47" id="d_local_6" class="cuadro" value="<?php echo $indice47s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="48" id="d_visitante_6" class="cuadro" value="<?php echo $indice48s  ?>" onkeypress="return isNumberKey(this);"></td>
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
            <td><input type="text" name="49" id="e_local_1" class="cuadro" value="<?php echo $indice49s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="50" id="e_visitante_1" class="cuadro" value="<?php echo $indice50s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/021-serbia.png" class="imagen"></td>
            <td><p class="informacion"><strong>SERBIA</strong></p></td>
         
         </tr>
         
         <tr id="e_partido_2">
        
            <td><p class="informacion"><strong>BRASIL</strong></p></td>
            <td><img src="equipos mundial/png/017-brazil.png" class="imagen"></td>
            <td><input type="text" name="51" id="e_local_2" class="cuadro" value="<?php echo $indice51s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="52" id="e_visitante_2" class="cuadro" value="<?php echo $indice52s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/031-switzerland.png" class="imagen"></td>
            <td><p class="informacion"><strong>SUIZA</strong></p></td>
         
         </tr>
         
         <tr id="e_partido_3">
        
            <td><p class="informacion"><strong>BRASIL</strong></p></td>
            <td><img src="equipos mundial/png/017-brazil.png" class="imagen"></td>
            <td><input type="text" name="53" id="e_local_3" class="cuadro" value="<?php echo $indice53s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="54" id="e_visitante_3" class="cuadro" value="<?php echo $indice54s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/026-costa-rica.png" class="imagen"></td>
            <td><p class="informacion"><strong>COSTA <br> RICA</strong></p></td>
         
         </tr>
         
         <tr id="e_partido_4">
        
            <td><p class="informacion"><strong>SERBIA</p></td>
            <td><img src="equipos mundial/png/021-serbia.png"  class="imagen"></td>
            <td><input type="text" name="55" id="e_local_4" class="cuadro" value="<?php echo $indice55s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="56" id="e_visitante_4" class="cuadro" value="<?php echo $indice56s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/031-switzerland.png" class="imagen"></td>
            <td><p class="informacion"><strong>SUIZA</strong></p></td>
         
         </tr>
         
         <tr id="e_partido_5">
        
            <td><p class="informacion"><strong>SUIZA</strong></p></td>
            <td><img src="equipos mundial/png/031-switzerland.png" class="imagen"></td>
            <td><input type="text" name="57" id="e_local_5" class="cuadro" value="<?php echo $indice57s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="58" id="e_visitante_5" class="cuadro" value="<?php echo $indice58s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/026-costa-rica.png" class="imagen"></td>
            <td><p class="informacion"><strong>COSTA <br> RICA</strong></p></td>
         
         </tr>
         
         <tr id="e_partido_6">
        
            <td><p class="informacion"><strong>SERBIA</strong></p></td>
            <td><img src="equipos mundial/png/021-serbia.png" class="imagen"></td>
            <td><input type="text" name="59" id="e_local_6" class="cuadro" value="<?php echo $indice59s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="60" id="e_visitante_6" class="cuadro" value="<?php echo $indice60s  ?>" onkeypress="return isNumberKey(this);"></td>
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
            <td><input type="text" name="61" id="f_local_1" class="cuadro" value="<?php echo $indice61s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="62" id="f_visitante_1" class="cuadro" value="<?php echo $indice62s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/018-mexico.png" class="imagen"></td>
            <td><p class="informacion"><strong>MEXICO</strong></p></td>
         
         </tr>
         
         <tr id="f_partido_2">
        
            <td><p class="informacion"><strong>SUECIA</strong></p></td>
            <td><img src="equipos mundial/png/016-sweden.png" class="imagen"></td>
            <td><input type="text" name="63" id="f_local_2" class="cuadro" value="<?php echo $indice63s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="64" id="f_visitante_2" class="cuadro" value="<?php echo $indice64s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/030-south-korea.png" class="imagen"></td>
            <td><p class="informacion"><strong>COREA DEL <br> SUR</strong></p></td>
         
         </tr>
         
         <tr id="f_partido_3">
        
            <td><p class="informacion"><strong>ALEMANIA</strong></p></td>
            <td><img src="equipos mundial/png/008-germany.png" class="imagen"></td>
            <td><input type="text" name="65" id="f_local_3" class="cuadro" value="<?php echo $indice65s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="66" id="f_visitante_3" class="cuadro" value="<?php echo $indice66s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/016-sweden.png" class="imagen"></td>
            <td><p class="informacion"><strong>SUECIA</strong></p></td>
         
         </tr>
         
         <tr id="f_partido_4">
        
            <td><p class="informacion"><strong>COREA DEL <br> SUR</p></td>
            <td><img src="equipos mundial/png/030-south-korea.png" class="imagen"></td>
            <td><input type="text" name="67" id="f_local_4" class="cuadro" value="<?php echo $indice67s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="68" id="f_visitante_4" class="cuadro" value="<?php echo $indice68s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/018-mexico.png" class="imagen"></td>
            <td><p class="informacion"><strong>MEXICO</strong></p></td>
         
         </tr>
         
         <tr id="f_partido_5">
        
            <td><p class="informacion"><strong>MEXICO</strong></p></td>
            <td><img src="equipos mundial/png/018-mexico.png" class="imagen"></td>
            <td><input type="text" name="69" id="f_local_5" class="cuadro" value="<?php echo $indice69s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="70" id="f_visitante_5" class="cuadro" value="<?php echo $indice70s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/016-sweden.png" class="imagen"></td>
            <td><p class="informacion"><strong>SUECIA</strong></p></td>
         
         </tr>
         
         <tr id="f_partido_6">
        
            <td><p class="informacion"><strong>COREA DEL <br> SUR</strong></p></td>
            <td><img src="equipos mundial/png/030-south-korea.png" class="imagen"></td>
            <td><input type="text" name="71" id="f_local_6" class="cuadro" value="<?php echo $indice71s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="72" id="f_visitante_6" class="cuadro" value="<?php echo $indice72s  ?>" onkeypress="return isNumberKey(this);"></td>
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
            <td><input type="text" name="73" id="g_local_1" class="cuadro" value="<?php echo $indice73s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="74" id="g_visitante_1" class="cuadro" value="<?php echo $indice74s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/020-panama.png" class="imagen"></td>
            <td><p class="informacion"><strong>PÁNAMA</strong></p></td>
         
         </tr>
         
         <tr id="g_partido_2">
        
            <td><p class="informacion"><strong>TÚNEZ</strong></p></td>
            <td><img src="equipos mundial/png/022-turkey.png" class="imagen"></td>
            <td><input type="text" name="75" id="g_local_2" class="cuadro" value="<?php echo $indice75s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="76" id="g_visitante_2" class="cuadro" value="<?php echo $indice76s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/006-england.png" class="imagen"></td>
            <td><p class="informacion"><strong>INGLATERRA</strong></p></td>
         
         </tr>
         
         <tr id="g_partido_3">
        
            <td><p class="informacion"><strong>BÉLGICA</strong></p></td>
            <td><img src="equipos mundial/png/002-belgium.png" class="imagen"></td>
            <td><input type="text" name="77" id="g_local_3" class="cuadro" value="<?php echo $indice77s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="78" id="g_visitante_3" class="cuadro" value="<?php echo $indice78s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/022-turkey.png" class="imagen"></td>
            <td><p class="informacion"><strong>TÚNEZ</strong></p></td>
         
         </tr>
         
         <tr id="g_partido_4">
        
            <td><p class="informacion"><strong>INGLATERRA</p></td>
            <td><img src="equipos mundial/png/006-england.png" class="imagen"></td>
            <td><input type="text" name="79" id="g_local_4" class="cuadro" value="<?php echo $indice79s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="80" id="g_visitante_4" class="cuadro" value="<?php echo $indice80s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/020-panama.png" class="imagen"></td>
            <td><p class="informacion"><strong>PÁNAMA</strong></p></td>
         
         </tr>
         
         <tr id="g_partido_5">
        
            <td><p class="informacion"><strong>PÁNAMA</strong></p></td>
            <td><img src="equipos mundial/png/020-panama.png" class="imagen"></td>
            <td><input type="text" name="81" id="g_local_5" class="cuadro" value="<?php echo $indice81s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="82" id="g_visitante_5" class="cuadro" value="<?php echo $indice82s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/022-turkey.png" class="imagen"></td>
            <td><p class="informacion"><strong>TÚNEZ</strong></p></td>
         
         </tr>
         
         <tr id="g_partido_6">
        
            <td><p class="informacion"><strong>INGLATERRA</strong></p></td>
            <td><img src="equipos mundial/png/006-england.png" class="imagen"></td>
            <td><input type="text" name="83" id="g_local_6" class="cuadro" value="<?php echo $indice83s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="84" id="g_visitante_6" class="cuadro" value="<?php echo $indice84s  ?>" onkeypress="return isNumberKey(this);"></td>
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
            <td><input type="text" name="85" id="h_local_1" class="cuadro" value="<?php echo $indice85s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="86" id="h_visitante_1" class="cuadro" value="<?php echo $indice86s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/014-senegal.png" class="imagen"></td>
            <td><p class="informacion"><strong>SENEGAL</strong></p></td>

         
         </tr>
         
         <tr id="h_partido_2">
        
            <td><p class="informacion"><strong>COLOMBIA</strong></p></td>
            <td><img src="equipos mundial/png/025-colombia.png" class="imagen"></td>
            <td><input type="text" name="87" id="h_local_2" class="cuadro" value="<?php echo $indice87s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="88" id="h_visitante_2" class="cuadro" value="<?php echo $indice88s  ?>"></td>
            <td><img src="equipos mundial/png/009-japan.png" class="imagen"></td>
            <td><p class="informacion"><strong>JAPÓN</strong></p></td>
         
         </tr>
         
         <tr id="h_partido_3">
        
            <td><p class="informacion"><strong>JAPÓN</strong></p></td>
            <td><img src="equipos mundial/png/009-japan.png" class="imagen"></td>
            <td><input type="text" name="89" id="h_local_3" class="cuadro" value="<?php echo $indice89s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="90" id="h_visitante_3" class="cuadro" value="<?php echo $indice90s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/014-senegal.png" class="imagen"></td>
            <td><p class="informacion"><strong>SENEGAL</strong></p></td>
         
         </tr>
         
         <tr id="h_partido_4">
        
            <td><p class="informacion"><strong>POLONIA</p></td>
            <td><img src="equipos mundial/png/010-poland.png" class="imagen"></td>
            <td><input type="text" name="91" id="h_local_4" class="cuadro" value="<?php echo $indice91s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="92" id="h_visitante_4" class="cuadro" value="<?php echo $indice92s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/025-colombia.png" class="imagen"></td>
            <td><p class="informacion"><strong>COLOMBIA</strong></p></td>
         
         </tr>
         
         <tr id="h_partido_5">
        
            <td><p class="informacion"><strong>SENEGAL</strong></p></td>
            <td><img src="equipos mundial/png/014-senegal.png" class="imagen"></td>
            <td><input type="text" name="93" id="h_local_5" class="cuadro" value="<?php echo $indice93s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="94" id="h_visitante_5" class="cuadro" value="<?php echo $indice94s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/025-colombia.png" class="imagen"></td>
            <td><p class="informacion"><strong>COLOMBIA</strong></p></td>
         
         </tr>
         
         <tr id="h_partido_6">
        
            <td><p class="informacion"><strong>JAPÓN</strong></p></td>
            <td><img src="equipos mundial/png/009-japan.png" class="imagen"></td>
            <td><input type="text" name="95" id="h_local_6" class="cuadro" value="<?php echo $indice95s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><input type="text" name="96" id="h_visitante_6" class="cuadro" value="<?php echo $indice96s  ?>" onkeypress="return isNumberKey(this);"></td>
            <td><img src="equipos mundial/png/010-poland.png" class="imagen"></td>
            <td><p class="informacion"><strong>POLONIA</strong></p></td>
         
         </tr>
        
        </table>   
       
    
    </div>
    
 <!-- ---------------------------------------------cuadro de octavos de final ----------------------------------------------------- -->
   
   </div> 
   
   <div id="cuadro_eliminatoria">
  
    <table>

    <tr>
    
    <td><p class="informacion"><strong><?php echo $paises_octavos[0] ?></strong></p></td>
    <td><img src="/intranet/uploads/<?php echo $logo[0];?>" class="imagen"></td>
    <td><input type="text" name="97"  class="cuadro" value="<?php echo $indice97s  ?>" onkeypress="return isNumberKey(this);"></td>    
  
    </tr>
    
    <tr>
    
    <td><p class="informacion"><strong><?php echo $paises_octavos[1] ?></strong></p></td>    
    <td><img src="/intranet/uploads/<?php echo $logo[1];?>" class="imagen"></td>
    <td><input type="text" name="98"  class="cuadro" value="<?php echo $indice98s  ?>" onkeypress="return isNumberKey(this);"></td>
    
    </tr>
    
    <tr>
    
    <td><p class="informacion"><strong><?php echo $paises_octavos[2] ?></strong></p></td>
    <td><img src="/intranet/uploads/<?php echo $logo[2];?>" class="imagen"></td>
    <td><input type="text" name="99"  class="cuadro" value="<?php echo $indice99s  ?>" onkeypress="return isNumberKey(this);"></td>
    
    </tr>
    
    <tr>
    
    <td><p class="informacion"><strong><?php echo $paises_octavos[3] ?></strong></p></td>
    <td><img src="/intranet/uploads/<?php echo $logo[3];?>" class="imagen"></td>
    <td><input type="text" name="100"  class="cuadro" value="<?php echo $indice100s  ?>" onkeypress="return isNumberKey(this);"></td>    
    
   
    </tr>
    
    <tr>
    <td><p class="informacion"><strong><?php echo $paises_octavos[4] ?></strong></p></td>
    <td><img src="/intranet/uploads/<?php echo $logo[4];?>" class="imagen"></td>
    <td><input type="text" name="101"  class="cuadro" value="<?php echo $indice101s  ?>" onkeypress="return isNumberKey(this);"></td>
    </tr>
    
    <tr>
    
    <td><p class="informacion"><strong><?php echo $paises_octavos[5] ?></strong></p></td>
    <td><img src="/intranet/uploads/<?php echo $logo[5];?>" class="imagen"></td>
    <td><input type="text" name="102"  class="cuadro" value="<?php echo $indice102s  ?>" onkeypress="return isNumberKey(this);"></td>
    
    </tr>
    
    <tr>
    
    <td><p class="informacion"><strong><?php echo $paises_octavos[6] ?></strong></p></td>    
    <td><img src="/intranet/uploads/<?php echo $logo[6];?>" class="imagen"></td>
    <td><input type="text" name="103"  class="cuadro" value="<?php echo $indice103s  ?>" onkeypress="return isNumberKey(this);"></td>    
       
    </tr>
    
    <tr>
    
    <td><p class="informacion"><strong><?php echo $paises_octavos[7] ?></strong></p></td>    
    <td><img src="/intranet/uploads/<?php echo $logo[7];?>" class="imagen"></td>
    <td><input type="text" name="104"  class="cuadro" value="<?php echo $indice104s  ?>" onkeypress="return isNumberKey(this);"></td>    
    
   
    </tr>
    
    <tr>
    
    <td><input type="text" name="105"  class="cuadro" value="<?php echo $indice105s  ?>" onkeypress="return isNumberKey(this);"></td>
    <td><img src="/intranet/uploads/<?php echo $logo[8];?>" class="imagen"></td>
    <td><p class="informacion"><strong><?php echo $paises_octavos[8] ?></strong></p></td>
        
   	</tr>
    
    <tr>
     
    <td><input type="text" name="106"  class="cuadro" value="<?php echo $indice106s  ?>" onkeypress="return isNumberKey(this);"></td>
    <td><img src="/intranet/uploads/<?php echo $logo[9];?>" class="imagen"></td>
    <td><p class="informacion"><strong><?php echo $paises_octavos[9] ?></strong></p></td>    
    
    </tr>
    
    <tr>
    
    <td><input type="text" name="107"  class="cuadro" value="<?php echo $indice107s  ?>" onkeypress="return isNumberKey(this);"></td>    
    <td><img src="/intranet/uploads/<?php echo $logo[10];?>" class="imagen"></td>
    <td><p class="informacion"><strong><?php echo $paises_octavos[10] ?></strong></p></td>
   
    </tr>
    
    <tr>
    
    <td><input type="text" name="108"  class="cuadro" value="<?php echo $indice108s  ?>" onkeypress="return isNumberKey(this);"></td>    
    <td><img src="/intranet/uploads/<?php echo $logo[11];?>" class="imagen"></td>
    <td><p class="informacion"><strong><?php echo $paises_octavos[11] ?></strong></p></td>
    
    </tr>
    
    <tr>
    
    <td><input type="text" name="109"  class="cuadro" value="<?php echo $indice109s  ?>" onkeypress="return isNumberKey(this);"></td>
    <td><img src="/intranet/uploads/<?php echo $logo[12];?>" class="imagen"></td>
     <td><p class="informacion"><strong><?php echo $paises_octavos[12] ?></strong></p></td>
   
    
    </tr>    
    
    <tr>
    
    <td><input type="text" name="110"  class="cuadro" value="<?php echo $indice110s  ?>" onkeypress="return isNumberKey(this);"></td> 
    <td><img src="/intranet/uploads/<?php echo $logo[13];?>" class="imagen"></td>
    <td><p class="informacion"><strong><?php echo $paises_octavos[13] ?></strong></p></td>
    
    </tr>    
    
    <tr>
    
    <td><input type="text" name="111"  class="cuadro" value="<?php echo $indice111s  ?>" onkeypress="return isNumberKey(this);"></td>   
    <td><img src="/intranet/uploads/<?php echo $logo[14];?>" class="imagen"></td>
    <td><p class="informacion"><strong><?php echo $paises_octavos[14] ?></strong></p></td>
    
    </tr>
    
    <tr>
    
    <td><input type="text" name="112"  class="cuadro" value="<?php echo $indice112s  ?>" onkeypress="return isNumberKey(this);"></td>       
    <td><img src="/intranet/uploads/<?php echo $logo[15];?>" class="imagen"></td>
    <td><p class="informacion"><strong><?php echo $paises_octavos[15] ?></strong></p></td> 
    
    </tr>

</table>
<!-----------------------------------------------------------cuartos de final-------------------------------------------------------->

<table>

<tr>
    
    <td><p class="informacion"><strong><?php echo $paises_cuartos[0] ?></strong></p></td>
    <td><img src="/intranet/uploads/<?php echo $logo_cuartos[0];?>" class="imagen"></td>
    <td><input type="text" name="113"  class="cuadro" value="<?php echo $indice113s  ?>" onkeypress="return isNumberKey(this);"></td>    
  
 </tr>
 
 <tr>
    
    <td><p class="informacion"><strong><?php echo $paises_cuartos[1] ?></strong></p></td>
    <td><img src="/intranet/uploads/<?php echo $logo_cuartos[1];?>" class="imagen"></td>
    <td><input type="text" name="114"  class="cuadro" value="<?php echo $indice114s  ?>" onkeypress="return isNumberKey(this);"></td>    
  
 </tr>
 
 <tr>
    
    <td><p class="informacion"><strong><?php echo $paises_cuartos[2] ?></strong></p></td>
    <td><img src="/intranet/uploads/<?php echo $logo_cuartos[2];?>" class="imagen"></td>
    <td><input type="text" name="115"  class="cuadro" value="<?php echo $indice115s  ?>" onkeypress="return isNumberKey(this);"></td>    
  
 </tr>
 
 <tr>
    
    <td><p class="informacion"><strong><?php echo $paises_cuartos[3] ?></strong></p></td>
    <td><img src="/intranet/uploads/<?php echo $logo_cuartos[3];?>" class="imagen"></td>
    <td><input type="text" name="116"  class="cuadro" value="<?php echo $indice116s  ?>" onkeypress="return isNumberKey(this);"></td>    
  
 </tr>
 
 <tr>
    
    <td><input type="text" name="117"  class="cuadro" value="<?php echo $indice117s  ?>" onkeypress="return isNumberKey(this);"></td>
    <td><img src="/intranet/uploads/<?php echo $logo_cuartos[4];?>" class="imagen"></td>
    <td><p class="informacion"><strong><?php echo $paises_cuartos[4] ?></strong></p></td>
   
        
  
 </tr>
 
  <tr>
  
    <td><input type="text" name="118"  class="cuadro" value="<?php echo $indice118s  ?>" onkeypress="return isNumberKey(this);"></td>  
    <td><img src="/intranet/uploads/<?php echo $logo_cuartos[5];?>" class="imagen"></td>
    <td><p class="informacion"><strong><?php echo $paises_cuartos[5] ?></strong></p></td>
   
  
 </tr> 
 
 <tr>
 
    <td><input type="text" name="119"  class="cuadro" value="<?php echo $indice119s  ?>" onkeypress="return isNumberKey(this);"></td>
    <td><img src="/intranet/uploads/<?php echo $logo_cuartos[6];?>" class="imagen"></td>  
    <td><p class="informacion"><strong><?php echo $paises_cuartos[6] ?></strong></p></td>
 
       
  
 </tr> 
 
 <tr>
    
    <td><input type="text" name="120"  class="cuadro" value="<?php echo $indice120s  ?>" onkeypress="return isNumberKey(this);"></td>
    <td><img src="/intranet/uploads/<?php echo $logo_cuartos[7];?>" class="imagen"></td>
    <td><p class="informacion"><strong><?php echo $paises_cuartos[7] ?></strong></p></td>
     
  
 </tr>

</table>

<!-----------------------------------------------------------semi-final ------------------------------------------------------>

<table>

<tr>
    
    <td><p class="informacion"><strong><?php echo $paises_semi[0] ?></strong></p></td>
    <td><img src="/intranet/uploads/<?php echo $logo_semi[0];?>" class="imagen"></td>
    <td><input type="text" name="121"  class="cuadro" value="<?php echo $indice121s  ?>" onkeypress="return isNumberKey(this);"></td>    
  
 </tr>
 
 <tr>
    
    <td><p class="informacion"><strong><?php echo $paises_semi[1] ?></strong></p></td>
    <td><img src="/intranet/uploads/<?php echo $logo_semi[1];?>" class="imagen"></td>
    <td><input type="text" name="122"  class="cuadro" value="<?php echo $indice122s  ?>" onkeypress="return isNumberKey(this);"></td>    
  
 </tr>
 
 <tr>
 
    <td><input type="text" name="123"  class="cuadro" value="<?php echo $indice123s  ?>" onkeypress="return isNumberKey(this);"></td>
    <td><img src="/intranet/uploads/<?php echo $logo_semi[2];?>" class="imagen"></td>  
    <td><p class="informacion"><strong><?php echo $paises_semi[2] ?></strong></p></td>
 
       
  
 </tr> 
 
 <tr>
    
    <td><input type="text" name="124"  class="cuadro" value="<?php echo $indice124s  ?>" onkeypress="return isNumberKey(this);"></td>
    <td><img src="/intranet/uploads/<?php echo $logo_semi[3];?>" class="imagen"></td>
    <td><p class="informacion"><strong><?php echo $paises_semi[3] ?></strong></p></td>
     
  
 </tr>

</table>

<!-----------------------------------------------------------final y 3 lugar ------------------------------------------------------>

<table>

 <tr>
 
 	<td><p class="informacion"><strong><?php echo $paises_final[0] ?></strong></p></td>
    <td><img src="/intranet/uploads/<?php echo $logo_final[0];?>" class="imagen"></td> 
    <td><input type="text" name="125"  class="cuadro" value="<?php echo $indice125s  ?>" onkeypress="return isNumberKey(this);"></td> 
    
 </tr> 
 
 <tr>
    
    <td><input type="text" name="126"  class="cuadro" value="<?php echo $indice126s  ?>" onkeypress="return isNumberKey(this);"></td>
    <td><img src="/intranet/uploads/<?php echo $logo_final[1] ;?>" class="imagen"></td>
    <td><p class="informacion"><strong><?php echo $paises_final[1] ?></strong></p></td>
     
  
 </tr>
 
 <tr>
    
    <td><p class="informacion"><strong><?php echo $paises_final[2] ?></strong></p></td>
    <td><img src="/intranet/uploads/<?php echo $logo_final[2];?>" class="imagen"></td>
    <td><input type="text" name="127"  class="cuadro" value="<?php echo $indice127s  ?>" onkeypress="return isNumberKey(this);"></td>    
  
 </tr>
 
 <tr>
    
    <td><input type="text" name="128"  class="cuadro" value="<?php echo $indice128s  ?>" onkeypress="return isNumberKey(this);"></td>
    <td><img src="/intranet/uploads/<?php echo $logo_final[3];?>" class="imagen"></td>
    <td><p class="informacion"><strong><?php echo $paises_final[3] ?></strong></p></td>
    
 </tr>

</table>

<!-------------------------------------------------------------------campeon------------------------------------------------------>

<table>

<tr><td><img src="/intranet/uploads/<?php echo $logo_campeon;?>" class="imagen"></td></tr>
  
<tr><td><p class="informacion"><strong><?php echo $campeon ?></strong></p></td></tr>

</table>



<input type="submit" name="actualizar" id="actualizar" value="Actualizar Quiniela">
   </form>
   
</div>

<script>
//var formulario = document.getElementById("formulario_fase_grupo"),
//    comodin = true;
// 
//formulario.addEventListener("submit", function(event){
//    event.preventDefault();
// 
//    var elementos = this.elements;
//    for (var i in elementos){
//        if (!elementos[i].value.length){
//            alert("Debe de completar el campo " + elementos[i].name);
//            comodin = false;
//            break;
//        }
//    }
// 
//    if (comodin){
//        this.submit();
//    }
//}, false);
</script>

</section>
  				
  </body>
</html>
