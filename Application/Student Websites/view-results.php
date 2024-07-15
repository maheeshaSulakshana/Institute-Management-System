<?php 
    include_once "DbConnection.php";

    $studentID = $_POST['studentID'];

    $query = "Select * from exam_marks where studentID = ".$studentID."";

    $res = mysqli_query($con, $query);

    $no_of_rows = mysqli_num_rows($res);

    $c = 0;
?>

<html>
    <head>
        <title>Student Results</title>

        <style>
            div{
                font-size: 40px;
                font-weight: bold;;
                width: 100%;
                height: 100px;
                background-color:cornsilk;
                text-align: center;
            }

            table{
                position: relative;
                top: 125px;
                font-size: 40px;
            }
        </style>
    </head>

    <body>
        <div>
            Student Results
        </div>

        <table border = "1" cellspacing = "0px" cellpadding = "5px" align = "center">
            <tr>
                <th>Student ID</th>
                <th>Course ID</th>
                <th>Exam Type</th>
                <th>Marks</th>
            </tr>

            <?php while ($c < $no_of_rows){
                $row = mysqli_fetch_assoc($res);
                $c = $c + 1; ?>
                <tr>
                    <td> <?php echo $row['StudentID'] ?> </td>
                    <td> <?php echo $row['CourseID'] ?> </td>
                    <td> <?php echo $row['Exam'] ?> </td>
                    <td> <?php echo $row['Marks'] ?> </td>
                </tr>
            <?php } ?>
        </table>
    </body>
</html>