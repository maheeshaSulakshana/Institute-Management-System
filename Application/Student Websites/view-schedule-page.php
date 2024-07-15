<?php 
    include_once 'DbConnection.php';

    $studentID = $_POST['studentID'];

    $query = "Select * from schedule where StudentID = ".$studentID."";

    $res = mysqli_query($con, $query);

    $no_of_rows = mysqli_num_rows($res);

    $c = 1;
?>


<html>
    <head>
        <Title>Answers</Title>

        <style>
            table{
                font-size: 40px;
                position: relative;
                top: 100px;
                width: auto;
            }

            div{
                font-size: 40px;
                font-weight: bold;
                width: 100%;
                height: 70px;
                background-color: wheat;
                text-align: center;
            }
        </style>
    </head>

    <body>
        <div>Student Schedule</div>
        <table border = "1" cellspacing = "0px" cellpadding = "10px" align = "center">
            <tr>
                <th>Student ID</th>
                <th>Course ID</th>
                <th>Day 1</th>
                <th>Time 1</th>
                <th>Day 2</th>
                <th>Time 2</th>
                <th>Day 3</th>
                <th>Time 3</th>
            </tr>

            <?php while ($c <= $no_of_rows){
                $record = mysqli_fetch_assoc($res);
                $c = $c + 1; ?>

            <tr>
                <td>
                    <?php echo $record['StudentID']; ?>
                </td>
                <td>
                    <?php echo $record['CourseID']; ?>
                </td>
                <td>
                    <?php echo $record['Day1']; ?>
                </td>`
                <td>
                    <?php echo $record['Time1']; ?>
                </td>
                <td>
                    <?php echo $record['Day2']; ?>
                </td>
                <td>
                    <?php echo $record['Time2']; ?>
                </td>
                <td>
                    <?php echo $record['Day3']; ?>
                </td>
                <td>
                    <?php echo $record['Time3']; ?>
                </td>
            </tr>
            <?php } ?>
        </table>
    </body>
</html>