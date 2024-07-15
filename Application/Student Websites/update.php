<?php
    include_once "DbConnection.php";
    $st_id=$_POST['studentid'];
    $st_name=$_POST['studentname'];
    $st_address=$_POST['address'];
    $query="update test_students SET student_name = '".$st_name."', student_adress = '".$st_address."' where student_id = '".$st_id."'";

    mysqli_query($con,$query);

    echo'UPDATED';
?>