<?php
    include_once 'DbConnection.php';

    $studentID = $_POST['studentID'] * 1;
    $question = $_POST['question'];

    $query = "insert into Q_A(studentid, question) values (".$studentID.", '".$question."')";

    $res = mysqli_query($con, $query);
?>

<html>
    <head>
        <title></title>

        <style>
            h1{
                color : darkseagreen;
                font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif
            }
        </style>
    </head>

    <body>
        <?php if ($res) {?>
            <h1>Question successfully Submitted!! <br>To Check Answers please visit answers page</h1>
        <?php }else {?>
            <h1>Error occurred</h1>
        <?php } ?>

        <a href = "home.php"><h2>Click here to go Home</h2></a>
    </body>
</html>