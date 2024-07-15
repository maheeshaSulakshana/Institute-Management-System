<?php
    include_once "DbConnection.php";
    $st_id=$_POST['studentid'];
    $st_name=$_POST['studentname'];
    $st_address=$_POST['address'];
    $query="insert into test_students values ('".$st_id."', '".$st_name."', '".$st_address."')";

    mysqli_query($con,$query);

    echo'Inserted';
?>