<?php
$nombre= $_REQUEST['nombre'];
$edad= $_REQUEST['edad'];
$email= $_REQUEST['email'];
$carrera= $_REQUEST['carrera'];
$destino = $_REQUEST['recipient'];
$subject = $_REQUEST['subject'];
$redirect = $_REQUEST['redirect'];



if ($nombre != '') {
$header = "From: $nombre <$email>\r\n";
}
else {
$header = "From: $email\r\n";
}
$header .= "Return-Path: $email\r\n";
$mensaje = "Nombre: $nombre\r\n";
$mensaje .="Email: $email\r\n";
$mensaje .= "Carrera de interes: $carrera\r\n";
$mensaje .= "Edad: $edad";

mail($destino, $subject, $mensaje, $header);
header('Location: ' . $redirect);
?>
